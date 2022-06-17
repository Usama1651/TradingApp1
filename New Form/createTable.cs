using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Form
{
    public class createTable
    {

        DataTable table = new DataTable();

        public DataTable createNewDataTable()
        {
            
            table = new DataTable();

            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Symbol", typeof(string));
            table.Columns.Add("Quantity", typeof(string));

            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("OrderTypes", typeof(string));
            table.Columns.Add("AccountTypes", typeof(string));
            table.Columns.Add("TIF", typeof(string));
            table.Columns.Add("Routes", typeof(string));

            return table;

        }
    }
}
