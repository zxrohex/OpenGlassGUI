using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

using OpenGlassGUI.Config;

namespace OpenGlassGUI
{
    public partial class MainForm : Form
    {
        OpenGlassConfiguration config = new OpenGlassConfiguration();
      
        public MainForm()
        {
            InitializeComponent();

            UpdateUI();

            label12.Text = $"{Assembly.GetExecutingAssembly().GetName().Version.ToString()}";

            pictureBox1.Image = Icon.ToBitmap();

        }

        void UpdateUI()
        {
    
            GlassTypeComboBox.SelectedIndex = config.RegistrySettings.GlassType;

            GlassOpacityNUD.Value = config.RegistrySettings.GlassOpacity;

            BlurDeviationNUD.Value = config.RegistrySettings.BlurDeviation;

            ColorizationGlassReflectionIntensityNUD.Value = config.RegistrySettings.ColorizationGlassReflectionIntensity;

            TextGlowSizeNUD.Value = config.RegistrySettings.TextGlowSize;

            CenterCaptionCheckBox.Checked = config.RegistrySettings.CenterCaption == 1;

            GlassLuminosityNUD.Value = config.RegistrySettings.GlassLuminosity;

            GlassOverrideBorderCheckBox.Checked = config.RegistrySettings.GlassOverrideBorder == 1;

            GlassCrossfadeTimeNUD.Value = config.RegistrySettings.GlassCrossFadeTime;

            GlassAdditionalPreScaleAmountNUD.Value = config.RegistrySettings.GlassAdditionalPreScaleAmount;

            RoundRectRadiusNUD.Value = config.RegistrySettings.RoundRectRadius;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(config.RegistrySettings.GlassOpacity);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateConfigs();
        }

        void UpdateConfigs()
        {
            config.RegistrySettings.GlassType = GlassTypeComboBox.SelectedIndex;

            config.RegistrySettings.GlassOpacity = (int)GlassOpacityNUD.Value;

            config.RegistrySettings.BlurDeviation = (int)BlurDeviationNUD.Value;

            config.RegistrySettings.ColorizationGlassReflectionIntensity = (int)ColorizationGlassReflectionIntensityNUD.Value;

            config.RegistrySettings.TextGlowSize = (int)TextGlowSizeNUD.Value;

            config.RegistrySettings.CenterCaption = CenterCaptionCheckBox.Checked ? 1 : 0;

            config.RegistrySettings.GlassLuminosity = (int)GlassLuminosityNUD.Value;

            config.RegistrySettings.GlassOverrideBorder = GlassOverrideBorderCheckBox.Checked ? 1 : 0;

            config.RegistrySettings.GlassCrossFadeTime = (int)GlassCrossfadeTimeNUD.Value;

            config.RegistrySettings.GlassAdditionalPreScaleAmount = (int)GlassAdditionalPreScaleAmountNUD.Value;

            config.RegistrySettings.RoundRectRadius = (int)RoundRectRadiusNUD.Value;

            config.UpdateDwm();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    config.RegistrySettings.ColorizationColorCaption = cd.Color.ToArgb();
               
                }
            }
        }
    }
}
