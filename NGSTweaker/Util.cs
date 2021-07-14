using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Text.Json;

namespace NGSTweaker
{
    public class Util
    {
        public struct Mod
        {
            public string Author;
            public decimal Version;
            public string Name;
            public string Title;
        }
        public struct ModConfig
        {
            public string NameVersion;
            public bool Active;
        }
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
                    string ConfigPath = BinPath + @"\data\config.json";
                    if (!System.IO.File.Exists(ConfigPath))
                    {
                        System.IO.File.Create(ConfigPath);
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
        public string GetNameVersion(System.IO.Stream Json)
        {
            string Name = string.Empty;
            string Version = string.Empty;
            using (var sr = new System.IO.StreamReader(Json))
            using (var ModJson = JsonDocument.Parse(sr.BaseStream))
            {
                foreach (var ModJsonObject in ModJson.RootElement.EnumerateObject())
                {
                    if (Name != string.Empty && Version != string.Empty)
                    {
                        break;
                    }
                    if (ModJsonObject.NameEquals("Name"))
                    {
                        Name = ModJsonObject.Value.GetString();
                        continue;
                    }
                    if (ModJsonObject.NameEquals("Version"))
                    {
                        Version = ModJsonObject.Value.ToString();
                        continue;
                    }
                }
                return Name + "-" + Version;
            }
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
                        if (Entry.FullName.Equals("mod.json"))
                        {
                            string NameVersion = GetNameVersion(Entry.Open());
                            try
                            {
                                ZipFile.ExtractToDirectory(ZipMod, ModPath + NameVersion);
                            }
                            catch (System.IO.IOException)
                            {
                                break;
                            }
                            Archive.Dispose();
                            System.IO.File.Delete(ZipMod);
                            // register the mod in config.json as inactive
                            break;
                        }
                    }
                }
            }
        }
        public ModConfig[] GetModConfig()
        {
            string ModConfigPath = Properties.Settings.Default.BinPath + @"\data\config.json";
            List<ModConfig> ModConfigs = new List<ModConfig>();
            using (var sr = new System.IO.StreamReader(ModConfigPath))
            using (var ModConfigFile = JsonDocument.Parse(sr.BaseStream))
            {
                foreach (var Mod in ModConfigFile.RootElement.EnumerateObject())
                {
                    ModConfig ModConfig = new ModConfig
                    {
                        NameVersion = Mod.Name,
                        Active = Mod.Value.GetBoolean()
                    };
                    ModConfigs.Add(ModConfig);
                }
                return ModConfigs.ToArray();
            }
        }
        public Mod GetModData(string ModJson)
        {
            using (var sr = new System.IO.StreamReader(ModJson))
            using (var ModInfo = JsonDocument.Parse(sr.BaseStream))
            {
                Mod Mod = new Mod
                {
                    Author = ModInfo.RootElement.GetProperty("Author").GetString(),
                    Version = ModInfo.RootElement.GetProperty("Version").GetDecimal(),
                    Name = ModInfo.RootElement.GetProperty("Name").GetString(),
                    Title = ModInfo.RootElement.GetProperty("Title").GetString()
                };
                return Mod;
            }
        }
    }
}
