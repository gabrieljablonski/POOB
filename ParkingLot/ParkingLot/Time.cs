using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLot
{
    class Time
    {
        private int hour;
        private int min;
        private int sec;

        public Time()
        {
            hour = 0;
            min = 0;
            sec = 0;
        }

        // Assuming the Time's are set within a day (00:00:00 ~ 23:59:59)
        public void set_time()
        {
            string[] time = Console.In.ReadLine().Split(':');
            hour = int.Parse(time[0]);
            min = int.Parse(time[1]);
            sec = int.Parse(time[2]);

            if(sec >= 60)
            {
                min += sec / 60;
                sec = sec % 60;
            }

            if(min >= 60)
            {
                hour += min / 60;
                min = min % 60;
            }

            if(hour >= 24)
            {
                hour = hour % 24;
            }
        }

        public int get_hour()
        {
            return hour;
        }

        public int get_min()
        {
            return min;
        }

        public int get_sec()
        {
            return sec;
        }

        public void set_hour(int h)
        {
            hour = h;
        }

        public void set_min(int m)
        {
            min = m;
        }

        public void set_sec(int s)
        {
            sec = s;
        }

        public void print_time()
        {
            Console.Out.Write(hour.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2"));
        }

        // Assuming both Time's are between 00:00:00 and 23:59:59
        public Time add_time(Time other_time)
        {
            Time added_time = new Time();
            int new_h = 0, new_m = 0, new_s = 0;

            new_s = sec + other_time.get_sec();

            if(new_s >= 60)
            {
                new_m = 1;
                new_s = new_s % 60;
            }

            new_m += min + other_time.get_min();

            if(new_m >= 60)
            {
                new_h = 1;
                new_m = new_m % 60;
            }

            new_h += hour + other_time.get_hour();

            added_time.set_hour(new_h);
            added_time.set_min(new_m);
            added_time.set_sec(new_s);

            return added_time;
        }

        // Assuming both Time's are between 00:00:00 and 23:59:59, and that the caller is the smaller time
        public Time subtract_time(Time other_time)
        {
            Time subtracted_time = new Time();
            int new_h = 0, new_m = 0, new_s = 0;

            new_s = other_time.get_sec() - sec;

            if(new_s < 0)
            {
                new_s += 60;
                new_m -= 1;
            }

            new_m += (other_time.get_min() - min);

            if (new_m < 0)
            {
                new_m += 60;
                new_h -= 1;
            }

            new_h += (other_time.get_hour() - hour);

            subtracted_time.set_hour(new_h);
            subtracted_time.set_min(new_m);
            subtracted_time.set_sec(new_s);

            return subtracted_time;
        }
    }
}
