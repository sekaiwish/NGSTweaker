using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (ofd.FileName != string.Empty)
                {
                    Properties.Settings.Default.BinPath = ofd.FileName.Substring(0, ofd.FileName.LastIndexOf(@"\"));
                    Properties.Settings.Default.Save();
                }
                return ofd.FileName;
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
    }
}
