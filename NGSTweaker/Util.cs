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
            string ModPath = Properties.Settings.Default.BinPath + @"\data\mods\";
            string[] ZipMods = System.IO.Directory.GetFiles(ModPath, "*.zip");
            foreach (string ZipMod in ZipMods)
            {
                string ZipName = System.IO.Path.GetFileName(ZipMod);
                using (ZipArchive Archive = ZipFile.OpenRead(ZipMod))
                {
                    foreach (ZipArchiveEntry Entry in Archive.Entries)
                    {
                        if (Entry.FullName.Equals("mod.xml"))
                        {
                            ZipFile.ExtractToDirectory(ZipMod, ModPath + System.IO.Path.GetFileNameWithoutExtension(ZipName));
                            Archive.Dispose();
                            System.IO.File.Delete(ZipMod);
                            break;
                        }
                    }
                }
            }
        }
    }
}
