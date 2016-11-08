using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace poseplayer
{
    class PoseController : Controller
    {
        // ----- public -----
        /* typedef, enum */
        /* const */
        /* constructor */
        public PoseController(ManualController c)
        {
            manual_controller_ = c;
        }
        /* destructor */
        /* property */
        public int Step { get { return step_; } set { step_ = value; } }
        /* member, static member */
        /* method, static method */
        public void SetTargetPose(int[] pose, int len)
        {
            target_pose_list_ = pose;
        }

        public void SetController(ManualController c)
        {
            manual_controller_ = c;
        }

        public void Move(int[] target_pose, int move_step)
        {
            target_pose_list_ = target_pose;
            step_ = move_step;

            // get current pose list
            for (int i=0; i<kPoseListMaxLength; i++)
            {
                manual_controller_.Motors[i].PositionFeedback = current_pose_[i];
            }

            // calc step_list_ values...
            // ...

            lock (lock_)
            {
                int i = 0;
                foreach (Motor m in manual_controller_.Motors)
                {
                    current_pose_[i] = m.PositionFeedback;
                    i++;
                }
            }

            is_new_command_ = true;
        }

        public void Stop()
        {
        }

        public void Free()
        {
        }

        public override void Start()
        {
            base.Start();
            is_thread_enable_ = true;
            this.service_thread_ = new Thread(new ThreadStart(main_proc));
            this.service_thread_.Start();
        }

        public override void Kill()
        {
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
        private const int kPoseListMaxLength = 6;
        private const int kProcessPeriodMs = 5;
        /* constructor */
        /* destructor */
        /* member, static member */
        private ManualController manual_controller_ = null;
        private int[] target_pose_list_ = new int[kPoseListMaxLength];
        private int step_ = 0;
        private bool is_thread_enable_ = false;
        private bool is_new_command_ = false;
        //
        private int[] current_pose_ = new int[kPoseListMaxLength];
        private int[] diff_pose_ = new int[kPoseListMaxLength];
        private int[] step_list_ = new int[kPoseListMaxLength];
        private int[] pos_order_list_ = new int[kPoseListMaxLength];
        //
        private object lock_ = new object();
        /* method, static method */
        private void main_proc()
        {
            while (is_thread_enable_)
            {
                try
                {
                    //if (is_new_command_)
                    //{
                    //    // target_pose - cur_pose = diff_pose
                    //    for (int i=0; i<kPoseListMaxLength; i++)
                    //    {
                    //        diff_pose_[i] = pose_list_[i] - current_pose_[i];
                    //    }
                    //    // diff_pose >>>> 0
                    //}

                    // create order value...
                    lock (lock_)
                    {
                        for (int i = 0; i < kPoseListMaxLength; i++)
                        {
                            if (Math.Abs(manual_controller_.Motors[i].PositionCommand - pos_order_list_[i]) < step_list_[i])
                            {
                                // target position に到達
                                manual_controller_.Motors[i].PositionCommand = target_pose_list_[i];
                            }
                            else
                            {
                                manual_controller_.Motors[i].PositionCommand += step_list_[i];
                            }
                        }
                        manual_controller_.RunOnce();
                        Thread.Sleep(kProcessPeriodMs);
                    }

                }
                catch { }
            }
        }
    }
}

