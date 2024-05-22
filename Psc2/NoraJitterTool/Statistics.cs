using System.Collections.Generic;
using System.Linq;
using NoraJitterTool.Model;

namespace NoraJitterTool
{
    public class Statistics
    {
        private readonly NoraJitterData _context;

        public Statistics(NoraJitterData context)
        {
            _context = context;
        }

        public JitterStatistics GetDelayStatistics(int setupId)
        {
            return GetStatistics(setupId, GetDelays(setupId));
        }

        public JitterStatistics GetTimeBetweenSamplesStatistics(int setupId)
        {
            return GetStatistics(setupId, GetTimesBetweenSamples(setupId));
        }

        private JitterStatistics GetStatistics(int setupId, List<int> numbers)
        {
            return new JitterStatistics
            {
                SetupId = setupId,
                Count = GetCount(numbers),
                Max = GetMax(numbers),
                Min = GetMin(numbers),
                Mean = GetMean(numbers),
                StdDev = GetStdDev(numbers)
            };
        }

        private double GetMean(List<int> numbers)
        {
            if (!numbers.Any()) return -1;

            return numbers.Average();
        }

        private int GetMax(List<int> numbers)
        {
            if (!numbers.Any()) return -1;

            return numbers.Max();
        }

        private int GetMin(List<int> numbers)
        {
            if (!numbers.Any()) return -1;

            return numbers.Min();
        }

        private int GetCount(List<int> numbers)
        {
            if (!numbers.Any()) return -1;

            return numbers.Count;
        }

        private double GetStdDev(List<int> numbers)
        {
            if (!numbers.Any()) return -1;

            return numbers.StdDev();
        }

        private List<int> GetDelays(int setupId)
        {
            var opcDelays = _context.Delays.
                Where(d => d.TestSetupId.Equals(setupId)).
                Select(d => d.Delay); 

            return opcDelays.Any() ? opcDelays.ToList() : new List<int>();
        }

        private List<int> GetTimesBetweenSamples(int setupId)
        {
            var tbs = _context.Delays.
                Where(d => d.TestSetup.Equals(setupId)).
                Select(d => d.TimeBetweenSamples).
                Where(t => t < 35000);

            return tbs.Any() ? tbs.ToList() : new List<int>();
        }
    }

    public struct JitterStatistics
    {
        public int SetupId;
        public int Count;
        public int Min;
        public int Max;
        public double Mean;
        public double StdDev;
    }
}
