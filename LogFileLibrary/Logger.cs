using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LogFileLibrary
{
   public static class Logger
    {
        public static void WriteLog(string pathName,string status, string root, string app, string creator, string msg)
        {
            string filename = pathName;
            StreamWriter sw = new StreamWriter(filename, append: true);
            sw.WriteLine("[" + DateTime.Now + "]    (" + status + ")    " + root + "    " + app + "    " + creator + "    :" + msg);
            sw.Close();
        }
    }
}
