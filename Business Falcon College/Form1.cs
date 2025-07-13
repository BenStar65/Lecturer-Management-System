using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Falcon_College
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if ((username == "Admin") && (password == "12345"))
            {
                Form2 F1 = new Form2();
                F1.Show();
                this.Hide();
            }
            else if ((username == "Reception") && (password == "2468"))
            {
                Form2 F2 = new Form2();
                F2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong password");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
