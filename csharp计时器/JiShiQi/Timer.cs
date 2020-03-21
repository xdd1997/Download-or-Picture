using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JiShiQi
{
    public partial class Timer : Form
    {
        System.DateTime TimeNow = new DateTime();
        TimeSpan TimeCount = new TimeSpan();

        public Timer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyTimer.Interval = 1000;
            this.Left = 1280;
            this.Top  = 110;
            //   btnstart_Click(object sender, EventArgs e);//开软件开始计时
            MyTimer.Start();
            TimeNow = DateTime.Now;
            TimeCount = DateTime.Now - TimeNow;
            txtTimeShow.Text = string.Format("{0:00}:{1:00}:{2:00}", TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            MyTimer.Start();
            TimeNow = DateTime.Now;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            TimeCount = DateTime.Now - TimeNow;
            txtTimeShow.Text = string.Format("{0:00}:{1:00}:{2:00}", TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds);
        }

        private void txtTimeShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MyTimer.Stop();
                txtTimeShow.Text = string.Empty;
            }
            catch   { }
            finally { }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            DaoJiShi frm2 = new DaoJiShi();
            frm2.Show(); 
            //this.Hide();
            
            
        }

        private void Timer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
