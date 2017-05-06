using System;
using System.IO;

namespace TestReazor.Common
{
    public static class Logger
    {
        public static void Log(string mensaje)
        {
            File.AppendAllText(@"C:\Users\Sergi\Desktop\ArchivoLogs.txt",
                string.Format("{0} - INFO: {1}", DateTime.Now,
                mensaje + Environment.NewLine));
        }
    }
}