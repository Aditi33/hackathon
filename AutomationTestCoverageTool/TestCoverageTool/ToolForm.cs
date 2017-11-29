using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCoverageTool
{
    public partial class ToolForm : Form
    {
        public ToolForm()
        {
            InitializeComponent();
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {

        }

        private void GetCoverage_Click(object sender, EventArgs e)
        {
            RunCoverage();
        }

        private void RunCoverage()
        {
            Process p = new Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = @"C:\Users\Aditi.Kulkarni\AppData\Local\JetBrains\Installations\dotCover09";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = @"D:\Hackathon\hackathon\AutomationTestCoverageTool\DotcoverCommand.bat";
            p.Start();


            ////System.Diagnostics.Process process = new System.Diagnostics.Process();
            ////System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            ////startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            ////startInfo.FileName = "cmd.exe";
            ////startInfo.WorkingDirectory = @"C:\Users\Aditi.Kulkarni\AppData\Local\JetBrains\Installations\dotCover09";
            ////startInfo.FileName = @"D:\Hackathon\hackathon\AutomationTestCoverageTool\DotcoverCommand.bat";
            ////process.StartInfo = startInfo;
            ////process.Start();
            ////Console.WriteLine(process.StandardOutput.ReadToEnd());
        }
    }
}
