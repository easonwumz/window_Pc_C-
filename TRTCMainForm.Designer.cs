
namespace TRTCCSharpDemo
{
    partial class kuaiji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kuaiji));
            this.panel1 = new System.Windows.Forms.Panel();
            this.beautyLabel = new System.Windows.Forms.Label();
            this.testDeviceLabel = new System.Windows.Forms.Label();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.settingLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.localUserLabel = new System.Windows.Forms.Label();
            this.remoteUserLabel3 = new System.Windows.Forms.Label();
            this.localVideoPanel = new System.Windows.Forms.Panel();
            this.localInfoLabel = new System.Windows.Forms.Label();
            this.localVoiceProgressBar = new System.Windows.Forms.ProgressBar();
            this.remoteVideoPanel3 = new System.Windows.Forms.Panel();
            this.remoteInfoLabel3 = new System.Windows.Forms.Label();
            this.remoteVoiceProgressBar3 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.voiceCheckBox = new System.Windows.Forms.CheckBox();
            this.customCaptureCheckBox = new System.Windows.Forms.CheckBox();
            this.connectRoomCheckBox = new System.Windows.Forms.CheckBox();
            this.systemAudioCheckBox = new System.Windows.Forms.CheckBox();
            this.shareUrlLabel = new System.Windows.Forms.Label();
            this.mixTransCodingCheckBox = new System.Windows.Forms.CheckBox();
            this.mirrorCheckBox = new System.Windows.Forms.CheckBox();
            this.muteAudioCheckBox = new System.Windows.Forms.CheckBox();
            this.muteVideoCheckBox = new System.Windows.Forms.CheckBox();
            this.screenShareCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlinked = new System.Windows.Forms.Button();
            this.lvlinkedUser = new System.Windows.Forms.ListView();
            this.avatarList = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.noLinkedUser = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.localVideoPanel.SuspendLayout();
            this.remoteVideoPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.beautyLabel);
            this.panel1.Controls.Add(this.testDeviceLabel);
            this.panel1.Controls.Add(this.deviceLabel);
            this.panel1.Controls.Add(this.logLabel);
            this.panel1.Controls.Add(this.settingLabel);
            this.panel1.Controls.Add(this.exitLabel);
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.roomLabel);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseUp);
            // 
            // beautyLabel
            // 
            this.beautyLabel.AutoSize = true;
            this.beautyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.beautyLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beautyLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.beautyLabel.ForeColor = System.Drawing.Color.White;
            this.beautyLabel.Location = new System.Drawing.Point(746, 16);
            this.beautyLabel.Name = "beautyLabel";
            this.beautyLabel.Size = new System.Drawing.Size(69, 19);
            this.beautyLabel.TabIndex = 9;
            this.beautyLabel.Text = "美颜设置";
            this.beautyLabel.Click += new System.EventHandler(this.OnBeautyLabelClick);
            // 
            // testDeviceLabel
            // 
            this.testDeviceLabel.AutoSize = true;
            this.testDeviceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.testDeviceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testDeviceLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.testDeviceLabel.ForeColor = System.Drawing.Color.White;
            this.testDeviceLabel.Location = new System.Drawing.Point(828, 16);
            this.testDeviceLabel.Name = "testDeviceLabel";
            this.testDeviceLabel.Size = new System.Drawing.Size(69, 19);
            this.testDeviceLabel.TabIndex = 8;
            this.testDeviceLabel.Text = "设备测试";
            this.testDeviceLabel.Click += new System.EventHandler(this.OnTestDeviceLabelClick);
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.deviceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deviceLabel.ForeColor = System.Drawing.Color.White;
            this.deviceLabel.Location = new System.Drawing.Point(911, 16);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(69, 19);
            this.deviceLabel.TabIndex = 7;
            this.deviceLabel.Text = "设备设置";
            this.deviceLabel.Click += new System.EventHandler(this.OnDeviceLabelClick);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.logLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logLabel.ForeColor = System.Drawing.Color.White;
            this.logLabel.Location = new System.Drawing.Point(676, 16);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(54, 19);
            this.logLabel.TabIndex = 6;
            this.logLabel.Text = "仪表盘";
            this.logLabel.Click += new System.EventHandler(this.OnLogLabelClick);
            // 
            // settingLabel
            // 
            this.settingLabel.AutoSize = true;
            this.settingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.settingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.settingLabel.ForeColor = System.Drawing.Color.White;
            this.settingLabel.Location = new System.Drawing.Point(993, 16);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(69, 19);
            this.settingLabel.TabIndex = 5;
            this.settingLabel.Text = "常规设置";
            this.settingLabel.Click += new System.EventHandler(this.OnSettingLabelClick);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(1074, 16);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(39, 19);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "退出";
            this.exitLabel.Click += new System.EventHandler(this.OnExitLabelClick);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.userLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.userLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.userLabel.Location = new System.Drawing.Point(900, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 20);
            this.userLabel.TabIndex = 2;
            // 
            // roomLabel
            // 
            this.roomLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.roomLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.roomLabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roomLabel.ForeColor = System.Drawing.Color.White;
            this.roomLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomLabel.Location = new System.Drawing.Point(20, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(600, 50);
            this.roomLabel.TabIndex = 1;
            this.roomLabel.Text = "控制台";
            this.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseDown);
            this.roomLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseMove);
            this.roomLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseUp);
            // 
            // localUserLabel
            // 
            this.localUserLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.localUserLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.localUserLabel.Location = new System.Drawing.Point(26, 65);
            this.localUserLabel.Name = "localUserLabel";
            this.localUserLabel.Size = new System.Drawing.Size(319, 22);
            this.localUserLabel.TabIndex = 4;
            this.localUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remoteUserLabel3
            // 
            this.remoteUserLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.remoteUserLabel3.Location = new System.Drawing.Point(20, 585);
            this.remoteUserLabel3.Name = "remoteUserLabel3";
            this.remoteUserLabel3.Size = new System.Drawing.Size(180, 20);
            this.remoteUserLabel3.TabIndex = 7;
            this.remoteUserLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // localVideoPanel
            // 
            this.localVideoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.localVideoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localVideoPanel.Controls.Add(this.localInfoLabel);
            this.localVideoPanel.Location = new System.Drawing.Point(25, 87);
            this.localVideoPanel.Name = "localVideoPanel";
            this.localVideoPanel.Size = new System.Drawing.Size(790, 395);
            this.localVideoPanel.TabIndex = 8;
            // 
            // localInfoLabel
            // 
            this.localInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.localInfoLabel.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.localInfoLabel.ForeColor = System.Drawing.Color.White;
            this.localInfoLabel.Location = new System.Drawing.Point(-1, 0);
            this.localInfoLabel.Name = "localInfoLabel";
            this.localInfoLabel.Size = new System.Drawing.Size(790, 395);
            this.localInfoLabel.TabIndex = 1;
            this.localInfoLabel.Text = "等待推流";
            this.localInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.localInfoLabel.Visible = false;
            // 
            // localVoiceProgressBar
            // 
            this.localVoiceProgressBar.ForeColor = System.Drawing.Color.Green;
            this.localVoiceProgressBar.Location = new System.Drawing.Point(25, 480);
            this.localVoiceProgressBar.Name = "localVoiceProgressBar";
            this.localVoiceProgressBar.Size = new System.Drawing.Size(790, 5);
            this.localVoiceProgressBar.TabIndex = 15;
            this.localVoiceProgressBar.Visible = false;
            // 
            // remoteVideoPanel3
            // 
            this.remoteVideoPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.remoteVideoPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remoteVideoPanel3.Controls.Add(this.remoteInfoLabel3);
            this.remoteVideoPanel3.Location = new System.Drawing.Point(20, 604);
            this.remoteVideoPanel3.Name = "remoteVideoPanel3";
            this.remoteVideoPanel3.Size = new System.Drawing.Size(180, 100);
            this.remoteVideoPanel3.TabIndex = 9;
            // 
            // remoteInfoLabel3
            // 
            this.remoteInfoLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.remoteInfoLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.remoteInfoLabel3.ForeColor = System.Drawing.Color.White;
            this.remoteInfoLabel3.Location = new System.Drawing.Point(-1, 0);
            this.remoteInfoLabel3.Name = "remoteInfoLabel3";
            this.remoteInfoLabel3.Size = new System.Drawing.Size(180, 100);
            this.remoteInfoLabel3.TabIndex = 2;
            this.remoteInfoLabel3.Text = "+添加源";
            this.remoteInfoLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remoteVoiceProgressBar3
            // 
            this.remoteVoiceProgressBar3.ForeColor = System.Drawing.Color.Green;
            this.remoteVoiceProgressBar3.Location = new System.Drawing.Point(20, 704);
            this.remoteVoiceProgressBar3.Name = "remoteVoiceProgressBar3";
            this.remoteVoiceProgressBar3.Size = new System.Drawing.Size(180, 10);
            this.remoteVoiceProgressBar3.TabIndex = 18;
            this.remoteVoiceProgressBar3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.voiceCheckBox);
            this.panel2.Controls.Add(this.customCaptureCheckBox);
            this.panel2.Controls.Add(this.connectRoomCheckBox);
            this.panel2.Controls.Add(this.systemAudioCheckBox);
            this.panel2.Controls.Add(this.shareUrlLabel);
            this.panel2.Controls.Add(this.mixTransCodingCheckBox);
            this.panel2.Controls.Add(this.mirrorCheckBox);
            this.panel2.Controls.Add(this.muteAudioCheckBox);
            this.panel2.Controls.Add(this.muteVideoCheckBox);
            this.panel2.Controls.Add(this.screenShareCheckBox);
            this.panel2.Location = new System.Drawing.Point(0, 731);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 45);
            this.panel2.TabIndex = 14;
            // 
            // voiceCheckBox
            // 
            this.voiceCheckBox.AutoSize = true;
            this.voiceCheckBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.voiceCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.voiceCheckBox.Location = new System.Drawing.Point(321, 11);
            this.voiceCheckBox.Name = "voiceCheckBox";
            this.voiceCheckBox.Size = new System.Drawing.Size(118, 24);
            this.voiceCheckBox.TabIndex = 16;
            this.voiceCheckBox.Text = "开启音量提示";
            this.voiceCheckBox.UseVisualStyleBackColor = true;
            this.voiceCheckBox.Click += new System.EventHandler(this.OnVoiceCheckBoxClick);
            // 
            // customCaptureCheckBox
            // 
            this.customCaptureCheckBox.AutoSize = true;
            this.customCaptureCheckBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.customCaptureCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.customCaptureCheckBox.Location = new System.Drawing.Point(656, 11);
            this.customCaptureCheckBox.Name = "customCaptureCheckBox";
            this.customCaptureCheckBox.Size = new System.Drawing.Size(103, 24);
            this.customCaptureCheckBox.TabIndex = 15;
            this.customCaptureCheckBox.Text = "自定义采集";
            this.customCaptureCheckBox.UseVisualStyleBackColor = true;
            this.customCaptureCheckBox.Click += new System.EventHandler(this.OnCustomCaptureCheckBoxClick);
            // 
            // connectRoomCheckBox
            // 
            this.connectRoomCheckBox.AutoSize = true;
            this.connectRoomCheckBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.connectRoomCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.connectRoomCheckBox.Location = new System.Drawing.Point(552, 11);
            this.connectRoomCheckBox.Name = "connectRoomCheckBox";
            this.connectRoomCheckBox.Size = new System.Drawing.Size(88, 24);
            this.connectRoomCheckBox.TabIndex = 14;
            this.connectRoomCheckBox.Text = "跨房通话";
            this.connectRoomCheckBox.UseVisualStyleBackColor = true;
            this.connectRoomCheckBox.Click += new System.EventHandler(this.OnConnectRoomCheckBoxClick);
            // 
            // systemAudioCheckBox
            // 
            this.systemAudioCheckBox.AutoSize = true;
            this.systemAudioCheckBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.systemAudioCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.systemAudioCheckBox.Location = new System.Drawing.Point(775, 11);
            this.systemAudioCheckBox.Name = "systemAudioCheckBox";
            this.systemAudioCheckBox.Size = new System.Drawing.Size(88, 24);
            this.systemAudioCheckBox.TabIndex = 13;
            this.systemAudioCheckBox.Text = "系统混音";
            this.systemAudioCheckBox.UseVisualStyleBackColor = true;
            this.systemAudioCheckBox.Click += new System.EventHandler(this.OnSystemAudioCheckBoxClick);
            // 
            // shareUrlLabel
            // 
            this.shareUrlLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.shareUrlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shareUrlLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shareUrlLabel.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.shareUrlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.shareUrlLabel.Location = new System.Drawing.Point(1008, 10);
            this.shareUrlLabel.Name = "shareUrlLabel";
            this.shareUrlLabel.Size = new System.Drawing.Size(105, 25);
            this.shareUrlLabel.TabIndex = 8;
            this.shareUrlLabel.Text = "分享播放地址";
            this.shareUrlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shareUrlLabel.Click += new System.EventHandler(this.OnShareUrlLabelClick);
            // 
            // mixTransCodingCheckBox
            // 
            this.mixTransCodingCheckBox.AutoSize = true;
            this.mixTransCodingCheckBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.mixTransCodingCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.mixTransCodingCheckBox.Location = new System.Drawing.Point(880, 11);
            this.mixTransCodingCheckBox.Name = "mixTransCodingCheckBox";
            this.mixTransCodingCheckBox.Size = new System.Drawing.Size(118, 24);
            this.mixTransCodingCheckBox.TabIndex = 12;
            this.mixTransCodingCheckBox.Text = "云端画面混合";
            this.mixTransCodingCheckBox.UseVisualStyleBackColor = true;
            this.mixTransCodingCheckBox.Click += new System.EventHandler(this.OnMixTransCodingCheckBoxClick);
            // 
            // mirrorCheckBox
            // 
            this.mirrorCheckBox.AutoSize = true;
            this.mirrorCheckBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.mirrorCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.mirrorCheckBox.Location = new System.Drawing.Point(219, 11);
            this.mirrorCheckBox.Name = "mirrorCheckBox";
            this.mirrorCheckBox.Size = new System.Drawing.Size(88, 24);
            this.mirrorCheckBox.TabIndex = 11;
            this.mirrorCheckBox.Text = "开启镜像";
            this.mirrorCheckBox.UseVisualStyleBackColor = true;
            this.mirrorCheckBox.Click += new System.EventHandler(this.OnMirrorCheckBoxClick);
            // 
            // muteAudioCheckBox
            // 
            this.muteAudioCheckBox.AutoSize = true;
            this.muteAudioCheckBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.muteAudioCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.muteAudioCheckBox.Location = new System.Drawing.Point(119, 11);
            this.muteAudioCheckBox.Name = "muteAudioCheckBox";
            this.muteAudioCheckBox.Size = new System.Drawing.Size(88, 24);
            this.muteAudioCheckBox.TabIndex = 10;
            this.muteAudioCheckBox.Text = "屏蔽音频";
            this.muteAudioCheckBox.UseVisualStyleBackColor = true;
            this.muteAudioCheckBox.Click += new System.EventHandler(this.OnMuteAudioCheckBoxClick);
            // 
            // muteVideoCheckBox
            // 
            this.muteVideoCheckBox.AutoSize = true;
            this.muteVideoCheckBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.muteVideoCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.muteVideoCheckBox.Location = new System.Drawing.Point(16, 11);
            this.muteVideoCheckBox.Name = "muteVideoCheckBox";
            this.muteVideoCheckBox.Size = new System.Drawing.Size(88, 24);
            this.muteVideoCheckBox.TabIndex = 9;
            this.muteVideoCheckBox.Text = "屏蔽视频";
            this.muteVideoCheckBox.UseVisualStyleBackColor = true;
            // 
            // screenShareCheckBox
            // 
            this.screenShareCheckBox.AutoSize = true;
            this.screenShareCheckBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.screenShareCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.screenShareCheckBox.Location = new System.Drawing.Point(451, 11);
            this.screenShareCheckBox.Name = "screenShareCheckBox";
            this.screenShareCheckBox.Size = new System.Drawing.Size(88, 24);
            this.screenShareCheckBox.TabIndex = 8;
            this.screenShareCheckBox.Text = "屏幕共享";
            this.screenShareCheckBox.UseVisualStyleBackColor = true;
            this.screenShareCheckBox.Click += new System.EventHandler(this.OnScreenShareCheckBoxClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 52);
            this.button1.TabIndex = 21;
            this.button1.Text = "主播";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(106, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 52);
            this.button2.TabIndex = 21;
            this.button2.Text = "嘉宾";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(206, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 52);
            this.button3.TabIndex = 21;
            this.button3.Text = "主播";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(308, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 52);
            this.button4.TabIndex = 21;
            this.button4.Text = "主播";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(410, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 52);
            this.button5.TabIndex = 21;
            this.button5.Text = "主播";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(455, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 52);
            this.button6.TabIndex = 21;
            this.button6.Text = "主播";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(529, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 52);
            this.button7.TabIndex = 21;
            this.button7.Text = "主播";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(569, 14);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 52);
            this.button8.TabIndex = 21;
            this.button8.Text = "主播";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.btnPush.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPush.ForeColor = System.Drawing.Color.White;
            this.btnPush.Location = new System.Drawing.Point(643, 14);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(139, 52);
            this.btnPush.TabIndex = 21;
            this.btnPush.Text = "开始推流";
            this.btnPush.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnPush);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(24, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 79);
            this.panel3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(848, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 140);
            this.label1.TabIndex = 2;
            this.label1.Text = "等待连麦";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnlinked
            // 
            this.btnlinked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.btnlinked.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnlinked.ForeColor = System.Drawing.Color.White;
            this.btnlinked.Location = new System.Drawing.Point(12, 25);
            this.btnlinked.Name = "btnlinked";
            this.btnlinked.Size = new System.Drawing.Size(227, 34);
            this.btnlinked.TabIndex = 21;
            this.btnlinked.Text = "暂无连麦";
            this.btnlinked.UseVisualStyleBackColor = false;
            // 
            // lvlinkedUser
            // 
            this.lvlinkedUser.LargeImageList = this.avatarList;
            this.lvlinkedUser.Location = new System.Drawing.Point(0, 51);
            this.lvlinkedUser.Margin = new System.Windows.Forms.Padding(10);
            this.lvlinkedUser.Name = "lvlinkedUser";
            this.lvlinkedUser.Scrollable = false;
            this.lvlinkedUser.ShowGroups = false;
            this.lvlinkedUser.Size = new System.Drawing.Size(250, 370);
            this.lvlinkedUser.SmallImageList = this.avatarList;
            this.lvlinkedUser.TabIndex = 23;
            this.lvlinkedUser.UseCompatibleStateImageBehavior = false;
            this.lvlinkedUser.View = System.Windows.Forms.View.Details;
            this.lvlinkedUser.Visible = false;
            this.lvlinkedUser.SelectedIndexChanged += new System.EventHandler(this.lvlinkedUser_SelectedIndexChanged);
            // 
            // avatarList
            // 
            this.avatarList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("avatarList.ImageStream")));
            this.avatarList.TransparentColor = System.Drawing.Color.Transparent;
            this.avatarList.Images.SetKeyName(0, "avatar1.png");
            this.avatarList.Images.SetKeyName(1, "avatar2.png");
            this.avatarList.Images.SetKeyName(2, "avatar3.png");
            this.avatarList.Images.SetKeyName(3, "avatar4.png");
            this.avatarList.Images.SetKeyName(4, "avatar5.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(928, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "预约连麦用户";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1059, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "刷新";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.noLinkedUser);
            this.panel6.Controls.Add(this.lvlinkedUser);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(848, 294);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 421);
            this.panel6.TabIndex = 26;
            // 
            // noLinkedUser
            // 
            this.noLinkedUser.AutoSize = true;
            this.noLinkedUser.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noLinkedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.noLinkedUser.Location = new System.Drawing.Point(78, 219);
            this.noLinkedUser.Name = "noLinkedUser";
            this.noLinkedUser.Size = new System.Drawing.Size(88, 25);
            this.noLinkedUser.TabIndex = 24;
            this.noLinkedUser.Text = "暂无用户";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.panel7.Controls.Add(this.btnlinked);
            this.panel7.Location = new System.Drawing.Point(848, 219);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 87);
            this.panel7.TabIndex = 27;
            // 
            // kuaiji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 776);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.remoteVoiceProgressBar3);
            this.Controls.Add(this.localVoiceProgressBar);
            this.Controls.Add(this.remoteUserLabel3);
            this.Controls.Add(this.localUserLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.localVideoPanel);
            this.Controls.Add(this.remoteVideoPanel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "kuaiji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRTCCSharpDemo";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.localVideoPanel.ResumeLayout(false);
            this.remoteVideoPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label userLabel;
        public System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label localUserLabel;
        private System.Windows.Forms.Label remoteUserLabel3;
        private System.Windows.Forms.Panel localVideoPanel;
        private System.Windows.Forms.Panel remoteVideoPanel3;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox screenShareCheckBox;
        private System.Windows.Forms.Label remoteInfoLabel3;
        private System.Windows.Forms.Label localInfoLabel;
        private System.Windows.Forms.CheckBox muteVideoCheckBox;
        private System.Windows.Forms.CheckBox muteAudioCheckBox;
        private System.Windows.Forms.CheckBox mirrorCheckBox;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.CheckBox mixTransCodingCheckBox;
        private System.Windows.Forms.Label shareUrlLabel;
        private System.Windows.Forms.Label testDeviceLabel;
        private System.Windows.Forms.Label beautyLabel;
        private System.Windows.Forms.CheckBox systemAudioCheckBox;
        private System.Windows.Forms.CheckBox connectRoomCheckBox;
        private System.Windows.Forms.CheckBox customCaptureCheckBox;
        private System.Windows.Forms.ProgressBar localVoiceProgressBar;
        private System.Windows.Forms.ProgressBar remoteVoiceProgressBar3;
        private System.Windows.Forms.CheckBox voiceCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlinked;
        private System.Windows.Forms.ListView lvlinkedUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ImageList avatarList;
        private System.Windows.Forms.Label noLinkedUser;
        private System.Windows.Forms.Panel panel7;
    }
}