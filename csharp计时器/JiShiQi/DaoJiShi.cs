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
    public partial class DaoJiShi : Form
    {
        public int minute ;//计时为1分钟，改变此处即可改变时间
        private int Seconds;
        public  string ShowFont;


        public DaoJiShi()
        {
            InitializeComponent();
        }

        public void DaoJiShi_Load(object sender, EventArgs e)
        {
            minute= Convert.ToInt32(txtboxminute.Text);
            this.Left = 1280;
            this.Top = 110;
            //Seconds = minute * 60;
            //ShowTime();
            timer1.Interval = 1000;
            //string str="{0}分钟倒计时 ",minute     //想改变最上面的标签，未成功
            //label1.Text = ("{0}分钟倒计时 ",minute);

        }

        private void DaoJiShi_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "开始")
                button1.Text = "结束";
            else
            {
                if (button1.Text == "结束")
                    button1.Text = "开始";
            }
    
            if (this.timer1.Enabled == false)
            { timer1.Start();
            minute = Convert.ToInt32(txtboxminute.Text);
            Seconds = minute * 60;
            ShowTime();

            }
            else
            {
                timer1.Stop();
                
            }

        }
        private void ShowTime()
        {
            textBox1.Text = string.Format("{0:d2}:{1:d2}",
                    Seconds / 60,
                    Seconds % 60);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Seconds--;
            if (Seconds < 0)
            {
                // 停止倒计时
                timer1.Stop();
                System.Media.SystemSounds.Hand.Play();//发出声音
                System.Media.SystemSounds.Hand.Play();

                //public string ShowFont;
                ShowFont = txtboxShow.Text;
                //Console.WriteLine("前面是{0}",ShowFont);
               // transform(ShowFont);
                //Warn frm4 = new Warn();
                //frm4.Show();
                //显示对话框
                MessageBox.Show(ShowFont, "倒计时结束", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

               
                return;
            }
            
            ShowTime();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            Seconds = minute * 60;
            textBox1.Text = string.Format("{0:d2}:{1:d2}",
                    Seconds / 60,
                    Seconds % 60);
            button1.Text = "开始";
            txtboxShow.Text = string.Empty;
        }

        private void btn_JiShiQi_Click(object sender, EventArgs e)
        {
            Timer frm3 = new Timer();
            frm3.Show();
           // this.Hide();
        }

        public void txtboxShow_TextChanged(object sender, EventArgs e)
        {
            string ShowFont2;
            ShowFont2 = txtboxShow.Text;
            Console.WriteLine("方法获得 {0}", ShowFont2);
            return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //public string transform(string str)
        //{
        //    string ShowFont2;
        //    ShowFont2 = str;
        //    Console.WriteLine("方法获得 {0}", ShowFont2);
        //    return ShowFont2;
        //}

       
    }
}
