using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGlassGUI.Core
{
    internal class LogManager
    {
        static string Time;

        static string FileName => $"OpenGlassGUI_Log_{Time.Replace(".", "_")}.txt";

        static LogManager()
        {
            Time = DateTime.Now.ToString();
        }
    }
}
