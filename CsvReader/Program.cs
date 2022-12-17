using System.IO;

namespace CsvReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            using (var reader = new StreamReader(@"C:\Temp\ford_escort.csv"))
            {
                List<FordEscort> fordEscorts = new List<FordEscort>();

                string headerLine = reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    var csValues = line.Split(',');

                    fordEscorts.Add(new FordEscort(csValues[0].Trim(), csValues[1].Trim(), csValues[2].Trim()));                    
                }
            }
        }
    }
}