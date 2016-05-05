using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadPool_ProducerConsumer
{
    public partial class Form1 : Form
    {
        Pool pool;

        public Form1()
        {
            InitializeComponent();
        }

        #region Validaciones
        public bool isNumber(string text)
        {
            foreach(char c in text)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        public bool ValidarTextbox(string pOrigen, string pDestino, string pCantidad)
        {
            if (pOrigen.Length > 0 && pDestino.Length > 0 && pCantidad.Length > 0)
                return isNumber(pCantidad);

            return false;
        }
        #endregion

        public void produce()
        {
            //while(true)
            //{
            //    int x = ran.Next(100);
            //    semaphore.WaitOne();
            //    stack.Push(x);
            //    Thread.Sleep(100);
            //    semaphore.Release();
            //}
        }

        public void consume()
        {
            //while(true)
            //{
            //    semaphore.WaitOne();
            //    int x = stack.Pop();
            //    Thread.Sleep(100);
            //    semaphore.Release();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pool = Pool.getInstance();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showPCWorker(dgvProducers, pool.producers, false);
            showPCWorker(dgvConsumers, pool.consumers, true);
        }

        private void showPCWorker(DataGridView dgv, List<PCWorker> list, bool isConsumer)
        {
            dgv.Rows.Clear();
            if(isConsumer)
            {
                foreach(Consumer v in list)
                {
                    dgv.Rows.Add(v.getId(), v.getWorking(), v.getStatus());
                }
            }
            else
            {
                foreach(Producer v in list)
                {
                    dgv.Rows.Add(v.getId(), v.getWorking(), v.getStatus());
                }

            }
        }

        private void dgvConsumers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Origen = tbOrigen.Text, Destino = tbDestino.Text, sCantidad = tbCantidad.Text;

            if (ValidarTextbox(Origen, Destino, sCantidad))
            {
                int Cantidad = int.Parse(sCantidad);
                pool.addRegister(Origen, Destino, Cantidad);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Origen = tbOrigen.Text, Destino = tbDestino.Text, sCantidad = tbCantidad.Text;

            if (ValidarTextbox(Origen, Destino, sCantidad))
            {
                int Cantidad = int.Parse(sCantidad);
                pool.removeRegister(Origen, Destino, Cantidad);
            }
        }
    }
}