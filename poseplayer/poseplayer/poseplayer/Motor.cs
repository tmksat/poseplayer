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
        /* const */
        private const byte kKondoPositionCommand = 0x80;
        private const int kPositionCommandMaxDefault = 16383;
        private const int kPositionCommandMinDefault = 0;
        private const int kMotorFreeCommand = 0;
        /* constructor */
        /* destructor */
        /* member, static member */
        private bool is_servo_on_ = true;
        private int id_ = 0;
        private int position_command_ = 0;
        private int position_feedback_ = 0;

        /* method, static method */

    }
}
