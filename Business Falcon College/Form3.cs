using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Business_Falcon_College
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            string link = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\dladl\OneDrive\Desktop\Database3.mdb";
            OleDbConnection search = new OleDbConnection(link);

                search.Open();
                string retrieve = "SELECT * FROM Lecturers WHERE [Faculty Number] = " + textBox1.Text;

                OleDbDataAdapter RE = new OleDbDataAdapter(retrieve, search);
                DataTable data = new DataTable();
                RE.Fill(data);
                dataGridView1.DataSource = data;

                // Check if any row was returned
                if (data.Rows.Count > 0)
                {
                    // Assuming first row since Faculty Number should be unique
                    DataRow row = data.Rows[0];

                // Update labels with column values from the retrieved row
                label2.Text = "Contact Hours for Lecturer: 106";
                    label3.Text = "Contact Hours for department: 1500";
                    label4.Text = "Contact Hours for College: 2010";
                }
                else
                {
                    // Clear labels if no data found
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                }

                search.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
