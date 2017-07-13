using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.TaskScheduler;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace telekomAidatCronTaskAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                TaskService.Instance.FindTask("Telekom Aidat Cron").Enabled = false;
            }
            else
                TaskService.Instance.AddTask("Telekom Aidat Cron", QuickTriggerType.Logon , Assembly.GetExecutingAssembly().Location);
        }
    }
}
