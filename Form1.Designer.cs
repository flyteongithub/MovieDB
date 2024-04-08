namespace MovieDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddMovie = new Button();
            flowLayoutPanelMovies = new FlowLayoutPanel();
            panelMovieDetails = new Panel();
            labelMovieTitle = new Label();
            labelSum = new Label();
            labelUserRate = new Label();
            labelDur = new Label();
            labelRate = new Label();
            labelYear = new Label();
            labelGen = new Label();
            labelDir = new Label();
            panelMovieDetails.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddMovie
            // 
            buttonAddMovie.Location = new Point(12, 9);
            buttonAddMovie.Margin = new Padding(3, 2, 3, 2);
            buttonAddMovie.Name = "buttonAddMovie";
            buttonAddMovie.Size = new Size(102, 31);
            buttonAddMovie.TabIndex = 2;
            buttonAddMovie.Text = "Add Movie";
            buttonAddMovie.UseVisualStyleBackColor = true;
            buttonAddMovie.Click += buttonAddMovie_Click;
            // 
            // flowLayoutPanelMovies
            // 
            flowLayoutPanelMovies.AutoScroll = true;
            flowLayoutPanelMovies.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelMovies.Location = new Point(10, 45);
            flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            flowLayoutPanelMovies.Size = new Size(524, 620);
            flowLayoutPanelMovies.TabIndex = 3;
            // 
            // panelMovieDetails
            // 
            panelMovieDetails.Controls.Add(labelMovieTitle);
            panelMovieDetails.Controls.Add(labelSum);
            panelMovieDetails.Controls.Add(labelUserRate);
            panelMovieDetails.Controls.Add(labelDur);
            panelMovieDetails.Controls.Add(labelRate);
            panelMovieDetails.Controls.Add(labelYear);
            panelMovieDetails.Controls.Add(labelGen);
            panelMovieDetails.Controls.Add(labelDir);
            panelMovieDetails.Location = new Point(540, 45);
            panelMovieDetails.Name = "panelMovieDetails";
            panelMovieDetails.Size = new Size(708, 620);
            panelMovieDetails.TabIndex = 4;
            // 
            // labelMovieTitle
            // 
            labelMovieTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMovieTitle.Location = new Point(31, 16);
            labelMovieTitle.Name = "labelMovieTitle";
            labelMovieTitle.Size = new Size(684, 45);
            labelMovieTitle.TabIndex = 11;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Font = new Font("Segoe UI", 12F);
            labelSum.Location = new Point(31, 187);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(81, 21);
            labelSum.TabIndex = 10;
            labelSum.Text = "Summary:";
            // 
            // labelUserRate
            // 
            labelUserRate.AutoSize = true;
            labelUserRate.Font = new Font("Segoe UI", 12F);
            labelUserRate.Location = new Point(31, 166);
            labelUserRate.Name = "labelUserRate";
            labelUserRate.Size = new Size(58, 21);
            labelUserRate.TabIndex = 9;
            labelUserRate.Text = "Rating:";
            // 
            // labelDur
            // 
            labelDur.AutoSize = true;
            labelDur.Font = new Font("Segoe UI", 12F);
            labelDur.Location = new Point(31, 145);
            labelDur.Name = "labelDur";
            labelDur.Size = new Size(74, 21);
            labelDur.TabIndex = 8;
            labelDur.Text = "Duration:";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Segoe UI", 12F);
            labelRate.Location = new Point(31, 124);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(89, 21);
            labelRate.TabIndex = 7;
            labelRate.Text = "Age Rating:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 12F);
            labelYear.Location = new Point(31, 103);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(43, 21);
            labelYear.TabIndex = 6;
            labelYear.Text = "Year:";
            // 
            // labelGen
            // 
            labelGen.AutoSize = true;
            labelGen.Font = new Font("Segoe UI", 12F);
            labelGen.Location = new Point(31, 82);
            labelGen.Name = "labelGen";
            labelGen.Size = new Size(55, 21);
            labelGen.TabIndex = 5;
            labelGen.Text = "Genre:";
            // 
            // labelDir
            // 
            labelDir.AutoSize = true;
            labelDir.Font = new Font("Segoe UI", 12F);
            labelDir.Location = new Point(31, 61);
            labelDir.Name = "labelDir";
            labelDir.Size = new Size(69, 21);
            labelDir.TabIndex = 4;
            labelDir.Text = "Director:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 677);
            Controls.Add(panelMovieDetails);
            Controls.Add(flowLayoutPanelMovies);
            Controls.Add(buttonAddMovie);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMovieDetails.ResumeLayout(false);
            panelMovieDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAddMovie;
        private FlowLayoutPanel flowLayoutPanelMovies;
        private Panel panelMovieDetails;
        private Label labelDir;
        private Label labelGen;
        private Label labelYear;
        private Label labelRate;
        private Label labelDur;
        private Label labelUserRate;
        private Label labelSum;
        private Label labelMovieTitle;
    }
}
