using System;
using Images.Properties;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

namespace Images
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
       
        public Form1()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; 
            timer1.Tick += Timer_Tick;
           
            timer2 = new System.Windows.Forms.Timer();
            timer2.Interval = 1000; 
            timer2.Tick += Timer_Tick;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }
        private void Timer_Tick1(object sender, EventArgs e)
        {
            Text = DateTime.Now.AddHours(-3).ToLongTimeString();
        }
        private void Baku_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Interval = 1000;
            timer1.Tick += Timer_Tick;
            Text = DateTime.Now.ToLongTimeString();
            BackgroundImage = Resources.baku;
            timer1.Start();
        }
        private void London_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Interval = 1000;
            timer2.Tick += Timer_Tick1;
            Text = DateTime.Now.AddHours(-3).ToLongTimeString();
            BackgroundImage = Resources.london;
            timer2.Start();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}