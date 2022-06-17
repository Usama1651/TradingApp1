using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class setData
    {

    public string? id { get; set; }
    public string? name { get; internal set; }

    //public string? Symbol { get; set; }

    public string? quantity
        {
            get; set;
        }

    public string? ordertypes { get; internal set; }
    public string? accounttypes { get; internal set; }


    public string? routes { get; internal set; }
    public string? tif { get; internal set; }
    public string? price { get; internal set; }


    // public DateTimeOffset Date { get; set; }
    public string? dd { get; set; }

    public string? stplmt { get; internal set; }
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
    public string? Dd { get; set; }


    // public DateTimeOffset Date { get; set; }



}



