using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace ReportClient
{

    delegate void SetTextCallBack(string text);

    [CallbackBehavior(UseSynchronizationContext = false, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public partial class Form1 : Form, ReportService.IReportServiceCallback
    {

        ReportService.ReportServiceClient client;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            InstanceContext context = new InstanceContext(this);
            client = new ReportService.ReportServiceClient(context);
            client.ProcessReport();
        }

        public void Progress(int precentCompleted)
        {
            textBox1.Text = precentCompleted.ToString() + " % completed";
        }

        private void SetText(string text)
        {
            if(textBox1.InvokeRequired)
            {
                SetTextCallBack d = new SetTextCallBack(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox1.Text = text;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            DownloadService.DownloadServiceClient client = new DownloadService.DownloadServiceClient();
            var file = client.DownloadFile();
            System.IO.File.WriteAllBytes("C:\\DownloadedFiles\\" + file.Name, file.Content);
            MessageBox.Show(file.Name + " downloaded and saved");
        }
    }
}
