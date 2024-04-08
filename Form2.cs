using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MovieDB
{
    // Form for adding a new movie entry
    public partial class Form2 : Form
    {
        // Stores the path of the image selected by the user
        private string selectedImagePath = string.Empty;

        public Form2()
        {
            InitializeComponent(); // Initialize the form's components
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // This method is intentionally left empty
        }

        // Event handler for the 'Add Movie' button click
        private void buttonNewEntry_Click(object sender, EventArgs e)
        {
            // Attempt to parse year, duration, and user rating from text to integer
            bool yearParse = int.TryParse(textBoxYear.Text, out int year);
            bool durationParse = int.TryParse(textBoxDur.Text, out int duration);
            bool userRatingParse = int.TryParse(textBoxUserRate.Text, out int userRating);

            // If parsing fails, show an error message and return
            if (!yearParse || !durationParse || !userRatingParse)
            {
                MessageBox.Show("Please enter valid numbers for year, duration, and user rating.");
                return;
            }

            // Prepare the rest of the movie data from the form fields
            string title = textBoxTitle.Text;
            string director = textBoxDir.Text;
            string genre = textBoxGen.Text;
            string ageRating = textBoxRate.Text;
            string summary = textBoxSum.Text;

            byte[] imageBytes = null; // Will hold the binary data of the movie image
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                imageBytes = File.ReadAllBytes(selectedImagePath); // Read the image file into a byte array
            }

            // SQL command for inserting the new movie into the database
            string sql = "INSERT INTO MovieTable ([Title], [Director], [Genre], [Year], [AgeRating], [Duration], [UserRating], [Summary], [Artwork]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

            // Connection string to connect to the database
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Emile\OneDrive\Proj\MovieDB\MovieDB\Database.accdb;Persist Security Info=False;";

            // Execute the SQL command with the provided movie data
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                // Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Director", director);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@AgeRating", ageRating);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@UserRating", userRating);
                cmd.Parameters.AddWithValue("@Summary", summary);
                cmd.Parameters.AddWithValue("@Artwork", imageBytes ?? (object)DBNull.Value); // Use DBNull.Value for null images

                try
                {
                    conn.Open(); // Open the connection to the database
                    cmd.ExecuteNonQuery(); // Execute the SQL command
                    MessageBox.Show("Movie added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message); // Display error if the operation fails
                }
            }
        }

        // Event handler for the 'Select Image' button click
        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Movie Artwork"; // Set the title of the dialog
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif"; // Filter to only show image files

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName; // Store the selected image path
                }
            }
        }
    }
}
