using System;
using System.Data.SQLite; // Corrected the missing semicolon and changed to SQLite
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class Form1 : Form
    {
        // Updated connection string for SQLite
        private readonly string connString = @"Data Source=C:\Users\Emile\OneDrive\Proj\MovieDB\MovieDB\MovieDatabase.db;";

        // Constructor
        public Form1()
        {
            InitializeComponent();
            LoadMovies();
            buttonDeleteMovie.Click += buttonDeleteMovie_Click;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
        }

        // Variable to store the selected movie item
        private UserControl1 _selectedMovieItem;

        // Load movies on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        // Load movies from the database
        private void LoadMovies(string filter = "")
        {
            // SQL query to select movies based on the filter
            string sql = "SELECT MovieId, Title, Director, Genre, Year, AgeRating, Duration, UserRating, Summary, Artwork FROM MovieTable WHERE Title LIKE @Filter";

            using (var conn = new SQLiteConnection(connString))
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Filter", $"%{filter}%");

                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanelMovies.Controls.Clear();
                        while (reader.Read())
                        {
                            var movieItem = new UserControl1
                            {
                                MovieTitle = reader["Title"].ToString(),
                                MovieId = Convert.ToInt32(reader["MovieId"])
                            };
                            movieItem.MoviePictureBox.Click += MoviePictureBox_Click;
                            movieItem.MoviePictureBox.Tag = movieItem.MovieId;
                            movieItem.Cursor = Cursors.Hand;

                            // Load artwork if available
                            if (!reader.IsDBNull(reader.GetOrdinal("Artwork")))
                            {
                                byte[] imageBytes = (byte[])reader["Artwork"];
                                using (var ms = new MemoryStream(imageBytes))
                                {
                                    movieItem.SetArtwork(Image.FromStream(ms));
                                }
                            }
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
                    conn.Close();
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

        // Display movie details in labels
        private void DisplayMovieDetails(int movieId)
        {
            const string sql = "SELECT Title, Director, Genre, Year, AgeRating, Duration, UserRating, Summary FROM MovieTable WHERE MovieId = @MovieId";

            using (var conn = new SQLiteConnection(connString))
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MovieId", movieId);

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

        // Delete movie from the database
        private void DeleteMovie(int movieId)
        {
            const string sql = "DELETE FROM MovieTable WHERE MovieId = @MovieId";
            using (var conn = new SQLiteConnection(connString))
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MovieId", movieId);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Movie deleted successfully!");
                        LoadMovies();
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

        // Event handler for search textbox key down
        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadMovies(textBoxSearch.Text.Trim());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Event handler for add movie button click
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
        }

        // Event handler for refresh button click
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }
    }
}
