namespace New_Form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (username.Text == "usama" && password.Text == "12345")
            {
               // new Form2().Show();
                this.Hide();
            }
            else {
                MessageBox.Show("The username or password is incorrect");
                //username.Clear();
                //password.Clear();
                //username.Focus();


                    }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            username.clear();
            password.clear();
            username.focus();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}