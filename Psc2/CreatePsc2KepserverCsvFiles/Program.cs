using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePsc2KepserverCsvFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xmlReader = new XmlNodeFileReader();
            var csvCreator = new CsvNodeFileCreator();

            var nodes = xmlReader.GetOpcUaNodes(args[0]);
            var fileName = args[0].Contains("Dexter") ? "Dxter" : "Psc2";
            csvCreator.CreateCsvFiles(nodes, fileName);
        }
    }
}
