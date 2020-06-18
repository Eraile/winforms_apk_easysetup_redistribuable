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

namespace winforms_apk_easysetup_redistribuable
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_uninstall_Click(object sender, EventArgs e)
        {
            this.RunADB(" uninstall com.mycompany.myapp");
        }

        private void button_install_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            openfile.Filter = "APK|*.apk";
            openfile.Title = "Open a file..";
            if (openfile.ShowDialog() == DialogResult.OK && openfile.FileName.EndsWith(".apk") == true)
            {
                this.RunADB(" install -r \"" + openfile.FileName  + "\"");
            }
        }

        public void RunADB(string _adbParameters)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "adbfastboot", "adb.exe");
            startInfo.Arguments = _adbParameters;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit(20000);
        }
    }
}
