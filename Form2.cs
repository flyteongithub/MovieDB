using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class Form2 : Form
    {
        private string selectedImagePath = string.Empty; // Stores the path of the selected image

        // Constructor for Form2
        public Form2()
        {
            InitializeComponent();
        }

        // Event handler for the 'Add New Entry' button click
        private void buttonNewEntry_Click(object sender, EventArgs e)
        {
            // Validate input fields for year, duration, and user rating
            if (!int.TryParse(textBoxYear.Text, out int year) ||
                !int.TryParse(textBoxDur.Text, out int duration) ||
                !int.TryParse(textBoxUserRate.Text, out int userRating))
            {
                MessageBox.Show("Please enter valid numbers for year, duration, and user rating.");
                return;
            }

            // Prepare movie data for insertion into the database
            string title = textBoxTitle.Text;
            string director = textBoxDir.Text;
            string genre = textBoxGen.Text;
            string ageRating = textBoxRate.Text;
            string summary = textBoxSum.Text;
            byte[] imageBytes = string.IsNullOrEmpty(selectedImagePath) ? null : File.ReadAllBytes(selectedImagePath);

            // SQL statement for inserting new movie
            string sql = "INSERT INTO MovieTable ([Title], [Director], [Genre], [Year], [AgeRating], [Duration], [UserRating], [Summary], [Artwork]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Emile\OneDrive\Proj\MovieDB\MovieDB\Database.accdb;Persist Security Info=False;";

            // Insert movie data into the database
            using (OleDbConnection conn = new OleDbConnection(connString))
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                // Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Director", director);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@AgeRating", ageRating);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@UserRating", userRating);
                cmd.Parameters.AddWithValue("@Summary", summary);
                cmd.Parameters.AddWithValue("@Artwork", (object)imageBytes ?? DBNull.Value);

                // Execute the command
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message); // Display an error message on exception
                }
            }
        }

        // Event handler for the 'Select Image' button click
        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configure the file dialog for image selection
                openFileDialog.Title = "Select Movie Artwork";
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

                // Show the dialog and process the selected image path
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                }
            }
        }
    }
}
