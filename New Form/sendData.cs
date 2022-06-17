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
    internal class sendData
    {

        public void serialize(setData setData)
        {
            MessageBox.Show("Data Submit Successfull");
            string jsonString = JsonSerializer.Serialize(setData);
            string path = @"E:\usama.txt";
            using (StreamWriter sw = File.AppendText(path))
            {

                sw.WriteLine(jsonString);


            }
        }
    }
}