using DuelystText.Common.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelystText
{
    public partial class Main : Form
    {
        private SynchronizationContext synchronizationContext;


        private DataTable versionDataTable;



        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //获取当前有哪些版本

        }



        private void GetText_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/JSVersion/" + GlobalVariable.version + "/duelyst.js";
            if (!File.Exists(path))
            {
                LogMgr.WriteLog("找不到文件：" + path);
            }
            try
            {
                FileStream fs = File.Open(path, FileMode.Open);


                byte[] bytes = ReadFileStream(fs);
                string txt = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                fs.Close();
            }
            catch (Exception error)
            {
                LogMgr.WriteLog("读取文件错误:" + error.ToString());
            }
        }

        public static byte[] ReadFileStream(FileStream stream)
        {
            const int size = 20607280; 
            byte[] buffer = new byte[size];
            using (MemoryStream memory = new MemoryStream())
            {
                int count = 0;
                do
                {
                    count = stream.Read(buffer, 0, size);
                    if (count > 0)
                    {
                        memory.Write(buffer, 0, count);
                    }
                }
                while (count > 0);
                return memory.ToArray();
            }
        }


    }
}
