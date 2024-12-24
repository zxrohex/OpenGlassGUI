namespace OpenGlassGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            HeaderPanel = new Panel();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            label1 = new Label();
            ContentPanel = new Panel();
            GlassAdditionalPreScaleAmountGroupBox = new GroupBox();
            label11 = new Label();
            GlassAdditionalPreScaleAmountNUD = new NumericUpDown();
            GlassCrossfadeTimeGroupBox = new GroupBox();
            label10 = new Label();
            GlassCrossfadeTimeNUD = new NumericUpDown();
            GlassOverrideBorderGroupBox = new GroupBox();
            GlassOverrideBorderCheckBox = new CheckBox();
            label9 = new Label();
            GlassLuminosityGroupBox = new GroupBox();
            label8 = new Label();
            GlassLuminosityNUD = new NumericUpDown();
            CenterCaptionGroupBox = new GroupBox();
            CenterCaptionCheckBox = new CheckBox();
            label7 = new Label();
            TextGlowSizeGroupBox = new GroupBox();
            label6 = new Label();
            TextGlowSizeNUD = new NumericUpDown();
            RoundRectRadiusGroupBox = new GroupBox();
            RoundRectRadiusNUD = new NumericUpDown();
            label5 = new Label();
            groupBox5 = new GroupBox();
            button2 = new Button();
            ReflectionIntensityGroupBox = new GroupBox();
            label4 = new Label();
            ColorizationGlassReflectionIntensityNUD = new NumericUpDown();
            BlurDeviationGroupBox = new GroupBox();
            label3 = new Label();
            BlurDeviationNUD = new NumericUpDown();
            GlassOpacityGroupBox = new GroupBox();
            label2 = new Label();
            GlassOpacityNUD = new NumericUpDown();
            GlassTypeGroupBox = new GroupBox();
            GlassTypeComboBox = new ComboBox();
            panel1 = new Panel();
            button1 = new Button();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ContentPanel.SuspendLayout();
            GlassAdditionalPreScaleAmountGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GlassAdditionalPreScaleAmountNUD).BeginInit();
            GlassCrossfadeTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GlassCrossfadeTimeNUD).BeginInit();
            GlassOverrideBorderGroupBox.SuspendLayout();
            GlassLuminosityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GlassLuminosityNUD).BeginInit();
            CenterCaptionGroupBox.SuspendLayout();
            TextGlowSizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextGlowSizeNUD).BeginInit();
            RoundRectRadiusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoundRectRadiusNUD).BeginInit();
            groupBox5.SuspendLayout();
            ReflectionIntensityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ColorizationGlassReflectionIntensityNUD).BeginInit();
            BlurDeviationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BlurDeviationNUD).BeginInit();
            GlassOpacityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GlassOpacityNUD).BeginInit();
            GlassTypeGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.White;
            HeaderPanel.BorderStyle = BorderStyle.Fixed3D;
            HeaderPanel.Controls.Add(pictureBox1);
            HeaderPanel.Controls.Add(label12);
            HeaderPanel.Controls.Add(label1);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(360, 60);
            HeaderPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(65, 23);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 1;
            label12.Text = "label12";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(65, 8);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "OpenGlassGUI";
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(GlassAdditionalPreScaleAmountGroupBox);
            ContentPanel.Controls.Add(GlassCrossfadeTimeGroupBox);
            ContentPanel.Controls.Add(GlassOverrideBorderGroupBox);
            ContentPanel.Controls.Add(GlassLuminosityGroupBox);
            ContentPanel.Controls.Add(CenterCaptionGroupBox);
            ContentPanel.Controls.Add(TextGlowSizeGroupBox);
            ContentPanel.Controls.Add(RoundRectRadiusGroupBox);
            ContentPanel.Controls.Add(groupBox5);
            ContentPanel.Controls.Add(ReflectionIntensityGroupBox);
            ContentPanel.Controls.Add(BlurDeviationGroupBox);
            ContentPanel.Controls.Add(GlassOpacityGroupBox);
            ContentPanel.Controls.Add(GlassTypeGroupBox);
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(0, 60);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(360, 459);
            ContentPanel.TabIndex = 1;
            // 
            // GlassAdditionalPreScaleAmountGroupBox
            // 
            GlassAdditionalPreScaleAmountGroupBox.Controls.Add(label11);
            GlassAdditionalPreScaleAmountGroupBox.Controls.Add(GlassAdditionalPreScaleAmountNUD);
            GlassAdditionalPreScaleAmountGroupBox.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            GlassAdditionalPreScaleAmountGroupBox.Location = new Point(194, 306);
            GlassAdditionalPreScaleAmountGroupBox.Name = "GlassAdditionalPreScaleAmountGroupBox";
            GlassAdditionalPreScaleAmountGroupBox.Padding = new Padding(12, 7, 12, 12);
            GlassAdditionalPreScaleAmountGroupBox.Size = new Size(154, 54);
            GlassAdditionalPreScaleAmountGroupBox.TabIndex = 11;
            GlassAdditionalPreScaleAmountGroupBox.TabStop = false;
            GlassAdditionalPreScaleAmountGroupBox.Text = "Glass Additional Pre-Scale Amount";
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(125, 18);
            label11.Name = "label11";
            label11.Size = new Size(17, 24);
            label11.TabIndex = 1;
            label11.Text = "%";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GlassAdditionalPreScaleAmountNUD
            // 
            GlassAdditionalPreScaleAmountNUD.Dock = DockStyle.Left;
            GlassAdditionalPreScaleAmountNUD.Font = new Font("Segoe UI", 9F);
            GlassAdditionalPreScaleAmountNUD.Location = new Point(12, 18);
            GlassAdditionalPreScaleAmountNUD.Name = "GlassAdditionalPreScaleAmountNUD";
            GlassAdditionalPreScaleAmountNUD.Size = new Size(113, 23);
            GlassAdditionalPreScaleAmountNUD.TabIndex = 0;
            // 
            // GlassCrossfadeTimeGroupBox
            // 
            GlassCrossfadeTimeGroupBox.Controls.Add(label10);
            GlassCrossfadeTimeGroupBox.Controls.Add(GlassCrossfadeTimeNUD);
            GlassCrossfadeTimeGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GlassCrossfadeTimeGroupBox.Location = new Point(12, 306);
            GlassCrossfadeTimeGroupBox.Name = "GlassCrossfadeTimeGroupBox";
            GlassCrossfadeTimeGroupBox.Padding = new Padding(12, 4, 12, 12);
            GlassCrossfadeTimeGroupBox.Size = new Size(154, 54);
            GlassCrossfadeTimeGroupBox.TabIndex = 10;
            GlassCrossfadeTimeGroupBox.TabStop = false;
            GlassCrossfadeTimeGroupBox.Text = "Glass Crossfade Time";
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(142, 20);
            label10.Name = "label10";
            label10.Size = new Size(0, 22);
            label10.TabIndex = 1;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GlassCrossfadeTimeNUD
            // 
            GlassCrossfadeTimeNUD.Dock = DockStyle.Left;
            GlassCrossfadeTimeNUD.Font = new Font("Segoe UI", 9F);
            GlassCrossfadeTimeNUD.Location = new Point(12, 20);
            GlassCrossfadeTimeNUD.Name = "GlassCrossfadeTimeNUD";
            GlassCrossfadeTimeNUD.Size = new Size(130, 23);
            GlassCrossfadeTimeNUD.TabIndex = 0;
            // 
            // GlassOverrideBorderGroupBox
            // 
            GlassOverrideBorderGroupBox.Controls.Add(GlassOverrideBorderCheckBox);
            GlassOverrideBorderGroupBox.Controls.Add(label9);
            GlassOverrideBorderGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GlassOverrideBorderGroupBox.Location = new Point(194, 246);
            GlassOverrideBorderGroupBox.Name = "GlassOverrideBorderGroupBox";
            GlassOverrideBorderGroupBox.Padding = new Padding(12, 4, 12, 12);
            GlassOverrideBorderGroupBox.Size = new Size(154, 54);
            GlassOverrideBorderGroupBox.TabIndex = 9;
            GlassOverrideBorderGroupBox.TabStop = false;
            GlassOverrideBorderGroupBox.Text = "Override Border";
            // 
            // GlassOverrideBorderCheckBox
            // 
            GlassOverrideBorderCheckBox.Dock = DockStyle.Fill;
            GlassOverrideBorderCheckBox.Location = new Point(12, 20);
            GlassOverrideBorderCheckBox.Name = "GlassOverrideBorderCheckBox";
            GlassOverrideBorderCheckBox.Size = new Size(130, 22);
            GlassOverrideBorderCheckBox.TabIndex = 2;
            GlassOverrideBorderCheckBox.Text = "Enabled";
            GlassOverrideBorderCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(12, 20);
            label9.Name = "label9";
            label9.Size = new Size(130, 22);
            label9.TabIndex = 1;
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GlassLuminosityGroupBox
            // 
            GlassLuminosityGroupBox.Controls.Add(label8);
            GlassLuminosityGroupBox.Controls.Add(GlassLuminosityNUD);
            GlassLuminosityGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GlassLuminosityGroupBox.Location = new Point(12, 246);
            GlassLuminosityGroupBox.Name = "GlassLuminosityGroupBox";
            GlassLuminosityGroupBox.Padding = new Padding(12, 4, 12, 12);
            GlassLuminosityGroupBox.Size = new Size(154, 54);
            GlassLuminosityGroupBox.TabIndex = 8;
            GlassLuminosityGroupBox.TabStop = false;
            GlassLuminosityGroupBox.Text = "Glass Luminosity";
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(142, 20);
            label8.Name = "label8";
            label8.Size = new Size(0, 22);
            label8.TabIndex = 1;
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GlassLuminosityNUD
            // 
            GlassLuminosityNUD.Dock = DockStyle.Left;
            GlassLuminosityNUD.Font = new Font("Segoe UI", 9F);
            GlassLuminosityNUD.Location = new Point(12, 20);
            GlassLuminosityNUD.Name = "GlassLuminosityNUD";
            GlassLuminosityNUD.Size = new Size(130, 23);
            GlassLuminosityNUD.TabIndex = 0;
            // 
            // CenterCaptionGroupBox
            // 
            CenterCaptionGroupBox.Controls.Add(CenterCaptionCheckBox);
            CenterCaptionGroupBox.Controls.Add(label7);
            CenterCaptionGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CenterCaptionGroupBox.Location = new Point(194, 186);
            CenterCaptionGroupBox.Name = "CenterCaptionGroupBox";
            CenterCaptionGroupBox.Padding = new Padding(12, 4, 12, 12);
            CenterCaptionGroupBox.Size = new Size(154, 54);
            CenterCaptionGroupBox.TabIndex = 7;
            CenterCaptionGroupBox.TabStop = false;
            CenterCaptionGroupBox.Text = "Center Caption";
            // 
            // CenterCaptionCheckBox
            // 
            CenterCaptionCheckBox.Dock = DockStyle.Fill;
            CenterCaptionCheckBox.Location = new Point(12, 20);
            CenterCaptionCheckBox.Name = "CenterCaptionCheckBox";
            CenterCaptionCheckBox.Size = new Size(130, 22);
            CenterCaptionCheckBox.TabIndex = 2;
            CenterCaptionCheckBox.Text = "Enabled";
            CenterCaptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(12, 20);
            label7.Name = "label7";
            label7.Size = new Size(130, 22);
            label7.TabIndex = 1;
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextGlowSizeGroupBox
            // 
            TextGlowSizeGroupBox.Controls.Add(label6);
            TextGlowSizeGroupBox.Controls.Add(TextGlowSizeNUD);
            TextGlowSizeGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TextGlowSizeGroupBox.Location = new Point(12, 186);
            TextGlowSizeGroupBox.Name = "TextGlowSizeGroupBox";
            TextGlowSizeGroupBox.Padding = new Padding(12, 4, 12, 12);
            TextGlowSizeGroupBox.Size = new Size(154, 54);
            TextGlowSizeGroupBox.TabIndex = 6;
            TextGlowSizeGroupBox.TabStop = false;
            TextGlowSizeGroupBox.Text = "Text Glow Size";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(142, 20);
            label6.Name = "label6";
            label6.Size = new Size(0, 22);
            label6.TabIndex = 1;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextGlowSizeNUD
            // 
            TextGlowSizeNUD.Dock = DockStyle.Left;
            TextGlowSizeNUD.Font = new Font("Segoe UI", 9F);
            TextGlowSizeNUD.Location = new Point(12, 20);
            TextGlowSizeNUD.Name = "TextGlowSizeNUD";
            TextGlowSizeNUD.Size = new Size(130, 23);
            TextGlowSizeNUD.TabIndex = 0;
            // 
            // RoundRectRadiusGroupBox
            // 
            RoundRectRadiusGroupBox.Controls.Add(RoundRectRadiusNUD);
            RoundRectRadiusGroupBox.Controls.Add(label5);
            RoundRectRadiusGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RoundRectRadiusGroupBox.Location = new Point(194, 366);
            RoundRectRadiusGroupBox.Name = "RoundRectRadiusGroupBox";
            RoundRectRadiusGroupBox.Padding = new Padding(12, 4, 12, 12);
            RoundRectRadiusGroupBox.Size = new Size(154, 54);
            RoundRectRadiusGroupBox.TabIndex = 5;
            RoundRectRadiusGroupBox.TabStop = false;
            RoundRectRadiusGroupBox.Text = "Round Rect Radius";
            // 
            // RoundRectRadiusNUD
            // 
            RoundRectRadiusNUD.Dock = DockStyle.Left;
            RoundRectRadiusNUD.Font = new Font("Segoe UI", 9F);
            RoundRectRadiusNUD.Location = new Point(12, 20);
            RoundRectRadiusNUD.Name = "RoundRectRadiusNUD";
            RoundRectRadiusNUD.Size = new Size(130, 23);
            RoundRectRadiusNUD.TabIndex = 2;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(12, 20);
            label5.Name = "label5";
            label5.Size = new Size(130, 22);
            label5.TabIndex = 1;
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button2);
            groupBox5.Enabled = false;
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox5.Location = new Point(194, 126);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(12, 4, 12, 12);
            groupBox5.Size = new Size(154, 54);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Accent";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(12, 20);
            button2.Name = "button2";
            button2.Size = new Size(130, 22);
            button2.TabIndex = 0;
            button2.Text = "Set";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ReflectionIntensityGroupBox
            // 
            ReflectionIntensityGroupBox.Controls.Add(label4);
            ReflectionIntensityGroupBox.Controls.Add(ColorizationGlassReflectionIntensityNUD);
            ReflectionIntensityGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ReflectionIntensityGroupBox.Location = new Point(12, 126);
            ReflectionIntensityGroupBox.Name = "ReflectionIntensityGroupBox";
            ReflectionIntensityGroupBox.Padding = new Padding(12, 4, 12, 12);
            ReflectionIntensityGroupBox.Size = new Size(154, 54);
            ReflectionIntensityGroupBox.TabIndex = 3;
            ReflectionIntensityGroupBox.TabStop = false;
            ReflectionIntensityGroupBox.Text = "Reflection Intensity";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(125, 20);
            label4.Name = "label4";
            label4.Size = new Size(17, 22);
            label4.TabIndex = 1;
            label4.Text = "%";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ColorizationGlassReflectionIntensityNUD
            // 
            ColorizationGlassReflectionIntensityNUD.Dock = DockStyle.Left;
            ColorizationGlassReflectionIntensityNUD.Font = new Font("Segoe UI", 9F);
            ColorizationGlassReflectionIntensityNUD.Location = new Point(12, 20);
            ColorizationGlassReflectionIntensityNUD.Name = "ColorizationGlassReflectionIntensityNUD";
            ColorizationGlassReflectionIntensityNUD.Size = new Size(113, 23);
            ColorizationGlassReflectionIntensityNUD.TabIndex = 0;
            // 
            // BlurDeviationGroupBox
            // 
            BlurDeviationGroupBox.Controls.Add(label3);
            BlurDeviationGroupBox.Controls.Add(BlurDeviationNUD);
            BlurDeviationGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BlurDeviationGroupBox.Location = new Point(194, 66);
            BlurDeviationGroupBox.Name = "BlurDeviationGroupBox";
            BlurDeviationGroupBox.Padding = new Padding(12, 4, 12, 12);
            BlurDeviationGroupBox.Size = new Size(154, 54);
            BlurDeviationGroupBox.TabIndex = 2;
            BlurDeviationGroupBox.TabStop = false;
            BlurDeviationGroupBox.Text = "Blur Deviation";
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(142, 20);
            label3.Name = "label3";
            label3.Size = new Size(0, 22);
            label3.TabIndex = 1;
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BlurDeviationNUD
            // 
            BlurDeviationNUD.Dock = DockStyle.Left;
            BlurDeviationNUD.Font = new Font("Segoe UI", 9F);
            BlurDeviationNUD.Location = new Point(12, 20);
            BlurDeviationNUD.Name = "BlurDeviationNUD";
            BlurDeviationNUD.Size = new Size(130, 23);
            BlurDeviationNUD.TabIndex = 0;
            // 
            // GlassOpacityGroupBox
            // 
            GlassOpacityGroupBox.Controls.Add(label2);
            GlassOpacityGroupBox.Controls.Add(GlassOpacityNUD);
            GlassOpacityGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GlassOpacityGroupBox.Location = new Point(12, 66);
            GlassOpacityGroupBox.Name = "GlassOpacityGroupBox";
            GlassOpacityGroupBox.Padding = new Padding(12, 4, 12, 12);
            GlassOpacityGroupBox.Size = new Size(154, 54);
            GlassOpacityGroupBox.TabIndex = 1;
            GlassOpacityGroupBox.TabStop = false;
            GlassOpacityGroupBox.Text = "Glass Opacity";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(125, 20);
            label2.Name = "label2";
            label2.Size = new Size(17, 22);
            label2.TabIndex = 1;
            label2.Text = "%";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GlassOpacityNUD
            // 
            GlassOpacityNUD.Dock = DockStyle.Left;
            GlassOpacityNUD.Font = new Font("Segoe UI", 9F);
            GlassOpacityNUD.Location = new Point(12, 20);
            GlassOpacityNUD.Name = "GlassOpacityNUD";
            GlassOpacityNUD.Size = new Size(113, 23);
            GlassOpacityNUD.TabIndex = 0;
            // 
            // GlassTypeGroupBox
            // 
            GlassTypeGroupBox.Controls.Add(GlassTypeComboBox);
            GlassTypeGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GlassTypeGroupBox.Location = new Point(12, 6);
            GlassTypeGroupBox.Name = "GlassTypeGroupBox";
            GlassTypeGroupBox.Padding = new Padding(12, 4, 12, 4);
            GlassTypeGroupBox.Size = new Size(336, 54);
            GlassTypeGroupBox.TabIndex = 0;
            GlassTypeGroupBox.TabStop = false;
            GlassTypeGroupBox.Text = "Glass Type";
            // 
            // GlassTypeComboBox
            // 
            GlassTypeComboBox.Dock = DockStyle.Fill;
            GlassTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GlassTypeComboBox.Font = new Font("Segoe UI", 9F);
            GlassTypeComboBox.FormattingEnabled = true;
            GlassTypeComboBox.Items.AddRange(new object[] { "Blur", "Aero", "Acrylic", "Mica", "Solid" });
            GlassTypeComboBox.Location = new Point(12, 20);
            GlassTypeComboBox.Name = "GlassTypeComboBox";
            GlassTypeComboBox.Size = new Size(312, 23);
            GlassTypeComboBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 519);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 38);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(255, 7);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 0;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 557);
            Controls.Add(ContentPanel);
            Controls.Add(panel1);
            Controls.Add(HeaderPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "OpenGlassGUI";
            Load += MainForm_Load;
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ContentPanel.ResumeLayout(false);
            GlassAdditionalPreScaleAmountGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GlassAdditionalPreScaleAmountNUD).EndInit();
            GlassCrossfadeTimeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GlassCrossfadeTimeNUD).EndInit();
            GlassOverrideBorderGroupBox.ResumeLayout(false);
            GlassLuminosityGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GlassLuminosityNUD).EndInit();
            CenterCaptionGroupBox.ResumeLayout(false);
            TextGlowSizeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TextGlowSizeNUD).EndInit();
            RoundRectRadiusGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RoundRectRadiusNUD).EndInit();
            groupBox5.ResumeLayout(false);
            ReflectionIntensityGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ColorizationGlassReflectionIntensityNUD).EndInit();
            BlurDeviationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BlurDeviationNUD).EndInit();
            GlassOpacityGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GlassOpacityNUD).EndInit();
            GlassTypeGroupBox.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Label label1;
        private Panel ContentPanel;
        private GroupBox GlassTypeGroupBox;
        private ComboBox GlassTypeComboBox;
        private Panel panel1;
        private Button button1;
        private GroupBox GlassOpacityGroupBox;
        private Label label2;
        private NumericUpDown GlassOpacityNUD;
        private GroupBox BlurDeviationGroupBox;
        private Label label3;
        private NumericUpDown BlurDeviationNUD;
        private GroupBox ReflectionIntensityGroupBox;
        private Label label4;
        private NumericUpDown ColorizationGlassReflectionIntensityNUD;
        private GroupBox groupBox5;
        private Button button2;
        private GroupBox RoundRectRadiusGroupBox;
        private Label label5;
        private GroupBox TextGlowSizeGroupBox;
        private Label label6;
        private NumericUpDown TextGlowSizeNUD;
        private GroupBox CenterCaptionGroupBox;
        private CheckBox CenterCaptionCheckBox;
        private Label label7;
        private GroupBox GlassLuminosityGroupBox;
        private Label label8;
        private NumericUpDown GlassLuminosityNUD;
        private GroupBox GlassOverrideBorderGroupBox;
        private CheckBox GlassOverrideBorderCheckBox;
        private Label label9;
        private GroupBox GlassCrossfadeTimeGroupBox;
        private Label label10;
        private NumericUpDown GlassCrossfadeTimeNUD;
        private GroupBox GlassAdditionalPreScaleAmountGroupBox;
        private Label label11;
        private NumericUpDown GlassAdditionalPreScaleAmountNUD;
        private NumericUpDown RoundRectRadiusNUD;
        private Label label12;
        private PictureBox pictureBox1;
    }
}
