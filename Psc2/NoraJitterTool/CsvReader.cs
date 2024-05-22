using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NoraJitterTool
{
    public class CsvReader
    {
        private readonly string _fileName;
        
        public CsvReader(string fileName)
        {
            _fileName = fileName;
        }

        public List<DelayInfo> GetRecords()
        {
            var records = new List<DelayInfo>();

            var lines = File.ReadAllLines(_fileName);

            foreach (var line in lines)
            {
                var parts = line.Split(';');

                //If the line can not be divided or the time diff or delay are not valid integers, skip the line.
                if (
                    !parts.Any() ||
                    !int.TryParse(parts[4], out var timeBetweenSamples) || 
                    !int.TryParse(parts[5], out var delay) ||
                    !int.TryParse(parts[2], out var sampleCounter)
                    ) continue;

                //First line after start
                if (
                    delay.Equals(-2147483648) ||
                    sampleCounter.Equals(0)
                    ) continue;

                var sampleNumber = parts[3];
                var opcTimeStamp = DateTime.Parse(parts[0].Replace(',','.')) ;
                var sampleTimeStamp = DateTime.Parse(parts[1].Replace(',', '.'));
                records.Add(new DelayInfo
                {
                    SampleNumber = sampleNumber,
                    TimeBetweenSamples = timeBetweenSamples,
                    Delay = delay,
                    OpcTimeStamp = opcTimeStamp,
                    SampleTimeStamp = sampleTimeStamp
                });
            } 

            return records;
        }
    }

    public struct DelayInfo
    {
        public string SampleNumber;
        public int TimeBetweenSamples;
        public int Delay;
        public DateTime OpcTimeStamp;
        public DateTime SampleTimeStamp;
    }
}
