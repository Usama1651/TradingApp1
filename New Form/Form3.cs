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
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 fr=new Form1();
            if (username.Text == "usama" && Password.Text == "12345")
            {
                fr.Show();
                // new Form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect");
                username.Clear();
                Password.Clear();
                username.Focus();


            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            username.Clear();
            Password.Clear();
            username.Focus();
        }
    }
}
