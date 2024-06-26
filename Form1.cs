using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update the connection string with the absolute path to your database
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Emile\OneDrive\Proj\MovieDB\MovieDB\Database.accdb;Persist Security Info=False;";

            // SQL query to retrieve data
            string sql = "SELECT * FROM MovieTable";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                try
                {
                    conn.Open();

                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear existing data source.
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();

                    // Set the new data source
                    dataGridView1.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed properly
                    conn.Close();
                }
            }
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
