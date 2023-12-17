namespace Twitch_Live_iRacing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            LinkLabelSettings = new LinkLabel();
            ButtonSaveChannelName = new Button();
            label3 = new Label();
            InputChannelNameTwitch = new TextBox();
            ButtonSaveClientIdTwitch = new Button();
            ButtonClientIdTwitch = new Button();
            label2 = new Label();
            InputClientIdTwitch = new TextBox();
            ButtonSaveTokenTwitch = new Button();
            ButtonShowTokenTwitch = new Button();
            label1 = new Label();
            InputTokenTwitch = new TextBox();
            groupBox2 = new GroupBox();
            InputLogs = new TextBox();
            groupBox3 = new GroupBox();
            CheckBoxEnabledLogs = new CheckBox();
            CheckBoxStartApplication = new CheckBox();
            CheckBoxStartMinified = new CheckBox();
            CheckBoxStartWithWindows = new CheckBox();
            LinkLabelHelpMe = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LinkLabelSettings);
            groupBox1.Controls.Add(ButtonSaveChannelName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(InputChannelNameTwitch);
            groupBox1.Controls.Add(ButtonSaveClientIdTwitch);
            groupBox1.Controls.Add(ButtonClientIdTwitch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(InputClientIdTwitch);
            groupBox1.Controls.Add(ButtonSaveTokenTwitch);
            groupBox1.Controls.Add(ButtonShowTokenTwitch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(InputTokenTwitch);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 322);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Twitch Settings";
            // 
            // LinkLabelSettings
            // 
            LinkLabelSettings.AutoSize = true;
            LinkLabelSettings.Location = new Point(14, 290);
            LinkLabelSettings.Name = "LinkLabelSettings";
            LinkLabelSettings.Size = new Size(217, 25);
            LinkLabelSettings.TabIndex = 12;
            LinkLabelSettings.TabStop = true;
            LinkLabelSettings.Text = "Where can I get this data?";
            LinkLabelSettings.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ButtonSaveChannelName
            // 
            ButtonSaveChannelName.Location = new Point(308, 239);
            ButtonSaveChannelName.Name = "ButtonSaveChannelName";
            ButtonSaveChannelName.Size = new Size(100, 34);
            ButtonSaveChannelName.TabIndex = 11;
            ButtonSaveChannelName.Text = "Save";
            ButtonSaveChannelName.UseVisualStyleBackColor = true;
            ButtonSaveChannelName.Click += ButtonSaveChannelName_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 205);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 9;
            label3.Text = "Channel Name";
            // 
            // InputChannelNameTwitch
            // 
            InputChannelNameTwitch.Location = new Point(14, 242);
            InputChannelNameTwitch.Name = "InputChannelNameTwitch";
            InputChannelNameTwitch.Size = new Size(288, 31);
            InputChannelNameTwitch.TabIndex = 8;
            // 
            // ButtonSaveClientIdTwitch
            // 
            ButtonSaveClientIdTwitch.Location = new Point(426, 164);
            ButtonSaveClientIdTwitch.Name = "ButtonSaveClientIdTwitch";
            ButtonSaveClientIdTwitch.Size = new Size(100, 34);
            ButtonSaveClientIdTwitch.TabIndex = 7;
            ButtonSaveClientIdTwitch.Text = "Save";
            ButtonSaveClientIdTwitch.UseVisualStyleBackColor = true;
            ButtonSaveClientIdTwitch.Click += ButtonSaveClientIdTwitch_Click;
            // 
            // ButtonClientIdTwitch
            // 
            ButtonClientIdTwitch.Location = new Point(308, 164);
            ButtonClientIdTwitch.Name = "ButtonClientIdTwitch";
            ButtonClientIdTwitch.Size = new Size(112, 34);
            ButtonClientIdTwitch.TabIndex = 6;
            ButtonClientIdTwitch.Text = "Show";
            ButtonClientIdTwitch.UseVisualStyleBackColor = true;
            ButtonClientIdTwitch.Click += ButtonClientIdTwitch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 127);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 5;
            label2.Text = "Client Id Twitch";
            // 
            // InputClientIdTwitch
            // 
            InputClientIdTwitch.Location = new Point(14, 164);
            InputClientIdTwitch.Name = "InputClientIdTwitch";
            InputClientIdTwitch.Size = new Size(288, 31);
            InputClientIdTwitch.TabIndex = 4;
            // 
            // ButtonSaveTokenTwitch
            // 
            ButtonSaveTokenTwitch.Location = new Point(426, 80);
            ButtonSaveTokenTwitch.Name = "ButtonSaveTokenTwitch";
            ButtonSaveTokenTwitch.Size = new Size(100, 34);
            ButtonSaveTokenTwitch.TabIndex = 3;
            ButtonSaveTokenTwitch.Text = "Save";
            ButtonSaveTokenTwitch.UseVisualStyleBackColor = true;
            ButtonSaveTokenTwitch.Click += ButtonSaveTokenTwitch_Click;
            // 
            // ButtonShowTokenTwitch
            // 
            ButtonShowTokenTwitch.Location = new Point(308, 80);
            ButtonShowTokenTwitch.Name = "ButtonShowTokenTwitch";
            ButtonShowTokenTwitch.Size = new Size(112, 34);
            ButtonShowTokenTwitch.TabIndex = 2;
            ButtonShowTokenTwitch.Text = "Show";
            ButtonShowTokenTwitch.UseVisualStyleBackColor = true;
            ButtonShowTokenTwitch.Click += ButtonShowTokenTwitch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 1;
            label1.Text = "Token Twitch";
            // 
            // InputTokenTwitch
            // 
            InputTokenTwitch.Location = new Point(14, 80);
            InputTokenTwitch.Name = "InputTokenTwitch";
            InputTokenTwitch.Size = new Size(288, 31);
            InputTokenTwitch.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(InputLogs);
            groupBox2.Location = new Point(595, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(553, 322);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Logs";
            // 
            // InputLogs
            // 
            InputLogs.Location = new Point(17, 49);
            InputLogs.Multiline = true;
            InputLogs.Name = "InputLogs";
            InputLogs.Size = new Size(518, 253);
            InputLogs.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CheckBoxEnabledLogs);
            groupBox3.Controls.Add(CheckBoxStartApplication);
            groupBox3.Controls.Add(CheckBoxStartMinified);
            groupBox3.Controls.Add(CheckBoxStartWithWindows);
            groupBox3.Location = new Point(19, 358);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1129, 120);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "App Settings";
            // 
            // CheckBoxEnabledLogs
            // 
            CheckBoxEnabledLogs.AutoSize = true;
            CheckBoxEnabledLogs.Location = new Point(689, 54);
            CheckBoxEnabledLogs.Name = "CheckBoxEnabledLogs";
            CheckBoxEnabledLogs.Size = new Size(260, 29);
            CheckBoxEnabledLogs.TabIndex = 6;
            CheckBoxEnabledLogs.Text = "Enable logs (recommended)";
            CheckBoxEnabledLogs.UseVisualStyleBackColor = true;
            CheckBoxEnabledLogs.CheckedChanged += CheckBoxEnabledLogs_CheckedChanged;
            // 
            // CheckBoxStartApplication
            // 
            CheckBoxStartApplication.AutoSize = true;
            CheckBoxStartApplication.Location = new Point(16, 54);
            CheckBoxStartApplication.Name = "CheckBoxStartApplication";
            CheckBoxStartApplication.Size = new Size(166, 29);
            CheckBoxStartApplication.TabIndex = 5;
            CheckBoxStartApplication.Text = "Start application";
            CheckBoxStartApplication.UseVisualStyleBackColor = true;
            CheckBoxStartApplication.CheckedChanged += CheckBoxStartApplication_CheckedChanged;
            // 
            // CheckBoxStartMinified
            // 
            CheckBoxStartMinified.AutoSize = true;
            CheckBoxStartMinified.Location = new Point(233, 54);
            CheckBoxStartMinified.Name = "CheckBoxStartMinified";
            CheckBoxStartMinified.Size = new Size(163, 29);
            CheckBoxStartMinified.TabIndex = 4;
            CheckBoxStartMinified.Text = "Start minimified";
            CheckBoxStartMinified.UseVisualStyleBackColor = true;
            CheckBoxStartMinified.CheckedChanged += CheckBoxStartMinified_CheckedChanged;
            // 
            // CheckBoxStartWithWindows
            // 
            CheckBoxStartWithWindows.AutoSize = true;
            CheckBoxStartWithWindows.Location = new Point(447, 54);
            CheckBoxStartWithWindows.Name = "CheckBoxStartWithWindows";
            CheckBoxStartWithWindows.Size = new Size(191, 29);
            CheckBoxStartWithWindows.TabIndex = 3;
            CheckBoxStartWithWindows.Text = "Start with Windows";
            CheckBoxStartWithWindows.UseVisualStyleBackColor = true;
            CheckBoxStartWithWindows.CheckedChanged += CheckBoxStartWithWindows_CheckedChanged;
            // 
            // LinkLabelHelpMe
            // 
            LinkLabelHelpMe.AutoSize = true;
            LinkLabelHelpMe.Location = new Point(26, 511);
            LinkLabelHelpMe.Name = "LinkLabelHelpMe";
            LinkLabelHelpMe.Size = new Size(589, 25);
            LinkLabelHelpMe.TabIndex = 3;
            LinkLabelHelpMe.TabStop = true;
            LinkLabelHelpMe.Text = "If you like my work, you can help me in Twitch subscribing to my channel";
            LinkLabelHelpMe.LinkClicked += LinkLabelHelpMe_LinkClicked_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 557);
            Controls.Add(LinkLabelHelpMe);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1182, 613);
            Name = "Form1";
            Text = "Twitch Live iRacing";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button ButtonSaveChannelName;
        private Button button6;
        private Label label3;
        private TextBox InputChannelNameTwitch;
        private Button ButtonSaveClientIdTwitch;
        private Button ButtonClientIdTwitch;
        private Label label2;
        private TextBox InputClientIdTwitch;
        private Button ButtonSaveTokenTwitch;
        private Button ButtonShowTokenTwitch;
        private Label label1;
        private TextBox InputTokenTwitch;
        private GroupBox groupBox2;
        private TextBox InputLogs;
        private GroupBox groupBox3;
        private CheckBox CheckBoxStartWithWindows;
        private LinkLabel LinkLabelSettings;
        private CheckBox CheckBoxStartApplication;
        private CheckBox CheckBoxStartMinified;
        private LinkLabel LinkLabelHelpMe;
        private CheckBox CheckBoxEnabledLogs;
    }
}
