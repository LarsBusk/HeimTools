using NiceLittleLogger;
using DexterOpcUaTestServer.Logging;
using DexterOpcUaTestServer.States;
using Opc.UaFx;
using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace DexterOpcUaTestServer
{
    public partial class MainForm : Form
    {
        public static string RootFolderName = "Foss.Dexter.";
        public static string ServerName = Properties.Settings.Default.ServerName;
        public static bool EnableUserPassword;
        public static bool EnableAnonymous = true;
        public static bool EnableCertificate;
        public static string User;
        public static string Password;
        public static X509Certificate2 Certificate;

        private OpcUaHelper helper;
        private readonly Logger statesLogger = new Logger("Logs", "States.txt");
        private LogHelper logHelper;
        public IState CurrentState
        {
            get => currentState;
            set
            {
                currentState = value;
                UpdateLabelText(stateLabel, $"State: {currentState.StateName}");
                AppendToRichTextBox(currentState.StateName);

                if (SettingsForm.LogOptions.LogStates)
                {
                    statesLogger.LogInfo($"New state: {currentState.StateName}");
                }
            }
        }
        
        private IState currentState;

        #region Private delegates

        private delegate void SetStartStopButtonTextCallback(string text);

        private delegate void UpdateLabelTextCallback(Label label, string text);

        private delegate void AppendToRichTextBoxDelegate(string text);

        #endregion





        public MainForm()
        {
            EnableUserPassword = false;
            InitializeComponent();
            Initialise();
        }

        #region EventHandlers

        private void BatchCounter_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            var counter = (OpcDataVariableNode<uint>)sender;
            UpdateLabelText(batchCounterLabel, $"Batch counter: {counter.Value}");
        }

        private void ResultCounter_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            var counter = (OpcDataVariableNode<uint>)sender;
            UpdateLabelText(resultCounterLabel, $"Result counter: {counter.Value}");
        }

        private void ProductName_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            var node = (OpcDataVariableNode<string>)sender;
            UpdateLabelText(productLabel, $"Product: {node.Value}");
        }

        private void WatchdogCounterAfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            var node = (OpcDataVariableNode<uint>)sender;
            var watchdog = node.Value.ToString();
            UpdateLabelText(watchdogLabel, watchdog);
            helper.UpdateServerWatchdog();
        }

        private void ModeNode_AfterApplyChanges(object sender, OpcNodeChangesEventArgs e)
        {
            var node = (OpcDataVariableNode<string>)sender;
            var noraMode = node.Value;

            switch (noraMode)
            {
                case "Measuring":
                    CurrentState = new StateDexterMeasuring(helper);
                    SetStartStopButtonText("Stop");
                    break;
                case "Stopped":
                    CurrentState = new StateDexterStopped(helper);
                    SetStartStopButtonText("Start");
                    logHelper.NewMeasurement();
                    break;
                case "SelfTest":
                    CurrentState = new StateDexterSelfTest(helper);
                    break;
                case "WaitConveyor":
                    CurrentState = new StateDexterWaitConveyor(helper);
                    break;
                case "WaitXray":
                    CurrentState = new StateDexterWaitXray(helper);
                    break;
                case "Reference":
                    CurrentState = new StateDexterReference(helper);
                    break;
            }
        }


        private void Server_StateChanged(object sender, Opc.UaFx.Server.OpcServerStateChangedEventArgs e)
        {
            var mes = e.NewState.ToString();
            serverStateLabel.Text = mes;

            switch (mes)
            {
                case "Started":
                    CurrentState = new StateServerStarted(helper);
                    break;
                case "Stopped":
                    CurrentState = new StateServerStopped(helper);
                    break;
            }
        }

        #endregion EventHandlers

        #region Ui Events

        private void startButton_Click(object sender, EventArgs e)
        {
            CurrentState.StartServer();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            CurrentState.StopServer();
        }

        private void nodesButton_Click(object sender, EventArgs e)
        {
            if (!helper.Server.Server.State.Equals(Opc.UaFx.Server.OpcServerState.Started)) return;

            var nodesForm = new NodesForm(helper);
            nodesForm.Show();
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            CurrentState.StartStopMeasuring();
        }

        private void productTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentState.ChangeProduct(productTextBox.Text);
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentState.OpenSettings();
            helper = null;
            Initialise();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(helper is null))
            {
                CurrentState.StopServer();
            }

            this.Close();
        }

        private void alarmsButton_Click(object sender, EventArgs e)
        {
            var alarmsForm = new AlarmsForm(helper);
            alarmsForm.Show();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            var eventsForm = new EventsForm(helper);
            eventsForm.Show();
        }

        private void recipeTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentState.ChangeRecipe(recipeTextBox.Text);
        }

        #endregion Ui Events

        private void Initialise()
        {
            if (!Directory.Exists(Properties.Settings.Default.LogFolder))
                Directory.CreateDirectory(Properties.Settings.Default.LogFolder);

            helper = new OpcUaHelper(
                serverName: ServerName,
                homeFolder: RootFolderName,
                enableAnonymous: EnableAnonymous,
                enableUserAndPassword: EnableUserPassword,
                enableCertificate: EnableCertificate,
                userName: User,
                password: Password,
                certificate: Certificate);

            logHelper = new LogHelper(helper);

            helper.Server.Server.StateChanged += Server_StateChanged;
            helper.Nodes.InstrumentNodes.Mode.AfterApplyChanges += ModeNode_AfterApplyChanges;
            helper.Nodes.InstrumentNodes.WatchdogCounter.AfterApplyChanges += WatchdogCounterAfterApplyChanges;
            helper.Nodes.InstrumentNodes.ProductName.AfterApplyChanges += ProductName_AfterApplyChanges;
            helper.Nodes.InstrumentNodesDexter.BatchCounter.AfterApplyChanges += BatchCounter_AfterApplyChanges;
            helper.Nodes.InstrumentNodesDexter.ResultCounter.AfterApplyChanges += ResultCounter_AfterApplyChanges;

            CurrentState = new StateServerStopped(helper);
            SettingsForm.LogOptions = InitialiseLogging();
        }



        private LogOptions InitialiseLogging()
        {
            return new LogOptions
            {
                LogJitter = true,
                LogStates = true,
                LogMeasuredValues = true,
                LogNodeValues = true
            };
        }

        
        #region Updaters

        private void SetStartStopButtonText(string text)
        {
            if (startStopButton.InvokeRequired)
            {
                SetStartStopButtonTextCallback d = SetStartStopButtonText;
                this.Invoke(d, new object[] { text });
                return;
            }

            startStopButton.Text = text;
        }

        private void UpdateLabelText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                UpdateLabelTextCallback d = new UpdateLabelTextCallback(UpdateLabelText);
                this.Invoke(d, new object[] { label, text });
                return;
            }

            label.Text = text;
        }


        private void AppendToRichTextBox(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                AppendToRichTextBoxDelegate d = AppendToRichTextBox;
                this.Invoke(d, new object[] { text });
                return;
            }

            richTextBox1.AppendText($"{DateTime.Now}: {text}\n");
            richTextBox1.ScrollToCaret();
        }



        #endregion

        private void simulateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SimulateForm(this);
            form.ShowDialog();
        }
    }
}
