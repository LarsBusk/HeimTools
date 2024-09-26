using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HeimdalEvents
{
    public class JsonFileHelper
    {
        public List<EventContent> GetEvents(string path)
        {
            var events = new List<EventContent>();

            var json = File.ReadAllText(path);
            JObject js = JObject.Parse(json);

            var module = (string)js["module"];
            var conditions = (JArray)js["conditions"];

            events.AddRange(conditions.Select(c => new EventContent
            {
                Type = "Condition",
                Module = module,
                Code = (int)c["code"],
                Message = (string)c["message"],
                Hint = (string)c["hint"]
            }));

            var incidents = (JArray)js["incidents"];

            events.AddRange(incidents.Select(i => new EventContent
            {
                Type = "Incident",
                Module = module,
                Code = (int)i["code"],
                Message = (string)i["message"],
                Hint = (string)i["hint"]
            }));
            

            return events;
        }

    }
}
