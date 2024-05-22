using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetJitterFromLogs
{
    internal class Program
    {
        const string TimeFormat = "yyyy-MM-dd HH:mm:ss.fff";
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("Logs");
            var allLines = new List<string>();

            foreach (var file in files)
            {
                allLines.AddRange(GetLines(file));
            }
            
            File.AppendAllLines("Times.csv", TimeDifs(allLines));
        }

        private static List<string> GetLines(string file)
        {
            var lines = File.ReadAllLines(file);
            var timelines = lines.Where(l => l.Contains("Foss.Nora.Sample.TimeStamp.DateTime") | l.Contains("Foss.Nora.Instrument.SampleCounter"));
            return timelines.Where(l => !l.Contains("skipping writing value to OPC node")).ToList();
        }

        private static IEnumerable<string> TimeDifs(List<string> timelines)
        {
            var timeDifs = new List<string>();
            var cultureProvider = CultureInfo.InvariantCulture;

            for (int i = 0; i < timelines.Count() - 1; i+=2)
            {
                var stampPart = timelines[i +1].Substring(0, 23);
                var timeStamp = DateTime.ParseExact(stampPart, TimeFormat, cultureProvider);

                var sTimePart = timelines[i].Substring(108, 23).Replace('T', ' ');
                var sampleTime = DateTime.ParseExact(sTimePart, TimeFormat, cultureProvider);

                var dif = timeStamp - sampleTime;
                timeDifs.Add(((int) dif.TotalMilliseconds).ToString());
            }

            return timeDifs;
        }
    }
}
