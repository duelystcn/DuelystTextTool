using DuelystText.Common.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelystText.Common.Util
{
    public class FileReadUtil
    {
        public static string GetTextFromFile(string path)
        {
            string txt = "";
            if (!File.Exists(path))
            {
                LogMgr.WriteLog("找不到文件：" + path);
            }
            try
            {
                FileStream fs = File.Open(path, FileMode.Open);


                byte[] bytes = ReadFileStream(fs);
                txt = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                fs.Close();
            }
            catch (Exception error)
            {
                LogMgr.WriteLog("读取文件错误:" + error.ToString());
            }
            return txt;
        }
        private static byte[] ReadFileStream(FileStream stream)
        {
            const int size = 114514;
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
