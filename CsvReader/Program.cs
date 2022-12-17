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

                // skip the header line
                string? headerLine = reader.ReadLine();
                
                while(!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();

                    var columns = line.Split(',');

                    fordEscorts.Add(new FordEscort(columns[0].Trim(), columns[1].Trim(), columns[2].Trim()));                    
                }
            }
        }
    }
}