using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LogFile
{
    public static class Logger
    {
        public static void WriteLog(string status, string root, string app, string creator, string msg)
        {
            string filename = "../../Logs/LogFile.txt";
            //string LogPath = "~/LogFile/Logs";
            StreamWriter sw = new StreamWriter(filename, append: true);
            sw.WriteLine("[" + DateTime.Now + "]    (" + status + ")    " + root + "    " + app + "    " + creator + "    :" + msg);
            sw.Close();
        }
    }
}
