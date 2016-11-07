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
            pose_list_ = pose;
        }

        public void SetController(ManualController c)
        {
            manual_controller_ = c;
        }

        public void Move()
        {
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
        private const int kPoseListMaxLength = 256;
        /* constructor */
        /* destructor */
        /* member, static member */
        private ManualController manual_controller_ = null;
        private int[] pose_list_ = new int[kPoseListMaxLength];
        private int step_ = 0;
        private bool is_thread_enable_ = false;
        /* method, static method */
        private void main_proc()
        {
        }
    }
}
