using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader
{
    public class FordEscort
    {  
        public FordEscort(string year, string mileage, string price)
        {
            Year = year;
            Mileage = mileage;
            Price = price;
        }
            
        public string Year { get; set; }

        public string Mileage { get; set; }

        public string Price { get; set; }
    }
}
