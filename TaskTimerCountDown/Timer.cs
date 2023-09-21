using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskTimerCountDown
{
    class Timer
    {
        public int secs = 60;
        public bool CountDownTimer(int hours, int minutes) {

            
            for (; hours >= 0; hours--)
            {
                for (; minutes >= 0; minutes--)
                {
                    for (; secs >= 1; secs--)
                    {
                        Thread.Sleep(1000); // hold execution for 4 seconds
                    }
                    secs = 60;
                }
                minutes = 59;
                //continue this using timer methods 
            }
            return true;

        }
    }
}

