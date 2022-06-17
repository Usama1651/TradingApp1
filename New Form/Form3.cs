using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "usama" && textBox2.Text == "12345")
            {
                Form1 frm = new Form1();    
                frm.Show();
                // new Form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();


            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
