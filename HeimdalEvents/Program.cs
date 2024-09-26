using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimdalEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = new JsonFileHelper();
            var events = new List<EventContent>();
            var files = Directory.GetFiles(".\\EventFiles", "*.json");
            var outFile = "HeimDalEvents.csv";
            foreach (var file in files)
            {
                events.AddRange(helper.GetEvents(file));
            }

            if (File.Exists(outFile))
            {
                File.Delete(outFile);
            }

            File.AppendAllText(outFile, "Module;Type;Code;Message;Hint\n");
            foreach (var e in events)
            {
                File.AppendAllText(outFile, $"{e}\n");
            }
        }
    }
}
