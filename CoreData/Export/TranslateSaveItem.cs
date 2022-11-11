using DuelystText.CoreData.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelystText.CoreData.Export
{
    public class TranslateSaveItem
    {
        public string versionCode;

        public string nodeCode;

        public string path;

        public int orderStart;

        public int orderEnd;

        public List<TranslateItem> translateItemList;


        public int GeSumByState(TranslateState translateState)
        {
            int sumState = 0;
            foreach (TranslateItem translateItem in this.translateItemList)
            {
                if (translateItem.translateState == translateState)
                {
                    sumState++;
                }
            }
            return sumState;
        }

        public TranslateItem GetTranslateItemByCode(string code) 
        {
            foreach (var item in translateItemList)
            {
                if(item.code == code) 
                {
                    return item;
                }
            }
            return null;
        }
    }
}
