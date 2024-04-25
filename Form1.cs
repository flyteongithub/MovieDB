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
        private readonly string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Emile\OneDrive\Proj\MovieDB\MovieDB\Database.accdb;Persist Security Info=False;";
        private UserControl1 _selectedMovieItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            const string sql = "SELECT MovieId, Title, Director, Genre, Year, AgeRating, Duration, UserRating, Summary, Artwork FROM MovieTable";

            using (var conn = new OleDbConnection(connString))
            using (var cmd = new OleDbCommand(sql, conn))
            {
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

                            if (reader["Artwork"] != DBNull.Value)
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
            }
        }

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

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog(); // Open the Form2 as a dialog
        }
    }
}
