using DuelystText.Common.Util;
using DuelystText.CoreData.Node;
using Newtonsoft.Json.Linq;
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

        public NodeItem nodeItem;

        public VersionItem(string versionCode)
        {
            this.versionCode = versionCode;
        }

        public void Initialization() 
        {
            string path = Application.StartupPath + "/JSVersion/" + versionCode + "/index.json";
            string indexJson = FileReadUtil.GetTextFromFile(path);
            JToken objTree = JObject.Parse(indexJson);
            this.nodeItem = new NodeItem("ENO");
            this.nodeItem.Initialization(null, objTree);
            return;
        }


        
    }
}
