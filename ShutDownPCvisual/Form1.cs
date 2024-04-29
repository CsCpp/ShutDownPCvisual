using System.Diagnostics;

namespace ShutDownPCvisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "shutdown.exe";
            p.StartInfo.Arguments = "/s /t 0";
            p.Start();
        }
    
    }
}
