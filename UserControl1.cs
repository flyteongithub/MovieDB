using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class UserControl1 : UserControl
    {
        public int MovieId { get; set; } // Property to store the Movie ID
        private bool isSelected = false; // Flag to track if the control is selected

        // Constructor
        public UserControl1()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None; // Initialize with no border
        }

        // Property to get or set the movie title
        public string MovieTitle
        {
            get { return labelMovieTitle.Text; }
            set { labelMovieTitle.Text = value; }
        }

        // Property to get the PictureBox control for the movie artwork
        public PictureBox MoviePictureBox
        {
            get { return pictureBoxMovie; }
        }

        // Method to set the artwork image for the movie
        public void SetArtwork(Image artwork)
        {
            pictureBoxMovie.Image = artwork;
        }

        // Method to toggle the border based on the active flag
        public void ToggleBorder(bool active)
        {
            isSelected = active;
            this.BorderStyle = active ? BorderStyle.FixedSingle : BorderStyle.None; // Apply border if active
        }

        // Event handler for when the control is clicked
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ToggleBorder(true); // Toggle border when clicked
        }

        // Optional: Reset border when focus is lost (when another movie is selected)
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (isSelected)
            {
                ToggleBorder(false); // Reset border if selected
            }
        }
    }
}
