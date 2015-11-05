using System;
using System.Diagnostics;

namespace MyData.utils
{
    public class Logger
    {
        private string sSource;
        private string sLog;

        public Logger()
        {
            sSource = "dotNET Sample App";
            sLog = "MyApplication";

            try
            {
                if (!EventLog.SourceExists(sSource))
                    EventLog.CreateEventSource(sSource, sLog);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void LogError(String message, String eventSrc)
        {
            EventLog.WriteEntry(message, eventSrc,
                EventLogEntryType.Error, 234);
        }

        public void LogWarning(String message, String eventSrc)
        {
            EventLog.WriteEntry(message, eventSrc, EventLogEntryType.Warning, 234);
        }
    }
}