using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelystText.CoreData.Version
{
    public class VersionItem
    {
        public string versionCode;

        public VersionItem(string versionCode)
        {
            this.versionCode = versionCode;
        }

        public void CheckNeedSplit() 
        {
            string path = Application.StartupPath + "/JSVersion/" + versionCode + "/split";
            if (!Directory.Exists(path))
            {
                
            }
        }
    }
}
