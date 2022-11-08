using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelystText.CoreData
{
    public class ToolDataManger
    {
        public static ToolDataManger Instance = null;

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

        }
    }
}
