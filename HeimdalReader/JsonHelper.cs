using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NiceLittleLogger;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeimdalReader
{
    public class JsonHelper
    {
        private Logger logger;
        private Logger timeLogger;

        public JsonHelper()
        {
            logger = new Logger("Log.txt");
        }
        
        public List<IContent> GetIncidentContents(string folder)
        {
            var fileContents = GetFileContents(folder);
            var incidents = new List<IContent>();

            foreach (var fileContent in fileContents)
            {
                var jsonObj = JObject.Parse(fileContent);
                List<ParameterContent> a;
                try
                {
                    a = jsonObj["Parameters"].Select(p => new ParameterContent
                    {
                        Name = (string)p["Name"],
                        Value = (string)p["Value"],
                        Type = (int)p["Type"]
                    }).ToList();
                }
                catch (Exception)
                {
                    a = new List<ParameterContent>();
                }

                var content = new IncidentContent
                {
                    Level = (int)jsonObj["Level"],
                    Code = (int)jsonObj["Code"],
                    Source = (string)jsonObj["Source"],
                    Message = (string)jsonObj["Message"],
                    DetailedMessage = (string)jsonObj["DetailedMessage"],
                    Hint = (string)jsonObj["Hint"],
                    TimeStamp = (DateTime)jsonObj["TimeStamp"],
                    Parameters = a
                };

                incidents.Add(content);
            }

            return incidents;
        }

        public List<IContent> GetConditionContents(string folder)
        {
            var fileContents = GetFileContents(folder);
            var conditions = new List<IContent>();

            foreach (var fileContent in fileContents)
            {
                var jsonObj = JObject.Parse(fileContent);

                conditions.Add(new ConditionContent
                {
                    State = (int)jsonObj["State"],
                    Code = (int)jsonObj["Code"],
                    Source = (string)jsonObj["Source"],
                    Message = (string)jsonObj["Message"],
                    DetailedMessage = (string)jsonObj["DetailedMessage"],
                    Hint = (string)jsonObj["Hint"],
                    TimeStamp = (DateTime)jsonObj["TimeStamp"]
                });
            }
            return conditions;
        }

        public string GetJs(string folder)
        {
            var fileContents = GetFileContents(folder);
            var js = new StringBuilder();
            js.Append("[");
            foreach (var fileContent in fileContents)
            {
                js.Append(fileContent);
                js.Append(",");
            }

            js.Remove(js.Length - 1, 1);
            js.Append("]");
            var str = js.ToString();
            File.WriteAllText("js.json", str);
            return str;
        }

        public void GetSamples(string folder)
        {
            GetFileContents(folder);
        }

        private IEnumerable<string> GetFileContents(string folder)
        {
            var files = Directory.GetFiles(folder).Where(f => f.Contains(@".slim"));
            logger.LogInfo("Start reading files");
            var fileContents = new ConcurrentBag<string>();


            Parallel.ForEach(files, f => { fileContents.Add(File.ReadAllText(f)); });
                
            logger.LogInfo($"{fileContents.Count()} files are read.");
            return fileContents;
        }

    }
}
