namespace MovieDB
{
    partial class MovieItemControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxMovie = new PictureBox();
            labelMovieTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMovie
            // 
            pictureBoxMovie.BackColor = SystemColors.Control;
            pictureBoxMovie.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMovie.Location = new Point(3, 3);
            pictureBoxMovie.Name = "pictureBoxMovie";
            pictureBoxMovie.Size = new Size(150, 215);
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMovie.TabIndex = 0;
            pictureBoxMovie.TabStop = false;
            // 
            // labelMovieTitle
            // 
            labelMovieTitle.Anchor = AnchorStyles.Bottom;
            labelMovieTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMovieTitle.Location = new Point(3, 221);
            labelMovieTitle.Name = "labelMovieTitle";
            labelMovieTitle.Size = new Size(150, 40);
            labelMovieTitle.TabIndex = 1;
            labelMovieTitle.Text = "label1";
            labelMovieTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // MovieItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMovieTitle);
            Controls.Add(pictureBoxMovie);
            Name = "MovieItemControl";
            Size = new Size(157, 264);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxMovie;
        private Label labelMovieTitle;
    }
}
