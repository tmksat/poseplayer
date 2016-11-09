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
        public int[] Step { get { return step_list_; } }
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

        public void Move(int[] target_pose, int[] move_step)
        {
            target_pose_list_ = target_pose;

            // get current pose list
            for (int i=0; i<kPoseListMaxLength; i++)
            {
                current_pose_[i] = manual_controller_.Motors[i].PositionFeedback;
            }

            // set initial order values
            pos_order_list_ = current_pose_;

            // calc step_list_ values...
            for (int i=0; i<5; i++)
            {
                if (target_pose_list_[i] - current_pose_[i] > 0) step_list_[i] = move_step[i];
                else step_list_[i] = -(move_step[i]);
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
        private const int kPoseListMaxLength = 5;
        private const int kProcessPeriodMs = 10;
        /* constructor */
        /* destructor */
        /* member, static member */
        private ManualController manual_controller_ = null;
        private int[] target_pose_list_ = new int[kPoseListMaxLength];
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
                    // calce order value...
                    for (int i = 0; i < kPoseListMaxLength; i++)
                    {
                        if (Math.Abs(target_pose_list_[i] - manual_controller_.Motors[i].PositionCommand) <= Math.Abs(step_list_[i]))
                        {
                            // target position に到達
                            manual_controller_.Motors[i].PositionCommand = target_pose_list_[i];
                        }
                        else
                        {
                            pos_order_list_[i] += step_list_[i];
                            manual_controller_.Motors[i].PositionCommand = pos_order_list_[i];
                        }
                    }
                    //manual_controller_.RunOnce();
                    Thread.Sleep(kProcessPeriodMs);
                }
                catch { }
            }
        }
    }
}

