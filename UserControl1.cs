using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieDB
{
    // Custom UserControl to represent a movie item visually in the UI
    public partial class MovieItemControl : UserControl
    {
        public MovieItemControl()
        {
            InitializeComponent(); // Initialize the component's UI elements
        }

        // Public property for getting/setting the movie title
        public string MovieTitle
        {
            get { return labelMovieTitle.Text; } // Get the text from the label
            set { labelMovieTitle.Text = value; } // Set the text of the label
        }

        // Public property for getting/setting the movie image
        public Image MovieImage
        {
            get { return pictureBoxMovie.Image; } // Get the image from the PictureBox
            set { pictureBoxMovie.Image = value; } // Set the image of the PictureBox
        }
    }
}
