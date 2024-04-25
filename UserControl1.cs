using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class UserControl1 : UserControl
    {
        public int MovieId { get; set; }
        private bool isSelected = false;

        public UserControl1()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None; // No border initially
        }

        public string MovieTitle
        {
            get { return labelMovieTitle.Text; }
            set { labelMovieTitle.Text = value; }
        }

        public PictureBox MoviePictureBox
        {
            get { return pictureBoxMovie; }
        }

        public void SetArtwork(Image artwork)
        {
            pictureBoxMovie.Image = artwork;
        }

        // Method to toggle border
        public void ToggleBorder(bool active)
        {
            isSelected = active;
            this.BorderStyle = active ? BorderStyle.FixedSingle : BorderStyle.None;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            ToggleBorder(true);
        }

        // Optional: To visually reset when another movie is selected
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (isSelected)
            {
                ToggleBorder(false);
            }
        }
    }
}
