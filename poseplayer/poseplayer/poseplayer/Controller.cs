using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace poseplayer
{
    public class Controller
    {
        public Controller()
        {
        }

        public virtual void Start()
        {
        }

        public virtual void Kill()
        {
        }

        protected Thread service_thread_ = null;
    }
}
