using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGlassGUI.Core.WinInterop
{
    internal class DwmInterop
    {
        internal const int WM_DWMCOLORIZATIONCHANGED = 0x0320;
        internal const int WM_THEMECHANGED = 0x031A;


        internal static void Extern_DwmUpdateStates()
        {
            IntPtr hWnd = User32Interop.Extern_FindWindow("Dwm");

            if (hWnd != IntPtr.Zero)
            {
                User32Interop.Extern_PostMessage(hWnd, WM_DWMCOLORIZATIONCHANGED);
                User32Interop.Extern_PostMessage(hWnd, WM_THEMECHANGED);
            }
        }
    }
}
