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
        static Semaphore consuming = new Semaphore(1, 1);

        public Consumer(int id) : base(id)
        {
        }

        public override void work()
        {
            while (true)
            {
                working = false;
                while (Pool.commands.Count < Pool.maxSize && Pool.getInstance().producers.Count != 0) ;
                Command cmd = null;
                while (Pool.commands.Count != 0)
                {
                    Pool.semaphore.WaitOne();
                    consuming.WaitOne();
                    working = true;
                    cmd = Pool.commands.FirstOrDefault();
                    Pool.commands.Remove(cmd);
                    Thread.Sleep(100);
                    consuming.Release();
                    Pool.semaphore.Release();
                    if (cmd != null)
                        cmd.delete();
                }
            }
        }
    }
}
