using DuelystText.Common.Log;
using DuelystText.CoreData.Node;
using DuelystText.CoreData.Version;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelystText.CoreData
{
    public class ToolDataManger
    {
        public static ToolDataManger Instance = null;

        public Dictionary<string, VersionItem> versionDic = new Dictionary<string, VersionItem>();

        public VersionItem currentVersionItem;

        public NodeItem currentNodeItem;

        public void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                Instance.Init();
            }

        }

        private void Init()
        {
            GetAllVersionList();
        }

        private void GetAllVersionList()
        {
            string path = Application.StartupPath + "/JSVersion";
            if (!Directory.Exists(path))
            {
                LogMgr.WriteLog("找不到文件夹：" + path);
            }
            string[] dir = Directory.GetDirectories(path);
            versionDic = new Dictionary<string, VersionItem>();
            foreach (var versionPath in dir)
            {
                VersionItem versionItem = new VersionItem(Path.GetFileName(versionPath));
                versionItem.Initialization();
                versionDic.Add(versionItem.versionCode, versionItem);
            }
        }

        public string GetTargetNodePath(NodeItem targetNodeItem) 
        {
            string direThisPath = targetNodeItem.path.Replace(".", "\\");
            string intactPath = Application.StartupPath + "\\JSVersion\\" + currentVersionItem.versionCode + "\\" + GlobalVariable.originNodeCode + "\\" + direThisPath + "\\";
            return intactPath;
        }

        public bool IsAdmin() 
        {
            return GlobalVariable.isAdmin;
        }
    }
}
