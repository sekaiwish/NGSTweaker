using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGSTweaker
{
    public partial class FormMain : Form
    {
        private Util Utils = new Util();
        private string ExecPath;
        private FormSettings _FormSettings;
        private FormMods _FormMods;
        public FormMain()
        {
            InitializeComponent();

        }
        private void UpdateButtons()
        {
            ExecPath = Utils.GetExecPath();
            if (ExecPath != string.Empty)
            {
                LaunchButton.Enabled = true;
                ModsButton.Enabled = true;
            }
        }
        private void LaunchButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gameInfo = new ProcessStartInfo()
            {
                FileName = ExecPath,
                UseShellExecute = false,
                Arguments = "-reboot -optimize"
            };
            gameInfo.EnvironmentVariables["SteamAppId"] = "1056640";
            Process gameProcess = new Process()
            {
                StartInfo = gameInfo
            };
            gameProcess.Start();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (_FormSettings == null)
            {
                _FormSettings = new FormSettings();
                _FormSettings.FormClosed += (o, ea) => { UpdateButtons(); _FormSettings = null; };
            }
            else
            {
                _FormSettings.WindowState = FormWindowState.Normal;
            }
            _FormSettings.Show();
        }
        private void ModButton_Click(object sender, EventArgs e)
        {
            if (_FormMods == null)
            {
                _FormMods = new FormMods();
                _FormMods.FormClosed += (o, ea) => _FormMods = null;
            }
            else
            {
                _FormMods.WindowState = FormWindowState.Normal;
            }
            _FormMods.Show();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ExecPath = Utils.GetExecPath();
            if (ExecPath == string.Empty)
            {
                MessageBox.Show("Binary folder has not been set, please locate pso2.exe.", "NGS Tweaker Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Utils.SetBinPath();
                ExecPath = Utils.GetExecPath();
                UpdateButtons();
            }
            else
            {
                UpdateButtons();
            }
            LaunchButton.Focus();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
