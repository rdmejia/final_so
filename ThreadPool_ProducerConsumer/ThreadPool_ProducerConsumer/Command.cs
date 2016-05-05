using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ThreadPool_ProducerConsumer
{
    class Command
    {
        private int id;
        private string from, to;

        public Command(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public void insert()
        {
            /*Insert on database*/
        }

        public void delete()
        {
            /*delete on database*/
        }
    }
}
