using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace HeimdalReader
{
    public class SqLiteHelper
    {
        private SQLiteConnection sqlite;

        #region SQL statements

        private const string GetIncidentsSql =
            "SELECT datetime(ROUND(ii.Timestamp / 1000), 'unixepoch') as [IncidentTime],s.name as [Source],i.Code,i.Severity,i.Message,i.Hint " +
            "FROM IncidentItem ii " +
            "INNER JOIN Incident i on i.Id = ii.IncidentId " +
            "INNER JOIN Source s ON s.Id = i.SourceId " +
            "ORDER BY ii.Id";

        private const string GetConditionsSql =
            "SELECT datetime(ROUND(ci.[From] / 1000), 'unixepoch') as [Raised]" +
            ",datetime(ROUND(ci.[To] / 1000), 'unixepoch') as [Lowered]" +
            ",s.name as [Source]" +
            ",c.Code," +
            "c.Message" +
            ",c.Hint " +
            "FROM ConditionItem ci " +
            "INNER JOIN Condition c ON c.Id = ci.ConditionId " +
            "INNER JOIN Source s ON s.Id = c.SourceId " +
            "ORDER BY ci.Id";

        private const string GetProductsSql = 
            "SELECT Name as ProductName, SampleType, Code as ProductCode " +
            "FROM Products";

        private const string GetPmsSql =
            "SELECT pm.Name as PredictionModelName, pm.Id " +
            "FROM Products pr " +
            "INNER JOIN ProductToPredictionModel ptpm ON ptpm.ProductId = pr.Id " +
            "INNER JOIN PredictionModels pm ON pm.Id = ptpm.PredictionModelId ";

        private const string GetOpsSql =
            "SELECT op.Name as OpName " +
            "FROM Products pr " +
            "INNER JOIN ProductToOperationProfile pto " +
            "ON pto.ProductId = pr.Id " +
            "INNER JOIN OperationProfiles op " +
            "ON op.Id = pto.OperationProfileId ";

        #endregion

        #region Public methods

        public SqLiteHelper()
        {
            sqlite = new SQLiteConnection(
                "Data Source=C:\\Users\\lab\\Projects\\GitHub\\HeimTools\\Full diagnostics - 2024-12-20 09.11.47.147\\Storage\\Sqlite\\Configuration.db");
        }

        public SqLiteHelper(string diagFolder)
        {
            var survDbPath = Path.Combine(diagFolder, "Storage", "Sqlite", "Surveillance.db");
            sqlite = new SQLiteConnection($"Data Source={survDbPath}");
        }

        public DataTable GetIncidents()
        {
            return GetStuff(GetIncidentsSql);
        }

        public DataTable GetConditions()
        {
            return GetStuff(GetConditionsSql);
        }

        public DataTable GetProducts()
        {
            return GetStuff(GetProductsSql);
        }

        public DataTable GetPms(string productName)
        {
            var sql = GetPmsSql + $"WHERE pr.Name = '{productName}'";
            return GetStuff(sql);
        }

        public DataTable GetOps(string productName)
        {
            var sql = GetOpsSql + $"WHERE pr.Name = '{productName}'";
            return GetStuff(sql);
        }

        #endregion

        private DataTable GetStuff(string query)
        {
            SQLiteDataAdapter ad;
            var dt = new DataTable();

            try
            {
                SQLiteCommand cmd = sqlite.CreateCommand();
                cmd.CommandText = query;
                sqlite.Open();
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            sqlite.Close();
            return dt;
        }
    }
}
