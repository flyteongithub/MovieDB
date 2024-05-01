using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class Form1 : Form
    {
        // Connection string to the database
        private readonly string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb;Persist Security Info=False;";
        // Variable to store the selected movie item
        private UserControl1 _selectedMovieItem;

        // Constructor
        public Form1()
        {
            InitializeComponent();
            // Initialize form controls and attach event handlers
            LoadMovies();
            buttonDeleteMovie.Click += buttonDeleteMovie_Click;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
        }

        // Form load event handler
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        // Method to load movies from the database
        private void LoadMovies(string filter = "")
        {
            string sql = "SELECT MovieId, Title, Director, Genre, Year, AgeRating, Duration, UserRating, Summary, Artwork FROM MovieTable WHERE Title LIKE ?";

            using (var conn = new OleDbConnection(connString))
            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?", $"%{filter}%"); // Apply filter

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanelMovies.Controls.Clear(); // Clear existing movies
                        while (reader.Read())
                        {
                            // Create a UserControl for each movie
                            var movieItem = new UserControl1
                            {
                                MovieTitle = reader["Title"].ToString(),
                                MovieId = Convert.ToInt32(reader["MovieId"])
                            };
                            // Attach event handlers
                            movieItem.MoviePictureBox.Click += MoviePictureBox_Click;
                            movieItem.MoviePictureBox.Tag = movieItem.MovieId;
                            movieItem.Cursor = Cursors.Hand;

                            // Set artwork if available
                            if (reader["Artwork"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["Artwork"];
                                using (var ms = new MemoryStream(imageBytes))
                                {
                                    movieItem.SetArtwork(Image.FromStream(ms));
                                }
                            }
                            // Add UserControl to the flow layout panel
                            flowLayoutPanelMovies.Controls.Add(movieItem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    conn.Close(); // Close connection in a finally block
                }
            }
        }

        // Event handler for movie picture box click
        private void MoviePictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is int movieId)
            {
                if (_selectedMovieItem != null)
                {
                    _selectedMovieItem.ToggleBorder(false);
                }

                var parentUserControl = (UserControl1)pictureBox.Parent;
                parentUserControl.ToggleBorder(true);
                _selectedMovieItem = parentUserControl;

                DisplayMovieDetails(movieId);
            }
        }

        // Method to display movie details
        private void DisplayMovieDetails(int movieId)
        {
            const string sql = "SELECT Title, Director, Genre, Year, AgeRating, Duration, UserRating, Summary FROM MovieTable WHERE MovieId = ?";

            using (var conn = new OleDbConnection(connString))
            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?", movieId);

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display movie details in labels
                            labelTitleValue.Text = reader["Title"].ToString();
                            labelDirValue.Text = reader["Director"].ToString();
                            labelGenValue.Text = reader["Genre"].ToString();
                            labelYearValue.Text = reader["Year"].ToString();
                            labelRateValue.Text = reader["AgeRating"].ToString();
                            labelDurValue.Text = reader["Duration"].ToString();
                            labelUserRateValue.Text = reader["UserRating"].ToString();
                            labelSumValue.Text = reader["Summary"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        // Event handler for delete movie button click
        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            if (_selectedMovieItem != null && MessageBox.Show("Are you sure you want to delete this movie?", "Delete Movie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteMovie(_selectedMovieItem.MovieId);
            }
        }

        // Method to delete a movie
        private void DeleteMovie(int movieId)
        {
            const string sql = "DELETE FROM MovieTable WHERE MovieId = ?";
            using (var conn = new OleDbConnection(connString))
            using (var cmd = new OleDbCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("?", movieId);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Movie deleted successfully!");
                        LoadMovies();  // Reload movies to reflect the changes
                    }
                    else
                    {
                        MessageBox.Show("No movie was deleted.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete movie: " + ex.Message);
                }
            }
        }

        // Event handler for search text box key down event
        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadMovies(textBoxSearch.Text.Trim()); // Only load movies when Enter is pressed
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent the ding sound on press Enter
            }
        }

        // Event handler for add movie button click
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog(); // Open the Form2 as a dialog
        }

        // Event handler for refresh button click
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }


    }
}
