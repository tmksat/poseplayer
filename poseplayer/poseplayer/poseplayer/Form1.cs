using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace poseplayer
{
    public partial class Form1 : Form
    {
        private const int kMotorCommunicationBaudrate = 115200;
        private const int kTimerViewUpdatePeriodMs = 50;
        private const string kJointUICheckedStrings = "0";
        
        private ManualController manual_controller_ = null;
        private PoseController pose_controller_ = null;
        //
        private ParameterWriteController parameter_write_controller_ = null;
        //
        private UdpBridgeController udp_bridge_controller_ = null;
        private object command_value_lock_ = new object();

        private int[] pose1_list_ = { 8620, 7686, 10095, 7514, 0 };
        private int[] pose2_list_ = { 8658, 9770, 5603, 7514, 0 };
        private int[] pose3_list_ = { 8658, 9770, 5603, 7514, 0 };
        private int[] pose4_list_ = { 8658, 9770, 5603, 7514, 0 };
        private int[] pose5_list_ = { 8658, 9770, 5603, 7514, 0 };

        public Form1()
        {
            InitializeComponent();

            
            // initialize forms
            timer_ViewUpdate.Interval = kTimerViewUpdatePeriodMs;


            // start proc
            timer_ViewUpdate.Start();

        }

        private void posePlayerTomokiSatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pose_controller_ != null)
                pose_controller_.Kill();
            if (manual_controller_ != null)
                manual_controller_.Kill();

            serialPort_Motor.Close();
            serialPort_Motor.Dispose();
            
            Environment.Exit(0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void comboBox_ComPorts_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_ComPorts.Items.Clear();

            foreach (string port in ports)
            {
                comboBox_ComPorts.Items.Add(port);
            }
        }

        private void button_ComPortOpenClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort_Motor.IsOpen)
                {
                    // port open
                    string portname = comboBox_ComPorts.Text;
                    serialPort_Motor.BaudRate = kMotorCommunicationBaudrate;
                    serialPort_Motor.PortName = portname;
                    serialPort_Motor.DataBits = 8;
                    serialPort_Motor.StopBits = StopBits.One;
                    serialPort_Motor.Parity = Parity.Even;

                    serialPort_Motor.Open();
                    serialPort_Motor.DiscardInBuffer();
                    serialPort_Motor.DiscardOutBuffer();
                    button_ComPortOpenClose.Text = "Close";
                }
                else
                {
                    // port close
                    serialPort_Motor.Close();
                    button_ComPortOpenClose.Text = "Open";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void button_ControlStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort_Motor.IsOpen)
                {
                    //if (manual_controller_ == null)
                    if(button_ControlStart.Text == "Start")
                    {
                        // start control service...

                        if (radioButton_Manual.Checked)
                        {
                            // control unlock...
                            checkBox_ControlEnable.Checked = false;
                            checkBox_ControlEnable.Enabled = true;

                            // manual mode
                            manual_controller_ = new ManualController(serialPort_Motor);
                            manual_controller_.Init();
                            manual_controller_.Start();
                        }
                        else if (radioButton_Pose.Checked)
                        {
                            // control lock...
                            checkBox_ControlEnable.Checked = false;
                            checkBox_ControlEnable.Enabled = false;
                            
                            // start pose mode thread and manual mode thread
                            manual_controller_ = new ManualController(serialPort_Motor);
                            pose_controller_ = new PoseController(manual_controller_);
                            manual_controller_.Init();
                            manual_controller_.Start();
                            //pose_controller_.Init();
                            pose_controller_.Start();
                        }
                        else if (radioButton_Param.Checked)
                        {
                            // parameter mode
                            parameter_write_controller_ = new ParameterWriteController(serialPort_Motor);
                            parameter_write_controller_.Init();
                            parameter_write_controller_.Start();

                        }else if(radioButton_UdpBridge.Checked)
                        {
                            // UdpBridge Mode
                            udp_bridge_controller_ = new UdpBridgeController(    serialPort_Motor, 
                                                                                 textBox_IpAdr.Text,
                                                                                 Convert.ToInt32(textBox_UdpPort.Text)
                                                                            );
                            udp_bridge_controller_.Init();
                            udp_bridge_controller_.Start();
                        }
                        else { }

                        button_ControlStart.Text = "Stop";
                    }
                    else
                    {
                        // kill controller service...
                        if (manual_controller_ != null)
                        {
                            manual_controller_.Kill();
                            manual_controller_ = null;
                        }
                        else { }

                        if (pose_controller_ != null)
                        {
                            pose_controller_.Kill();
                            pose_controller_ = null;
                        }
                        else { }

                        if (udp_bridge_controller_ != null)
                        {
                            udp_bridge_controller_.Kill();
                            udp_bridge_controller_.Dispose();
                            udp_bridge_controller_ = null;
                        }
                        else { }

                        if (parameter_write_controller_ != null)
                        {
                            parameter_write_controller_.Kill();
                            parameter_write_controller_.Dispose();
                            parameter_write_controller_ = null;
                        }

                        // control unlock
                        checkBox_ControlEnable.Checked = false;
                        checkBox_ControlEnable.Enabled = true;

                        button_ControlStart.Text = "Start";
                    }


                }
                else
                {
                    // show a aleart message.
                    MessageBox.Show("Can not open your com port!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer_ViewUpdate_Tick(object sender, EventArgs e)
        {
            // view update...
            lock (command_value_lock_)
            {
                // J1
                if (checkBox_J1.Checked)
                {
                    textBox_CmdJ1.Text = kJointUICheckedStrings;
                }
                else
                {
                    textBox_CmdJ1.Text = trackBar_J1.Value.ToString();
                }

                // J2
                if (checkBox_J2.Checked)
                {
                    textBox_CmdJ2.Text = kJointUICheckedStrings;
                }
                else
                {
                    textBox_CmdJ2.Text = trackBar_J2.Value.ToString();
                }

                // J3
                if (checkBox_J3.Checked)
                {
                    textBox_CmdJ3.Text = kJointUICheckedStrings;
                }
                else
                {
                    textBox_CmdJ3.Text = trackBar_J3.Value.ToString();
                }

                // J4
                if (checkBox_J4.Checked)
                {
                    textBox_CmdJ4.Text = kJointUICheckedStrings;
                }
                else
                {
                    textBox_CmdJ4.Text = trackBar_J4.Value.ToString();
                }

                // J5
                if (checkBox_J5.Checked)
                {
                    textBox_CmdJ5.Text = kJointUICheckedStrings;
                }
                else
                {
                    textBox_CmdJ5.Text = trackBar_J5.Value.ToString();
                }



                if (manual_controller_ != null)
                {
                    if (checkBox_ControlEnable.Checked)
                    {
                        // input to manual controller from textbox value
                        manual_controller_.Motors[0].PositionCommand = Convert.ToInt32(textBox_CmdJ1.Text);
                        manual_controller_.Motors[1].PositionCommand = Convert.ToInt32(textBox_CmdJ2.Text);
                        manual_controller_.Motors[2].PositionCommand = Convert.ToInt32(textBox_CmdJ3.Text);
                        manual_controller_.Motors[3].PositionCommand = Convert.ToInt32(textBox_CmdJ4.Text);
                        manual_controller_.Motors[4].PositionCommand = Convert.ToInt32(textBox_CmdJ5.Text);
                        
                    }
                    else
                    {
                        // show command value in textbox
                        textBox_CmdJ1.Text = manual_controller_.Motors[0].PositionCommand.ToString();
                        textBox_CmdJ2.Text = manual_controller_.Motors[1].PositionCommand.ToString();
                        textBox_CmdJ3.Text = manual_controller_.Motors[2].PositionCommand.ToString();
                        textBox_CmdJ4.Text = manual_controller_.Motors[3].PositionCommand.ToString();
                        textBox_CmdJ5.Text = manual_controller_.Motors[4].PositionCommand.ToString();
                    }

                    // show position feedback
                    textBox_FbJ1.Text = manual_controller_.Motors[0].PositionFeedback.ToString();
                    textBox_FbJ2.Text = manual_controller_.Motors[1].PositionFeedback.ToString();
                    textBox_FbJ3.Text = manual_controller_.Motors[2].PositionFeedback.ToString();
                    textBox_FbJ4.Text = manual_controller_.Motors[3].PositionFeedback.ToString();
                    textBox_FbJ5.Text = manual_controller_.Motors[4].PositionFeedback.ToString();

                } else { }


                // pose list values
                label_Pose1.Text = "Pose1={" + String.Join(", ", pose1_list_) + "}";
                label_Pose2.Text = "Pose2={" + String.Join(", ", pose2_list_) + "}";
                label_Pose3.Text = "Pose3={" + String.Join(", ", pose3_list_) + "}";
                label_Pose4.Text = "Pose4={" + String.Join(", ", pose4_list_) + "}";
                label_Pose5.Text = "Pose5={" + String.Join(", ", pose5_list_) + "}";

            }

        }

        private void checkBox_J1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lock (command_value_lock_)
            {
                checkBox_J1.Checked = false;
                trackBar_J1.Value = Convert.ToInt32(textBox_FbJ1.Text);
                //
                checkBox_J2.Checked = false;
                trackBar_J2.Value = Convert.ToInt32(textBox_FbJ2.Text);
                //
                checkBox_J3.Checked = false;
                trackBar_J3.Value = Convert.ToInt32(textBox_FbJ3.Text);
                //
                checkBox_J4.Checked = false;
                trackBar_J4.Value = Convert.ToInt32(textBox_FbJ4.Text);
                //
                //checkBox_J5.Checked = false;
                //trackBar_J5.Value = Convert.ToInt32(textBox_FbJ5.Text);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pose_controller_ != null)
                pose_controller_.Kill();
            if (manual_controller_ != null)
                manual_controller_.Kill();

            serialPort_Motor.Close();
            serialPort_Motor.Dispose();

            Environment.Exit(0);
        }

        private void button_SetPose1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    pose1_list_[i] = manual_controller_.Motors[i].PositionFeedback;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_SetPose2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    pose2_list_[i] = manual_controller_.Motors[i].PositionFeedback;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_WriteAllAxis_Click(object sender, EventArgs e)
        {
            if (parameter_write_controller_ != null)
            {
                int order_stretch = (int)numericUpDown_Stretch.Value;
                int order_speed = (int)numericUpDown_Speed.Value;
                int order_curlimit = (int)numericUpDown_CurrentLimit.Value;
                int order_templimit = (int)numericUpDown_TempLimit.Value;

                foreach (Motor m in parameter_write_controller_.Motors)
                {
                    m.Stretch = order_stretch;
                    m.Speed = order_speed;
                    m.CurrentLimit = order_curlimit;
                    m.TempLimit = order_templimit;
                }

                parameter_write_controller_.RunOnce();   // send command once
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_MovePose1_Click(object sender, EventArgs e)
        {
            if (pose_controller_ != null && manual_controller_ != null)
            {
                pose_controller_.Move(pose1_list_, get_ui_step_list());
            }
            else { }
        }

        private void button_MovePose2_Click(object sender, EventArgs e)
        {
            if (pose_controller_ != null && manual_controller_ != null)
            {
                pose_controller_.Move(pose2_list_, get_ui_step_list());
            }
            else { }
        }

        private int[] get_ui_step_list()
        {
            int[] ret = {   (int)numericUpDown_MoveStep_J0.Value,
                            (int)numericUpDown_MoveStep_J1.Value,
                            (int)numericUpDown_MoveStep_J2.Value,
                            (int)numericUpDown_MoveStep_J3.Value,
                            (int)numericUpDown_MoveStep_J4.Value};

            return ret;
        }

        private void button_SetPose3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    pose3_list_[i] = manual_controller_.Motors[i].PositionFeedback;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_SetPose4_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    pose4_list_[i] = manual_controller_.Motors[i].PositionFeedback;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_SetPose5_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    pose5_list_[i] = manual_controller_.Motors[i].PositionFeedback;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_MovePose3_Click(object sender, EventArgs e)
        {
            if (pose_controller_ != null && manual_controller_ != null)
            {
                pose_controller_.Move(pose3_list_, get_ui_step_list());
            }
            else { }
        }

        private void button_MovePose4_Click(object sender, EventArgs e)
        {
            if (pose_controller_ != null && manual_controller_ != null)
            {
                pose_controller_.Move(pose4_list_, get_ui_step_list());
            }
            else { }
        }

        private void button_MovePose5_Click(object sender, EventArgs e)
        {
            if (pose_controller_ != null && manual_controller_ != null)
            {
                pose_controller_.Move(pose5_list_, get_ui_step_list());
            }
            else { }
        }
    }
}
