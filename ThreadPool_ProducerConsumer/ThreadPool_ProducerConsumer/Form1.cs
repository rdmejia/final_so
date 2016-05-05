﻿using System;
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
            showPCWorker(dgvProducers, pool.producers);
            showPCWorker(dgvConsumers, pool.consumers);
        }

        private void showPCWorker(DataGridView dgv, List<PCWorker> list)
        {
            dgv.Rows.Clear();
            foreach(var v in list)
            {
                dgv.Rows.Add(v.getId(), v.getWorking());
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
            pool.addRegister();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pool.removeRegister();
        }
    }
}