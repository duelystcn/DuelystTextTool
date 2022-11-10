using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelystText.CoreData.Node
{
    public class TranslateItem
    {
        public string code;
        public string eng;
        public string chi;

        public TranslateItem(string code, string eng)
        {
            this.code = code;
            this.eng = eng;
        }
    }
}
