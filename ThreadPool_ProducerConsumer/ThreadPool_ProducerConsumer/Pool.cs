using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ThreadPool_ProducerConsumer
{
    class Pool
    {
        public MySqlConnection conn;
        string myConnectionString = "server=localhost;uid=root;" + "pwd=sysdba;database=sistemas_op;";

        public List<PCWorker> producers;
        public List<PCWorker> consumers;

        public static int maxSize;
        public static List<Command> commands;
        public static Semaphore semaphore;

        private static Pool _instance = null;

        private Pool(int producerParam, int consumerParam, int commandsSize)
        {
            commands = new List<Command>();
            semaphore = new Semaphore(producerParam + consumerParam, producerParam + consumerParam);

            this.producers = new List<PCWorker>();
            this.consumers = new List<PCWorker>();

            Producer.producing = new Semaphore(producerParam, producerParam);
            Consumer.consuming = new Semaphore(consumerParam, consumerParam);

            //for(int i = 0; i < producerParam; i++)
            //{
            //    this.producers.Add(new Producer(i));
            //}

            //for(int i = 0; i < consumerParam; i++)
            //{
            //    this.consumers.Add(new Consumer(i + producers.Count));
            //}

            maxSize = commandsSize;

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySqlException ex)
            {
                bool f = false;
            }
        }

        public static Pool getInstance()
        {
            if (_instance == null)
                _instance = new Pool(3, 5, 10);
            return _instance;
        }

        public void addRegister(string OrigenParam, string DestinoParam, int CantidadParam)
        {
            //SQL INSERT
            PCWorker producer = new Producer(producers.Count + consumers.Count, CantidadParam, new InsertionCommand(OrigenParam, DestinoParam));
            producers.Add(producer);
        }

        public void removeRegister(string OrigenParam, string DestinoParam, int CantidadParam)
        {
            //SQL DELETE
            PCWorker consumer = new Producer(producers.Count + consumers.Count, CantidadParam, new DeleteCommand(OrigenParam, DestinoParam));
            producers.Add(consumer);
        }
    }
}
