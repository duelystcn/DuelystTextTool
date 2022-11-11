using DuelystText.Common.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelystText.Common.Util
{
    public class FileWriteUtil
    {
        public static void FileWrite(string fileName, string needWriteStr, string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(needWriteStr);
            //文件夹路径确认
            if (!Directory.Exists(path))
            {
                LogMgr.WriteLog("FileWrite 找不到文件夹：" + path);
            }
            FileStream fs = new FileStream(path + "/" + fileName, FileMode.Create); 
            byte[] bytes = new UTF8Encoding().GetBytes(sb.ToString());
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }
    }
}
