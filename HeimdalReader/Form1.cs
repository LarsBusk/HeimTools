using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using NiceLittleLogger;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeimdalReader
{
    public partial class Form1 : Form
    {
        private Logger logger;

        private string testfolder =
            @"C:\Users\lab\Projects\GitHub\HeimTools\Full diagnostics - 2024-12-20 09.11.47.147\Storage\Json\IncidentRepository";

        private string testCondfolder =
            @"C:\Users\lab\Projects\GitHub\HeimTools\Full diagnostics - 2024-12-20 09.11.47.147\Storage\Json\ConditionRepository";

        private string samplesFolder =
            "C:\\Users\\lab\\Projects\\GitHub\\HeimTools\\Full diagnostics - 2024-12-20 09.11.47.147\\Storage\\Json\\SampleRepository";

        private string logsFolderPath;
        private SqLiteHelper helper;

        public Form1()
        {
            InitializeComponent();
            logger = new Logger("Main.txt");
            logsFolderPath = string.Empty;
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            var helper = new JsonHelper();
            
            logger.LogInfo("Starting to read incidents.");
            var inc = helper.GetIncidentContents(testfolder);
            logger.LogInfo($"{inc.Count} incidents added to list.");
            
            logger.LogInfo("Starting to log conditions.");
            var con = helper.GetConditionContents(testCondfolder);
            logger.LogInfo($"{con.Count} conditions added to list.");
            ShowStuff(inc);
        }

        private void ShowStuff(List<IContent> con)
        {
            var dt = new DataTable();
            dt.Columns.AddRange(con[0].Headers.Select(c => new DataColumn(c)).ToArray());

            foreach (var conditionContent in con)
            {
                dt.Rows.Add(conditionContent.Data);
            }

            dataGridView1.DataSource = dt;
        }

        private void incidentsBtn_Click(object sender, EventArgs e)
        {
            GetLogsFolder();
            helper = new SqLiteHelper(logsFolderPath);
            dataGridView1.DataSource = helper.GetIncidents();
        }

        private void conditionsBtn_Click(object sender, EventArgs e)
        {
            GetLogsFolder();
            helper = new SqLiteHelper(logsFolderPath);
            dataGridView1.DataSource = helper.GetConditions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jHelper = new JsonHelper();
            new Thread( () => jHelper.GetSamples(samplesFolder) ).Start();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            helper = new SqLiteHelper();

            var dt = helper.GetProducts();

            foreach (DataRow dataRow in dt.Rows)
            {
                var pName = dataRow["ProductName"].ToString();
                var root = new TreeNode(pName, Children(pName));
                treeView1.Nodes.Add(root);
            }
        }

        private void GetLogsFolder()
        {
            if (fromSimCb.Checked)
            {
                logsFolderPath = Path.Combine(Environment.GetEnvironmentVariable("Appdata"), "Foss", "Nora", "app_data");
                return;
            }

            var dialog = new FolderBrowserDialog
            {
                Description = "Select the surveillance logs folder.",
                SelectedPath = logsFolderPath
            };
            logsFolderPath = dialog.ShowDialog() == DialogResult.OK ?
                 dialog.SelectedPath:
                 string.Empty;
        }

        private TreeNode[] Children(string pName)
        {
            string[] byrn = new string[] { "PredictionModels", "OperationProfile" };

            var nodes = byrn.Select(b => new TreeNode(b, moreChildNodes(b, pName)));
            return nodes.ToArray();
        }

        private TreeNode[] moreChildNodes(string nodeName, string pName)
        {
            List<string> nods = new List<string>();

            if (nodeName.Equals("PredictionModels"))
            {
                var pms = helper.GetPms(pName);

                foreach (DataRow pm in pms.Rows)
                {
                    nods.Add(pm["PredictionModelName"].ToString());
                }
            }

            if (nodeName.Equals("OperationProfile"))
            {
                var ops = helper.GetOps(pName);

                foreach (DataRow op in ops.Rows)
                {
                    nods.Add(op["OpName"].ToString());
                }
            }

            var childNodes = nods.Select(b => new TreeNode(b));
            return childNodes.ToArray();
        }
    }
}
