using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Form
{
    internal class GridClass
    {
        /*string val1, val2, val3;
        public GridClass(string val1, string val2, string val3)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.val3 = val3;
        }*/

        DataTable datatable = new DataTable();
        DataGridView gv = new DataGridView();

        public DataGridView saveGridInfo(DataGridView gridView)
        {
            gv = gridView;
            string path = @"E:\usama.txt";
            File.WriteAllText(path, String.Empty);

            int counter = 0;
            List<String> valuesList = new List<String>();
            foreach (DataGridViewRow item in gridView.Rows)
            {
                counter++;


                String id = item.Cells["Id"].Value.ToString();
                String name = item.Cells["Name"].Value.ToString();
                //  String Symbol = item.Cells["Symbol"].Value.ToString();
                String quanity = item.Cells["Quantity"].Value.ToString();
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
                    // Symbol = Symbol,
                    quantity = quanity,
                    Price = price,
                    OrderTypes = ordertypes,
                    AccountTypes = accounttypes,
                    Tif = tif,
                    Routes = routes,
                    Dd = date,
                };

                // Convert String to Json

                string jsonString = System.Text.Json.JsonSerializer.Serialize(jsonCLASS);
                //yahan se jraha hay filr mau
                /*Console.WriteLine(jsonString);*/



                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine(jsonString);

                }
                if (counter == (gridView.Rows.Count - 1))
                {
                    break;
                }
            }

            return gv;
        }

        public DataGridView updateRow(int rowindex, DataGridView gridView, string rowName, string rowQuantity, string rowDate, string rowPrice, string rowOrderTypes, string rowAccountTypes, string rowTif, string rowRoutes)
        {
            gv = gridView;
            gridView.Rows[rowindex].Cells["Name"].Value = rowName;
            //  dataGridView1.Rows[rowindex].Cells["Symbol"].Value = rowAddress;
            gridView.Rows[rowindex].Cells["Quantity"].Value = rowQuantity;
            gridView.Rows[rowindex].Cells["Date"].Value = rowDate;
            gridView.Rows[rowindex].Cells["Price"].Value = rowPrice;
            gridView.Rows[rowindex].Cells["OrderTypes"].Value = rowOrderTypes;
            gridView.Rows[rowindex].Cells["AccountTypes"].Value = rowAccountTypes;
            gridView.Rows[rowindex].Cells["TIF"].Value = rowTif;
            gridView.Rows[rowindex].Cells["Routes"].Value = rowRoutes;
            saveGridInfo(gv);
            return gv;
        }


        public void getValluesFromForm1(string val1, string val2, string val3)
        {

        }
    }
}
