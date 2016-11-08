namespace poseplayer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posePlayerTomokiSatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.radioButton_Param = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_UdpPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IpAdr = new System.Windows.Forms.TextBox();
            this.radioButton_UdpBridge = new System.Windows.Forms.RadioButton();
            this.button_ControlStart = new System.Windows.Forms.Button();
            this.radioButton_Pose = new System.Windows.Forms.RadioButton();
            this.radioButton_Manual = new System.Windows.Forms.RadioButton();
            this.groupBox_ComPort = new System.Windows.Forms.GroupBox();
            this.button_ComPortOpenClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ComPorts = new System.Windows.Forms.ComboBox();
            this.groupBox_Manual = new System.Windows.Forms.GroupBox();
            this.checkBox_J6 = new System.Windows.Forms.CheckBox();
            this.checkBox_J5 = new System.Windows.Forms.CheckBox();
            this.checkBox_J4 = new System.Windows.Forms.CheckBox();
            this.checkBox_J3 = new System.Windows.Forms.CheckBox();
            this.checkBox_J2 = new System.Windows.Forms.CheckBox();
            this.checkBox_J1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_FbJ6 = new System.Windows.Forms.TextBox();
            this.textBox_CmdJ6 = new System.Windows.Forms.TextBox();
            this.trackBar_J6 = new System.Windows.Forms.TrackBar();
            this.textBox_FbJ5 = new System.Windows.Forms.TextBox();
            this.textBox_CmdJ5 = new System.Windows.Forms.TextBox();
            this.trackBar_J5 = new System.Windows.Forms.TrackBar();
            this.textBox_FbJ4 = new System.Windows.Forms.TextBox();
            this.textBox_CmdJ4 = new System.Windows.Forms.TextBox();
            this.trackBar_J4 = new System.Windows.Forms.TrackBar();
            this.textBox_FbJ3 = new System.Windows.Forms.TextBox();
            this.textBox_CmdJ3 = new System.Windows.Forms.TextBox();
            this.trackBar_J3 = new System.Windows.Forms.TrackBar();
            this.textBox_FbJ2 = new System.Windows.Forms.TextBox();
            this.textBox_CmdJ2 = new System.Windows.Forms.TextBox();
            this.trackBar_J2 = new System.Windows.Forms.TrackBar();
            this.textBox_FbJ1 = new System.Windows.Forms.TextBox();
            this.textBox_CmdJ1 = new System.Windows.Forms.TextBox();
            this.trackBar_J1 = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox_Pose = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MoveStepPls = new System.Windows.Forms.TextBox();
            this.button_MovePose2 = new System.Windows.Forms.Button();
            this.button_MovePose1 = new System.Windows.Forms.Button();
            this.label_Pose2 = new System.Windows.Forms.Label();
            this.label_Pose1 = new System.Windows.Forms.Label();
            this.button_SetPose2 = new System.Windows.Forms.Button();
            this.button_SetPose1 = new System.Windows.Forms.Button();
            this.groupBox_Parameter = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Speed = new System.Windows.Forms.NumericUpDown();
            this.button_WriteAllAxis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.serialPort_Motor = new System.IO.Ports.SerialPort(this.components);
            this.timer_ViewUpdate = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown_CurrentLimit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_TempLimit = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox_Control.SuspendLayout();
            this.groupBox_ComPort.SuspendLayout();
            this.groupBox_Manual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J1)).BeginInit();
            this.groupBox_Pose.SuspendLayout();
            this.groupBox_Parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TempLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.vIewToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // vIewToolStripMenuItem
            // 
            this.vIewToolStripMenuItem.Name = "vIewToolStripMenuItem";
            this.vIewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.vIewToolStripMenuItem.Text = "View";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posePlayerTomokiSatoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // posePlayerTomokiSatoToolStripMenuItem
            // 
            this.posePlayerTomokiSatoToolStripMenuItem.Name = "posePlayerTomokiSatoToolStripMenuItem";
            this.posePlayerTomokiSatoToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.posePlayerTomokiSatoToolStripMenuItem.Text = "PosePlayer 1.0.0 by tomoki sato";
            this.posePlayerTomokiSatoToolStripMenuItem.Click += new System.EventHandler(this.posePlayerTomokiSatoToolStripMenuItem_Click);
            // 
            // groupBox_Control
            // 
            this.groupBox_Control.Controls.Add(this.radioButton_Param);
            this.groupBox_Control.Controls.Add(this.label5);
            this.groupBox_Control.Controls.Add(this.textBox_UdpPort);
            this.groupBox_Control.Controls.Add(this.label4);
            this.groupBox_Control.Controls.Add(this.textBox_IpAdr);
            this.groupBox_Control.Controls.Add(this.radioButton_UdpBridge);
            this.groupBox_Control.Controls.Add(this.button_ControlStart);
            this.groupBox_Control.Controls.Add(this.radioButton_Pose);
            this.groupBox_Control.Controls.Add(this.radioButton_Manual);
            this.groupBox_Control.Location = new System.Drawing.Point(279, 27);
            this.groupBox_Control.Name = "groupBox_Control";
            this.groupBox_Control.Size = new System.Drawing.Size(717, 46);
            this.groupBox_Control.TabIndex = 3;
            this.groupBox_Control.TabStop = false;
            this.groupBox_Control.Text = "Control Tyep";
            this.groupBox_Control.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton_Param
            // 
            this.radioButton_Param.AutoSize = true;
            this.radioButton_Param.Location = new System.Drawing.Point(135, 18);
            this.radioButton_Param.Name = "radioButton_Param";
            this.radioButton_Param.Size = new System.Drawing.Size(55, 16);
            this.radioButton_Param.TabIndex = 36;
            this.radioButton_Param.TabStop = true;
            this.radioButton_Param.Text = "Param";
            this.radioButton_Param.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "port";
            // 
            // textBox_UdpPort
            // 
            this.textBox_UdpPort.Location = new System.Drawing.Point(624, 17);
            this.textBox_UdpPort.Name = "textBox_UdpPort";
            this.textBox_UdpPort.Size = new System.Drawing.Size(79, 19);
            this.textBox_UdpPort.TabIndex = 34;
            this.textBox_UdpPort.Text = "10012";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "ip_adr";
            // 
            // textBox_IpAdr
            // 
            this.textBox_IpAdr.Location = new System.Drawing.Point(442, 17);
            this.textBox_IpAdr.Name = "textBox_IpAdr";
            this.textBox_IpAdr.Size = new System.Drawing.Size(139, 19);
            this.textBox_IpAdr.TabIndex = 4;
            this.textBox_IpAdr.Text = "192.168.1.100";
            // 
            // radioButton_UdpBridge
            // 
            this.radioButton_UdpBridge.AutoSize = true;
            this.radioButton_UdpBridge.Location = new System.Drawing.Point(202, 18);
            this.radioButton_UdpBridge.Name = "radioButton_UdpBridge";
            this.radioButton_UdpBridge.Size = new System.Drawing.Size(83, 16);
            this.radioButton_UdpBridge.TabIndex = 3;
            this.radioButton_UdpBridge.Text = "UDP Bridge";
            this.radioButton_UdpBridge.UseVisualStyleBackColor = true;
            // 
            // button_ControlStart
            // 
            this.button_ControlStart.Location = new System.Drawing.Point(306, 15);
            this.button_ControlStart.Name = "button_ControlStart";
            this.button_ControlStart.Size = new System.Drawing.Size(75, 23);
            this.button_ControlStart.TabIndex = 2;
            this.button_ControlStart.Text = "Start";
            this.button_ControlStart.UseVisualStyleBackColor = true;
            this.button_ControlStart.Click += new System.EventHandler(this.button_ControlStart_Click);
            // 
            // radioButton_Pose
            // 
            this.radioButton_Pose.AutoSize = true;
            this.radioButton_Pose.Location = new System.Drawing.Point(81, 18);
            this.radioButton_Pose.Name = "radioButton_Pose";
            this.radioButton_Pose.Size = new System.Drawing.Size(48, 16);
            this.radioButton_Pose.TabIndex = 1;
            this.radioButton_Pose.Text = "Pose";
            this.radioButton_Pose.UseVisualStyleBackColor = true;
            // 
            // radioButton_Manual
            // 
            this.radioButton_Manual.AutoSize = true;
            this.radioButton_Manual.Checked = true;
            this.radioButton_Manual.Location = new System.Drawing.Point(16, 18);
            this.radioButton_Manual.Name = "radioButton_Manual";
            this.radioButton_Manual.Size = new System.Drawing.Size(59, 16);
            this.radioButton_Manual.TabIndex = 0;
            this.radioButton_Manual.TabStop = true;
            this.radioButton_Manual.Text = "Manual";
            this.radioButton_Manual.UseVisualStyleBackColor = true;
            // 
            // groupBox_ComPort
            // 
            this.groupBox_ComPort.Controls.Add(this.button_ComPortOpenClose);
            this.groupBox_ComPort.Controls.Add(this.label1);
            this.groupBox_ComPort.Controls.Add(this.comboBox_ComPorts);
            this.groupBox_ComPort.Location = new System.Drawing.Point(12, 27);
            this.groupBox_ComPort.Name = "groupBox_ComPort";
            this.groupBox_ComPort.Size = new System.Drawing.Size(261, 46);
            this.groupBox_ComPort.TabIndex = 4;
            this.groupBox_ComPort.TabStop = false;
            this.groupBox_ComPort.Text = "ComPort";
            // 
            // button_ComPortOpenClose
            // 
            this.button_ComPortOpenClose.Location = new System.Drawing.Point(175, 15);
            this.button_ComPortOpenClose.Name = "button_ComPortOpenClose";
            this.button_ComPortOpenClose.Size = new System.Drawing.Size(75, 23);
            this.button_ComPortOpenClose.TabIndex = 2;
            this.button_ComPortOpenClose.Text = "Open";
            this.button_ComPortOpenClose.UseVisualStyleBackColor = true;
            this.button_ComPortOpenClose.Click += new System.EventHandler(this.button_ComPortOpenClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // comboBox_ComPorts
            // 
            this.comboBox_ComPorts.FormattingEnabled = true;
            this.comboBox_ComPorts.Location = new System.Drawing.Point(48, 17);
            this.comboBox_ComPorts.Name = "comboBox_ComPorts";
            this.comboBox_ComPorts.Size = new System.Drawing.Size(121, 20);
            this.comboBox_ComPorts.TabIndex = 0;
            this.comboBox_ComPorts.DropDown += new System.EventHandler(this.comboBox_ComPorts_DropDown);
            // 
            // groupBox_Manual
            // 
            this.groupBox_Manual.Controls.Add(this.checkBox_J6);
            this.groupBox_Manual.Controls.Add(this.checkBox_J5);
            this.groupBox_Manual.Controls.Add(this.checkBox_J4);
            this.groupBox_Manual.Controls.Add(this.checkBox_J3);
            this.groupBox_Manual.Controls.Add(this.checkBox_J2);
            this.groupBox_Manual.Controls.Add(this.checkBox_J1);
            this.groupBox_Manual.Controls.Add(this.button1);
            this.groupBox_Manual.Controls.Add(this.label9);
            this.groupBox_Manual.Controls.Add(this.label8);
            this.groupBox_Manual.Controls.Add(this.textBox_FbJ6);
            this.groupBox_Manual.Controls.Add(this.textBox_CmdJ6);
            this.groupBox_Manual.Controls.Add(this.trackBar_J6);
            this.groupBox_Manual.Controls.Add(this.textBox_FbJ5);
            this.groupBox_Manual.Controls.Add(this.textBox_CmdJ5);
            this.groupBox_Manual.Controls.Add(this.trackBar_J5);
            this.groupBox_Manual.Controls.Add(this.textBox_FbJ4);
            this.groupBox_Manual.Controls.Add(this.textBox_CmdJ4);
            this.groupBox_Manual.Controls.Add(this.trackBar_J4);
            this.groupBox_Manual.Controls.Add(this.textBox_FbJ3);
            this.groupBox_Manual.Controls.Add(this.textBox_CmdJ3);
            this.groupBox_Manual.Controls.Add(this.trackBar_J3);
            this.groupBox_Manual.Controls.Add(this.textBox_FbJ2);
            this.groupBox_Manual.Controls.Add(this.textBox_CmdJ2);
            this.groupBox_Manual.Controls.Add(this.trackBar_J2);
            this.groupBox_Manual.Controls.Add(this.textBox_FbJ1);
            this.groupBox_Manual.Controls.Add(this.textBox_CmdJ1);
            this.groupBox_Manual.Controls.Add(this.trackBar_J1);
            this.groupBox_Manual.Location = new System.Drawing.Point(12, 79);
            this.groupBox_Manual.Name = "groupBox_Manual";
            this.groupBox_Manual.Size = new System.Drawing.Size(408, 370);
            this.groupBox_Manual.TabIndex = 5;
            this.groupBox_Manual.TabStop = false;
            this.groupBox_Manual.Text = "Manual";
            // 
            // checkBox_J6
            // 
            this.checkBox_J6.AutoSize = true;
            this.checkBox_J6.Checked = true;
            this.checkBox_J6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_J6.Location = new System.Drawing.Point(19, 325);
            this.checkBox_J6.Name = "checkBox_J6";
            this.checkBox_J6.Size = new System.Drawing.Size(37, 16);
            this.checkBox_J6.TabIndex = 32;
            this.checkBox_J6.Text = "J5";
            this.checkBox_J6.UseVisualStyleBackColor = true;
            // 
            // checkBox_J5
            // 
            this.checkBox_J5.AutoSize = true;
            this.checkBox_J5.Checked = true;
            this.checkBox_J5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_J5.Location = new System.Drawing.Point(19, 271);
            this.checkBox_J5.Name = "checkBox_J5";
            this.checkBox_J5.Size = new System.Drawing.Size(37, 16);
            this.checkBox_J5.TabIndex = 31;
            this.checkBox_J5.Text = "J4";
            this.checkBox_J5.UseVisualStyleBackColor = true;
            // 
            // checkBox_J4
            // 
            this.checkBox_J4.AutoSize = true;
            this.checkBox_J4.Checked = true;
            this.checkBox_J4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_J4.Location = new System.Drawing.Point(19, 217);
            this.checkBox_J4.Name = "checkBox_J4";
            this.checkBox_J4.Size = new System.Drawing.Size(37, 16);
            this.checkBox_J4.TabIndex = 30;
            this.checkBox_J4.Text = "J3";
            this.checkBox_J4.UseVisualStyleBackColor = true;
            // 
            // checkBox_J3
            // 
            this.checkBox_J3.AutoSize = true;
            this.checkBox_J3.Checked = true;
            this.checkBox_J3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_J3.Location = new System.Drawing.Point(19, 167);
            this.checkBox_J3.Name = "checkBox_J3";
            this.checkBox_J3.Size = new System.Drawing.Size(37, 16);
            this.checkBox_J3.TabIndex = 29;
            this.checkBox_J3.Text = "J2";
            this.checkBox_J3.UseVisualStyleBackColor = true;
            // 
            // checkBox_J2
            // 
            this.checkBox_J2.AutoSize = true;
            this.checkBox_J2.Checked = true;
            this.checkBox_J2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_J2.Location = new System.Drawing.Point(19, 119);
            this.checkBox_J2.Name = "checkBox_J2";
            this.checkBox_J2.Size = new System.Drawing.Size(37, 16);
            this.checkBox_J2.TabIndex = 28;
            this.checkBox_J2.Text = "J1";
            this.checkBox_J2.UseVisualStyleBackColor = true;
            // 
            // checkBox_J1
            // 
            this.checkBox_J1.AutoSize = true;
            this.checkBox_J1.Checked = true;
            this.checkBox_J1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_J1.Location = new System.Drawing.Point(19, 70);
            this.checkBox_J1.Name = "checkBox_J1";
            this.checkBox_J1.Size = new System.Drawing.Size(37, 16);
            this.checkBox_J1.TabIndex = 27;
            this.checkBox_J1.Text = "J0";
            this.checkBox_J1.UseVisualStyleBackColor = true;
            this.checkBox_J1.CheckedChanged += new System.EventHandler(this.checkBox_J1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "All ServoOn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "Feedback";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "Command";
            // 
            // textBox_FbJ6
            // 
            this.textBox_FbJ6.Location = new System.Drawing.Point(315, 322);
            this.textBox_FbJ6.Name = "textBox_FbJ6";
            this.textBox_FbJ6.Size = new System.Drawing.Size(76, 19);
            this.textBox_FbJ6.TabIndex = 17;
            // 
            // textBox_CmdJ6
            // 
            this.textBox_CmdJ6.Location = new System.Drawing.Point(225, 322);
            this.textBox_CmdJ6.Name = "textBox_CmdJ6";
            this.textBox_CmdJ6.Size = new System.Drawing.Size(76, 19);
            this.textBox_CmdJ6.TabIndex = 16;
            // 
            // trackBar_J6
            // 
            this.trackBar_J6.Location = new System.Drawing.Point(65, 322);
            this.trackBar_J6.Maximum = 11500;
            this.trackBar_J6.Minimum = 3500;
            this.trackBar_J6.Name = "trackBar_J6";
            this.trackBar_J6.Size = new System.Drawing.Size(149, 45);
            this.trackBar_J6.TabIndex = 15;
            this.trackBar_J6.Value = 3500;
            // 
            // textBox_FbJ5
            // 
            this.textBox_FbJ5.Location = new System.Drawing.Point(315, 268);
            this.textBox_FbJ5.Name = "textBox_FbJ5";
            this.textBox_FbJ5.Size = new System.Drawing.Size(76, 19);
            this.textBox_FbJ5.TabIndex = 14;
            // 
            // textBox_CmdJ5
            // 
            this.textBox_CmdJ5.Location = new System.Drawing.Point(225, 268);
            this.textBox_CmdJ5.Name = "textBox_CmdJ5";
            this.textBox_CmdJ5.Size = new System.Drawing.Size(76, 19);
            this.textBox_CmdJ5.TabIndex = 13;
            // 
            // trackBar_J5
            // 
            this.trackBar_J5.Location = new System.Drawing.Point(65, 268);
            this.trackBar_J5.Maximum = 11500;
            this.trackBar_J5.Minimum = 3500;
            this.trackBar_J5.Name = "trackBar_J5";
            this.trackBar_J5.Size = new System.Drawing.Size(149, 45);
            this.trackBar_J5.TabIndex = 12;
            this.trackBar_J5.Value = 3500;
            // 
            // textBox_FbJ4
            // 
            this.textBox_FbJ4.Location = new System.Drawing.Point(315, 214);
            this.textBox_FbJ4.Name = "textBox_FbJ4";
            this.textBox_FbJ4.Size = new System.Drawing.Size(76, 19);
            this.textBox_FbJ4.TabIndex = 11;
            // 
            // textBox_CmdJ4
            // 
            this.textBox_CmdJ4.Location = new System.Drawing.Point(225, 214);
            this.textBox_CmdJ4.Name = "textBox_CmdJ4";
            this.textBox_CmdJ4.Size = new System.Drawing.Size(76, 19);
            this.textBox_CmdJ4.TabIndex = 10;
            // 
            // trackBar_J4
            // 
            this.trackBar_J4.Location = new System.Drawing.Point(65, 214);
            this.trackBar_J4.Maximum = 11500;
            this.trackBar_J4.Minimum = 3500;
            this.trackBar_J4.Name = "trackBar_J4";
            this.trackBar_J4.Size = new System.Drawing.Size(149, 45);
            this.trackBar_J4.TabIndex = 9;
            this.trackBar_J4.Value = 3500;
            // 
            // textBox_FbJ3
            // 
            this.textBox_FbJ3.Location = new System.Drawing.Point(315, 164);
            this.textBox_FbJ3.Name = "textBox_FbJ3";
            this.textBox_FbJ3.Size = new System.Drawing.Size(76, 19);
            this.textBox_FbJ3.TabIndex = 8;
            // 
            // textBox_CmdJ3
            // 
            this.textBox_CmdJ3.Location = new System.Drawing.Point(225, 164);
            this.textBox_CmdJ3.Name = "textBox_CmdJ3";
            this.textBox_CmdJ3.Size = new System.Drawing.Size(76, 19);
            this.textBox_CmdJ3.TabIndex = 7;
            // 
            // trackBar_J3
            // 
            this.trackBar_J3.Location = new System.Drawing.Point(65, 164);
            this.trackBar_J3.Maximum = 11500;
            this.trackBar_J3.Minimum = 3500;
            this.trackBar_J3.Name = "trackBar_J3";
            this.trackBar_J3.Size = new System.Drawing.Size(149, 45);
            this.trackBar_J3.TabIndex = 6;
            this.trackBar_J3.Value = 3500;
            // 
            // textBox_FbJ2
            // 
            this.textBox_FbJ2.Location = new System.Drawing.Point(315, 117);
            this.textBox_FbJ2.Name = "textBox_FbJ2";
            this.textBox_FbJ2.Size = new System.Drawing.Size(76, 19);
            this.textBox_FbJ2.TabIndex = 5;
            // 
            // textBox_CmdJ2
            // 
            this.textBox_CmdJ2.Location = new System.Drawing.Point(225, 117);
            this.textBox_CmdJ2.Name = "textBox_CmdJ2";
            this.textBox_CmdJ2.Size = new System.Drawing.Size(76, 19);
            this.textBox_CmdJ2.TabIndex = 4;
            // 
            // trackBar_J2
            // 
            this.trackBar_J2.Location = new System.Drawing.Point(65, 117);
            this.trackBar_J2.Maximum = 11500;
            this.trackBar_J2.Minimum = 3500;
            this.trackBar_J2.Name = "trackBar_J2";
            this.trackBar_J2.Size = new System.Drawing.Size(149, 45);
            this.trackBar_J2.TabIndex = 3;
            this.trackBar_J2.Value = 3500;
            // 
            // textBox_FbJ1
            // 
            this.textBox_FbJ1.Location = new System.Drawing.Point(315, 67);
            this.textBox_FbJ1.Name = "textBox_FbJ1";
            this.textBox_FbJ1.Size = new System.Drawing.Size(76, 19);
            this.textBox_FbJ1.TabIndex = 2;
            // 
            // textBox_CmdJ1
            // 
            this.textBox_CmdJ1.Location = new System.Drawing.Point(225, 67);
            this.textBox_CmdJ1.Name = "textBox_CmdJ1";
            this.textBox_CmdJ1.Size = new System.Drawing.Size(76, 19);
            this.textBox_CmdJ1.TabIndex = 1;
            // 
            // trackBar_J1
            // 
            this.trackBar_J1.Location = new System.Drawing.Point(65, 67);
            this.trackBar_J1.Maximum = 11500;
            this.trackBar_J1.Minimum = 3500;
            this.trackBar_J1.Name = "trackBar_J1";
            this.trackBar_J1.Size = new System.Drawing.Size(149, 45);
            this.trackBar_J1.TabIndex = 0;
            this.trackBar_J1.Value = 3500;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox_Pose
            // 
            this.groupBox_Pose.Controls.Add(this.label3);
            this.groupBox_Pose.Controls.Add(this.label2);
            this.groupBox_Pose.Controls.Add(this.textBox_MoveStepPls);
            this.groupBox_Pose.Controls.Add(this.button_MovePose2);
            this.groupBox_Pose.Controls.Add(this.button_MovePose1);
            this.groupBox_Pose.Controls.Add(this.label_Pose2);
            this.groupBox_Pose.Controls.Add(this.label_Pose1);
            this.groupBox_Pose.Controls.Add(this.button_SetPose2);
            this.groupBox_Pose.Controls.Add(this.button_SetPose1);
            this.groupBox_Pose.Location = new System.Drawing.Point(695, 79);
            this.groupBox_Pose.Name = "groupBox_Pose";
            this.groupBox_Pose.Size = new System.Drawing.Size(301, 367);
            this.groupBox_Pose.TabIndex = 7;
            this.groupBox_Pose.TabStop = false;
            this.groupBox_Pose.Text = "Pose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Step[pls] =";
            // 
            // textBox_MoveStepPls
            // 
            this.textBox_MoveStepPls.Location = new System.Drawing.Point(109, 190);
            this.textBox_MoveStepPls.Name = "textBox_MoveStepPls";
            this.textBox_MoveStepPls.Size = new System.Drawing.Size(75, 19);
            this.textBox_MoveStepPls.TabIndex = 6;
            this.textBox_MoveStepPls.Text = "1";
            // 
            // button_MovePose2
            // 
            this.button_MovePose2.Location = new System.Drawing.Point(109, 159);
            this.button_MovePose2.Name = "button_MovePose2";
            this.button_MovePose2.Size = new System.Drawing.Size(75, 23);
            this.button_MovePose2.TabIndex = 5;
            this.button_MovePose2.Text = "MovePose2";
            this.button_MovePose2.UseVisualStyleBackColor = true;
            // 
            // button_MovePose1
            // 
            this.button_MovePose1.Location = new System.Drawing.Point(15, 159);
            this.button_MovePose1.Name = "button_MovePose1";
            this.button_MovePose1.Size = new System.Drawing.Size(75, 23);
            this.button_MovePose1.TabIndex = 4;
            this.button_MovePose1.Text = "MovePose1";
            this.button_MovePose1.UseVisualStyleBackColor = true;
            // 
            // label_Pose2
            // 
            this.label_Pose2.AutoSize = true;
            this.label_Pose2.Location = new System.Drawing.Point(15, 117);
            this.label_Pose2.Name = "label_Pose2";
            this.label_Pose2.Size = new System.Drawing.Size(42, 12);
            this.label_Pose2.TabIndex = 3;
            this.label_Pose2.Text = "Pose2=";
            // 
            // label_Pose1
            // 
            this.label_Pose1.AutoSize = true;
            this.label_Pose1.Location = new System.Drawing.Point(15, 67);
            this.label_Pose1.Name = "label_Pose1";
            this.label_Pose1.Size = new System.Drawing.Size(42, 12);
            this.label_Pose1.TabIndex = 2;
            this.label_Pose1.Text = "Pose1=";
            // 
            // button_SetPose2
            // 
            this.button_SetPose2.Location = new System.Drawing.Point(109, 21);
            this.button_SetPose2.Name = "button_SetPose2";
            this.button_SetPose2.Size = new System.Drawing.Size(75, 23);
            this.button_SetPose2.TabIndex = 1;
            this.button_SetPose2.Text = "SetPose2";
            this.button_SetPose2.UseVisualStyleBackColor = true;
            this.button_SetPose2.Click += new System.EventHandler(this.button_SetPose2_Click);
            // 
            // button_SetPose1
            // 
            this.button_SetPose1.Location = new System.Drawing.Point(15, 21);
            this.button_SetPose1.Name = "button_SetPose1";
            this.button_SetPose1.Size = new System.Drawing.Size(75, 23);
            this.button_SetPose1.TabIndex = 0;
            this.button_SetPose1.Text = "SetPose1";
            this.button_SetPose1.UseVisualStyleBackColor = true;
            this.button_SetPose1.Click += new System.EventHandler(this.button_SetPose1_Click);
            // 
            // groupBox_Parameter
            // 
            this.groupBox_Parameter.Controls.Add(this.numericUpDown_TempLimit);
            this.groupBox_Parameter.Controls.Add(this.label10);
            this.groupBox_Parameter.Controls.Add(this.numericUpDown_CurrentLimit);
            this.groupBox_Parameter.Controls.Add(this.label7);
            this.groupBox_Parameter.Controls.Add(this.numericUpDown_Speed);
            this.groupBox_Parameter.Controls.Add(this.button_WriteAllAxis);
            this.groupBox_Parameter.Controls.Add(this.label6);
            this.groupBox_Parameter.Location = new System.Drawing.Point(426, 79);
            this.groupBox_Parameter.Name = "groupBox_Parameter";
            this.groupBox_Parameter.Size = new System.Drawing.Size(263, 367);
            this.groupBox_Parameter.TabIndex = 8;
            this.groupBox_Parameter.TabStop = false;
            this.groupBox_Parameter.Text = "Parameter";
            // 
            // numericUpDown_Speed
            // 
            this.numericUpDown_Speed.Location = new System.Drawing.Point(159, 37);
            this.numericUpDown_Speed.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown_Speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Speed.Name = "numericUpDown_Speed";
            this.numericUpDown_Speed.Size = new System.Drawing.Size(75, 19);
            this.numericUpDown_Speed.TabIndex = 37;
            this.numericUpDown_Speed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // button_WriteAllAxis
            // 
            this.button_WriteAllAxis.Location = new System.Drawing.Point(27, 172);
            this.button_WriteAllAxis.Name = "button_WriteAllAxis";
            this.button_WriteAllAxis.Size = new System.Drawing.Size(207, 23);
            this.button_WriteAllAxis.TabIndex = 35;
            this.button_WriteAllAxis.Text = "Write parameter all axis";
            this.button_WriteAllAxis.UseVisualStyleBackColor = true;
            this.button_WriteAllAxis.Click += new System.EventHandler(this.button_WriteAllAxis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "Speed (1-127)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // timer_ViewUpdate
            // 
            this.timer_ViewUpdate.Tick += new System.EventHandler(this.timer_ViewUpdate_Tick);
            // 
            // numericUpDown_CurrentLimit
            // 
            this.numericUpDown_CurrentLimit.Location = new System.Drawing.Point(159, 72);
            this.numericUpDown_CurrentLimit.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.numericUpDown_CurrentLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_CurrentLimit.Name = "numericUpDown_CurrentLimit";
            this.numericUpDown_CurrentLimit.Size = new System.Drawing.Size(75, 19);
            this.numericUpDown_CurrentLimit.TabIndex = 39;
            this.numericUpDown_CurrentLimit.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 12);
            this.label7.TabIndex = 38;
            this.label7.Text = "CurrentLimit (1-63)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // numericUpDown_TempLimit
            // 
            this.numericUpDown_TempLimit.Location = new System.Drawing.Point(159, 107);
            this.numericUpDown_TempLimit.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDown_TempLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TempLimit.Name = "numericUpDown_TempLimit";
            this.numericUpDown_TempLimit.Size = new System.Drawing.Size(75, 19);
            this.numericUpDown_TempLimit.TabIndex = 41;
            this.numericUpDown_TempLimit.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 12);
            this.label10.TabIndex = 40;
            this.label10.Text = "TempLimit (1-127)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 474);
            this.Controls.Add(this.groupBox_Parameter);
            this.Controls.Add(this.groupBox_Pose);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_Manual);
            this.Controls.Add(this.groupBox_ComPort);
            this.Controls.Add(this.groupBox_Control);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "PosePlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_Control.ResumeLayout(false);
            this.groupBox_Control.PerformLayout();
            this.groupBox_ComPort.ResumeLayout(false);
            this.groupBox_ComPort.PerformLayout();
            this.groupBox_Manual.ResumeLayout(false);
            this.groupBox_Manual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_J1)).EndInit();
            this.groupBox_Pose.ResumeLayout(false);
            this.groupBox_Pose.PerformLayout();
            this.groupBox_Parameter.ResumeLayout(false);
            this.groupBox_Parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CurrentLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TempLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posePlayerTomokiSatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Control;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton_Pose;
        private System.Windows.Forms.RadioButton radioButton_Manual;
        private System.Windows.Forms.GroupBox groupBox_ComPort;
        private System.Windows.Forms.Button button_ComPortOpenClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ComPorts;
        private System.Windows.Forms.GroupBox groupBox_Manual;
        private System.Windows.Forms.TextBox textBox_FbJ6;
        private System.Windows.Forms.TextBox textBox_CmdJ6;
        private System.Windows.Forms.TrackBar trackBar_J6;
        private System.Windows.Forms.TextBox textBox_FbJ5;
        private System.Windows.Forms.TextBox textBox_CmdJ5;
        private System.Windows.Forms.TrackBar trackBar_J5;
        private System.Windows.Forms.TextBox textBox_FbJ4;
        private System.Windows.Forms.TextBox textBox_CmdJ4;
        private System.Windows.Forms.TrackBar trackBar_J4;
        private System.Windows.Forms.TextBox textBox_FbJ3;
        private System.Windows.Forms.TextBox textBox_CmdJ3;
        private System.Windows.Forms.TrackBar trackBar_J3;
        private System.Windows.Forms.TextBox textBox_FbJ2;
        private System.Windows.Forms.TextBox textBox_CmdJ2;
        private System.Windows.Forms.TrackBar trackBar_J2;
        private System.Windows.Forms.TextBox textBox_FbJ1;
        private System.Windows.Forms.TextBox textBox_CmdJ1;
        private System.Windows.Forms.TrackBar trackBar_J1;
        private System.Windows.Forms.CheckBox checkBox_J6;
        private System.Windows.Forms.CheckBox checkBox_J5;
        private System.Windows.Forms.CheckBox checkBox_J4;
        private System.Windows.Forms.CheckBox checkBox_J3;
        private System.Windows.Forms.CheckBox checkBox_J2;
        private System.Windows.Forms.CheckBox checkBox_J1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox_Pose;
        private System.Windows.Forms.GroupBox groupBox_Parameter;
        private System.Windows.Forms.Button button_ControlStart;
        private System.IO.Ports.SerialPort serialPort_Motor;
        private System.Windows.Forms.Timer timer_ViewUpdate;
        private System.Windows.Forms.Label label_Pose2;
        private System.Windows.Forms.Label label_Pose1;
        private System.Windows.Forms.Button button_SetPose2;
        private System.Windows.Forms.Button button_SetPose1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MoveStepPls;
        private System.Windows.Forms.Button button_MovePose2;
        private System.Windows.Forms.Button button_MovePose1;
        private System.Windows.Forms.RadioButton radioButton_UdpBridge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_UdpPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IpAdr;
        private System.Windows.Forms.RadioButton radioButton_Param;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_WriteAllAxis;
        private System.Windows.Forms.NumericUpDown numericUpDown_Speed;
        private System.Windows.Forms.NumericUpDown numericUpDown_TempLimit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_CurrentLimit;
        private System.Windows.Forms.Label label7;
    }
}

