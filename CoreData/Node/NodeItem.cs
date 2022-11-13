using DuelystText.Common.Log;
using DuelystText.Common.Util;
using DuelystText.CoreData.Export;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelystText.CoreData.Node
{
    public class NodeItem
    {
        public string nodeCode;
        public string path;
        public NodeItem parent;
        public List<NodeItem> childNodeList;
        public Dictionary<string, TranslateItem> translateItemCache;//读取时储存做缓存
        public List<TranslateSaveItem> translateSaveItemList;

        public NodeItem(string nodeCode)
        {
            this.nodeCode = nodeCode;
            this.childNodeList = new List<NodeItem>();
            this.translateItemCache = new Dictionary<string, TranslateItem>();
            this.translateSaveItemList = new List<TranslateSaveItem>();
        }
        //初始化
        public void Initialization(NodeItem parent, JToken objTree) 
        {
            this.parent = parent;
            if(parent == null) 
            {
                this.path = objTree.Path;
            }
            else 
            {
                this.path = this.nodeCode;
            }
            //只有一个那么就到底了
            if (objTree.Children().Count() == 1) 
            {
                foreach (JProperty item in objTree.Values())
                {
                    string name = item.Name;
                    TranslateItem translateItem = new TranslateItem();
                    translateItem.code = item.Name;
                    translateItem.eng = item.Value.Value<string>();
                    this.translateItemCache.Add(translateItem.code, translateItem);
                }
            }
            else 
            {
                List<string> nemes = ((JObject)objTree).Properties().Select(p => p.Name).ToList();
                int index = 0;
                foreach (JToken item in objTree.Children())
                {
                    NodeItem childNode = new NodeItem(nemes[index]);
                    this.childNodeList.Add(childNode);
                    childNode.Initialization(this, item);
                    index++;
                }
            }
        }

        public NodeItem GetChildNodeByCode(string nodeCode) 
        {
            foreach (var item in this.childNodeList)
            {
                if(item.nodeCode == nodeCode) 
                {
                    return item;
                }
            }
            return null;
        }

        public TranslateSaveItem GetTranslateSaveItemByStartAndEnd(int start, int end)
        {
            foreach (var item in this.translateSaveItemList)
            {
                if (item.orderEnd == end && item.orderStart == start)
                {
                    return item;
                }
            }
            return null;
        }

        public int GeSumByState(TranslateState translateState) 
        {
            int sumState = 0;
            foreach (var translateSaveItem in this.translateSaveItemList)
            {
                sumState+= translateSaveItem.GeSumByState(translateState);
            }
            return sumState;
        }

        public int GeSumAllState()
        {
            int sumState = 0;
            foreach (var translateSaveItem in this.translateSaveItemList)
            {
                sumState += translateSaveItem.translateItemList.Count;
            }
            return sumState;
        }


        //生成文件
        public void CreateTranslateFile(string versionCode) 
        {
            string direThisPath = this.path.Replace(".","/");
            string intactPath = Application.StartupPath + "/JSVersion/" + versionCode + "/"+ GlobalVariable.originNodeCode + "/" + direThisPath;
            Directory.CreateDirectory(intactPath);
            foreach (var childNode in this.childNodeList)
            {
                childNode.CreateTranslateFile(versionCode);
            }

            if(this.translateItemCache.Count > 0) 
            {
                List<TranslateItem> translateItemList = new List<TranslateItem>(this.translateItemCache.Values);
                int cutNum = translateItemList.Count / GlobalVariable.cutSpac;
                for (int i = 0; i < cutNum + 1; i++)
                {
                    int orderStart = i * GlobalVariable.cutSpac;
                    int orderEnd = (i + 1) * GlobalVariable.cutSpac - 1;

                    if (orderEnd > this.translateItemCache.Count - 1)
                    {
                        orderEnd = this.translateItemCache.Count - 1;
                    }

                    TranslateSaveItem translateSaveItem = new TranslateSaveItem();
                    translateSaveItem.versionCode = versionCode;
                    translateSaveItem.nodeCode = this.nodeCode;
                    translateSaveItem.path = this.path;
                    translateSaveItem.translateItemList = new List<TranslateItem>();
                    translateSaveItem.orderStart = orderStart;
                    translateSaveItem.orderEnd = orderEnd;
                    for (int orderNum = orderStart; orderNum < orderEnd + 1; orderNum++)
                    {
                        translateItemList[orderNum].chi = "";
                        translateItemList[orderNum].originVersionCode = versionCode;
                        translateItemList[orderNum].translateState = TranslateState.UnStart;
                        translateSaveItem.translateItemList.Add(translateItemList[orderNum]);
                    }
                    WriteTargetTranslateSaveItem(translateSaveItem, intactPath);
                    this.translateSaveItemList.Add(translateSaveItem);
                }
            }
        }

        public void WriteTargetTranslateSaveItem(TranslateSaveItem translateSaveItem, string intactPath) 
        {
            string translateSaveStr = JsonConvert.SerializeObject(translateSaveItem, Formatting.Indented);
            string fileName = this.nodeCode + "#" + translateSaveItem.orderStart + "-" + translateSaveItem.orderEnd + ".json";
            FileWriteUtil.FileWrite(fileName, translateSaveStr, intactPath);
        }


        public void LoadTranslateFile(string versionCode) 
        {
            string direThisPath = this.path.Replace(".", "/");
            string intactPath = Application.StartupPath + "/JSVersion/" + versionCode + "/" + GlobalVariable.originNodeCode + "/" + direThisPath;
            DirectoryInfo root = new DirectoryInfo(intactPath);
            foreach (FileInfo file in root.GetFiles())
            {
                string indexJson = FileReadUtil.GetTextFromFile(file.FullName);
                TranslateSaveItem translateSaveItem = JsonConvert.DeserializeObject<TranslateSaveItem>(indexJson);
                if(translateSaveItem.nodeCode == this.nodeCode) 
                {
                    this.translateSaveItemList.Add(translateSaveItem);
                    //Console.WriteLine(translateSaveItem.path + "/" + file.Name);
                }
                else 
                {
                    LogMgr.WriteLog("nodeCode 不对应 thisNodeCode:" + this.nodeCode + ",targetCode:" + translateSaveItem.nodeCode);
                }
            }
            foreach (var childNode in this.childNodeList)
            {
                childNode.LoadTranslateFile(versionCode);
            }
        }

        public void GetAllTranslateItem(List<TranslateItem> translateItemReturnList) 
        {
            foreach (TranslateSaveItem item in this.translateSaveItemList)
            {
                translateItemReturnList.AddRange(item.translateItemList);
            }
            foreach (var childNode in this.childNodeList)
            {
                childNode.GetAllTranslateItem(translateItemReturnList);
            }
        
        }
    }
}
