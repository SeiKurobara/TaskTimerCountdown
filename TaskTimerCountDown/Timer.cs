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
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        public Timer(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;

        }

        
    }
    public class TimerCountDown
    {
        public int ConvertToSeconds(int Hours, int Minutes)
        {
            int totalSeconds = (Hours * 60 * 60) + (Minutes * 60);
            return totalSeconds;
        }
        public string ConvertToSecondsString(int Hours, int Minutes)
        {
            int totalSeconds = (Hours * 60 * 60) + (Minutes * 60);
            return totalSeconds.ToString();
        }

        public string ConvertToHoursAndMinutes(int secs)
        {
            TimeSpan time = TimeSpan.FromSeconds(secs);
            int hours = time.Hours;
            int minutes = time.Minutes;
            int seconds = time.Seconds;
            string kangkng = $"{hours}:{minutes}:{seconds}";
            return kangkng;
        }
    }
}

