using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPool_ProducerConsumer
{
    class Consumer : PCWorker
    {
        public static Semaphore consuming;

        public Consumer(int id) : base(id, 0, null)
        {
            //thread = new Thread(this.work);
            //thread.Join(0);
            //while (this.thread.IsAlive) ;
            //Pool.getInstance().consumers.Remove(this);
        }

        public override void work()
        {
            working = false;
            //while (Producer.size < Pool.maxSize) ;
            Pool.semaphore.WaitOne();
            consuming.WaitOne();
            working = true;
            cmd = Pool.commands.FirstOrDefault();
            Pool.commands.Remove(cmd);
            //Pool.getInstance().consumers.Remove(this);
            Thread.Sleep(1500);
            working = false;
            consuming.Release();
            Pool.semaphore.Release();
            used++;
            if (cmd != null)
            {
                Producer.size--;
                if (cmd != null) cmd.execute();
                Pool.getInstance().consumers.Clear();
            }
        }
    }
}
