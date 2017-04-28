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
        public enum EAutoMode
        {
             RepeatMode,
             RandomMode,
             StopMode,
        }
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
        //
        public int[] PresetPoseList1 { set { preset_pose1_ = value; } get { return preset_pose1_; } }
        public int[] PresetPoseList2 { set { preset_pose2_ = value; } get { return preset_pose2_; } }
        public int[] PresetStepList { set { preset_step_ = value; } get { return preset_step_; } }
        public int TargetRepeatCount { set { repeat_count_target_ = value; } get { return repeat_count_target_; } }
        public int NowCount { get { return repeat_count_; } }
        //
        public EAutoMode Mode { set { mode_ = value; } get { return mode_; } }

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
        private const int kJointNum = 5;
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
        private EAutoMode mode_ = EAutoMode.RepeatMode;   // default
        private int[] preset_pose1_ = new int[kJointNum];
        private int[] preset_pose2_ = new int[kJointNum];
        private int[] preset_step_ = new int[kJointNum];
        private int repeat_count_target_ = 0;
        private int repeat_count_ = 0;

        /* method, static method */
        private void main_proc()
        {
            while (is_thread_enable_)
            {
                try
                {
                    if (mode_ == EAutoMode.RandomMode)
                    {
                        // 
                        for (int i = 0; i < kJointNum; i++)
                        {
                            new_pose_[i] = rand_.Next(joint_limit_[i].lower, joint_limit_[i].upper);
                            new_step_[i] = rand_.Next(step_limit_[0], step_limit_[1]);
                        }
                        pose_controller_.Move(new_pose_, new_step_);
                        Thread.Sleep(rand_.Next(200, interval_ms_));
                    }
                    else if (mode_ == EAutoMode.RepeatMode)
                    {
                        if ( (repeat_count_ % 2) == 0)
                        {
                            new_pose_ = preset_pose1_;
                        }
                        else
                        {
                            new_pose_ = preset_pose2_;
                        }
                        new_step_ = preset_step_;
                        pose_controller_.Move(new_pose_, new_step_);
                        Thread.Sleep(interval_ms_);
                        repeat_count_++;

                        if (repeat_count_ >= repeat_count_target_)
                        {
                            mode_ = EAutoMode.StopMode;
                        }

                    }
                    else if (mode_ == EAutoMode.StopMode)
                    {
                        // stop mode is sleep...
                        Thread.Sleep(1000);
                    }
                    
                }
                catch
                {
                }
            }
        }

    }
}
