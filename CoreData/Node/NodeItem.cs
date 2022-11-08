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

    }
}
