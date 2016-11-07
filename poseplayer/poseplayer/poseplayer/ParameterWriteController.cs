using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.IO.Ports;

namespace poseplayer
{
    class ParameterWriteController : Controller
    {
        // ----- public -----
        /* typedef, enum */
        /* const */
        /* constructor */
        public ParameterWriteController(SerialPort p)
        {
            uart_ = p;
        }
        /* destructor */
        /* member, static member */
        public List<Motor> Motors { get { return motors_; } }
        /* method, static method */
        public void Init()
        {
            for (int i = 0; i < kMaxMotorNum; i++)
            {
                Motor motor = new Motor(i);
                motor.Init();
                motors_.Add(motor);
            }
        }

        public void Clear()
        {
            motors_.Clear();
        }

        public Motor GetMotorInstance(int list_index)
        {
            return motors_[list_index];
        }

        public void Dispose()
        {
        }

        public override void Start()
        {
            // start service
            base.Start();
            is_thread_enable_ = true;
            this.service_thread_ = new Thread(new ThreadStart(main_proc));
            this.service_thread_.Start();

        }

        public void RunOnce()
        {
            for (int i = 0; i < kMaxMotorNum; i++)
            {
                byte[] send_command = new byte[256];
                int data_length = 0;
                data_length = motors_[i].SerializeSpeed(send_command);
                if (uart_.IsOpen)
                    uart_.DiscardInBuffer();
                uart_.Write(send_command, 0, data_length);

                Thread.Sleep(5);    // 5ms

                byte[] read_data = new byte[6];
                if (uart_.IsOpen)
                    uart_.Read(read_data, 0, 6);
                int read_id = read_data[3] & 0x1f;
                motors_[i].SpeedFeedback = (read_data[5]);
            }
        }

        public override void Kill()
        {
            // kill service
            base.Kill();
            is_thread_enable_ = false;
        }






        // ----- protected -----
        /* typedef, enum */
        /* const */
        /* constructor */
        /* destructor */
        /* member, static member */
        /* method, static method */





        // ----- private -----
        /* typedef, enum */
        /* const */
        private const int kMaxMotorNum = 5;
        private const int kProcessPeriodMs = 5;
        /* constructor */
        /* destructor */
        /* member, static member */
        private SerialPort uart_ = null;
        private List<Motor> motors_ = new List<Motor>();
        private bool is_thread_enable_ = false;
        /* method, static method */
        private void main_proc()
        {
            while (is_thread_enable_)
            {

                try
                {
                    //for (int i = 0; i < kMaxMotorNum; i++)
                    //{
                    //    byte[] send_command = new byte[256];
                    //    int data_length = 0;
                    //    data_length = motors_[i].Serialize(send_command);
                    //    if (uart_.IsOpen)
                    //        uart_.DiscardInBuffer();
                    //    uart_.Write(send_command, 0, data_length);

                    //    Thread.Sleep(5);    // 5ms

                    //    byte[] read_data = new byte[6];
                    //    if (uart_.IsOpen)
                    //        uart_.Read(read_data, 0, 6);
                    //    int read_id = read_data[3] & 0x1f;
                    //    motors_[i].PositionFeedback = (read_data[4] << 7) | read_data[5];
                    //}
                }
                catch
                {
                }

                Thread.Sleep(kProcessPeriodMs);
            }
        }
    }
}
