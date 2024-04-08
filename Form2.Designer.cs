namespace MovieDB
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelDir = new Label();
            labelGen = new Label();
            labelYear = new Label();
            labelRate = new Label();
            labelDur = new Label();
            labelUserRate = new Label();
            labelSum = new Label();
            textBoxTitle = new TextBox();
            textBoxDir = new TextBox();
            textBoxGen = new TextBox();
            textBoxYear = new TextBox();
            textBoxRate = new TextBox();
            textBoxDur = new TextBox();
            textBoxUserRate = new TextBox();
            textBoxSum = new TextBox();
            buttonNewEntry = new Button();
            labelArt = new Label();
            openFileDialog1 = new OpenFileDialog();
            buttonSelectImage = new Button();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 9F);
            labelTitle.Location = new Point(90, 34);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Title";
            // 
            // labelDir
            // 
            labelDir.AutoSize = true;
            labelDir.Font = new Font("Segoe UI", 9F);
            labelDir.Location = new Point(65, 67);
            labelDir.Name = "labelDir";
            labelDir.Size = new Size(63, 20);
            labelDir.TabIndex = 3;
            labelDir.Text = "Director";
            
            // 
            // labelGen
            // 
            labelGen.AutoSize = true;
            labelGen.Font = new Font("Segoe UI", 9F);
            labelGen.Location = new Point(80, 100);
            labelGen.Name = "labelGen";
            labelGen.Size = new Size(48, 20);
            labelGen.TabIndex = 4;
            labelGen.Text = "Genre";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 9F);
            labelYear.Location = new Point(91, 133);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(37, 20);
            labelYear.TabIndex = 5;
            labelYear.Text = "Year";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Segoe UI", 9F);
            labelRate.Location = new Point(45, 162);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(83, 20);
            labelRate.TabIndex = 6;
            labelRate.Text = "Age Rating";
            // 
            // labelDur
            // 
            labelDur.AutoSize = true;
            labelDur.Font = new Font("Segoe UI", 9F);
            labelDur.Location = new Point(61, 199);
            labelDur.Name = "labelDur";
            labelDur.Size = new Size(67, 20);
            labelDur.TabIndex = 7;
            labelDur.Text = "Duration";
            // 
            // labelUserRate
            // 
            labelUserRate.AutoSize = true;
            labelUserRate.Font = new Font("Segoe UI", 9F);
            labelUserRate.Location = new Point(76, 232);
            labelUserRate.Name = "labelUserRate";
            labelUserRate.Size = new Size(52, 20);
            labelUserRate.TabIndex = 8;
            labelUserRate.Text = "Rating";
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Font = new Font("Segoe UI", 9F);
            labelSum.Location = new Point(57, 261);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(71, 20);
            labelSum.TabIndex = 9;
            labelSum.Text = "Summary";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(134, 27);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(100, 27);
            textBoxTitle.TabIndex = 10;
            // 
            // textBoxDir
            // 
            textBoxDir.Location = new Point(134, 60);
            textBoxDir.Name = "textBoxDir";
            textBoxDir.Size = new Size(100, 27);
            textBoxDir.TabIndex = 11;
            // 
            // textBoxGen
            // 
            textBoxGen.Location = new Point(134, 93);
            textBoxGen.Name = "textBoxGen";
            textBoxGen.Size = new Size(100, 27);
            textBoxGen.TabIndex = 12;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(134, 126);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 27);
            textBoxYear.TabIndex = 13;
            // 
            // textBoxRate
            // 
            textBoxRate.Location = new Point(134, 159);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(100, 27);
            textBoxRate.TabIndex = 14;
            // 
            // textBoxDur
            // 
            textBoxDur.Location = new Point(134, 192);
            textBoxDur.Name = "textBoxDur";
            textBoxDur.Size = new Size(100, 27);
            textBoxDur.TabIndex = 15;
            // 
            // textBoxUserRate
            // 
            textBoxUserRate.Location = new Point(134, 225);
            textBoxUserRate.Name = "textBoxUserRate";
            textBoxUserRate.Size = new Size(100, 27);
            textBoxUserRate.TabIndex = 16;
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(134, 258);
            textBoxSum.Multiline = true;
            textBoxSum.Name = "textBoxSum";
            textBoxSum.ScrollBars = ScrollBars.Vertical;
            textBoxSum.Size = new Size(377, 129);
            textBoxSum.TabIndex = 17;
            // 
            // buttonNewEntry
            // 
            buttonNewEntry.Location = new Point(623, 443);
            buttonNewEntry.Name = "buttonNewEntry";
            buttonNewEntry.Size = new Size(140, 59);
            buttonNewEntry.TabIndex = 18;
            buttonNewEntry.Text = "Add Movie";
            buttonNewEntry.UseVisualStyleBackColor = true;
            buttonNewEntry.Click += buttonNewEntry_Click;
            // 
            // labelArt
            // 
            labelArt.AutoSize = true;
            labelArt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelArt.Location = new Point(35, 400);
            labelArt.Name = "labelArt";
            labelArt.Size = new Size(93, 20);
            labelArt.TabIndex = 19;
            labelArt.Text = "Add Artwork";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSelectImage
            // 
            buttonSelectImage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSelectImage.Location = new Point(134, 397);
            buttonSelectImage.Name = "buttonSelectImage";
            buttonSelectImage.Size = new Size(100, 27);
            buttonSelectImage.TabIndex = 20;
            buttonSelectImage.Text = "Browse...";
            buttonSelectImage.UseVisualStyleBackColor = true;
            buttonSelectImage.Click += buttonSelectImage_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 514);
            Controls.Add(buttonSelectImage);
            Controls.Add(labelArt);
            Controls.Add(buttonNewEntry);
            Controls.Add(textBoxSum);
            Controls.Add(textBoxUserRate);
            Controls.Add(textBoxDur);
            Controls.Add(textBoxRate);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxGen);
            Controls.Add(textBoxDir);
            Controls.Add(textBoxTitle);
            Controls.Add(labelSum);
            Controls.Add(labelUserRate);
            Controls.Add(labelDur);
            Controls.Add(labelRate);
            Controls.Add(labelYear);
            Controls.Add(labelGen);
            Controls.Add(labelDir);
            Controls.Add(labelTitle);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private Label labelDir;
        private Label labelGen;
        private Label labelYear;
        private Label labelRate;
        private Label labelDur;
        private Label labelUserRate;
        private Label labelSum;
        private TextBox textBoxTitle;
        private TextBox textBoxDir;
        private TextBox textBoxGen;
        private TextBox textBoxYear;
        private TextBox textBoxRate;
        private TextBox textBoxDur;
        private TextBox textBoxUserRate;
        private TextBox textBoxSum;
        private Button buttonNewEntry;
        private Label labelArt;
        private OpenFileDialog openFileDialog1;
        private Button buttonSelectImage;
        private OpenFileDialog openFileDialog2;
    }
}