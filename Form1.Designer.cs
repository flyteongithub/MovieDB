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
            buttonDeleteMovie = new Button();
            buttonRefresh = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            panelMovieDetails.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddMovie
            // 
            buttonAddMovie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonAddMovie.Location = new Point(12, 9);
            buttonAddMovie.Margin = new Padding(3, 2, 3, 2);
            buttonAddMovie.Name = "buttonAddMovie";
            buttonAddMovie.Size = new Size(110, 31);
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
            panelMovieDetails.BackgroundImageLayout = ImageLayout.Stretch;
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
            labelTitleValue.BackColor = Color.Transparent;
            labelTitleValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitleValue.Location = new Point(166, 34);
            labelTitleValue.Name = "labelTitleValue";
            labelTitleValue.Size = new Size(0, 37);
            labelTitleValue.TabIndex = 15;
            // 
            // labelSumValue
            // 
            labelSumValue.AutoEllipsis = true;
            labelSumValue.BackColor = Color.Transparent;
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
            labelUserRateValue.BackColor = Color.Transparent;
            labelUserRateValue.Font = new Font("Segoe UI", 15.75F);
            labelUserRateValue.Location = new Point(166, 336);
            labelUserRateValue.Name = "labelUserRateValue";
            labelUserRateValue.Size = new Size(0, 30);
            labelUserRateValue.TabIndex = 13;
            // 
            // labelDurValue
            // 
            labelDurValue.AutoSize = true;
            labelDurValue.BackColor = Color.Transparent;
            labelDurValue.Font = new Font("Segoe UI", 15.75F);
            labelDurValue.Location = new Point(166, 282);
            labelDurValue.Name = "labelDurValue";
            labelDurValue.Size = new Size(0, 30);
            labelDurValue.TabIndex = 12;
            // 
            // labelRateValue
            // 
            labelRateValue.AutoSize = true;
            labelRateValue.BackColor = Color.Transparent;
            labelRateValue.Font = new Font("Segoe UI", 15.75F);
            labelRateValue.Location = new Point(166, 234);
            labelRateValue.Name = "labelRateValue";
            labelRateValue.Size = new Size(0, 30);
            labelRateValue.TabIndex = 11;
            // 
            // labelYearValue
            // 
            labelYearValue.AutoSize = true;
            labelYearValue.BackColor = Color.Transparent;
            labelYearValue.Font = new Font("Segoe UI", 15.75F);
            labelYearValue.Location = new Point(166, 185);
            labelYearValue.Name = "labelYearValue";
            labelYearValue.Size = new Size(0, 30);
            labelYearValue.TabIndex = 10;
            // 
            // labelGenValue
            // 
            labelGenValue.AutoSize = true;
            labelGenValue.BackColor = Color.Transparent;
            labelGenValue.Font = new Font("Segoe UI", 15.75F);
            labelGenValue.Location = new Point(166, 137);
            labelGenValue.Name = "labelGenValue";
            labelGenValue.Size = new Size(0, 30);
            labelGenValue.TabIndex = 9;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.BackColor = Color.Transparent;
            labelSum.BorderStyle = BorderStyle.FixedSingle;
            labelSum.Font = new Font("Segoe UI", 15.75F);
            labelSum.Location = new Point(39, 382);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(107, 32);
            labelSum.TabIndex = 8;
            labelSum.Text = "Summary:";
            // 
            // labelUserRate
            // 
            labelUserRate.AutoSize = true;
            labelUserRate.BackColor = Color.Transparent;
            labelUserRate.BorderStyle = BorderStyle.FixedSingle;
            labelUserRate.Font = new Font("Segoe UI", 15.75F);
            labelUserRate.Location = new Point(41, 336);
            labelUserRate.Name = "labelUserRate";
            labelUserRate.Size = new Size(80, 32);
            labelUserRate.TabIndex = 7;
            labelUserRate.Text = "Rating:";
            // 
            // labelDur
            // 
            labelDur.AutoSize = true;
            labelDur.BackColor = Color.Transparent;
            labelDur.BorderStyle = BorderStyle.FixedSingle;
            labelDur.Font = new Font("Segoe UI", 15.75F);
            labelDur.Location = new Point(39, 282);
            labelDur.Name = "labelDur";
            labelDur.Size = new Size(101, 32);
            labelDur.TabIndex = 6;
            labelDur.Text = "Duration:";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.BackColor = Color.Transparent;
            labelRate.BorderStyle = BorderStyle.FixedSingle;
            labelRate.Font = new Font("Segoe UI", 15.75F);
            labelRate.Location = new Point(39, 234);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(123, 32);
            labelRate.TabIndex = 5;
            labelRate.Text = "Age Rating:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.BackColor = Color.Transparent;
            labelYear.BorderStyle = BorderStyle.FixedSingle;
            labelYear.Font = new Font("Segoe UI", 15.75F);
            labelYear.Location = new Point(39, 185);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(59, 32);
            labelYear.TabIndex = 4;
            labelYear.Text = "Year:";
            // 
            // labelGen
            // 
            labelGen.AutoSize = true;
            labelGen.BackColor = Color.Transparent;
            labelGen.BorderStyle = BorderStyle.FixedSingle;
            labelGen.Font = new Font("Segoe UI", 15.75F);
            labelGen.Location = new Point(39, 137);
            labelGen.Name = "labelGen";
            labelGen.Size = new Size(75, 32);
            labelGen.TabIndex = 3;
            labelGen.Text = "Genre:";
            // 
            // labelDirValue
            // 
            labelDirValue.AutoSize = true;
            labelDirValue.BackColor = Color.Transparent;
            labelDirValue.Font = new Font("Segoe UI", 15.75F);
            labelDirValue.Location = new Point(166, 90);
            labelDirValue.Name = "labelDirValue";
            labelDirValue.Size = new Size(0, 30);
            labelDirValue.TabIndex = 2;
            // 
            // labelDir
            // 
            labelDir.AutoSize = true;
            labelDir.BackColor = Color.Transparent;
            labelDir.BorderStyle = BorderStyle.FixedSingle;
            labelDir.Font = new Font("Segoe UI", 15.75F);
            labelDir.Location = new Point(39, 90);
            labelDir.Name = "labelDir";
            labelDir.Size = new Size(94, 32);
            labelDir.TabIndex = 1;
            labelDir.Text = "Director:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.BorderStyle = BorderStyle.FixedSingle;
            labelTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(39, 31);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(79, 42);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title:";
            // 
            // labelLibraryHead
            // 
            labelLibraryHead.AutoSize = true;
            labelLibraryHead.BorderStyle = BorderStyle.Fixed3D;
            labelLibraryHead.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLibraryHead.Location = new Point(24, 52);
            labelLibraryHead.Name = "labelLibraryHead";
            labelLibraryHead.Size = new Size(157, 34);
            labelLibraryHead.TabIndex = 5;
            labelLibraryHead.Text = "Your Library";
            // 
            // labelMovieHead
            // 
            labelMovieHead.AutoSize = true;
            labelMovieHead.BorderStyle = BorderStyle.Fixed3D;
            labelMovieHead.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMovieHead.Location = new Point(701, 52);
            labelMovieHead.Name = "labelMovieHead";
            labelMovieHead.Size = new Size(87, 34);
            labelMovieHead.TabIndex = 6;
            labelMovieHead.Text = "Movie";
            // 
            // buttonDeleteMovie
            // 
            buttonDeleteMovie.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonDeleteMovie.Location = new Point(128, 9);
            buttonDeleteMovie.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteMovie.Name = "buttonDeleteMovie";
            buttonDeleteMovie.Size = new Size(95, 31);
            buttonDeleteMovie.TabIndex = 7;
            buttonDeleteMovie.Text = "Delete Movie";
            buttonDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            buttonRefresh.Location = new Point(229, 9);
            buttonRefresh.Margin = new Padding(3, 2, 3, 2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(95, 31);
            buttonRefresh.TabIndex = 8;
            buttonRefresh.Text = "Refresh List";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(280, 56);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(341, 23);
            textBoxSearch.TabIndex = 9;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BorderStyle = BorderStyle.Fixed3D;
            labelSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(185, 52);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(91, 34);
            labelSearch.TabIndex = 10;
            labelSearch.Text = "Search";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.RED_GRADIENTS_COLOR_SCHEME;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1500, 879);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonDeleteMovie);
            Controls.Add(labelMovieHead);
            Controls.Add(labelLibraryHead);
            Controls.Add(panelMovieDetails);
            Controls.Add(flowLayoutPanelMovies);
            Controls.Add(buttonAddMovie);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "MovieDB";
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
        private Button buttonDeleteMovie;
        private Button buttonRefresh;
        private TextBox textBoxSearch;
        private Label labelSearch;
    }
}
