namespace MovieDB
{
    partial class MovieDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDB));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            buttonAddMovie = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(58, 116);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 38);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(139, 88);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(920, 412);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonAddMovie
            // 
            buttonAddMovie.Location = new Point(12, 66);
            buttonAddMovie.Margin = new Padding(3, 2, 3, 2);
            buttonAddMovie.Name = "buttonAddMovie";
            buttonAddMovie.Size = new Size(102, 31);
            buttonAddMovie.TabIndex = 2;
            buttonAddMovie.Text = "Add Movie";
            buttonAddMovie.UseVisualStyleBackColor = true;
            buttonAddMovie.Click += buttonAddMovie_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(475, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MovieDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 511);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAddMovie);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MovieDB";
            Text = "MovieDB";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button buttonAddMovie;
        private PictureBox pictureBox1;
    }
}
