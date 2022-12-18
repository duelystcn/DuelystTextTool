using DuelystText.Common.Util;
using DuelystText.CoreData.Export;
using DuelystText.CoreData.Node;
using Newtonsoft.Json;
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
            this.nodeItem = new NodeItem(GlobalVariable.originNodeCode);
            this.nodeItem.Initialization(null, objTree);
            //检查是否生成了此版本的翻译文件
            string pathTrans = Application.StartupPath + "/JSVersion/" + versionCode + "/" + GlobalVariable.originNodeCode;
            if (!Directory.Exists(pathTrans))
            {
               Directory.CreateDirectory(pathTrans);
               nodeItem.CreateTranslateFile(versionCode);
            }
            else 
            {
                nodeItem.LoadTranslateFile(versionCode);
            }
        }

        //根据目标版本来生成这个版本的
        public void ReferenceByTargetVersion(VersionItem targetVersion) 
        {
            this.nodeItem.ReferenceByTargetVersion(targetVersion, this.versionCode);
        }

        //根据code和path来获取指定node
        public NodeItem GetTargetNodeByCodeAndPath(string nodeCodeTarget, string pathTarget) 
        {
            if(this.nodeItem.nodeCode == nodeCodeTarget && this.nodeItem.path == pathTarget) 
            {
                return this.nodeItem;
            }
            return this.nodeItem.GetTargetNodeByCodeAndPath(nodeCodeTarget, pathTarget);
        }

        //导出汉化文本
        public void ExportChiJson() 
        {
            Dictionary<string, Dictionary<string, string>> exportDic = new Dictionary<string, Dictionary<string, string>>();
            this.nodeItem.ExportChiJson(exportDic);

            string pathDuplictae = Application.StartupPath + "/JSVersion/" + versionCode + "/ExportJson";
            if (!Directory.Exists(pathDuplictae))
            {
                Directory.CreateDirectory(pathDuplictae);
            }
            string duplictaeExport = JsonConvert.SerializeObject(exportDic, Formatting.Indented);
            string fileName = "index.json";
            FileWriteUtil.FileWrite(fileName, duplictaeExport, pathDuplictae);
            pathDuplictae = pathDuplictae.Replace("/", "\\");
            FileReadUtil.OpenFolder(pathDuplictae + "\\");
        }

        //导出重复文本
        public void CreateDuplicateTextFileAndExport() 
        {
            List<TranslateItem> translateItemReturnList = new List<TranslateItem>();
            nodeItem.GetAllTranslateItem(translateItemReturnList);
            Dictionary<string, List<TranslateItem>> countEngDIc = new Dictionary<string, List<TranslateItem>>();
            foreach (var item in translateItemReturnList)
            {
                if (!countEngDIc.ContainsKey(item.eng)) 
                {
                    countEngDIc.Add(item.eng, new List<TranslateItem>());
                }
                countEngDIc[item.eng].Add(item);
            }
            List<DuplicateTextItem> duplicateTextItems = new List<DuplicateTextItem>();
            foreach (var countList in countEngDIc.Values)
            {
                if(countList.Count >= 3) 
                {
                    DuplicateTextItem duplicateTextItem = new DuplicateTextItem();
                    duplicateTextItem.eng = countList[0].eng;
                    duplicateTextItem.chi = countList[0].chi;
                    duplicateTextItem.codeList = new List<string>();
                    foreach (var item in countList)
                    {
                        if(item.translateState == TranslateState.Confirm) 
                        {
                            duplicateTextItem.chi = item.chi;
                        }
                        duplicateTextItem.codeList.Add(item.code);
                    }
                    duplicateTextItems.Add(duplicateTextItem);
                }
            }
            string pathDuplictae = Application.StartupPath + "/JSVersion/" + versionCode + "/DuplictaeText";
            if (!Directory.Exists(pathDuplictae))
            {
                Directory.CreateDirectory(pathDuplictae);
            }
            string duplictaeExport = JsonConvert.SerializeObject(duplicateTextItems, Formatting.Indented);
            string fileName = "duplictaeTextExport " + DateTime.Now.Ticks + ".json";
            FileWriteUtil.FileWrite(fileName, duplictaeExport, pathDuplictae);
            pathDuplictae = pathDuplictae.Replace("/", "\\");
            FileReadUtil.OpenFolder(pathDuplictae + "\\");

        }

    
        
    }
}
