using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPool_ProducerConsumer
{
    class Producer : PCWorker
    {
        public static Semaphore producing;
        public static int size = 0;

        public Producer(int id, int total, Command cmd) : base(id, total, cmd)
        {
        }

        public override void work()
        {
            while (used < total)
            {
                working = false;
                while (Pool.commands.Count != 0 && Pool.getInstance().consumers.Count != 0)  ;
                while (used < total && size < Pool.maxSize)
                {
                    Pool.semaphore.WaitOne();
                    producing.WaitOne();
                    working = true;
                    Pool.commands.Add(cmd);
                    Thread.Sleep(100);
                    producing.Release();
                    Pool.semaphore.Release();
                    //cmd.execute();
                    used++;
                    size++;
                }
                int aux = Pool.commands.Count;
                for (int i = 0; i < aux; i++)
                {
                    PCWorker consumer = new Consumer(Pool.getInstance().consumers.Count + Pool.getInstance().producers.Count);
                    Pool.getInstance().consumers.Add(consumer);
                }
            }
            Pool.getInstance().producers.Remove(this);
        }
    }
}
