using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MovieDB
{
    public partial class Form2 : Form
    {
        private string selectedImagePath = string.Empty; // To store the path of the selected image

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // This method is intentionally left empty
        }

        private void buttonNewEntry_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string director = textBoxDir.Text;
            string genre = textBoxGen.Text;
            int year = int.Parse(textBoxYear.Text); 
            string ageRating = textBoxRate.Text;
            int duration = int.Parse(textBoxDur.Text); 
            int userRating = int.Parse(textBoxUserRate.Text); 
            string summary = textBoxSum.Text;

            byte[] imageBytes = null;
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                imageBytes = File.ReadAllBytes(selectedImagePath); // Convert the image file to byte array
            }

            // Connection string
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Emile\OneDrive\Proj\MovieDB\MovieDB\Database.accdb;Persist Security Info=False;";

            // SQL command with parameters
            string sql = "INSERT INTO MovieTable ([Title], [Director], [Genre], [Year], [AgeRating], [Duration], [UserRating], [Summary], [Artwork]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                // Added parameters
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Director", director);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@AgeRating", ageRating);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@UserRating", userRating);
                cmd.Parameters.AddWithValue("@Summary", summary);
                cmd.Parameters.AddWithValue("@Artwork", imageBytes ?? (object)DBNull.Value); // Use DBNull.Value idk why

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); // Executes the SQL command
                    MessageBox.Show("Movie added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Movie Artwork";
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    // Load the image into a PictureBox or some other control soon TM
                    // e.g., pictureBoxArtwork.Image = Image.FromFile(selectedImagePath);
                }
            }
        }
    }
}
