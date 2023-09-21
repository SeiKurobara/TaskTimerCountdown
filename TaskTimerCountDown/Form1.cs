using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTimerCountDown
{
    public partial class Form1 : Form
    {
        SpawnUI spawnUI = new SpawnUI();
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           bool stopper = false;

            l_Timer1.Text = tb_For.Text;
            cb_Timer1.Text = "Time Remaining: " + tb_Hours.Text + ":" + tb_Minutes.Text + ":" + timer.secs.ToString();
            while (stopper == false)
            {

                stopper = timer.CountDownTimer(int.Parse(tb_Hours.Text), int.Parse(tb_Minutes.Text));
            }



        }
    }
}
