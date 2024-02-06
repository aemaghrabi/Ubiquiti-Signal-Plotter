using Renci.SshNet;
using ScottPlot.Plottable;
using System.ComponentModel;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Ubiquiti_Signal_Plotter
{
    public partial class Form1 : Form
    {
        public SshClient client;

        private bool isConnected = false;
        private bool isStarted = false;
        private readonly BackgroundWorker backgroundWorker;

        private DataLogger signal_plot_logger;
        //private DataLogger txPower_plot_logger;
        //private DataLogger rssi_plot_logger;

        //private DataStreamer plot_logger;
        private int sampleCount = 0;

        private Dictionary<int, double> samples = new Dictionary<int, double>();

        public Form1()
        {
            InitializeComponent();

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            db_formsPlot.Plot.Legend(true);
            db_formsPlot.Plot.XLabel("Sample Number");
            db_formsPlot.Plot.XAxis.AxisTicks.MajorLineWidth = 1;
            db_formsPlot.Plot.XAxis.AxisTicks.MinorLineWidth = 1;
            db_formsPlot.Plot.YLabel("Power (dBm)");
            db_formsPlot.Refresh();
        }

        private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                start_button.Text = "Start";
                isStarted = false;
            }
        }

        private void BackgroundWorker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            if (isStarted == true)
            {
                start_button.Text = "Stop";
            }

            var rawData = e.UserState as string;

            if (string.IsNullOrEmpty(rawData))
                return;

            var dtObj = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<WstalistResponse>>(rawData);
            //var dtObj = Newtonsoft.Json.JsonConvert.DeserializeObject<IWConfig>(rawData);

            if (dtObj == null)
                return;
            //if (string.IsNullOrEmpty(rawData))


            var receivedData = dtObj.First();

            rawdata_richTextBox.Text = rawData;

            rxPower_textbox.Text = receivedData.Remote.Signal.ToString();
            rx_power_dbm_7seg.Value = receivedData.Remote.Signal.ToString();
            rx_power_mw_7seg.Value = dbmTomW(receivedData.Remote.Signal).ToString();
            txPower_textbox.Text = receivedData.TransmitPower.ToString();
            rssi_textbox.Text = receivedData.Remote.RSSI.ToString();
            tx_power_dbm_7seg.Value = receivedData.TransmitPower.ToString();
            tx_power_mw_7seg.Value = dbmTomW(receivedData.TransmitPower).ToString();
            //rssi_sevenSegmentArray.Value = dbmTomW(receivedData.Remote.RSSI).ToString();

            //var timestamp = receivedData.Remote.Time;
            //var time = DateTime.Parse(timestamp);

            //TimeSpan t = time - new DateTime(1970, 1, 1);

            //plot_logger.Add(receivedData.Remote.Signal);
            var value = receivedData.Remote.Signal;
            signal_plot_logger.Add(sampleCount, value);
            samples.Add(sampleCount, value);
            //txPower_plot_logger.Add(sampleCount, receivedData.TransmitPower);
            //rssi_plot_logger.Add(sampleCount, receivedData.Remote.RSSI);
            //plot_logger.ViewWipeRight(); // new data overwrites old data left to right
            //plot_logger.ViewWipeLeft(); // new data overwrites old data right to left
            //plot_logger.ViewScrollRight(); // new data is inserted on the left
            //plot_logger.ViewScrollLeft(); // new data is inserted on the right
            db_formsPlot.Refresh();
            sampleCount++;
        }

        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            isStarted = true;

            while (true)
            {
                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                //var command = client.CreateCommand("wstalist");
                var command = client.CreateCommand("wstalist");

                command.Execute();

                string output = command.Result;

                backgroundWorker.ReportProgress(0, output);

                command.Dispose();

                Thread.Sleep(500);

                var valuedBm = (string.IsNullOrEmpty(rxPower_textbox.Text)) ? 0 : Convert.ToDecimal(rxPower_textbox.Text);
                var upperVal = upper_level_numericUpDown.Value;
                var lowerVal = lower_level_numericUpDown.Value;

                if (valuedBm >= lowerVal && valuedBm <= upperVal)
                {
                    ledBulb1.Color = Color.Red;
                }
                else
                {
                    ledBulb1.Color = Color.Green;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isConnected = false;
            isStarted = false;

            signal_plot_logger = db_formsPlot.Plot.AddDataLogger(label: "Received Signal", color: Color.Black, lineWidth: 2);
            //rssi_plot_logger = db_formsPlot.Plot.AddDataLogger(label: "RSSI", color: Color.Blue);
            //txPower_plot_logger = db_formsPlot.Plot.AddDataLogger(label: "TX Power", color: Color.Red);

            signal_plot_logger.ViewSlide(100);
            //signal_plot_logger.ViewFull();
            //signal_plot_logger.ViewWipeRight();
            //rssi_plot_logger.ViewSlide();
            //txPower_plot_logger.ViewSlide();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (isConnected)
                disconnect();
            else
                connect();
        }

        private void disconnect()
        {

            if (isStarted)
            {
                stop();
            }

            if (client == null)
                return;

            client.Disconnect();
            client.Dispose();

            isConnected = false;

            start_button.Enabled = false;
            connect_button.Text = "Connect";
        }

        private void connect()
        {
            // Check IP Address
            var ipCheck = Regex.Match(ip_textbox.Text, @"^(?:(?:25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])$");

            if (!ipCheck.Success)
            {
                MessageBox.Show("IP Should follow the format 255.255.255.255", "Incorrect IP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            client = new SshClient(ip_textbox.Text, username_textbox.Text, password_textbox.Text);

            client.ClientConnected += (s, e) =>
            {
                isConnected = true;
                connect_button.Text = "Disconnect";
                start_button.Enabled = true;
            };

            client.ErrorOccurred += (s, e) =>
            {
                if (e != null)
                    MessageBox.Show(e.Exception.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            try
            {
                client.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (isStarted)
                stop();
            else
                start();
        }

        private void start()
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void stop()
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }

        private void saveFigure_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                db_formsPlot.Plot.SaveFig(saveFileDialog.FileName);
            }
        }

        private void exportData_button_Click(object sender, EventArgs e)
        {
            String csvStr = String.Join(Environment.NewLine, samples.Select(s => $"{s.Key},{s.Value};"));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, csvStr);
            }
        }

        private string dbmTomW(double dbm)
        {
            var P_mw = 1000 * Math.Pow(10, (dbm - 30) / 10);

            return String.Format("{0:0.0000}", P_mw);
            //if (dbm < 0) dbm = -1 * dbm;
            //var val = (1 * 10 ^ (-3)) * Math.Pow(10, (dbm / 10));
            //return String.Format("{0:0.00}", val); ;
        }
    }
}