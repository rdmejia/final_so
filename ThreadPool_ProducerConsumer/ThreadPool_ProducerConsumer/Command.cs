using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ThreadPool_ProducerConsumer
{
    public interface Command
    {
        void execute();
    }

    public abstract class DBCommand : Command
    {
        int id;
        public string from, to;

        public DBCommand(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public abstract void execute();
    }

    public class InsertionCommand : DBCommand
    {
        public InsertionCommand(string from, string to) : base(from, to)
        {

        }

        public override void execute()
        {
            /*insert on database*/
            //MySql.Data.MySqlClient.MySqlConnection conn2;
            //string myConnectionString = "server=localhost;uid=root;" + "pwd=sysdba;database=sistemas_op;";

            //try
            //{
            //    conn2 = new MySqlConnection();
            //    conn2.ConnectionString = myConnectionString;
            //    conn2.Open();
            //    string sql = "INSERT INTO lista_transaccion (Origen, Destino) VALUES ('" + from + "', '" + to + "')";
            //    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Pool.getInstance().conn);
            //    cmd.ExecuteNonQuery();

            //    conn2.Close();
            //}
            //catch (MySql.Data.MySqlClient.MySqlException ex)
            //{
            //    string example = ex.ToString();
            //    bool f2 = false;
            //}

            try
            {
                //MySql.Data.MySqlClient.MySqlConnection conn2;
                //string myConnectionString = "server=localhost;uid=root;" + "pwd=sysdba;database=sistemas_op;";
                //conn2 = new MySqlConnection();
                //conn2.ConnectionString = myConnectionString;
                //conn2.Open();
                string sql = "INSERT INTO lista_transaccion (Origen, Destino) VALUES ('" + from + "', '" + to + "')";
                //MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Pool.getInstance().conn);
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Pool.getInstance().conn);
                cmd.ExecuteNonQueryAsync();
                
                //conn2.Close();
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                bool f2 = false;
            }
        }
    }

    public class DeleteCommand : DBCommand
    {
        public DeleteCommand(string from, string to) : base(from,to)
        {
            string sql = "DELETE FROM lista_transaccion WHERE Origen = '" + from + "' AND Destino = '"+ to + "' LIMIT 1";
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, Pool.getInstance().conn);
            cmd.ExecuteNonQuery();
        }

        public override void execute()
        {
            /*delete on database*/
        }
    }
}
