using System;
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
    public partial class FormMods : Form
    {
        private Util Utils = new Util();
        public FormMods()
        {
            InitializeComponent();
        }
        private void FormMods_Load(object sender, EventArgs e)
        {
            Utils.UnpackMods();
            string[] ModFolders = System.IO.Directory.GetDirectories(Properties.Settings.Default.BinPath + @"\data\mods\");
            foreach (string ModFolder in ModFolders)
            {
                foreach (string ModFile in System.IO.Directory.GetFiles(ModFolder))
                {
                    if (System.IO.Path.GetFileName(ModFile).Equals("mod.xml"))
                    {
                        // import xml data
                    }
                }
            }
        }
        private void ButtonDisable_Click(object sender, EventArgs e)
        {
            // disable selected mods
        }
        private void ButtonEnable_Click(object sender, EventArgs e)
        {
            // enable selected mods
        }
    }
}
