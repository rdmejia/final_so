using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPool_ProducerConsumer
{
    class Pool
    {
        public List<PCWorker> producers;
        public List<PCWorker> consumers;

        public static int maxSize;
        public static List<Command> commands;
        public static Semaphore semaphore;

        private static Pool _instance = null;

        private Pool(int producerParam, int consumerParam, int commandsSize)
        {
            commands = new List<Command>();
            semaphore = new Semaphore(1, 1);

            this.producers = new List<PCWorker>();
            this.consumers = new List<PCWorker>();

            for(int i = 0; i < producerParam; i++)
            {
                this.producers.Add(new Producer(i));
            }

            for(int i = 0; i < consumerParam; i++)
            {
                this.consumers.Add(new Consumer(i + producers.Count));
            }

            maxSize = commandsSize;
        }

        public static Pool getInstance()
        {
            if (_instance == null)
                _instance = new Pool(3, 5, 10);
            return _instance;
        }

        public void addRegister(string OrigenParam, string DestinoParam, int CantidadParam)
        {
            Producer producer = new Producer(producers.Count + consumers.Count);
            producers.Add(producer);
        }

        public void removeRegister(string OrigenParam, string DestinoParam, int CantidadParam)
        {
            PCWorker producer = producers.LastOrDefault();
            if (producer != null)
            {
                producer.remove();
                producers.Remove(producer);
            }
        }
    }
}
