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
        private Util.ModConfig[] ModConfigs = new Util.ModConfig[] { };
        private List<Util.Mod> Mods = new List<Util.Mod>();
        public FormMods()
        {
            InitializeComponent();
        }
        private void FormMods_Load(object sender, EventArgs e)
        {
            Utils.UnpackMods();
            ModConfigs = Utils.GetModConfigs();
            string[] ModFolders = System.IO.Directory.GetDirectories(Properties.Settings.Default.BinPath + @"\data\mods\");
            foreach (string ModFolder in ModFolders)
            {
                foreach (string ModFile in System.IO.Directory.GetFiles(ModFolder))
                {
                    if (System.IO.Path.GetFileName(ModFile).Equals("mod.json"))
                    {
                        Util.Mod Mod = Utils.GetModData(ModFolder + @"\mod.json");
                        Mods.Add(Mod);
                        foreach (var ModConfig in ModConfigs)
                        {
                            if (ModConfig.NameVersion == Mod.Name + "-" + Mod.Version)
                            {
                                if (ModConfig.Active)
                                {
                                    ListActive.Items.Add(String.Format("{0} ({1})", Mod.Title, Mod.Version));
                                }
                                else
                                {
                                    ListInactive.Items.Add(String.Format("{0} ({1})", Mod.Title, Mod.Version));
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void ButtonDisable_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection ToDisable = ListActive.SelectedIndices;
            // disable selected mods
        }
        private void ButtonEnable_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection ToEnable = ListInactive.SelectedIndices;
            // enable selected mods
        }
    }
}
