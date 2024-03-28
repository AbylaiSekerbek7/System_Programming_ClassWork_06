using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SampleSemaphore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // список потоков в ожидании
        public List<Thread> lstThWait = new List<Thread>();

        // список активных потоков
        public List<Thread> lstThActive = new List<Thread>();

        // событие для синхронного старта потоков
        public ManualResetEvent evnStart = new ManualResetEvent(false);

        // семафор для потоков
        public Semaphore semaphore = null;

        // объект мьютекс для сихронизации вывода в поле txtLog
        public Mutex mtxLog = new Mutex();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int cntAll = 0;
            int cntActive = 0;
            if (!(int.TryParse(txtCntAll.Text, out cntAll) && int.TryParse(txtCntActive.Text, out cntActive)))
            {
                txtLog.Text += "Error: incorrect input for all thread cnt or active thread!\r\n";
                txtCntAll.Focus();
                txtCntAll.SelectAll();

                txtCntActive.Focus();
                txtCntActive.SelectAll();
                return;
            }
            
            semaphore = new Semaphore(cntActive, cntActive);
            evnStart.Reset();
            for (int i = 0; i < cntAll; ++i)
            {
                Thread th = new Thread(ThreadProc);
                th.IsBackground = true;
                th.Name = $"Thread №{i + 1}";
                th.Start(this);
                lstThWait.Add(th);
            }
            ListUpdate();
        } // private void btnCreate_Click();

        public void ListUpdate()
        {
            if (lbWait.InvokeRequired)
            {
                lbWait.Invoke(new Action(() =>
                {
                    lbWait.Items.Clear();
                    foreach (Thread t in lstThWait)
                    {
                        string str = t.ManagedThreadId.ToString() + ": " + t.Name;
                        lbWait.Items.Add(str);
                    }
                    lbActive.Items.Clear();
                    foreach (Thread t in lstThActive)
                    {
                        string str = t.ManagedThreadId.ToString() + ": " + t.Name;
                        lbActive.Items.Add(str);
                    }
                }));
            }
            else
            {
                lbWait.Items.Clear();
                foreach (Thread t in lstThWait)
                {
                    string str = t.ManagedThreadId.ToString() + ": " + t.Name;
                    lbWait.Items.Add(str);
                }
                lbActive.Items.Clear();
                foreach (Thread t in lstThActive)
                {
                    string str = t.ManagedThreadId.ToString() + ": " + t.Name;
                    lbActive.Items.Add(str);
                }
            }
        } // public void ListUpdate();

        private void btnStart_Click(object sender, EventArgs e)
        {
            evnStart.Set();
        } // private void btnStart_Click();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ThreadProc(object Param)
        {
            Form1 form1 = Param as Form1;

            form1.evnStart.WaitOne();
            form1.semaphore.WaitOne();

            Thread t = Thread.CurrentThread;
            form1.mtxLog.WaitOne();
            {
                form1.lstThWait.Remove(t);
                form1.lstThActive.Add(t);
            }
            form1.mtxLog.ReleaseMutex();
            form1.ListUpdate();

            form1.Invoke(new Action(() => {
                form1.txtLog.Text += $"Thread ID {t.ManagedThreadId} started\r\n";
            }));

            // Иммитация работы потока

            Random rnd = new Random(t.ManagedThreadId);
            int sleep = rnd.Next(1000, 4000);
            Thread.Sleep(sleep);

            form1.mtxLog.WaitOne();
            {
                form1.lstThActive.Remove(t);
            }
            form1.mtxLog.ReleaseMutex();
            form1.ListUpdate();

            form1.Invoke(new Action(() =>
            {
                form1.txtLog.Text += $"Thread ID {t.ManagedThreadId} exit\r\n";
            }));

            form1.semaphore.Release();
        } // конец ф-ции потока
    }
}