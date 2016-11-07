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

        private int[] pose1_list_ = new int[5];
        private int[] pose2_list_ = new int[5];
        
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
                            // manual mode
                            manual_controller_ = new ManualController(serialPort_Motor);
                            manual_controller_.Init();
                            manual_controller_.Start();
                        }
                        else if (radioButton_Pose.Checked)
                        {
                            // pose mode
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
                    manual_controller_.Motors[0].PositionCommand = Convert.ToInt32(textBox_CmdJ1.Text);
                    textBox_FbJ1.Text = manual_controller_.Motors[0].PositionFeedback.ToString();

                    manual_controller_.Motors[1].PositionCommand = Convert.ToInt32(textBox_CmdJ2.Text);
                    textBox_FbJ2.Text = manual_controller_.Motors[1].PositionFeedback.ToString();

                    manual_controller_.Motors[2].PositionCommand = Convert.ToInt32(textBox_CmdJ3.Text);
                    textBox_FbJ3.Text = manual_controller_.Motors[2].PositionFeedback.ToString();

                    manual_controller_.Motors[3].PositionCommand = Convert.ToInt32(textBox_CmdJ4.Text);
                    textBox_FbJ4.Text = manual_controller_.Motors[3].PositionFeedback.ToString();

                    manual_controller_.Motors[4].PositionCommand = Convert.ToInt32(textBox_CmdJ5.Text);
                    textBox_FbJ5.Text = manual_controller_.Motors[4].PositionFeedback.ToString();
                }
                else
                {

                }

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
                label_Pose1.Text = "Pose1=";
                for (int i = 0; i < 5; i++)
                {
                    pose1_list_[i] = manual_controller_.Motors[i].PositionFeedback;
                    label_Pose1.Text += pose1_list_[i].ToString() + ", ";
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
                label_Pose2.Text = "Pose2=";
                for (int i = 0; i < 5; i++)
                {
                    pose2_list_[i] = manual_controller_.Motors[i].PositionFeedback;
                    label_Pose2.Text += pose2_list_[i].ToString() + ", ";
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
                int order_speed = (int)numericUpDown_Speed.Value;

                foreach (Motor m in parameter_write_controller_.Motors)
                {
                    m.Speed = order_speed;
                }

                parameter_write_controller_.RunOnce();   // send command once
            }
        }
    }
}
