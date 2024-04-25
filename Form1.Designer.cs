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
            labelTitleValue = new Label();
            labelSumValue = new Label();
            labelUserRateValue = new Label();
            labelDurValue = new Label();
            labelRateValue = new Label();
            labelYearValue = new Label();
            labelGenValue = new Label();
            labelSum = new Label();
            labelUserRate = new Label();
            labelDur = new Label();
            labelRate = new Label();
            labelYear = new Label();
            labelGen = new Label();
            labelDirValue = new Label();
            labelDir = new Label();
            labelTitle = new Label();
            labelLibraryHead = new Label();
            labelMovieHead = new Label();
            panelMovieDetails.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddMovie
            // 
            buttonAddMovie.Location = new Point(12, 9);
            buttonAddMovie.Margin = new Padding(3, 2, 3, 2);
            buttonAddMovie.Name = "buttonAddMovie";
            buttonAddMovie.Size = new Size(95, 31);
            buttonAddMovie.TabIndex = 2;
            buttonAddMovie.Text = "Add Movie";
            buttonAddMovie.UseVisualStyleBackColor = true;
            buttonAddMovie.Click += buttonAddMovie_Click;
            // 
            // flowLayoutPanelMovies
            // 
            flowLayoutPanelMovies.AutoScroll = true;
            flowLayoutPanelMovies.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelMovies.Location = new Point(10, 83);
            flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            flowLayoutPanelMovies.Size = new Size(671, 784);
            flowLayoutPanelMovies.TabIndex = 3;
            // 
            // panelMovieDetails
            // 
            panelMovieDetails.BackColor = SystemColors.Window;
            panelMovieDetails.BorderStyle = BorderStyle.FixedSingle;
            panelMovieDetails.Controls.Add(labelTitleValue);
            panelMovieDetails.Controls.Add(labelSumValue);
            panelMovieDetails.Controls.Add(labelUserRateValue);
            panelMovieDetails.Controls.Add(labelDurValue);
            panelMovieDetails.Controls.Add(labelRateValue);
            panelMovieDetails.Controls.Add(labelYearValue);
            panelMovieDetails.Controls.Add(labelGenValue);
            panelMovieDetails.Controls.Add(labelSum);
            panelMovieDetails.Controls.Add(labelUserRate);
            panelMovieDetails.Controls.Add(labelDur);
            panelMovieDetails.Controls.Add(labelRate);
            panelMovieDetails.Controls.Add(labelYear);
            panelMovieDetails.Controls.Add(labelGen);
            panelMovieDetails.Controls.Add(labelDirValue);
            panelMovieDetails.Controls.Add(labelDir);
            panelMovieDetails.Controls.Add(labelTitle);
            panelMovieDetails.Location = new Point(687, 83);
            panelMovieDetails.Name = "panelMovieDetails";
            panelMovieDetails.Size = new Size(801, 784);
            panelMovieDetails.TabIndex = 4;
            // 
            // labelTitleValue
            // 
            labelTitleValue.AutoEllipsis = true;
            labelTitleValue.AutoSize = true;
            labelTitleValue.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitleValue.Location = new Point(160, 10);
            labelTitleValue.Name = "labelTitleValue";
            labelTitleValue.Size = new Size(0, 65);
            labelTitleValue.TabIndex = 15;
            // 
            // labelSumValue
            // 
            labelSumValue.AutoEllipsis = true;
            labelSumValue.Font = new Font("Segoe UI", 15.75F);
            labelSumValue.Location = new Point(166, 382);
            labelSumValue.MinimumSize = new Size(500, 220);
            labelSumValue.Name = "labelSumValue";
            labelSumValue.Size = new Size(500, 220);
            labelSumValue.TabIndex = 14;
            // 
            // labelUserRateValue
            // 
            labelUserRateValue.AutoSize = true;
            labelUserRateValue.Font = new Font("Segoe UI", 15.75F);
            labelUserRateValue.Location = new Point(166, 336);
            labelUserRateValue.Name = "labelUserRateValue";
            labelUserRateValue.Size = new Size(0, 30);
            labelUserRateValue.TabIndex = 13;
            // 
            // labelDurValue
            // 
            labelDurValue.AutoSize = true;
            labelDurValue.Font = new Font("Segoe UI", 15.75F);
            labelDurValue.Location = new Point(166, 282);
            labelDurValue.Name = "labelDurValue";
            labelDurValue.Size = new Size(0, 30);
            labelDurValue.TabIndex = 12;
            // 
            // labelRateValue
            // 
            labelRateValue.AutoSize = true;
            labelRateValue.Font = new Font("Segoe UI", 15.75F);
            labelRateValue.Location = new Point(166, 234);
            labelRateValue.Name = "labelRateValue";
            labelRateValue.Size = new Size(0, 30);
            labelRateValue.TabIndex = 11;
            // 
            // labelYearValue
            // 
            labelYearValue.AutoSize = true;
            labelYearValue.Font = new Font("Segoe UI", 15.75F);
            labelYearValue.Location = new Point(166, 185);
            labelYearValue.Name = "labelYearValue";
            labelYearValue.Size = new Size(0, 30);
            labelYearValue.TabIndex = 10;
            // 
            // labelGenValue
            // 
            labelGenValue.AutoSize = true;
            labelGenValue.Font = new Font("Segoe UI", 15.75F);
            labelGenValue.Location = new Point(166, 137);
            labelGenValue.Name = "labelGenValue";
            labelGenValue.Size = new Size(0, 30);
            labelGenValue.TabIndex = 9;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Font = new Font("Segoe UI", 15.75F);
            labelSum.Location = new Point(39, 382);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(105, 30);
            labelSum.TabIndex = 8;
            labelSum.Text = "Summary:";
            // 
            // labelUserRate
            // 
            labelUserRate.AutoSize = true;
            labelUserRate.Font = new Font("Segoe UI", 15.75F);
            labelUserRate.Location = new Point(41, 336);
            labelUserRate.Name = "labelUserRate";
            labelUserRate.Size = new Size(78, 30);
            labelUserRate.TabIndex = 7;
            labelUserRate.Text = "Rating:";
            // 
            // labelDur
            // 
            labelDur.AutoSize = true;
            labelDur.Font = new Font("Segoe UI", 15.75F);
            labelDur.Location = new Point(39, 282);
            labelDur.Name = "labelDur";
            labelDur.Size = new Size(99, 30);
            labelDur.TabIndex = 6;
            labelDur.Text = "Duration:";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Segoe UI", 15.75F);
            labelRate.Location = new Point(39, 234);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(121, 30);
            labelRate.TabIndex = 5;
            labelRate.Text = "Age Rating:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 15.75F);
            labelYear.Location = new Point(39, 185);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(57, 30);
            labelYear.TabIndex = 4;
            labelYear.Text = "Year:";
            // 
            // labelGen
            // 
            labelGen.AutoSize = true;
            labelGen.Font = new Font("Segoe UI", 15.75F);
            labelGen.Location = new Point(39, 137);
            labelGen.Name = "labelGen";
            labelGen.Size = new Size(73, 30);
            labelGen.TabIndex = 3;
            labelGen.Text = "Genre:";
            // 
            // labelDirValue
            // 
            labelDirValue.AutoSize = true;
            labelDirValue.Font = new Font("Segoe UI", 15.75F);
            labelDirValue.Location = new Point(166, 90);
            labelDirValue.Name = "labelDirValue";
            labelDirValue.Size = new Size(0, 30);
            labelDirValue.TabIndex = 2;
            // 
            // labelDir
            // 
            labelDir.AutoSize = true;
            labelDir.Font = new Font("Segoe UI", 15.75F);
            labelDir.Location = new Point(39, 90);
            labelDir.Name = "labelDir";
            labelDir.Size = new Size(92, 30);
            labelDir.TabIndex = 1;
            labelDir.Text = "Director:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(10, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(128, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title:";
            // 
            // labelLibraryHead
            // 
            labelLibraryHead.AutoSize = true;
            labelLibraryHead.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLibraryHead.Location = new Point(24, 52);
            labelLibraryHead.Name = "labelLibraryHead";
            labelLibraryHead.Size = new Size(155, 32);
            labelLibraryHead.TabIndex = 5;
            labelLibraryHead.Text = "Your Library";
            // 
            // labelMovieHead
            // 
            labelMovieHead.AutoSize = true;
            labelMovieHead.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMovieHead.Location = new Point(701, 52);
            labelMovieHead.Name = "labelMovieHead";
            labelMovieHead.Size = new Size(85, 32);
            labelMovieHead.TabIndex = 6;
            labelMovieHead.Text = "Movie";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.adrien_olichon_ilVYjf0J378_unsplash;
            ClientSize = new Size(1500, 879);
            Controls.Add(labelMovieHead);
            Controls.Add(labelLibraryHead);
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
            PerformLayout();
        }

        #endregion
        private Button buttonAddMovie;
        private FlowLayoutPanel flowLayoutPanelMovies;
        private Panel panelMovieDetails;
        private Label labelTitle;
        private Label labelDir;
        private Label labelUserRate;
        private Label labelDur;
        private Label labelRate;
        private Label labelYear;
        private Label labelGen;
        private Label labelDirValue;
        private Label labelTitleValue;
        private Label labelSumValue;
        private Label labelUserRateValue;
        private Label labelDurValue;
        private Label labelRateValue;
        private Label labelYearValue;
        private Label labelGenValue;
        private Label labelSum;
        private Label labelLibraryHead;
        private Label labelMovieHead;
    }
}
