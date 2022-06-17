using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Form
{

    public class User
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public DateTimeOffset date { get; set; }
        //public string Symbol { get; set; }
        public string? quantity { get; set; }

        public string? price { get; set; }
        public string? OrderTypes { get; set; }
        public string? AccountTypes { get; set; }
        public string? routes { get; set; }
        public string? tif { get; set; }
        public string? dd { get; set; }


        DataTable table = new DataTable();
       
        
        public DataTable getAllUser()
        {


            
            createTable ct = new createTable();
            table = ct.createNewDataTable();


            string[] lines = File.ReadAllLines(@"E:\usama.txt");
        

            for (int i = 0; i < lines.Length; i++)
            {
                User values = JsonConvert.DeserializeObject<User>(lines[i]);
                //values = JsonConvert.DeserializeObject<User>(lines[i]);
                //string[] row = new string[values.Length];

                //yahan file se utha rhay hen wo grid may show karwa rhay
                //List<User> valuesList = new List<User>();

                table.Rows.Add(values.id, values.name, values.quantity, values.dd, values.price, values.OrderTypes, values.AccountTypes, values.tif, values.routes);

                //.Rows.RemoveAt(i);
                //Button btn;
                //for (int n_i = 0; n_i < 10; n_i++) { 
                //btn = (Button)Controls.Find("button" + n_i, true)[];
                //btn.Text = "";
                //}

            }

            return table;
        }


       


    }
}
