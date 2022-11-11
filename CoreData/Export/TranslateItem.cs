using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelystText.CoreData.Export
{
    public enum TranslateState 
    {
        //未处理
        UnStart = 0,
        //存在差异
        Difference  = 1,
        //处理完成
        Processed = 2,
        //标记
        Mark = 3,
        //确认完成
        Confirm = 4
    }

    public class TranslateItem
    {
        public string code;
        public string eng;
        public string chi;

        public string originVersionCode;
        public TranslateState translateState;

        public string GetStateStr() 
        {
            if(translateState == TranslateState.UnStart) 
            {
                return "未开始";
            }
            else if (translateState == TranslateState.Difference)
            {
                return "有差异";
            }
            else if (translateState == TranslateState.Processed)
            {
                return "已处理";
            }
            else if (translateState == TranslateState.Mark)
            {
                return "标记中";
            }
            else if (translateState == TranslateState.Confirm)
            {
                return "已确认";
            }
            return "";
        }

    }

}
