using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPool_ProducerConsumer
{
    interface Worker
    {
        void work();
    }

    public abstract class PCWorker : Worker
    {
        protected int id;
        protected bool working;
        protected Thread thread;

        public PCWorker(int id)
        {
            this.id = id;
            this.thread = new Thread(this.work);
            this.thread.Name = "Thread " + this.id;
            this.thread.Start();
        }

        public int getId()
        {
            return id;
        }

        public bool getWorking()
        {
            return working;
        }

        public abstract void work();

        public void remove()
        {
            this.thread.Abort();
        }
    }
}
