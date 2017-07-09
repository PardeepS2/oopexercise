using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopexercise
{
    class MyTime
    {
        
        private int hour = 0;       
        private int minute = 0;     
        private int second = 0;     

        

        public MyTime()
        {

        }
        public MyTime(int hour, int minute, int second)
        {
            SetTime(hour, minute, second);
        }
        public void SetTime(int hour, int minute, int second)
        {
            setHour(hour);
            if (minute < 0 || minute > 59)
            {
                this.minute = 0;
            }
            else
            {
                this.minute = minute;
            }
            if (second < 0 || second > 59)
            {
                this.second = 0;
            }
            else
            {
                this.second = second;
            }
        }
        public int getHour()
        {
            return hour;
        }
        public int getMinute()
        {
            return minute;
        }
        public int getSecond()
        {
            return second;
        }
        public void setHour(int hour)
        {
            if (hour >= 0 && hour <= 23)
            {
                this.hour = hour;
            }
        }
        public void setMinute(int minute)
        {
            if (minute>= 0 && minute <= 59)
            {
                this.minute = minute;
            }
        }
        public void setSecond(int second)
        {
            if (second >= 0 && second <= 59)
            {
                this.second = second;
            }
        }
        public string toString()
        {
            return string.Format("%02d:%02d:%02d", hour, minute, second);
        }

        public MyTime nextSecond()
        {
            ++second;
            minute = minute + second / 60;
            second = second % 60;
            hour = hour + minute / 60;
            minute = minute % 60;
            hour = hour % 24;

            return this;
        }
        public MyTime nextMinute()
        {
            ++minute;
            hour = hour + minute / 60;
            minute = minute % 60;
            second = second + hour / 24;
            hour = hour % 24;
            second = second % 60;

            return this;
        }
        public MyTime nextHour()
        {
            ++hour;
            second = second + hour / 24;
            hour = hour % 24;
            minute = minute + second / 60;
            second = second % 60;
            minute = minute % 60;

            return this;
        }
        public MyTime previousSecond()
        {
            --second;
            if (second == -1)
            {
                second = 59;
                --minute;

            }
            return this;
        }
        public MyTime previousMinute()
        {
            --minute;
            if (minute == -1)
            {
                minute = 59;
                --hour;
            }
            return this;
        }
        public MyTime previousHour()
        {
            --hour;
            if (hour == -1)
            {
                hour = 23;
                --second;
            }
            return this;
        }
    }
}
