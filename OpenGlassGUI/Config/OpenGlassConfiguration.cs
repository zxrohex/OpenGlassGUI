using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;

using OpenGlassGUI.Core.WinInterop;

namespace OpenGlassGUI.Config
{
    

    internal class OpenGlassConfiguration
    {
        public const string DWMRegistryKey = "SOFTWARE\\Microsoft\\Windows\\Dwm";

        public const string InstallationPath = "C:\\OpenGlass\\";

        public const string InstallationConfirmation = "INSTALLED.dat";

        public OpenGlassRegistrySettings RegistrySettings { get; }

        /*
         * 
         * dbghelp.dll
install.bat
INSTALLED.dat
OpenGlass.dll
OpenGlass.pdb
shutdown.bat
startup.bat
symsrv.dll
symsrv.yes
uninstall.bat
         * */

        public List<string> Files = new List<string>
        {
            "dbghelp.dll",
            "install.bat",
            "OpenGlass.dll",
            "OpenGlass.pdb",
            "shutdown.bat",
            "startup.bat",
            "symsrv.dll",
            "symsrv.yes",
            "uninstall.bat"
        };

        public OpenGlassConfiguration()
        {
            if (!Directory.Exists(InstallationPath) /*&& !File.Exists(InstallationPath + InstallationConfirmation)*/)
            {
              
                var result = MessageBox.Show("OpenGlass is not installed on this system or not inside the expected location. Please install OpenGlass into C:\\OpenGlass\\", "OpenGlassGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                /*if (result == DialogResult.Yes)
                {
                    OpenGlassConfigurator.Setup();
                }
                else
                {*/
                Environment.Exit(-1);
                /*}*/
            }

            foreach (var i in Files)
            {
                if (!File.Exists(InstallationPath + i))
                {
                    var result = MessageBox.Show($"OpenGlass is missing the file {i}. Please reinstall OpenGlass into C:\\OpenGlass\\", "OpenGlassGUI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    /*if (result == DialogResult.Yes)
                    {
                        OpenGlassConfigurator.Setup();
                    }
                    else
                    {*/
                    Environment.Exit(-1);
                    /*}*/
                }
            }

            //OpenGlassConfigurator.Test();

            RegistrySettings = new OpenGlassRegistrySettings();
        }

        public void UpdateDwm()
        {
            DwmInterop.Extern_DwmUpdateStates();
        }
    }

    internal interface IOpenGlassRegistrySettings
    {
        int DisableGlassOnBattery { get; set; }

        int GlassOpacity { get; set; }

        int ColorizationColorCaption { get; set; }

        int BlurDeviation { get; set; }

        int RoundRectRadius { get; set; }

        int ColorizationGlassReflectionIntensity { get; set; }

        int ColorizationGlassReflectionParallaxIntensity { get; set; }

        string CustomThemeReflection { get; set; }

        string CustomThemeMaterial { get; set; }

        int MaterialOpacity { get; set; }

        string CustomThemeMsstyle { get; set; }

        int CustomThemeMsstyleUseDefaults { get; set; }

        int TextGlowSize { get; set; }

        int CenterCaption { get; set; }

        int GlassLuminosity { get; set; }

        int GlassType { get; set; }

        int GlassOverrideBorder { get; set; }

        int GlassCrossFadeTime { get; set; }

        int GlassOverrideAccent { get; set; }

        int GlassAdditionalPreScaleAmount { get; set; }

        int ForceAccentColorization { get; set; }

        int GlassCrossFadeEasingFunction { get; set; }

        int ColorizationColorBalanceOverride { get; set; }

        int ColorizationAfterglowBalanceOverride { get; set; }
    }

    internal class OpenGlassRegistrySettings : IOpenGlassRegistrySettings
    {
        private readonly RegistryKey _dwmKey;

        public OpenGlassRegistrySettings()
        {
            _dwmKey = Registry.LocalMachine.OpenSubKey(OpenGlassConfiguration.DWMRegistryKey, true);

           
        }

        

        public int DisableGlassOnBattery
        {
            get => (int)_dwmKey.GetValue("DisableGlassOnBattery", 0);
            set => _dwmKey.SetValue("DisableGlassOnBattery", value, RegistryValueKind.DWord);
        }
        public int GlassOpacity
        {
            get => (int)_dwmKey.GetValue("GlassOpacity", 100);
            set => _dwmKey.SetValue("GlassOpacity", value, RegistryValueKind.DWord);
        }
        public int ColorizationColorCaption
        {
            get => (int)_dwmKey.GetValue("ColorizationColorCaption", 0);
            set => _dwmKey.SetValue("ColorizationColorCaption", value, RegistryValueKind.DWord);
        }
        public int BlurDeviation
        {
            get => (int)_dwmKey.GetValue("BlurDeviation", 30);
            set => _dwmKey.SetValue("BlurDeviation", value, RegistryValueKind.DWord);
        }
        public int RoundRectRadius
        {
            get => (int)_dwmKey.GetValue("RoundRectRadius", 0);
            set => _dwmKey.SetValue("RoundRectRadius", value, RegistryValueKind.DWord);
        }
        public int ColorizationGlassReflectionIntensity
        {
            get => (int)_dwmKey.GetValue("ColorizationGlassReflectionIntensity", 0);
            set => _dwmKey.SetValue("ColorizationGlassReflectionIntensity", value, RegistryValueKind.DWord);
        }
        public int ColorizationGlassReflectionParallaxIntensity
        {
            get => (int)_dwmKey.GetValue("ColorizationGlassReflectionParallaxIntensity", 0);
            set => _dwmKey.SetValue("ColorizationGlassReflectionParallaxIntensity", value, RegistryValueKind.DWord);
        }
        public string CustomThemeReflection
        {
            get => (string)_dwmKey.GetValue("CustomThemeReflection", "");
            set => _dwmKey.SetValue("CustomThemeReflection", value, RegistryValueKind.String);
        }
        public string CustomThemeMaterial
        {
            get => (string)_dwmKey.GetValue("CustomThemeMaterial", "");
            set => _dwmKey.SetValue("CustomThemeMaterial", value, RegistryValueKind.String);
        }

        public int MaterialOpacity
        {
            get => (int)_dwmKey.GetValue("MaterialOpacity", 0);
            set => _dwmKey.SetValue("MaterialOpacity", value, RegistryValueKind.DWord);
        }

        public string CustomThemeMsstyle
        {
            get => (string)_dwmKey.GetValue("CustomThemeMsstyle", "");
            set => _dwmKey.SetValue("CustomThemeMsstyle", value, RegistryValueKind.String);
        }

        public int CustomThemeMsstyleUseDefaults
        {
            get => (int)_dwmKey.GetValue("CustomThemeMsstyleUseDefaults", 0);
            set => _dwmKey.SetValue("CustomThemeMsstyleUseDefaults", value, RegistryValueKind.DWord);
        }

        public int TextGlowSize
        {
            get => (int)_dwmKey.GetValue("TextGlowSize", 0);
            set => _dwmKey.SetValue("TextGlowSize", value, RegistryValueKind.DWord);
        }

        public int CenterCaption
        {
            get => (int)_dwmKey.GetValue("CenterCaption", 0);
            set => _dwmKey.SetValue("CenterCaption", value, RegistryValueKind.DWord);
        }


        public int GlassLuminosity
        {
            get => (int)_dwmKey.GetValue("GlassLuminosity", 0);
            set => _dwmKey.SetValue("GlassLuminosity", value, RegistryValueKind.DWord);
        }

        public int GlassType
        {
            get => (int)_dwmKey.GetValue("GlassType", 0);
            set => _dwmKey.SetValue("GlassType", value, RegistryValueKind.DWord);
        }

        public int GlassOverrideBorder
        {
            get => (int)_dwmKey.GetValue("GlassOverrideBorder", 0);
            set => _dwmKey.SetValue("GlassOverrideBorder", value, RegistryValueKind.DWord);
        }

        public int GlassCrossFadeTime
        {
            get => (int)_dwmKey.GetValue("GlassCrossFadeTime", 0);
            set => _dwmKey.SetValue("GlassCrossFadeTime", value, RegistryValueKind.DWord);
        }

        public int GlassOverrideAccent
        {
            get => (int)_dwmKey.GetValue("GlassOverrideAccent", 0);
            set => _dwmKey.SetValue("GlassOverrideAccent", value, RegistryValueKind.DWord);
        }

        public int GlassAdditionalPreScaleAmount
        {
            get => (int)_dwmKey.GetValue("GlassAdditionalPreScaleAmount", 0);
            set => _dwmKey.SetValue("GlassAdditionalPreScaleAmount", value, RegistryValueKind.DWord);
        }

        public int ForceAccentColorization
        {
            get => (int)_dwmKey.GetValue("ForceAccentColorization", 0);
            set => _dwmKey.SetValue("ForceAccentColorization", value, RegistryValueKind.DWord);
        }

        public int GlassCrossFadeEasingFunction
        {
            get => (int)_dwmKey.GetValue("GlassCrossFadeEasingFunction", 0);
            set => _dwmKey.SetValue("GlassCrossFadeEasingFunction", value, RegistryValueKind.DWord);
        }

        public int ColorizationColorBalanceOverride
        {
            get => (int)_dwmKey.GetValue("ColorizationColorBalanceOverride", 0);
            set => _dwmKey.SetValue("ColorizationColorBalanceOverride", value, RegistryValueKind.DWord);
        }

        public int ColorizationAfterglowBalanceOverride
        {
            get => (int)_dwmKey.GetValue("ColorizationAfterglowBalanceOverride", 0);
            set => _dwmKey.SetValue("ColorizationAfterglowBalanceOverride", value, RegistryValueKind.DWord);
        }
    }
}