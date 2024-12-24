using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenGlassGUI.Core.WinInterop
{
    internal static class User32Interop
    {
       
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        internal static IntPtr Extern_FindWindow(string lpClassName, string lpWindowName = null)
        {
            return FindWindow(lpClassName, lpWindowName);
        }

        internal static void Extern_PostMessage(IntPtr hWnd, uint msg)
        {        
            if (hWnd != IntPtr.Zero)
            {
                PostMessage(hWnd, msg, IntPtr.Zero, IntPtr.Zero);
            }
        }

    }
}
