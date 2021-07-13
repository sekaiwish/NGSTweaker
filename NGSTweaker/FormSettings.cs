using System;
using System.Xml;
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
    public partial class FormSettings : Form
    {
        private Util utils = new Util();
        public FormSettings()
        {
            InitializeComponent();
        }
        private void BinButton_Click(object sender, EventArgs e)
        {
            BinText.Text = utils.SetBinPath();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            BinText.Text = Properties.Settings.Default.BinPath;
        }
    }
}
