using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.TaskScheduler;
using System.Diagnostics;

namespace telekomAidatCronTaskAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskService.Instance.AddTask("Telekom Aidat Cron", QuickTriggerType.Logon , Environment.CurrentDirectory + "\\telekomAidatTakipCron.exe");
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " +
                           Environment.CurrentDirectory + "\\telekomAidatCronAdder.exe";
            Info.WindowStyle = ProcessWindowStyle.Hidden;
            Info.CreateNoWindow = true;
            Info.FileName = "cmd.exe";
            Process.Start(Info);
        }
    }
}
