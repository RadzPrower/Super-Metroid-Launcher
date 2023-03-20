namespace Super_Metroid_Launcher
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.general = new System.Windows.Forms.GroupBox();
            this.disableFrameDelay = new System.Windows.Forms.CheckBox();
            this.checkBoxExtend = new System.Windows.Forms.CheckBox();
            this.noVisualFixes = new System.Windows.Forms.CheckBox();
            this.unchangedSprites = new System.Windows.Forms.CheckBox();
            this.aspectRatio = new System.Windows.Forms.GroupBox();
            this.steamdeck = new System.Windows.Forms.RadioButton();
            this.widescreen = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.performance = new System.Windows.Forms.CheckBox();
            this.autosaveCheck = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radioFullscreenMode = new System.Windows.Forms.RadioButton();
            this.radioFullscreen = new System.Windows.Forms.RadioButton();
            this.radioWindowed = new System.Windows.Forms.RadioButton();
            this.height = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.customSize = new System.Windows.Forms.RadioButton();
            this.windowAuto = new System.Windows.Forms.RadioButton();
            this.checkPPU = new System.Windows.Forms.CheckBox();
            this.numericWindowScale = new System.Windows.Forms.NumericUpDown();
            this.labelScale = new System.Windows.Forms.Label();
            this.checkMode7 = new System.Windows.Forms.CheckBox();
            this.checkStretch = new System.Windows.Forms.CheckBox();
            this.checkSpriteLimit = new System.Windows.Forms.CheckBox();
            this.checkLinearFiltering = new System.Windows.Forms.CheckBox();
            this.buttonOpenShader = new System.Windows.Forms.Button();
            this.textBoxGLSLShader = new System.Windows.Forms.TextBox();
            this.buttonOpenSprites = new System.Windows.Forms.Button();
            this.textBoxCustomLink = new System.Windows.Forms.TextBox();
            this.checkBoxCustomLinkSprites = new System.Windows.Forms.CheckBox();
            this.checkBoxShader = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAudio = new System.Windows.Forms.CheckBox();
            this.labelAudioFrequency = new System.Windows.Forms.Label();
            this.labelAudioSamples = new System.Windows.Forms.Label();
            this.groupBoxMSUSettings = new System.Windows.Forms.GroupBox();
            this.comboBoxMSU = new System.Windows.Forms.ComboBox();
            this.textBoxMSUDirectory = new System.Windows.Forms.TextBox();
            this.labelMSUVersion = new System.Windows.Forms.Label();
            this.labelMSUDirectory = new System.Windows.Forms.Label();
            this.numericMSUVolume = new System.Windows.Forms.NumericUpDown();
            this.checkBoxResumeMSU = new System.Windows.Forms.CheckBox();
            this.labelMSUVolume = new System.Windows.Forms.Label();
            this.buttonMSUDirectory = new System.Windows.Forms.Button();
            this.comboBoxSamples = new System.Windows.Forms.ComboBox();
            this.comboBoxFrequency = new System.Windows.Forms.ComboBox();
            this.checkBoxEnableMSU = new System.Windows.Forms.CheckBox();
            this.radioButtonStereo = new System.Windows.Forms.RadioButton();
            this.radioButtonMono = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelRenderMethod = new System.Windows.Forms.Label();
            this.comboRenderMethod = new System.Windows.Forms.ComboBox();
            this.linkLabelCustomSprites = new System.Windows.Forms.LinkLabel();
            this.buttonKeymapping = new System.Windows.Forms.Button();
            this.graphics = new System.Windows.Forms.GroupBox();
            this.linkLabelGLSLShaders = new System.Windows.Forms.LinkLabel();
            this.fullscreenMode = new System.Windows.Forms.GroupBox();
            this.windowSize = new System.Windows.Forms.GroupBox();
            this.windowSizeX = new System.Windows.Forms.Label();
            this.checkBoxDimFlashing = new System.Windows.Forms.CheckBox();
            this.groupBoxSound = new System.Windows.Forms.GroupBox();
            this.groupBoxAudioChannels = new System.Windows.Forms.GroupBox();
            this.groupBoxGameplay = new System.Windows.Forms.GroupBox();
            this.labelHoverNote = new System.Windows.Forms.Label();
            this.labelMSUCopy = new System.Windows.Forms.Label();
            this.progressMSU = new System.Windows.Forms.ProgressBar();
            this.general.SuspendLayout();
            this.aspectRatio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWindowScale)).BeginInit();
            this.groupBoxMSUSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMSUVolume)).BeginInit();
            this.graphics.SuspendLayout();
            this.fullscreenMode.SuspendLayout();
            this.windowSize.SuspendLayout();
            this.groupBoxSound.SuspendLayout();
            this.groupBoxAudioChannels.SuspendLayout();
            this.SuspendLayout();
            // 
            // general
            // 
            this.general.Controls.Add(this.disableFrameDelay);
            this.general.Location = new System.Drawing.Point(214, 169);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(173, 49);
            this.general.TabIndex = 5;
            this.general.TabStop = false;
            this.general.Text = "General";
            // 
            // disableFrameDelay
            // 
            this.disableFrameDelay.AutoSize = true;
            this.disableFrameDelay.Location = new System.Drawing.Point(12, 22);
            this.disableFrameDelay.Name = "disableFrameDelay";
            this.disableFrameDelay.Size = new System.Drawing.Size(132, 19);
            this.disableFrameDelay.TabIndex = 4;
            this.disableFrameDelay.Text = "Disable Frame Delay";
            this.toolTip1.SetToolTip(this.disableFrameDelay, "Disable the SDL_Delay that happens on each frame (Gives slightly better performan" +
        "ce if your display is set to exactly 60Hz)");
            this.disableFrameDelay.UseVisualStyleBackColor = true;
            // 
            // checkBoxExtend
            // 
            this.checkBoxExtend.AutoSize = true;
            this.checkBoxExtend.Location = new System.Drawing.Point(994, 878);
            this.checkBoxExtend.Name = "checkBoxExtend";
            this.checkBoxExtend.Size = new System.Drawing.Size(72, 19);
            this.checkBoxExtend.TabIndex = 3;
            this.checkBoxExtend.Text = "Extend Y";
            this.toolTip1.SetToolTip(this.checkBoxExtend, "Displays 240 vertical lines rather than the default 224");
            this.checkBoxExtend.UseVisualStyleBackColor = true;
            this.checkBoxExtend.Visible = false;
            // 
            // noVisualFixes
            // 
            this.noVisualFixes.AutoSize = true;
            this.noVisualFixes.Location = new System.Drawing.Point(1238, 878);
            this.noVisualFixes.Name = "noVisualFixes";
            this.noVisualFixes.Size = new System.Drawing.Size(105, 19);
            this.noVisualFixes.TabIndex = 5;
            this.noVisualFixes.Text = "No Visual Fixes";
            this.toolTip1.SetToolTip(this.noVisualFixes, "Avoid fixing some graphics glitches. If enabled, memory compare will not work.");
            this.noVisualFixes.UseVisualStyleBackColor = true;
            this.noVisualFixes.Visible = false;
            // 
            // unchangedSprites
            // 
            this.unchangedSprites.AutoSize = true;
            this.unchangedSprites.Location = new System.Drawing.Point(1238, 853);
            this.unchangedSprites.Name = "unchangedSprites";
            this.unchangedSprites.Size = new System.Drawing.Size(125, 19);
            this.unchangedSprites.TabIndex = 2;
            this.unchangedSprites.Text = "Unchanged Sprites";
            this.toolTip1.SetToolTip(this.unchangedSprites, "Avoid changing sprite spawn/die behavior. (Required for replay compatibility)");
            this.unchangedSprites.UseVisualStyleBackColor = true;
            this.unchangedSprites.Visible = false;
            // 
            // aspectRatio
            // 
            this.aspectRatio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aspectRatio.Controls.Add(this.steamdeck);
            this.aspectRatio.Controls.Add(this.widescreen);
            this.aspectRatio.Controls.Add(this.normal);
            this.aspectRatio.Location = new System.Drawing.Point(994, 783);
            this.aspectRatio.Name = "aspectRatio";
            this.aspectRatio.Size = new System.Drawing.Size(369, 50);
            this.aspectRatio.TabIndex = 6;
            this.aspectRatio.TabStop = false;
            this.aspectRatio.Text = "Aspect Ratio";
            this.toolTip1.SetToolTip(this.aspectRatio, "This is the aspect ratio which the game will render. All aspect ratios other than" +
        " Normal will result in black bars on the left and right in various scenarios.");
            this.aspectRatio.Visible = false;
            // 
            // steamdeck
            // 
            this.steamdeck.AutoSize = true;
            this.steamdeck.Location = new System.Drawing.Point(238, 22);
            this.steamdeck.Name = "steamdeck";
            this.steamdeck.Size = new System.Drawing.Size(125, 19);
            this.steamdeck.TabIndex = 2;
            this.steamdeck.Text = "Steam Deck (16:10)";
            this.toolTip1.SetToolTip(this.steamdeck, "Steam Deck\'s untraditional aspect ratio");
            this.steamdeck.UseVisualStyleBackColor = true;
            // 
            // widescreen
            // 
            this.widescreen.AutoSize = true;
            this.widescreen.Location = new System.Drawing.Point(107, 22);
            this.widescreen.Name = "widescreen";
            this.widescreen.Size = new System.Drawing.Size(118, 19);
            this.widescreen.TabIndex = 1;
            this.widescreen.Text = "Widescreen (16:9)";
            this.toolTip1.SetToolTip(this.widescreen, "Traditional widescreen screens");
            this.widescreen.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Checked = true;
            this.normal.Location = new System.Drawing.Point(6, 22);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(91, 19);
            this.normal.TabIndex = 0;
            this.normal.TabStop = true;
            this.normal.Text = "Normal (4:3)";
            this.toolTip1.SetToolTip(this.normal, "Original output of the SNES");
            this.normal.UseVisualStyleBackColor = true;
            // 
            // performance
            // 
            this.performance.AutoSize = true;
            this.performance.Location = new System.Drawing.Point(1087, 853);
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(132, 19);
            this.performance.TabIndex = 1;
            this.performance.Text = "Performance in Title";
            this.toolTip1.SetToolTip(this.performance, "Show current performance in window title");
            this.performance.UseVisualStyleBackColor = true;
            this.performance.Visible = false;
            // 
            // autosaveCheck
            // 
            this.autosaveCheck.AutoSize = true;
            this.autosaveCheck.Location = new System.Drawing.Point(108, 53);
            this.autosaveCheck.Name = "autosaveCheck";
            this.autosaveCheck.Size = new System.Drawing.Size(75, 19);
            this.autosaveCheck.TabIndex = 0;
            this.autosaveCheck.Text = "Autosave";
            this.toolTip1.SetToolTip(this.autosaveCheck, "Automatically save state on quit and reload on start");
            this.autosaveCheck.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "toolTip1";
            // 
            // radioFullscreenMode
            // 
            this.radioFullscreenMode.AutoSize = true;
            this.radioFullscreenMode.Location = new System.Drawing.Point(6, 72);
            this.radioFullscreenMode.Name = "radioFullscreenMode";
            this.radioFullscreenMode.Size = new System.Drawing.Size(78, 19);
            this.radioFullscreenMode.TabIndex = 2;
            this.radioFullscreenMode.Text = "Fullscreen";
            this.toolTip1.SetToolTip(this.radioFullscreenMode, "Game will launch in exclusive fullscreen mode");
            this.radioFullscreenMode.UseVisualStyleBackColor = true;
            // 
            // radioFullscreen
            // 
            this.radioFullscreen.AutoSize = true;
            this.radioFullscreen.Location = new System.Drawing.Point(6, 47);
            this.radioFullscreen.Name = "radioFullscreen";
            this.radioFullscreen.Size = new System.Drawing.Size(135, 19);
            this.radioFullscreen.TabIndex = 1;
            this.radioFullscreen.Text = "Borderless Fullscreen";
            this.toolTip1.SetToolTip(this.radioFullscreen, "Game will launch in borderless fullscreen");
            this.radioFullscreen.UseVisualStyleBackColor = true;
            // 
            // radioWindowed
            // 
            this.radioWindowed.AutoSize = true;
            this.radioWindowed.Checked = true;
            this.radioWindowed.Location = new System.Drawing.Point(6, 22);
            this.radioWindowed.Name = "radioWindowed";
            this.radioWindowed.Size = new System.Drawing.Size(82, 19);
            this.radioWindowed.TabIndex = 0;
            this.radioWindowed.TabStop = true;
            this.radioWindowed.Text = "Windowed";
            this.toolTip1.SetToolTip(this.radioWindowed, "The game will play within a window on the desktop at your selected aspect ratio a" +
        "nd window scaling");
            this.radioWindowed.UseVisualStyleBackColor = true;
            // 
            // height
            // 
            this.height.Enabled = false;
            this.height.Location = new System.Drawing.Point(59, 71);
            this.height.MaxLength = 4;
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(35, 23);
            this.height.TabIndex = 3;
            this.toolTip1.SetToolTip(this.height, "Height");
            // 
            // width
            // 
            this.width.Enabled = false;
            this.width.Location = new System.Drawing.Point(6, 71);
            this.width.MaxLength = 4;
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(35, 23);
            this.width.TabIndex = 2;
            this.toolTip1.SetToolTip(this.width, "Width");
            // 
            // customSize
            // 
            this.customSize.AutoSize = true;
            this.customSize.Location = new System.Drawing.Point(6, 47);
            this.customSize.Name = "customSize";
            this.customSize.Size = new System.Drawing.Size(67, 19);
            this.customSize.TabIndex = 1;
            this.customSize.Text = "Custom";
            this.toolTip1.SetToolTip(this.customSize, "Set a custom aspect ratio");
            this.customSize.UseVisualStyleBackColor = true;
            // 
            // windowAuto
            // 
            this.windowAuto.AutoSize = true;
            this.windowAuto.Checked = true;
            this.windowAuto.Location = new System.Drawing.Point(6, 22);
            this.windowAuto.Name = "windowAuto";
            this.windowAuto.Size = new System.Drawing.Size(51, 19);
            this.windowAuto.TabIndex = 0;
            this.windowAuto.TabStop = true;
            this.windowAuto.Text = "Auto";
            this.toolTip1.SetToolTip(this.windowAuto, "Automatically resize window to match selected aspect ratio");
            this.windowAuto.UseVisualStyleBackColor = true;
            this.windowAuto.CheckedChanged += new System.EventHandler(this.customSizeChange);
            // 
            // checkPPU
            // 
            this.checkPPU.AutoSize = true;
            this.checkPPU.Checked = true;
            this.checkPPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPPU.Location = new System.Drawing.Point(6, 130);
            this.checkPPU.Name = "checkPPU";
            this.checkPPU.Size = new System.Drawing.Size(136, 19);
            this.checkPPU.TabIndex = 2;
            this.checkPPU.Text = "Optimized SNES PPU";
            this.toolTip1.SetToolTip(this.checkPPU, "Use an optimized SNES PPU implementation (potentially buggy)");
            this.checkPPU.UseVisualStyleBackColor = true;
            // 
            // numericWindowScale
            // 
            this.numericWindowScale.Location = new System.Drawing.Point(340, 180);
            this.numericWindowScale.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericWindowScale.Name = "numericWindowScale";
            this.numericWindowScale.Size = new System.Drawing.Size(35, 23);
            this.numericWindowScale.TabIndex = 7;
            this.toolTip1.SetToolTip(this.numericWindowScale, "1 = 100%\r\n2 = 200%\r\n3 = 300%\r\netc.");
            this.numericWindowScale.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelScale
            // 
            this.labelScale.Location = new System.Drawing.Point(239, 180);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(95, 23);
            this.labelScale.TabIndex = 4;
            this.labelScale.Text = "Window Scaling:";
            this.labelScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelScale, "This sets the scaling of the game window when not fullscreen");
            // 
            // checkMode7
            // 
            this.checkMode7.AutoSize = true;
            this.checkMode7.Checked = true;
            this.checkMode7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMode7.Location = new System.Drawing.Point(6, 155);
            this.checkMode7.Name = "checkMode7";
            this.checkMode7.Size = new System.Drawing.Size(118, 19);
            this.checkMode7.TabIndex = 5;
            this.checkMode7.Text = "Enhanced Mode7";
            this.toolTip1.SetToolTip(this.checkMode7, "Display the world map with higher resolution");
            this.checkMode7.UseVisualStyleBackColor = true;
            // 
            // checkStretch
            // 
            this.checkStretch.AutoSize = true;
            this.checkStretch.Location = new System.Drawing.Point(152, 155);
            this.checkStretch.Name = "checkStretch";
            this.checkStretch.Size = new System.Drawing.Size(63, 19);
            this.checkStretch.TabIndex = 6;
            this.checkStretch.Text = "Stretch";
            this.toolTip1.SetToolTip(this.checkStretch, "Stretches the graphics to take up the entire window/screen regardless of aspect r" +
        "atio.");
            this.checkStretch.UseVisualStyleBackColor = true;
            // 
            // checkSpriteLimit
            // 
            this.checkSpriteLimit.AutoSize = true;
            this.checkSpriteLimit.Checked = true;
            this.checkSpriteLimit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSpriteLimit.Location = new System.Drawing.Point(152, 130);
            this.checkSpriteLimit.Name = "checkSpriteLimit";
            this.checkSpriteLimit.Size = new System.Drawing.Size(105, 19);
            this.checkSpriteLimit.TabIndex = 3;
            this.checkSpriteLimit.Text = "No Sprite Limit";
            this.toolTip1.SetToolTip(this.checkSpriteLimit, "Remove the sprite limit per scan line");
            this.checkSpriteLimit.UseVisualStyleBackColor = true;
            // 
            // checkLinearFiltering
            // 
            this.checkLinearFiltering.AutoSize = true;
            this.checkLinearFiltering.Location = new System.Drawing.Point(270, 130);
            this.checkLinearFiltering.Name = "checkLinearFiltering";
            this.checkLinearFiltering.Size = new System.Drawing.Size(104, 19);
            this.checkLinearFiltering.TabIndex = 4;
            this.checkLinearFiltering.Text = "Linear Filtering";
            this.toolTip1.SetToolTip(this.checkLinearFiltering, "Use linear filter. Softens image and results in less crisp pixels.");
            this.checkLinearFiltering.UseVisualStyleBackColor = true;
            // 
            // buttonOpenShader
            // 
            this.buttonOpenShader.AutoSize = true;
            this.buttonOpenShader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenShader.Location = new System.Drawing.Point(348, 230);
            this.buttonOpenShader.Name = "buttonOpenShader";
            this.buttonOpenShader.Size = new System.Drawing.Size(26, 25);
            this.buttonOpenShader.TabIndex = 13;
            this.buttonOpenShader.Text = "...";
            this.toolTip1.SetToolTip(this.buttonOpenShader, "Opens a dialog for selecting your GLSL shader file.");
            this.buttonOpenShader.UseVisualStyleBackColor = true;
            this.buttonOpenShader.Click += new System.EventHandler(this.buttonOpenShader_Click);
            // 
            // textBoxGLSLShader
            // 
            this.textBoxGLSLShader.Location = new System.Drawing.Point(6, 231);
            this.textBoxGLSLShader.Name = "textBoxGLSLShader";
            this.textBoxGLSLShader.Size = new System.Drawing.Size(336, 23);
            this.textBoxGLSLShader.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBoxGLSLShader, "The path where your .glsl or .slslp file is located");
            // 
            // buttonOpenSprites
            // 
            this.buttonOpenSprites.AutoSize = true;
            this.buttonOpenSprites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenSprites.Location = new System.Drawing.Point(1337, 752);
            this.buttonOpenSprites.Name = "buttonOpenSprites";
            this.buttonOpenSprites.Size = new System.Drawing.Size(26, 25);
            this.buttonOpenSprites.TabIndex = 10;
            this.buttonOpenSprites.Text = "...";
            this.toolTip1.SetToolTip(this.buttonOpenSprites, "Opens a dialog for selecting your ZSPR custom sprite file.");
            this.buttonOpenSprites.UseVisualStyleBackColor = true;
            this.buttonOpenSprites.Visible = false;
            this.buttonOpenSprites.Click += new System.EventHandler(this.buttonOpenSprites_Click);
            // 
            // textBoxCustomLink
            // 
            this.textBoxCustomLink.Location = new System.Drawing.Point(995, 753);
            this.textBoxCustomLink.Name = "textBoxCustomLink";
            this.textBoxCustomLink.Size = new System.Drawing.Size(336, 23);
            this.textBoxCustomLink.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBoxCustomLink, "The path where your .zspr file is located");
            this.textBoxCustomLink.Visible = false;
            // 
            // checkBoxCustomLinkSprites
            // 
            this.checkBoxCustomLinkSprites.AutoSize = true;
            this.checkBoxCustomLinkSprites.Location = new System.Drawing.Point(995, 728);
            this.checkBoxCustomLinkSprites.Name = "checkBoxCustomLinkSprites";
            this.checkBoxCustomLinkSprites.Size = new System.Drawing.Size(131, 19);
            this.checkBoxCustomLinkSprites.TabIndex = 0;
            this.checkBoxCustomLinkSprites.Text = "Custom Link Sprites";
            this.toolTip1.SetToolTip(this.checkBoxCustomLinkSprites, "Enables custom ZSPR Link sprites");
            this.checkBoxCustomLinkSprites.UseVisualStyleBackColor = true;
            this.checkBoxCustomLinkSprites.Visible = false;
            this.checkBoxCustomLinkSprites.CheckedChanged += new System.EventHandler(this.checkBoxCustomLinkSprites_CheckedChanged);
            // 
            // checkBoxShader
            // 
            this.checkBoxShader.AutoSize = true;
            this.checkBoxShader.Location = new System.Drawing.Point(6, 209);
            this.checkBoxShader.Name = "checkBoxShader";
            this.checkBoxShader.Size = new System.Drawing.Size(113, 19);
            this.checkBoxShader.TabIndex = 17;
            this.checkBoxShader.Text = "Use GLSL Shader";
            this.toolTip1.SetToolTip(this.checkBoxShader, "This will enable the use of GLSL shaders.\r\n\r\nThis is only supported by the OpenGL" +
        " renderer.");
            this.checkBoxShader.UseVisualStyleBackColor = true;
            this.checkBoxShader.CheckedChanged += new System.EventHandler(this.checkBoxShader_CheckedChanged);
            // 
            // checkBoxEnableAudio
            // 
            this.checkBoxEnableAudio.AutoSize = true;
            this.checkBoxEnableAudio.Checked = true;
            this.checkBoxEnableAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableAudio.Location = new System.Drawing.Point(6, 53);
            this.checkBoxEnableAudio.Name = "checkBoxEnableAudio";
            this.checkBoxEnableAudio.Size = new System.Drawing.Size(96, 19);
            this.checkBoxEnableAudio.TabIndex = 7;
            this.checkBoxEnableAudio.Text = "Enable Audio";
            this.toolTip1.SetToolTip(this.checkBoxEnableAudio, "Enable audio output by the game");
            this.checkBoxEnableAudio.UseVisualStyleBackColor = true;
            this.checkBoxEnableAudio.CheckedChanged += new System.EventHandler(this.checkBoxEnableAudio_CheckedChanged);
            // 
            // labelAudioFrequency
            // 
            this.labelAudioFrequency.AutoSize = true;
            this.labelAudioFrequency.Location = new System.Drawing.Point(35, 84);
            this.labelAudioFrequency.Name = "labelAudioFrequency";
            this.labelAudioFrequency.Size = new System.Drawing.Size(100, 15);
            this.labelAudioFrequency.TabIndex = 1;
            this.labelAudioFrequency.Text = "Audio Frequency:";
            this.toolTip1.SetToolTip(this.labelAudioFrequency, "DSP frequency in samples per second");
            // 
            // labelAudioSamples
            // 
            this.labelAudioSamples.AutoSize = true;
            this.labelAudioSamples.Location = new System.Drawing.Point(46, 112);
            this.labelAudioSamples.Name = "labelAudioSamples";
            this.labelAudioSamples.Size = new System.Drawing.Size(89, 15);
            this.labelAudioSamples.TabIndex = 2;
            this.labelAudioSamples.Text = "Audio Samples:";
            this.toolTip1.SetToolTip(this.labelAudioSamples, "Audio buffer size in samples");
            // 
            // groupBoxMSUSettings
            // 
            this.groupBoxMSUSettings.Controls.Add(this.comboBoxMSU);
            this.groupBoxMSUSettings.Controls.Add(this.textBoxMSUDirectory);
            this.groupBoxMSUSettings.Controls.Add(this.labelMSUVersion);
            this.groupBoxMSUSettings.Controls.Add(this.labelMSUDirectory);
            this.groupBoxMSUSettings.Controls.Add(this.numericMSUVolume);
            this.groupBoxMSUSettings.Controls.Add(this.checkBoxResumeMSU);
            this.groupBoxMSUSettings.Controls.Add(this.labelMSUVolume);
            this.groupBoxMSUSettings.Controls.Add(this.buttonMSUDirectory);
            this.groupBoxMSUSettings.Location = new System.Drawing.Point(1163, 555);
            this.groupBoxMSUSettings.Name = "groupBoxMSUSettings";
            this.groupBoxMSUSettings.Size = new System.Drawing.Size(190, 145);
            this.groupBoxMSUSettings.TabIndex = 4;
            this.groupBoxMSUSettings.TabStop = false;
            this.groupBoxMSUSettings.Text = "MSU Settings";
            this.toolTip1.SetToolTip(this.groupBoxMSUSettings, "Settings specifically for MSU");
            this.groupBoxMSUSettings.Visible = false;
            // 
            // comboBoxMSU
            // 
            this.comboBoxMSU.FormattingEnabled = true;
            this.comboBoxMSU.Items.AddRange(new object[] {
            "MSU",
            "MSU Deluxe",
            "OPUZ",
            "OPUZ Deluxe"});
            this.comboBoxMSU.Location = new System.Drawing.Point(85, 68);
            this.comboBoxMSU.MaxDropDownItems = 4;
            this.comboBoxMSU.Name = "comboBoxMSU";
            this.comboBoxMSU.Size = new System.Drawing.Size(99, 23);
            this.comboBoxMSU.TabIndex = 2;
            this.comboBoxMSU.Text = "MSU";
            this.toolTip1.SetToolTip(this.comboBoxMSU, "Select the version of MSU you wish to use");
            // 
            // textBoxMSUDirectory
            // 
            this.textBoxMSUDirectory.Location = new System.Drawing.Point(6, 115);
            this.textBoxMSUDirectory.Name = "textBoxMSUDirectory";
            this.textBoxMSUDirectory.Size = new System.Drawing.Size(146, 23);
            this.textBoxMSUDirectory.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxMSUDirectory, "MSU directory path");
            // 
            // labelMSUVersion
            // 
            this.labelMSUVersion.AutoSize = true;
            this.labelMSUVersion.Location = new System.Drawing.Point(6, 71);
            this.labelMSUVersion.Name = "labelMSUVersion";
            this.labelMSUVersion.Size = new System.Drawing.Size(73, 15);
            this.labelMSUVersion.TabIndex = 7;
            this.labelMSUVersion.Text = "MSU Version";
            // 
            // labelMSUDirectory
            // 
            this.labelMSUDirectory.AutoSize = true;
            this.labelMSUDirectory.Location = new System.Drawing.Point(6, 94);
            this.labelMSUDirectory.Name = "labelMSUDirectory";
            this.labelMSUDirectory.Size = new System.Drawing.Size(86, 15);
            this.labelMSUDirectory.TabIndex = 8;
            this.labelMSUDirectory.Text = "MSU Directory:";
            this.toolTip1.SetToolTip(this.labelMSUDirectory, "Directory where MSU files are located");
            // 
            // numericMSUVolume
            // 
            this.numericMSUVolume.Location = new System.Drawing.Point(90, 39);
            this.numericMSUVolume.Name = "numericMSUVolume";
            this.numericMSUVolume.Size = new System.Drawing.Size(42, 23);
            this.numericMSUVolume.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numericMSUVolume, "Volume of MSU output (0-100)");
            this.numericMSUVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBoxResumeMSU
            // 
            this.checkBoxResumeMSU.AutoSize = true;
            this.checkBoxResumeMSU.Location = new System.Drawing.Point(6, 20);
            this.checkBoxResumeMSU.Name = "checkBoxResumeMSU";
            this.checkBoxResumeMSU.Size = new System.Drawing.Size(96, 19);
            this.checkBoxResumeMSU.TabIndex = 0;
            this.checkBoxResumeMSU.Text = "Resume MSU";
            this.toolTip1.SetToolTip(this.checkBoxResumeMSU, "Resume MSU music from the same point in the track when returning to an area");
            this.checkBoxResumeMSU.UseVisualStyleBackColor = true;
            // 
            // labelMSUVolume
            // 
            this.labelMSUVolume.AutoSize = true;
            this.labelMSUVolume.Location = new System.Drawing.Point(6, 43);
            this.labelMSUVolume.Name = "labelMSUVolume";
            this.labelMSUVolume.Size = new System.Drawing.Size(78, 15);
            this.labelMSUVolume.TabIndex = 8;
            this.labelMSUVolume.Text = "MSU Volume:";
            this.toolTip1.SetToolTip(this.labelMSUVolume, "Volume of MSU output (0-100)");
            // 
            // buttonMSUDirectory
            // 
            this.buttonMSUDirectory.AutoSize = true;
            this.buttonMSUDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMSUDirectory.Location = new System.Drawing.Point(158, 114);
            this.buttonMSUDirectory.Name = "buttonMSUDirectory";
            this.buttonMSUDirectory.Size = new System.Drawing.Size(26, 25);
            this.buttonMSUDirectory.TabIndex = 4;
            this.buttonMSUDirectory.Text = "...";
            this.toolTip1.SetToolTip(this.buttonMSUDirectory, "Open dialog to select MSU directory");
            this.buttonMSUDirectory.UseVisualStyleBackColor = true;
            this.buttonMSUDirectory.Click += new System.EventHandler(this.buttonMSUDirectory_Click);
            // 
            // comboBoxSamples
            // 
            this.comboBoxSamples.FormattingEnabled = true;
            this.comboBoxSamples.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096"});
            this.comboBoxSamples.Location = new System.Drawing.Point(141, 109);
            this.comboBoxSamples.MaxDropDownItems = 4;
            this.comboBoxSamples.Name = "comboBoxSamples";
            this.comboBoxSamples.Size = new System.Drawing.Size(55, 23);
            this.comboBoxSamples.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBoxSamples, "Audio buffer size in samples");
            // 
            // comboBoxFrequency
            // 
            this.comboBoxFrequency.FormattingEnabled = true;
            this.comboBoxFrequency.Items.AddRange(new object[] {
            "48000",
            "44100",
            "32000",
            "22050",
            "11025"});
            this.comboBoxFrequency.Location = new System.Drawing.Point(141, 80);
            this.comboBoxFrequency.MaxDropDownItems = 5;
            this.comboBoxFrequency.Name = "comboBoxFrequency";
            this.comboBoxFrequency.Size = new System.Drawing.Size(55, 23);
            this.comboBoxFrequency.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxFrequency, "DSP frequency in samples per second");
            // 
            // checkBoxEnableMSU
            // 
            this.checkBoxEnableMSU.AutoSize = true;
            this.checkBoxEnableMSU.Location = new System.Drawing.Point(1163, 530);
            this.checkBoxEnableMSU.Name = "checkBoxEnableMSU";
            this.checkBoxEnableMSU.Size = new System.Drawing.Size(89, 19);
            this.checkBoxEnableMSU.TabIndex = 3;
            this.checkBoxEnableMSU.Text = "Enable MSU";
            this.toolTip1.SetToolTip(this.checkBoxEnableMSU, resources.GetString("checkBoxEnableMSU.ToolTip"));
            this.checkBoxEnableMSU.UseVisualStyleBackColor = true;
            this.checkBoxEnableMSU.Visible = false;
            this.checkBoxEnableMSU.CheckedChanged += new System.EventHandler(this.checkBoxEnableMSU_CheckedChanged);
            // 
            // radioButtonStereo
            // 
            this.radioButtonStereo.AutoSize = true;
            this.radioButtonStereo.Checked = true;
            this.radioButtonStereo.Location = new System.Drawing.Point(92, 22);
            this.radioButtonStereo.Name = "radioButtonStereo";
            this.radioButtonStereo.Size = new System.Drawing.Size(58, 19);
            this.radioButtonStereo.TabIndex = 1;
            this.radioButtonStereo.TabStop = true;
            this.radioButtonStereo.Text = "Stereo";
            this.toolTip1.SetToolTip(this.radioButtonStereo, "Outputs audio to the left or right speakers based where the sound is generated on" +
        " screen");
            this.radioButtonStereo.UseVisualStyleBackColor = true;
            // 
            // radioButtonMono
            // 
            this.radioButtonMono.AutoSize = true;
            this.radioButtonMono.Location = new System.Drawing.Point(29, 22);
            this.radioButtonMono.Name = "radioButtonMono";
            this.radioButtonMono.Size = new System.Drawing.Size(57, 19);
            this.radioButtonMono.TabIndex = 0;
            this.radioButtonMono.Text = "Mono";
            this.toolTip1.SetToolTip(this.radioButtonMono, "Uniform audio output across all speakers");
            this.radioButtonMono.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(214, 53);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(173, 35);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Reset all settings to their default values");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(214, 92);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(173, 35);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.toolTip1.SetToolTip(this.buttonSave, "Save current settings and close window");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(214, 130);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(173, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.buttonCancel, "Close window without saving any settings");
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelRenderMethod
            // 
            this.labelRenderMethod.AutoSize = true;
            this.labelRenderMethod.Location = new System.Drawing.Point(6, 183);
            this.labelRenderMethod.Name = "labelRenderMethod";
            this.labelRenderMethod.Size = new System.Drawing.Size(92, 15);
            this.labelRenderMethod.TabIndex = 11;
            this.labelRenderMethod.Text = "Render Method:";
            this.toolTip1.SetToolTip(this.labelRenderMethod, "Rendering software used. SDL-software rendering may give better performance on Ra" +
        "spberry Pi");
            // 
            // comboRenderMethod
            // 
            this.comboRenderMethod.FormattingEnabled = true;
            this.comboRenderMethod.Items.AddRange(new object[] {
            "SDL (Default)",
            "SDL-Software",
            "OpenGL"});
            this.comboRenderMethod.Location = new System.Drawing.Point(104, 180);
            this.comboRenderMethod.MaxDropDownItems = 3;
            this.comboRenderMethod.Name = "comboRenderMethod";
            this.comboRenderMethod.Size = new System.Drawing.Size(129, 23);
            this.comboRenderMethod.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboRenderMethod, "Rendering software used. SDL-software rendering may give better performance on Ra" +
        "spberry Pi");
            // 
            // linkLabelCustomSprites
            // 
            this.linkLabelCustomSprites.AutoSize = true;
            this.linkLabelCustomSprites.Location = new System.Drawing.Point(1219, 729);
            this.linkLabelCustomSprites.Name = "linkLabelCustomSprites";
            this.linkLabelCustomSprites.Size = new System.Drawing.Size(144, 15);
            this.linkLabelCustomSprites.TabIndex = 11;
            this.linkLabelCustomSprites.TabStop = true;
            this.linkLabelCustomSprites.Text = "Custom Sprite Downloads";
            this.toolTip1.SetToolTip(this.linkLabelCustomSprites, "Click here for some custom sprites you can download");
            this.linkLabelCustomSprites.Visible = false;
            this.linkLabelCustomSprites.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCustomSprites_LinkClicked);
            // 
            // buttonKeymapping
            // 
            this.buttonKeymapping.Location = new System.Drawing.Point(6, 493);
            this.buttonKeymapping.Name = "buttonKeymapping";
            this.buttonKeymapping.Size = new System.Drawing.Size(381, 35);
            this.buttonKeymapping.TabIndex = 0;
            this.buttonKeymapping.Text = "Keymapping";
            this.toolTip1.SetToolTip(this.buttonKeymapping, "Open a new settings menu exclusively for configuring keymappings for the game");
            this.buttonKeymapping.UseVisualStyleBackColor = true;
            this.buttonKeymapping.Click += new System.EventHandler(this.buttonKeymapping_Click);
            // 
            // graphics
            // 
            this.graphics.Controls.Add(this.linkLabelGLSLShaders);
            this.graphics.Controls.Add(this.checkBoxShader);
            this.graphics.Controls.Add(this.checkStretch);
            this.graphics.Controls.Add(this.textBoxGLSLShader);
            this.graphics.Controls.Add(this.buttonOpenShader);
            this.graphics.Controls.Add(this.labelRenderMethod);
            this.graphics.Controls.Add(this.comboRenderMethod);
            this.graphics.Controls.Add(this.checkLinearFiltering);
            this.graphics.Controls.Add(this.checkSpriteLimit);
            this.graphics.Controls.Add(this.checkMode7);
            this.graphics.Controls.Add(this.numericWindowScale);
            this.graphics.Controls.Add(this.labelScale);
            this.graphics.Controls.Add(this.checkPPU);
            this.graphics.Controls.Add(this.fullscreenMode);
            this.graphics.Controls.Add(this.windowSize);
            this.graphics.Location = new System.Drawing.Point(6, 224);
            this.graphics.Name = "graphics";
            this.graphics.Size = new System.Drawing.Size(381, 262);
            this.graphics.TabIndex = 6;
            this.graphics.TabStop = false;
            this.graphics.Text = "Graphics";
            // 
            // linkLabelGLSLShaders
            // 
            this.linkLabelGLSLShaders.AutoSize = true;
            this.linkLabelGLSLShaders.Location = new System.Drawing.Point(268, 210);
            this.linkLabelGLSLShaders.Name = "linkLabelGLSLShaders";
            this.linkLabelGLSLShaders.Size = new System.Drawing.Size(106, 15);
            this.linkLabelGLSLShaders.TabIndex = 14;
            this.linkLabelGLSLShaders.TabStop = true;
            this.linkLabelGLSLShaders.Text = "Suggested Shaders";
            this.linkLabelGLSLShaders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGLSLShaders_LinkClicked);
            // 
            // fullscreenMode
            // 
            this.fullscreenMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fullscreenMode.Controls.Add(this.radioFullscreenMode);
            this.fullscreenMode.Controls.Add(this.radioFullscreen);
            this.fullscreenMode.Controls.Add(this.radioWindowed);
            this.fullscreenMode.Location = new System.Drawing.Point(189, 22);
            this.fullscreenMode.Name = "fullscreenMode";
            this.fullscreenMode.Size = new System.Drawing.Size(185, 102);
            this.fullscreenMode.TabIndex = 1;
            this.fullscreenMode.TabStop = false;
            this.fullscreenMode.Text = "Fullscreen Mode";
            // 
            // windowSize
            // 
            this.windowSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowSize.Controls.Add(this.height);
            this.windowSize.Controls.Add(this.windowSizeX);
            this.windowSize.Controls.Add(this.width);
            this.windowSize.Controls.Add(this.customSize);
            this.windowSize.Controls.Add(this.windowAuto);
            this.windowSize.Location = new System.Drawing.Point(6, 22);
            this.windowSize.Name = "windowSize";
            this.windowSize.Size = new System.Drawing.Size(177, 102);
            this.windowSize.TabIndex = 0;
            this.windowSize.TabStop = false;
            this.windowSize.Text = "Window Size";
            // 
            // windowSizeX
            // 
            this.windowSizeX.AutoSize = true;
            this.windowSizeX.Enabled = false;
            this.windowSizeX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.windowSizeX.Location = new System.Drawing.Point(43, 76);
            this.windowSizeX.Name = "windowSizeX";
            this.windowSizeX.Size = new System.Drawing.Size(14, 15);
            this.windowSizeX.TabIndex = 3;
            this.windowSizeX.Text = "X";
            // 
            // checkBoxDimFlashing
            // 
            this.checkBoxDimFlashing.AutoSize = true;
            this.checkBoxDimFlashing.Location = new System.Drawing.Point(834, 878);
            this.checkBoxDimFlashing.Name = "checkBoxDimFlashing";
            this.checkBoxDimFlashing.Size = new System.Drawing.Size(95, 19);
            this.checkBoxDimFlashing.TabIndex = 9;
            this.checkBoxDimFlashing.Text = "Dim Flashing";
            this.checkBoxDimFlashing.UseVisualStyleBackColor = true;
            this.checkBoxDimFlashing.Visible = false;
            // 
            // groupBoxSound
            // 
            this.groupBoxSound.Controls.Add(this.comboBoxSamples);
            this.groupBoxSound.Controls.Add(this.comboBoxFrequency);
            this.groupBoxSound.Controls.Add(this.groupBoxAudioChannels);
            this.groupBoxSound.Controls.Add(this.labelAudioSamples);
            this.groupBoxSound.Controls.Add(this.labelAudioFrequency);
            this.groupBoxSound.Location = new System.Drawing.Point(6, 78);
            this.groupBoxSound.Name = "groupBoxSound";
            this.groupBoxSound.Size = new System.Drawing.Size(202, 140);
            this.groupBoxSound.TabIndex = 8;
            this.groupBoxSound.TabStop = false;
            this.groupBoxSound.Text = "Sound";
            // 
            // groupBoxAudioChannels
            // 
            this.groupBoxAudioChannels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxAudioChannels.Controls.Add(this.radioButtonStereo);
            this.groupBoxAudioChannels.Controls.Add(this.radioButtonMono);
            this.groupBoxAudioChannels.Location = new System.Drawing.Point(6, 22);
            this.groupBoxAudioChannels.Name = "groupBoxAudioChannels";
            this.groupBoxAudioChannels.Size = new System.Drawing.Size(190, 54);
            this.groupBoxAudioChannels.TabIndex = 0;
            this.groupBoxAudioChannels.TabStop = false;
            this.groupBoxAudioChannels.Text = "Audio Channels";
            // 
            // groupBoxGameplay
            // 
            this.groupBoxGameplay.Location = new System.Drawing.Point(1155, 88);
            this.groupBoxGameplay.Name = "groupBoxGameplay";
            this.groupBoxGameplay.Size = new System.Drawing.Size(202, 409);
            this.groupBoxGameplay.TabIndex = 4;
            this.groupBoxGameplay.TabStop = false;
            this.groupBoxGameplay.Text = "Gameplay";
            this.groupBoxGameplay.Visible = false;
            // 
            // labelHoverNote
            // 
            this.labelHoverNote.Location = new System.Drawing.Point(6, 9);
            this.labelHoverNote.Name = "labelHoverNote";
            this.labelHoverNote.Size = new System.Drawing.Size(381, 37);
            this.labelHoverNote.TabIndex = 5;
            this.labelHoverNote.Text = "NOTE: You can hover over an option to get a more detailed description of what eac" +
    "h setting does.";
            this.labelHoverNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMSUCopy
            // 
            this.labelMSUCopy.Location = new System.Drawing.Point(27, 783);
            this.labelMSUCopy.Name = "labelMSUCopy";
            this.labelMSUCopy.Size = new System.Drawing.Size(797, 23);
            this.labelMSUCopy.TabIndex = 6;
            this.labelMSUCopy.Text = "Copying MSU Files...";
            this.labelMSUCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMSUCopy.Visible = false;
            // 
            // progressMSU
            // 
            this.progressMSU.Location = new System.Drawing.Point(30, 809);
            this.progressMSU.Name = "progressMSU";
            this.progressMSU.Size = new System.Drawing.Size(797, 23);
            this.progressMSU.TabIndex = 7;
            this.progressMSU.Visible = false;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1451, 953);
            this.Controls.Add(this.groupBoxMSUSettings);
            this.Controls.Add(this.checkBoxDimFlashing);
            this.Controls.Add(this.linkLabelCustomSprites);
            this.Controls.Add(this.checkBoxExtend);
            this.Controls.Add(this.checkBoxEnableMSU);
            this.Controls.Add(this.aspectRatio);
            this.Controls.Add(this.checkBoxCustomLinkSprites);
            this.Controls.Add(this.buttonKeymapping);
            this.Controls.Add(this.textBoxCustomLink);
            this.Controls.Add(this.progressMSU);
            this.Controls.Add(this.buttonOpenSprites);
            this.Controls.Add(this.noVisualFixes);
            this.Controls.Add(this.labelMSUCopy);
            this.Controls.Add(this.unchangedSprites);
            this.Controls.Add(this.labelHoverNote);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.performance);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.autosaveCheck);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBoxGameplay);
            this.Controls.Add(this.groupBoxSound);
            this.Controls.Add(this.graphics);
            this.Controls.Add(this.general);
            this.Controls.Add(this.checkBoxEnableAudio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.aspectRatio.ResumeLayout(false);
            this.aspectRatio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericWindowScale)).EndInit();
            this.groupBoxMSUSettings.ResumeLayout(false);
            this.groupBoxMSUSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMSUVolume)).EndInit();
            this.graphics.ResumeLayout(false);
            this.graphics.PerformLayout();
            this.fullscreenMode.ResumeLayout(false);
            this.fullscreenMode.PerformLayout();
            this.windowSize.ResumeLayout(false);
            this.windowSize.PerformLayout();
            this.groupBoxSound.ResumeLayout(false);
            this.groupBoxSound.PerformLayout();
            this.groupBoxAudioChannels.ResumeLayout(false);
            this.groupBoxAudioChannels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox general;
        private CheckBox autosaveCheck;
        private ToolTip toolTip1;
        private GroupBox aspectRatio;
        private RadioButton steamdeck;
        private RadioButton widescreen;
        private RadioButton normal;
        private CheckBox performance;
        private CheckBox noVisualFixes;
        private CheckBox unchangedSprites;
        private CheckBox disableFrameDelay;
        private GroupBox graphics;
        private RadioButton windowAuto;
        private GroupBox windowSize;
        private TextBox width;
        private RadioButton customSize;
        private TextBox height;
        private Label windowSizeX;
        private GroupBox fullscreenMode;
        private RadioButton radioFullscreenMode;
        private RadioButton radioFullscreen;
        private RadioButton radioWindowed;
        private NumericUpDown numericWindowScale;
        private Label labelScale;
        private CheckBox checkPPU;
        private CheckBox checkMode7;
        private CheckBox checkStretch;
        private Label labelRenderMethod;
        private ComboBox comboRenderMethod;
        private CheckBox checkLinearFiltering;
        private CheckBox checkSpriteLimit;
        private CheckBox checkBoxShader;
        private CheckBox checkBoxCustomLinkSprites;
        private TextBox textBoxCustomLink;
        private Button buttonOpenSprites;
        private TextBox textBoxGLSLShader;
        private Button buttonOpenShader;
        private GroupBox groupBoxSound;
        private ComboBox comboBoxFrequency;
        private GroupBox groupBoxAudioChannels;
        private RadioButton radioButtonStereo;
        private RadioButton radioButtonMono;
        private Label labelAudioSamples;
        private Label labelAudioFrequency;
        private CheckBox checkBoxEnableAudio;
        private ComboBox comboBoxSamples;
        private NumericUpDown numericMSUVolume;
        private GroupBox groupBoxMSUSettings;
        private CheckBox checkBoxResumeMSU;
        private Label labelMSUVolume;
        private CheckBox checkBoxEnableMSU;
        private TextBox textBoxMSUDirectory;
        private Label labelMSUDirectory;
        private Button buttonMSUDirectory;
        private GroupBox groupBoxGameplay;
        private Button buttonReset;
        private Button buttonSave;
        private Button buttonCancel;
        private CheckBox checkBoxExtend;
        private Label labelHoverNote;
        private ComboBox comboBoxMSU;
        private Label labelMSUVersion;
        private LinkLabel linkLabelCustomSprites;
        private LinkLabel linkLabelGLSLShaders;
        private Label labelMSUCopy;
        private ProgressBar progressMSU;
        private Button buttonKeymapping;
        private CheckBox checkBoxDimFlashing;
    }
}