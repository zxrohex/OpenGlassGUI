using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using SharpCompress.Archives;

namespace OpenGlassGUI.Config
{
    internal class OpenGlassConfigurator
    {
        public enum RundllAction
        {
            Install,
            Uninstall,
            Shutdown,
            Startup
        }

        /*
         * 
         * 
██  ██████  ███    ██  ██████  ██████  ███████ ██ 
██ ██       ████   ██ ██    ██ ██   ██ ██      ██ 
██ ██   ███ ██ ██  ██ ██    ██ ██████  █████   ██ 
██ ██    ██ ██  ██ ██ ██    ██ ██   ██ ██         
██  ██████  ██   ████  ██████  ██   ██ ███████ ██ 
                                                  
                                                 
         * 
         * 
         * 
         * 
         * 
         */

        /*private static Func<RundllAction, ProcessStartInfo> RundllStartInfo => (action) =>
        {
            return new ProcessStartInfo("C:\\Windows\\System32\\rundll32.exe",
            $"{OpenGlassConfiguration.InstallationPath}OpenGlass.dll, Main /{Enum.GetName(action).ToLower()}")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                Verb = "runas"
            };
        };

        public static void Test()
        {
            Process.Start(RundllStartInfo(RundllAction.Shutdown)).WaitForExit();
        }*/

        // Ignore for now
        /*public const string OpenGlassRelease = @"https://github.com/ALTaleX531/OpenGlass/releases/download/v1.3/OpenGlass.rar";

        public static async void Setup()
        {
            string tempPath = Path.GetTempPath() + @"\\OGGUI\\";

            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }

            using (HttpClient client = new HttpClient())
            {
                var file = await client.GetByteArrayAsync(new Uri(OpenGlassRelease));

                File.WriteAllBytes(tempPath + "OpenGlass.rar", file);
            }


            SharpCompress.Archives.Rar.RarArchive.Open(tempPath + "OpenGlass.rar").ExtractToDirectory(OpenGlassConfiguration.InstallationPath);

            File.Create(OpenGlassConfiguration.InstallationPath + OpenGlassConfiguration.InstallationConfirmation);


            Install();
        }

        public static void Install()
        {
            if (!Directory.Exists(OpenGlassConfiguration.InstallationPath))
            {
                Setup();
            }

            Process.Start(OpenGlassConfiguration.InstallationPath + "install.bat").WaitForExit();

            MessageBox.Show("Installed successfully!", "OpenGlassGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }*/
    }
}
