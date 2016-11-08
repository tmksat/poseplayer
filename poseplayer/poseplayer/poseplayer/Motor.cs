using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poseplayer
{
    public class Motor
    {
        // ----- public -----
        /* typedef, enum */
        /* const */
        /* constructor */
        public Motor(int id)
        {
            id_ = id;
        }
        /* destructor */
        /* member, static member */
        /* method, static method */

        public int Serialize(byte[] d)
        {
            int ret = 0;

            // serialize process...
            
            // cmd, id
            if (id_ >= 0 && id_ <= 31)
            {
                d[(int)eCommandIndex.CMD] = (byte)(kKondoPositionCommand | id_);
            }
            else { }

            // pos_h, pos_l
            if (is_servo_on_)
            {
                if (position_command_ >= kPositionCommandMinDefault && position_command_ <= kPositionCommandMaxDefault)
                {
                    d[(int)eCommandIndex.POS_H] = (byte)((position_command_ >> 7) & 0x007f);
                    d[(int)eCommandIndex.POS_L] = (byte)(position_command_ & 0x007f);
                }
                else { }
            }
            else
            {
                d[(int)eCommandIndex.POS_H] = 0x0;  // free
                d[(int)eCommandIndex.POS_L] = 0x0;  // free
            }

            ret = (int)eCommandIndex.COMMAND_PACKET_LENGTH;

            return ret;
        }

        // set speed parameter
        public int SerializeSpeed(byte[] d)
        {
            int ret = 0;
            // serialize process...

            // cmd, id
            if (id_ >= 0 && id_ <= 31)
            {
                d[(int)eCommandIndex.CMD] = (byte)(kKondoParameterWrite | id_);
            }
            else { }

            d[(int)eParameterWriteIndex.SC] = kKondoSCSpeed;
            d[(int)eParameterWriteIndex.PARAMETER_VALUE] = (byte)(clump(kParameterSpeedMinDefault, kParameterSpeedMaxDefault, speed_));

            ret = (int)eParameterWriteIndex.COMMAND_PACKET_LENGTH;

            return ret;
        }

        // set speed parameter
        public int SerializeCurrentLimit(byte[] d)
        {
            int ret = 0;
            // serialize process...

            // cmd, id
            if (id_ >= 0 && id_ <= 31)
            {
                d[(int)eCommandIndex.CMD] = (byte)(kKondoParameterWrite | id_);
            }
            else { }

            d[(int)eParameterWriteIndex.SC] = kKondoSCCurLim;
            d[(int)eParameterWriteIndex.PARAMETER_VALUE] = (byte)(clump(kParameterCurrentMinDefault, kParameterCurrentMaxDefault, currentlimit_));

            ret = (int)eParameterWriteIndex.COMMAND_PACKET_LENGTH;

            return ret;
        }

        // set speed parameter
        public int SerializeTempLimit(byte[] d)
        {
            int ret = 0;
            // serialize process...

            // cmd, id
            if (id_ >= 0 && id_ <= 31)
            {
                d[(int)eCommandIndex.CMD] = (byte)(kKondoParameterWrite | id_);
            }
            else { }

            d[(int)eParameterWriteIndex.SC] = kKondoSCTmpLim;
            d[(int)eParameterWriteIndex.PARAMETER_VALUE] = (byte)(clump(kParameterTempMinDefault, kParameterTempMaxDefault, templimit_));

            ret = (int)eParameterWriteIndex.COMMAND_PACKET_LENGTH;

            return ret;
        }


        public void Free()
        {
            position_command_ = kMotorFreeCommand;
        }

        public void Same()
        {
            position_command_ = position_feedback_;
        }

        public void Init()
        {

        }

        public void Clear()
        {

        }

        /* property */
        public bool IsServoOn { get { return is_servo_on_; } set { is_servo_on_ = value; } }
        public int PositionCommand { get { return position_command_; } set { position_command_ = value; } }
        public int PositionFeedback { get { return position_feedback_; } set { position_feedback_ = value; } }
        public int Id { get { return id_; } }
        public int Speed { get { return speed_; } set { speed_ = value; } }
        public int SpeedFeedback { get { return speed_feedback_; } set { speed_feedback_ = value; } }
        public int CurrentLimit { get { return currentlimit_; } set { currentlimit_ = value; } }
        public int CurrentLimitFeedback { get { return currentlimit_feedback_; } set { currentlimit_feedback_ = value; } }
        public int TempLimit { get { return templimit_; } set { templimit_ = value; } }
        public int TempLimitFeedback { get { return templimit_feedback_; } set { templimit_feedback_ = value; } }


        // ----- protected -----
        /* typedef, enum */
        /* const */
        /* constructor */
        /* destructor */
        /* member, static member */
        /* method, static method */




        // ----- private -----
        /* typedef, enum */
        private enum eCommandIndex
        {
            CMD = 0x0,
            POS_H,
            POS_L,
            COMMAND_PACKET_LENGTH,
        }
        private enum eParameterWriteIndex
        {
            CMD = 0x0,
            SC,
            PARAMETER_VALUE,
            COMMAND_PACKET_LENGTH
        }
        /* const */
        private const byte kKondoPositionCommand = 0x80;
        private const byte kKondoParameterWrite = 0xC0;
        private const byte kKondoSCSpeed = 0x02;
        private const byte kKondoSCCurLim = 0x03;
        private const byte kKondoSCTmpLim = 0x04;

        //
        private const int kPositionCommandMaxDefault = 11500;
        private const int kPositionCommandMinDefault = 3500;
        //
        private const int kParameterSpeedMaxDefault = 127;
        private const int kParameterSpeedMinDefault = 1;
        //
        private const int kParameterCurrentMaxDefault = 63;
        private const int kParameterCurrentMinDefault = 1;
        //
        private const int kParameterTempMaxDefault = 127;
        private const int kParameterTempMinDefault = 1;
        //
        private const int kMotorFreeCommand = 0;
        /* constructor */
        /* destructor */
        /* member, static member */
        private bool is_servo_on_ = true;
        private int id_ = 0;
        private int position_command_ = 0;
        private int position_feedback_ = 0;
        private int speed_ = 1;
        private int speed_feedback_ = 0;
        private int currentlimit_ = 1;
        private int currentlimit_feedback_ = 0;
        private int templimit_ = 1;
        private int templimit_feedback_ = 0;


        /* method, static method */
        private int clump(int min, int max, int input_value)
        {
            int ret = 0;

            if (input_value > max) ret = max;
            else if (input_value < min) ret = min;
            else ret = input_value;

            return ret;
        }

    }
}
