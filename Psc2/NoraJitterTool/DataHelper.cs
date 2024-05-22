using Microsoft.Extensions.Configuration;
using NoraJitterTool.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NoraJitterTool
{
    public class DataHelper
    {
        private readonly NoraJitterData context;
        private readonly Statistics statistics;

        public DataHelper()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json");
            var config = builder.Build();
            context = new NoraJitterData(config);
            statistics = new Statistics(context);
        }

        public int AddTestSystem(string serialNumber, long chassisId, string type, string systemName)
        {
            if (GetTestSystem(chassisId) != 0) return GetTestSystem(chassisId);

            context.TestSystem.Add(new TestSystem
            {
                ChassisId = chassisId,
                SerialNumber = serialNumber,
                Type = type,
                SystemName = systemName
            });
            context.SaveChanges();
            var testSystemId = context.TestSystem.Max(t => t.TestSystemId);

            return testSystemId;
        }

        public int GetTestSystem(long chassisId)
        {
            var system = context.TestSystem.FirstOrDefault(t => t.ChassisId.Equals(chassisId));
            return system is null ? 0 : system.TestSystemId;
        }

        public List<TestSystemComboItem> TestSystems()
        {
            var comboItems = new List<TestSystemComboItem>();
            var systems = context.TestSystem.Distinct().ToList();
            comboItems = systems.Select(s => new TestSystemComboItem(s.SystemName, s.ChassisId)).ToList();
            return comboItems;
        }

        public List<TestSetupComboItems> TestSetups()
        {
            var comboItems = new List<TestSetupComboItems>();
            var setups = context.TestSetup.Distinct();
            comboItems = setups.Select(s => new TestSetupComboItems(s.TestTime, s.TestSetupId)).ToList();
            comboItems.Sort();
            return comboItems;
        }

        public List<DelayComboItem> Delays(int testSetupId)
        {
            var comboItems = new List<DelayComboItem>();
            var delays = context.Delays.Where(d => d.TestSetupId.Equals(testSetupId)).ToList();
            comboItems = delays.Select(d => new DelayComboItem(d.SampleNumber, d.DelaysId)).ToList();
            return comboItems;
        }

        public string[] NoraVersions()
        {
            var versions = context.TestSetup.Select(t => t.NoraVersion).Distinct().OrderByDescending(s => s);
            return versions.ToArray();
        }

        public string[] PlatformVersions()
        {
            var versions = context.TestSetup.Select(t => t.PlatformVersion).Distinct().OrderByDescending(s => s);
            return versions.ToArray();
        }

        public int AddNewTestSetup(long chassisId, string novaVersion, DateTime testTime, string platformVersion,
            string comment, string csvFileName, bool noDelayedResults, bool physicalPc, int numberOfCycles)
        {
            var testSystem = context.TestSystem.First(t => t.ChassisId.Equals(chassisId));
            testSystem.TestSetup.Add(new TestSetup
            {
                NoraVersion = novaVersion,
                TestTime = testTime,
                PlatformVersion = platformVersion,
                Comment = comment,
                CsvFileName = csvFileName,
                NoDelayedResults = noDelayedResults,
                PhysicalPC = physicalPc,
                NumberOfCycles = numberOfCycles
            });
            context.SaveChanges();

            return context.TestSetup.Max(t => t.TestSetupId);
        }

        public void RemoveTestSetup(int setupId)
        {
            var testSetup = GetTestSetup(setupId);
            context.TestSetup.Remove(testSetup);
            context.SaveChanges();
        }

        public void RemoveDelay(int delayId)
        {
            var delay = GetDelay(delayId);
            context.Delays.Remove(delay);
            context.SaveChanges();
        }

        public void AddDelays(int testSetupId, List<DelayInfo> delayInfos)
        {
            var testSetup = GetTestSetup(testSetupId);

            var delays = delayInfos.Select(d => new Delays
            {
                SampleNumber = d.SampleNumber,
                TimeBetweenSamples = d.TimeBetweenSamples,
                Delay = d.Delay,
                OpcServerTimeStamp = d.OpcTimeStamp,
                SampleDateTime = d.SampleTimeStamp
            }).ToList();

            testSetup.Delays = delays;
            
            context.SaveChanges();
        }

        public void AddStatistics(int testSetupId)
        {
            context.Database.ExecuteSql($"EXEC dbo.sp_add_statistics @TestSetupId = {testSetupId}");
        }

        public JitterStatistics GetDelayStatistics(int setupId)
        {
            return statistics.GetDelayStatistics(setupId);
        }

        private TestSetup GetTestSetup(int setupId)
        {
            var testSetup = context.TestSetup.First(t => t.TestSetupId.Equals(setupId));
            return testSetup;
        }

        private Delays GetDelay(int delayId)
        {
            var delay = context.Delays.First(d => d.DelaysId.Equals(delayId));
            return delay;
        }
    }
}
