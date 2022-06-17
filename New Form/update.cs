using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Form;

    public class update
    {
    private object rowindex;
    private object dataGridView1;

    public void upadteDoc() {
        Form2 ff2 = new Form2();
        DataTable table = new DataTable();


        rowindex = dataGridView1.CurrentCell.RowIndex;
        if (dataGridView1.SelectedRows.Count == 0)
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
}

