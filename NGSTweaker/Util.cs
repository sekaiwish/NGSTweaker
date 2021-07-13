using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace NGSTweaker
{
    public class Util
    {
        public string SetBinPath()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\";
                ofd.Title = "Choose PSO2 Executable...";
                ofd.Filter = "PSO2 Executable|pso2.exe|All files (*.*)|*.*";
                ofd.ShowDialog();
                string BinPath = string.Empty;
                if (ofd.FileName != string.Empty)
                {
                    BinPath = ofd.FileName.Substring(0, ofd.FileName.LastIndexOf(@"\"));
                    Properties.Settings.Default.BinPath = BinPath;
                    string[] Folders = { BinPath + @"\data\mods", BinPath + @"\data\backup" };
                    foreach (string Folder in Folders)
                    {
                        if (!System.IO.Directory.Exists(Folder))
                        {
                            System.IO.Directory.CreateDirectory(Folder);
                        }
                    }
                    Properties.Settings.Default.Save();
                }
                return BinPath;
            }
        }
        public string GetExecPath()
        {
            if (Properties.Settings.Default.BinPath != string.Empty)
            {
                return Properties.Settings.Default.BinPath + @"\pso2.exe";
            }
            return string.Empty;
        }
        public void UnpackMods()
        {
            string[] ZipMods = System.IO.Directory.GetFiles(Properties.Settings.Default.BinPath + @"\data\mods", "*.zip");
            foreach (string ZipMod in ZipMods)
            {
                // use ziparchive.entries to find if mod.xml exists, only extract if true
                string ZipName = ZipMod.Substring(ZipMod.LastIndexOf(@"\"));
                ZipFile.ExtractToDirectory(ZipMod, Properties.Settings.Default.BinPath + @"\data\mods\" + ZipName.Substring(0, ZipName.LastIndexOf(".")));
                System.IO.File.Delete(ZipMod);
            }
        }
    }
}
