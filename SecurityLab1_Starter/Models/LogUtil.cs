using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.IO;

namespace SecurityLab1_Starter.Models
{
    public class LogUtil
    {
        public void LogToFile(String text)
        {
            using (var writer = new StreamWriter("C:\\a\\ErrorLog.txt"))
            {
                writer.WriteLine(text);
            }
        }

        public void LogToEventViewer(EventLogEntryType type, String text) {
            using (EventLog eventLog = new EventLog("Application")) {
                eventLog.Source = "Application";
                eventLog.WriteEntry("Log Message Example", type, 101, 1);
            }
        }
    }
}