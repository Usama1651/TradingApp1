using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace New_Form
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        User userClass = new User();
        GridClass gridClass = new GridClass();

        //public void createButton() {
        //    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        //    btn.HeaderText = "DEL";
        //    btn.Name = "button";
        //    btn.Text = "Delete";
        //    btn.UseColumnTextForButtonValue = true;
        //    dataGridView1.Columns.Add(btn);


        //}
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MyMethod();
            /*    // get lines from the text file
                string[] lines = File.ReadAllLines(@"D:\usama.txt");
                //string[] values;

                for (int i = 0; i < lines.Length; i++)
                {
                    User values = JsonConvert.DeserializeObject<User>(lines[i]);
                    //values = JsonConvert.DeserializeObject<User>(lines[i]);
                    //string[] row = new string[values.Length];

                    table.Rows.Add(values.id, values.name, values.address, values.date);

                }*/
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // add columns to datatable

            dataGridView1.DataSource = userClass.getAllUser();
            // for showing delete button
            //createButton();
            // to show the data in grid view from

            if(rowName != "" && /*rowDate != "" &&*/ rowQuantity !="" && rowPrice!="" && rowOrderTypes != "" && rowAccountTypes != "" && rowTif != "" && rowRoutes != "")
            {
                dataGridView1 = gridClass.updateRow(rowindex, dataGridView1, rowName, rowQuantity, rowDate, rowPrice, rowOrderTypes, rowAccountTypes, rowTif, rowRoutes);

                /*dataGridView1 = gridClass.saveGridInfo(dataGridView1);
*/
                //MessageBox.Show(valuesList.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static String rowName = "";
       // public static String rowSymbol = "";
        public static String rowDate = "";
        public static String rowQuantity = "";
        public static String rowPrice = "";
        public static String rowOrderTypes = "";
        public static String rowRoutes = "";
        public static String rowAccountTypes = "";
        public static String rowTif = "";

        public static int rowindex = 0;

        private void update_btn_Click(object sender, EventArgs e)
        {
            rowindex = dataGridView1.CurrentCell.RowIndex;
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
/*
            String rowData = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();*/
            rowName = dataGridView1.Rows[rowindex].Cells["Name"].Value.ToString();
           // rowSymbol = dataGridView1.Rows[rowindex].Cells["Symbol"].Value.ToString();
            rowQuantity = dataGridView1.Rows[rowindex].Cells["Quantity"].Value.ToString();
            rowDate = dataGridView1.Rows[rowindex].Cells["Date"].Value.ToString();
            rowPrice = dataGridView1.Rows[rowindex].Cells["Price"].Value.ToString();
            rowOrderTypes = dataGridView1.Rows[rowindex].Cells["OrderTypes"].Value.ToString();
            rowAccountTypes = dataGridView1.Rows[rowindex].Cells["AccountTypes"].Value.ToString();
            rowTif = dataGridView1.Rows[rowindex].Cells["TIF"].Value.ToString();
            rowRoutes = dataGridView1.Rows[rowindex].Cells["Routes"].Value.ToString();

            /*MessageBox.Show(rowName + " " + rowDate + " " + rowAddress);*/
            

            UpdateItemForm form = new UpdateItemForm();
            form.Show();
            this.Close();
                        
            //Form2 formS = new Form2();
            //formS.Show();
            //this.Close();



        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
            if (selectedrowindex == 0)
            {
                MessageBox.Show("Please select a row.");
                return;
            }
            dataGridView1.Rows.RemoveAt(selectedrowindex);

            gridClass.saveGridInfo(dataGridView1);

          /*  string path = @"E:\usama.txt";
            File.WriteAllText(path, String.Empty);

            int counter = 0;
            List<String> valuesList = new List<String>();*/
/*            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                counter++;


                String id = item.Cells["Id"].Value.ToString();
                String name = item.Cells["Name"].Value.ToString();
               // String Symbol = item.Cells["Symbol"].Value.ToString();
                String Quantity = item.Cells["Quantity"].Value.ToString();  // if anything is here so change it.
                String date = item.Cells["Date"].Value.ToString();
                String price = item.Cells["Price"].Value.ToString();
                String ordertypes = item.Cells["OrderTypes"].Value.ToString();
                String accounttypes = item.Cells["AccountTypes"].Value.ToString();
                String tif = item.Cells["TIF"].Value.ToString();
                String routes = item.Cells["Routes"].Value.ToString();
                var jsonCLASS = new JSONCLASS
                {
                    Id = id,
                    Name = name,
                  //  Symbol = Symbol,
                    quantity= Quantity,
                    Price = price,
                    OrderTypes = ordertypes,
                    AccountTypes = accounttypes,
                    Tif = tif,
                    Routes = routes,
                    //Date = date,
                };

                // Convert String to Json

                string jsonString = System.Text.Json.JsonSerializer.Serialize(jsonCLASS);
                //yahan se jraha hay filr mau
                *//*Console.WriteLine(jsonString);*//*



                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine(jsonString);

                }
                if (counter == (dataGridView1.Rows.Count - 1))
                {
                    break;
                }
            }
*/        }
    } }

        
    

 


