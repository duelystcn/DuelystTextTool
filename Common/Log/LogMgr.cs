using DuelystText.Common.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DuelystText.Common.Log
{
    public class LogMgr
    {
        public static void WriteLog(string msg)
        {
            Console.WriteLine(msg);
            string path = Application.StartupPath + "/Resource/Log/" + TimeUtil.GetCurrentUSATimeYYMMDD() + ".log";
            if (!Directory.Exists(Application.StartupPath + "/Resource/Log"))
            {
                Directory.CreateDirectory(Application.StartupPath + "/Resource/Log");
            }
            try
            {
                FileStream fs;
                StreamWriter sw;
                StringBuilder sbr = new StringBuilder(16);
                if (!System.IO.File.Exists(path))
                {
                    fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite);
                    sw = new StreamWriter(fs, Encoding.UTF8);
                    sbr.Append("日志开始-");
                    sbr.Append(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    sbr.AppendLine();
                }
                else
                {
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    sw = new StreamWriter(fs, Encoding.UTF8);
                }
                sbr.Append("--");
                sbr.Append(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"));
                sbr.Append("--");
                sbr.Append(msg);
                sw.WriteLine(sbr.ToString());

                sw.Flush();
                sw.Close();
                fs.Close();
                sbr.Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
