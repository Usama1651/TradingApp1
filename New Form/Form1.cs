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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        GridClass gridClass = new GridClass();

        private void button1_Click(object sender,  EventArgs e )
        {/*
            gridClass.getValluesFromForm1(textBox2.Text, textBox3.Text, Text)*/
            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                errorProvider1.SetError(textBox3, "symbol is required");
                return;
            }
            else if (string.IsNullOrEmpty(textBox2.Text.Trim())) {

                errorProvider2.SetError(textBox2, "price is required");
                return;
            }

            else if (string.IsNullOrEmpty(textBox5.Text.Trim()))
            {

                errorProvider2.SetError(textBox5, "quantity is required");
                return;
            }

            else if (string.IsNullOrEmpty(comboOrderTypes.Text.Trim()))
            {

                errorProvider2.SetError(comboOrderTypes, "order type is required");
                return;
            }

            else if (string.IsNullOrEmpty(comboRoutes.Text.Trim()))
            {

                errorProvider2.SetError(comboRoutes, "routes is required");
                return;
            }

            else if (string.IsNullOrEmpty(comboTIF.Text.Trim()))
            {

                errorProvider2.SetError(comboTIF, "routes is required");
                return;
            }

            else if (string.IsNullOrEmpty(combaccount.Text.Trim()))
            {

                errorProvider2.SetError(combaccount, "routes is required");
                return;
            }
            else
            {

                // ID GENERTOR  CLASS      
                idGenerator ids = new idGenerator();

                this.textBox4.Text = ids.idf();

                datetext.Text = dateTimePicker1.Value.ToString();


                //Json Object
                var setData = new setData
                {
                    id = textBox4.Text,
                    name = textBox3.Text,
                    //Symbol = textBox2.Text,
                    quantity = textBox5.Text,
                    ordertypes = comboOrderTypes.Text,
                    accounttypes = combaccount.Text,
                    stplmt = stp.Text,
                    routes = comboRoutes.Text,
                    tif = comboTIF.Text,
                    price = textBox2.Text,
                    dd = datetext.Text,
                    // Date = DateTime.Parse(textBox1.Text),




                };

                sendData sendData = new sendData();
                sendData.serialize(setData);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();

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