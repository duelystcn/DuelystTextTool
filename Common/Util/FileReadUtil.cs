using DuelystText.Common.Log;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        /// <summary>
        /// 打开目录
        /// </summary>
        /// <param name="folderPath">目录路径（比如：C:\Users\Administrator\）</param>
        public static void OpenFolder(string folderPath)
        {
            if (string.IsNullOrEmpty(folderPath)) return;

            Process process = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("Explorer.exe");
            psi.Arguments = folderPath;
            process.StartInfo = psi;

            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                process?.Close();

            }

        }
    }
}
