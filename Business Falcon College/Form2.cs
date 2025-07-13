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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string link=@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\dladl\OneDrive\Desktop\Database3.mdb";
            OleDbConnection hi = new OleDbConnection(link);
            hi.Open();

            string data = "insert into [Lecturers]([Faculty Number], [Lecturer Number], [Lecturer Name], [Module Number], [Credit Hours], [Class Size]) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox5.Text + "','" + textBox6.Text +"')";
            OleDbCommand command = new OleDbCommand(data, hi);
            command.ExecuteNonQuery();
            MessageBox.Show("Submitted Sucessfully");
            hi.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 DB = new Form3();
            DB.Show();
            this.Hide();
        }
    }
}
