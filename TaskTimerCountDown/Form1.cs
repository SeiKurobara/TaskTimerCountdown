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

namespace TaskTimerCountDown
{
    
    public partial class Form1 : Form
    {
        TimerCountDown timerCountdown = new TimerCountDown();
        SpawnUI spawnUI = new SpawnUI();

        int countDown = 60;
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
            
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {   
        }
    }
}
