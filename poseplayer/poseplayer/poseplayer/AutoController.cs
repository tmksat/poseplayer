using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace poseplayer
{
    class AutoController : Controller
    {
        // ----- public -----
        /* typedef, enum */
        public struct JointLimit
        {
            public int upper;
            public int lower;
        }
        /* const */
        /* constructor */
        public AutoController(PoseController c)
        {
            pose_controller_ = c;
        }
        /* destructor */
        /* member, static member */
        /* method, static method */
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
        public bool SetJointLimit(int n, int upper, int lower)
        {
            bool ret = false;
            if (n < kJointNum)
            {
                joint_limit_[n].upper = upper;
                joint_limit_[n].lower = lower;
                ret = true;
            }
            return ret;
        }
        /* property */
        public int IntervalMs { set { interval_ms_ = value; } get { return interval_ms_; } }
        public int[] PoseList { get { return new_pose_; } }
        public int[] StepList { get { return new_step_; } }

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
        private const int kJointNum = 4;
        private const int kDefaultIntervalMs = 10000;   // 10000ms = 10s
        private const int kStepMax = 40;
        /* constructor */
        /* destructor */
        /* member, static member */
        private Random rand_ = new Random();
        private PoseController pose_controller_ = null;
        private bool is_thread_enable_ = false;
        private int interval_ms_ = kDefaultIntervalMs;
        private JointLimit[] joint_limit_ = new JointLimit[kJointNum];
        private int[] step_limit_ = { 10, 30 };
        private int[] new_pose_ = new int[kJointNum];
        private int[] new_step_ = new int[kJointNum];


        /* method, static method */
        private void main_proc()
        {
            while (is_thread_enable_)
            {
                try
                {
                    for (int i=0; i<kJointNum; i++)
                    {
                        new_pose_[i] = rand_.Next(joint_limit_[i].lower, joint_limit_[i].upper);
                        new_step_[i] = rand_.Next(step_limit_[0], step_limit_[1]);
                    }
                    pose_controller_.Move(new_pose_, new_step_);
                    
                }
                catch
                {
                }
                //Thread.Sleep(interval_ms_);
                Thread.Sleep(rand_.Next(200, interval_ms_));
            }
        }

    }
}
