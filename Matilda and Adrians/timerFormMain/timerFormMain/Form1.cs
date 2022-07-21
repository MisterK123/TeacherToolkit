using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerFormMain
{
    public partial class Form1 : Form
    {
        int countdown = 0;
        int original = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTimer();
        }

        private void add30secs_Click(object sender, EventArgs e)
        {
            addTime(add30secs);
        }

        private void add1min_Click(object sender, EventArgs e)
        {
            addTime(add1min);
        }

        private void add5mins_Click(object sender, EventArgs e)
        {
            addTime(add5mins);
        }

        private void stopStart_Click(object sender, EventArgs e)
        {
            startStopFunc();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetTimer();
        }

        private void add3mins_Click(object sender, EventArgs e)
        {
            addTime(add3mins);
        }

        private void startStopFunc()
        {
            if (countdown > 0)
            {
                if (timer1.Enabled)
                {
                    timer1.Enabled = false;
                    stopStart.Text = "▶ Start";
                }
                else
                {
                    timer1.Enabled = true;
                    stopStart.Text = "■ Stop";
                    original = countdown;
                }
            }
        }

        private void updateTimer()
        {
            countdown -= 1;

            timerBox.Text = (countdown / 100 / 60).ToString("00") + ":" + (countdown / 100 % 60).ToString("00");
            if (countdown == 0f)
            {
                timer1.Enabled = false;
                stopStart.Text = "▶ Start";
            }
            //Console.WriteLine((countdown / 60).ToString("00") + ":" + (countdown % 60).ToString("00"));
            Refresh();
        }


        private void addTime(Button sender)
        {
            int amount;
            if (sender == add30secs) amount = 30;
            else amount = Convert.ToInt32(sender.Text.Replace(" secs", "").Replace(" mins", "").Replace(" min", "").Replace("+", ""))*60;
            countdown += amount*100;
            timerBox.Text = (countdown / 6000).ToString("00") + ":" + (countdown /100 % 60).ToString("00");
            original += amount*100;
        }

        private void resetTimer()
        {
            timer1.Enabled = false;
            countdown = 0;
            timerBox.Text = "00:00";
            stopStart.Text = "▶ Start";
            Refresh();
        }

        private void timerBox_KeyDown(object sender, KeyEventArgs e)
        {
            enterValue(e);
        }

        private void enterValue(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try { countdown = Convert.ToInt32(timerBox.Text) * 6000; startStopFunc(); }
                catch { }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            drawCircle(e);
        }

        private void drawCircle(PaintEventArgs e)
        {
            if (countdown == 0) e.Graphics.DrawArc(new Pen(Color.Black, 5), new Rectangle(25, 25, 150, 150), 0, 360);
            Console.WriteLine(360 * ((float)countdown / (float)original));
            e.Graphics.DrawArc(new Pen(Color.Black, 5), new Rectangle(25, 25, 150, 150), -90, 360 * ((float)countdown / (float)original));// Console.WriteLine(360 * (countdown / original)); }
        }
    }
}
