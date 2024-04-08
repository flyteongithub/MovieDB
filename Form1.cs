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
        public Form1()
        {
            InitializeComponent(); // Initializes the components defined in the designer
        }

        // Event handler for when Form1 loads
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMovies(); // Load movies into the FlowLayoutPanel on form load
        }

        // Method to load movies from the database and display them in the FlowLayoutPanel
        private void LoadMovies()
        {
            // Connection string to connect to the database
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Emile\OneDrive\Proj\MovieDB\MovieDB\Database.accdb;Persist Security Info=False;";
            // SQL query to select movie details
            string sql = "SELECT MovieId, Title, Artwork FROM MovieTable";

            // Using statement to ensure the connection is properly disposed
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn); // Create a command to execute the SQL query
                try
                {
                    conn.Open(); // Open the database connection
                    using (OleDbDataReader reader = cmd.ExecuteReader()) // Execute the query and get the result set
                    {
                        flowLayoutPanelMovies.Controls.Clear(); // Clear the FlowLayoutPanel before adding new items

                        // Iterate through each row in the result set
                        while (reader.Read())
                        {
                            MovieItemControl movieItem = new MovieItemControl(); // Create a new MovieItemControl for each movie
                            movieItem.MovieTitle = reader["Title"].ToString(); // Set the movie title

                            // Check if the 'Artwork' field is not DBNull and then set the movie image
                            if (!(reader["Artwork"] is DBNull))
                            {
                                byte[] imageBytes = (byte[])reader["Artwork"]; // Get the image bytes from the database
                                using (var ms = new MemoryStream(imageBytes)) // Create a memory stream from the image bytes
                                {
                                    movieItem.MovieImage = Image.FromStream(ms); // Create an image from the memory stream and set it to the MovieItemControl
                                }
                            }

                            flowLayoutPanelMovies.Controls.Add(movieItem); // Add the MovieItemControl to the FlowLayoutPanel
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message); // Show a message box if an error occurs
                }
                finally
                {
                    conn.Close(); // Ensure the connection is closed
                }
            }
        }

        // Event handler for when the 'Add Movie' button is clicked
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Create a new instance of Form2
            var result = form2.ShowDialog(); // Show Form2 as a dialog and store the result
            if (result == DialogResult.OK) // Check if the dialog result is OK
            {
                LoadMovies(); // Reload the movies to include any new additions
            }
        }
    }
}
