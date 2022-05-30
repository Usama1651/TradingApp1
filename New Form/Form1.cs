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



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Submit Successfull");


            //Json Object
            datetext.Text = dateTimePicker1.Value.ToString();
           
            var jsonCLASS = new JSONCLASS
            {
                Id = textBox4.Text,
                Name = textBox3.Text,
                //Symbol = textBox2.Text,
                quantity = textBox5.Text,
                OrderTypes = comboOrderTypes.Text,
                AccountTypes = combaccount.Text,

                Routes = comboRoutes.Text,
                Tif = comboTIF.Text,
                Price = textBox2.Text,
                dd= datetext.Text,
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
                price.Enabled = false;
            }
            else
            {

                textBox2.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboTIF_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}