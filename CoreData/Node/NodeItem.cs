using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelystText.CoreData.Node
{
    public class NodeItem
    {
        public string nodeCode;
        public NodeItem parent;
        public List<NodeItem> childNodeList;
        public List<TranslateItem> translateItemList;

        public NodeItem(string nodeCode)
        {
            this.nodeCode = nodeCode;
            this.childNodeList = new List<NodeItem>();
            this.translateItemList = new List<TranslateItem>();
        }

        public void Initialization(NodeItem parent, JToken objTree) 
        {
            this.parent = parent;
            //只有一个那么就到底了
            if (objTree.Children().Count() == 1) 
            {
                foreach (JProperty item in objTree.Values())
                {
                    string name = item.Name;
                    TranslateItem translateItem = new TranslateItem(item.Name, item.Value.Value<string>());
                    this.translateItemList.Add(translateItem);
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
    }
}
