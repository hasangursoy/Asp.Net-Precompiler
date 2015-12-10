using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using System.Runtime.InteropServices;
using System.IO;

namespace Asp.Net_Precompiler
{
    public partial class frmMain : Form
    {
        [DllImport("kernel32", EntryPoint = "GetShortPathName", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetShortPathName(string longPath, StringBuilder shortPath, int bufSize);

        public frmMain()
        {
            InitializeComponent();
        }

        #region Load & Save settings
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text += " v" + Application.ProductVersion.Substring(0, 3);
            tSourcePath.Text = AspNetPrecompiler.Properties.Settings.Default.LastSourcePath;
            tDestinationPath.Text = AspNetPrecompiler.Properties.Settings.Default.LastDestinationPath;
            cbVersion.SelectedItem = AspNetPrecompiler.Properties.Settings.Default.LastVersion;
            cbOpenDestinationAfterCompile.Checked = AspNetPrecompiler.Properties.Settings.Default.OpenDFAC;
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            AspNetPrecompiler.Properties.Settings.Default.LastSourcePath = tSourcePath.Text;
            AspNetPrecompiler.Properties.Settings.Default.LastDestinationPath = tDestinationPath.Text;
            AspNetPrecompiler.Properties.Settings.Default.LastVersion = cbVersion.SelectedItem.ToString();
            AspNetPrecompiler.Properties.Settings.Default.OpenDFAC = cbOpenDestinationAfterCompile.Checked;
            AspNetPrecompiler.Properties.Settings.Default.Save();
        }
        #endregion

        #region SelectSourcePath
        private void btnSelectSource_Click(object sender, EventArgs e) { SelectSourcePath(sender); }
        private void btnSelectSource_Click(object sender, MouseEventArgs e) { SelectSourcePath(sender); }
        private void SelectSourcePath(object sender)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please select sourcecode folder";
            fbd.RootFolder = System.Environment.SpecialFolder.Desktop;

            if (!String.IsNullOrEmpty(tSourcePath.Text)) fbd.SelectedPath = tSourcePath.Text;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tSourcePath.Text = fbd.SelectedPath;
            }
        }
        #endregion

        #region SelectDestinationPath
        private void btnSelectDestination_Click(object sender, EventArgs e) { SelectDestination(sender); }
        private void btnSelectDestination_Click(object sender, MouseEventArgs e) { SelectDestination(sender); }
        private void SelectDestination(object sender)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please select destination folder";
            fbd.RootFolder = System.Environment.SpecialFolder.Desktop;

            if (!String.IsNullOrEmpty(tDestinationPath.Text)) fbd.SelectedPath = tDestinationPath.Text;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tDestinationPath.Text = fbd.SelectedPath;
            }
        }
        #endregion

        #region Pre-Compilation & BackgroundWorker
        private void btnCompile_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tSourcePath.Text))
            {
                MessageBox.Show("Source path not valid or deleted!");
                return;
            }

            if (bw.IsBusy != true)
            {
                pbMain.Visible = !(btnCompile.Enabled = tSourcePath.Enabled = tDestinationPath.Enabled = cbVersion.Enabled = btnSelectSource.Enabled = btnSelectDestination.Enabled = false);
                bw.RunWorkerAsync();
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            Application.DoEvents();

            if (!Directory.Exists(tDestinationPath.Text)) Directory.CreateDirectory(tDestinationPath.Text);

            string result = Execute("C:\\Windows\\Microsoft.NET\\Framework\\" + cbVersion.SelectedItem + "\\aspnet_compiler.exe -v / -p " + GetShortName(tSourcePath.Text) + " " + GetShortName(tDestinationPath.Text));

            if (result.Contains("error")) { MessageBox.Show(result.Substring(result.IndexOf("error"), result.IndexOf('\n', result.IndexOf("error")) - result.IndexOf("error")), "Error"); }

            if (cbOpenDestinationAfterCompile.Checked) Process.Start(tDestinationPath.Text);

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = true;
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbMain.Visible = !(btnCompile.Enabled = tSourcePath.Enabled = tDestinationPath.Enabled = cbVersion.Enabled = btnSelectSource.Enabled = btnSelectDestination.Enabled = true);
        }
        #endregion

        #region Command Line & Short Path
        public static string Execute(string Command)
        {
            ProcessStartInfo si = new ProcessStartInfo("cmd.exe");
            // Redirect both streams so we can write/read them.
            si.RedirectStandardInput = true;
            si.RedirectStandardOutput = true;
            si.UseShellExecute = false;
            
            //Hide dos window
            si.CreateNoWindow = true;
            si.WindowStyle = ProcessWindowStyle.Hidden;

            // Start the procses.
            Process p = Process.Start(si);
            // Issue the dir command.
            p.StandardInput.WriteLine(@"" + Command);
            // Exit the application.
            p.StandardInput.WriteLine(@"exit");
            // Read all the output generated from it.
            string result = p.StandardOutput.ReadToEnd();

            return result;
        }
        public static string GetShortName(string sLongFileName)
        {
            var buffer = new StringBuilder(259);
            int len = GetShortPathName(sLongFileName, buffer, buffer.Capacity);
            if (len == 0) throw new System.ComponentModel.Win32Exception();
            return buffer.ToString();
        }
        #endregion

        private void pbInnovacube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.innovacube.com/?ref=Asp.Net_Precompiler_v" + Application.ProductVersion.Substring(0, 3));
        }
    }
}