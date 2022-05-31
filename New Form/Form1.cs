using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;





namespace New_Form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            
            InitializeComponent();
            datetext.Enabled = false;
            
            
            textBox4.Enabled = false;
            stp.Enabled = false;
        }

        public void autogen() {
            string num = "123456789";
            int len = num.Length;
            string otp = string.Empty;
            int otpdigit = 5;
            string finaldigit;

            int getindex;
            for (int i =0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getindex].ToString();

                } while (otp.IndexOf(finaldigit) != -1);
                otp = finaldigit;
            
            }
            textBox4.Text=(otp);
        
       }
        public class JSONCLASS
        {

            public string? Id { get; set; }
            public string? Name { get; set; }

            //public string? Symbol { get; set; }

            public string? quantity
            {
                get; set;
            }

            public string? OrderTypes { get; set; }
            public string? AccountTypes { get; set; }

            

            public string? Routes { get; set; }

            public string? Tif { get; set; }

            public string? Price { get; set; }


           // public DateTimeOffset Date { get; set; }
            public string? dd { get; set; }

            public string? Stplmt { get; set; }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Symbol");
            }
             else if (textBox2.Text == String.Empty) {
                MessageBox.Show("Please Enter Price");

            }

            else if (textBox5.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Quantity");

            }

            else if (comboOrderTypes.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Order Type");

            }

            else if (comboRoutes.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Route");

            }

            else if (comboTIF.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Tif");

            }

            else if (combaccount.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Account");

            }



            else
            {
                MessageBox.Show("Data Submit Successfull");


                //Json Object

                autogen();
                datetext.Text = dateTimePicker1.Value.ToString();

                var jsonCLASS = new JSONCLASS
                {
                    Id = textBox4.Text,
                    Name = textBox3.Text,
                    //Symbol = textBox2.Text,
                    quantity = textBox5.Text,
                    OrderTypes = comboOrderTypes.Text,
                    AccountTypes = combaccount.Text,
                    Stplmt=stp.Text,
                    Routes = comboRoutes.Text,
                    Tif = comboTIF.Text,
                    Price = textBox2.Text,
                    dd = datetext.Text,
                    // Date = DateTime.Parse(textBox1.Text),




                };

                // Convert String to Json

                string jsonString = JsonSerializer.Serialize(jsonCLASS);
                //yahan se jraha hay filr mau
                /*Console.WriteLine(jsonString);*/

                string path = @"D:\usama.txt";


                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine(jsonString);


                }
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();

            // Form2 data = new Form2();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (datetext.Text == "")
            {
                textBox2.Enabled = false;
                
            }

            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboOrderTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string l1 = "MKT";
            if (comboOrderTypes.Text == "MKT")
            {


                textBox2.Enabled = false;

                textBox2.Enabled = false;
                stp.Enabled = false;
                stp.Clear();
                textBox2.Clear();


            }
            else if (comboOrderTypes.Text == "STOP" || comboOrderTypes.Text == "LMT")
            { 
                textBox2.Enabled=true;
                stp.Clear();

                stp.Enabled = false; }
            
            else
            {
                stp.Enabled = true;
                textBox2.Enabled = true;
               
            }

            //if (comboOrderTypes.Text == "STOPLMT")
            //{
            //    stp.Enabled = true;

            //}
            //else {
            //    stp.Enabled = false;
            //}
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboTIF_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //JSONCLASS clear = new JSONCLASS();
            textBox3.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox4.Clear();
            combaccount.Text = String.Empty;
            // combaccount.Items.Clear();
            comboRoutes.Text = String.Empty;
            comboTIF.Text = String.Empty;
            comboOrderTypes.Text = String.Empty;
            stp.Clear();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void stp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}