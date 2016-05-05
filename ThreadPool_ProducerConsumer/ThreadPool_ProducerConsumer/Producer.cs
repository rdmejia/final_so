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
        static Semaphore producing = new Semaphore(1, 1);

        public Producer(int id) : base(id)
        {
        }

        public override void work()
        {
            while(true)
            {
                working = false;
                while (Pool.commands.Count != 0) ;
                Command cmd = new Command("Producer " + id, "Some Consumer");
                while(Pool.commands.Count < Pool.maxSize)
                {
                    Pool.semaphore.WaitOne();
                    producing.WaitOne();
                    working = true;
                    Pool.commands.Add(cmd);
                    Thread.Sleep(100);
                    producing.Release();
                    Pool.semaphore.Release();
                    cmd.insert();
                }
            }
        }
    }
}
