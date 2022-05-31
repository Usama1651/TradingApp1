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
    public partial class UpdateItemForm : System.Windows.Forms.Form
    {
        public UpdateItemForm()
        {
            InitializeComponent();
        }

        //public class JSONCLASS1
        //{

        //    public string? rowName { get; set; }
        //    public string? rowAddress { get; set; }

        //    public string? rowDate { get; set; }
        //}


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {

            if (Form2.rowTif == "DAY" || Form2.rowTif == "FOK" || Form2.rowTif == "GTC")
            {
                //<<<<<<< Updated upstream
                price.Enabled = false;
                price.Enabled = true;
                price.Enabled = true;
                textBox4.Enabled = true;
                textBox1.Enabled = false;
                uptorder.Enabled = false;
                uptroute.Enabled = false;
                upttiff.Enabled = false;
                Uptaccount.Enabled = false;
                textBox3.Enabled = false;
            }
            else {
                price.Enabled = true;
                price.Enabled = true;
                textBox4.Enabled = true;
                textBox1.Enabled = false;
                uptorder.Enabled = false;
                uptroute.Enabled = false;
                upttiff.Enabled = false;
                Uptaccount.Enabled = false;
                textBox3.Enabled = false;
            }
        

               
            
            //else { 
           // price.Enabled = true;

            

            //if (Form2.rowTif == "GTC") {
            //    price.Enabled = false;
            //    textBox4.Enabled = true;
            //    textBox1.Enabled = false;
            //    uptorder.Enabled = false;
            //    uptroute.Enabled = false;
            //    upttiff.Enabled = false;
            //    Uptaccount.Enabled = false;
            //    textBox3.Enabled = false;

            //}
            textBox1.Text = Form2.rowName;  
            //textBox2.Text = Form2.rowAddress;
            textBox4.Text = Form2.rowQuantity;
            price.Text = Form2.rowPrice;
            uptorder.Text = Form2.rowOrderTypes;
            Uptaccount.Text = Form2.rowAccountTypes;
            uptroute.Text = Form2.rowRoutes;
            upttiff.Text = Form2.rowTif;
            //accounttype.Text = Form2.rowAccountTypes;
            //ordertype.Text = Form2.rowOrderTypes;
           // routes.Text = Form2.rowRoutes;
            //tiff.Text = Form2.rowTif;
            textBox3.Text = Form2.rowDate;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            //var JSONCLASS1 = new JSONCLASS1
            //{
            //    rowName = textBox1.Text,
            //    rowAddress = textBox2.Text,
            //    rowDate = textBox3.Text,
            //};




            Form2.rowName = textBox1.Text;
            // Form2.rowAddress = textBox2.Text;
            Form2.rowQuantity = textBox4.Text;
            Form2.rowDate = textBox3.Text;
            Form2.rowPrice = price.Text;
            Form2.rowOrderTypes = uptorder.Text;
            Form2.rowAccountTypes = Uptaccount.Text;
            Form2.rowTif = upttiff.Text;
            Form2.rowRoutes = uptroute.Text;
            



            //var JSONCLASS1 = new JSONCLASS1 { 
            //};


            //List<String> updated= new List<String>();
            //updated.Add(Form2.rowName);
            //updated.Add(Form2.rowAddress);
            //updated.Add(Form2.rowDate);





            //string jsonString1 = JsonSerializer.Serialize(JSONCLASS1);
            //string path = @"D:\usama.txt";


            //using (StreamWriter sw = File.AppendText(path))
            //{

            //    sw.WriteLine(jsonString1);

            //}

            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void combaccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
