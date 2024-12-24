using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGlassGUI.Core
{
    internal class LogManager
    {
        internal static string Time;

        internal static string FileName => $"OpenGlassGUI_Log_{Time.Replace(".", "_")}.txt";

        internal static List<string> Messages = new List<string>();

        static LogManager()
        {
            Time = DateTime.Now.ToString();
        }

        internal static void Log(string message, string module = "Main")
        {
            Messages.Add($"[{DateTime.Now}] [{module}]: {message}");
        }
    }
}
