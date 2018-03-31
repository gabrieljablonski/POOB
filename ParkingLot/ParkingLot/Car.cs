using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLot
{
    class Car
    {
        const float hourly_rate = 7;
        private string plate;
        private string brand;
        Time entrance_time = new Time();
        Time exit_time = new Time();

        public void set_car_info()
        {
            Console.Out.Write("Inform the plate of the car:\n>>");
            plate = Console.In.ReadLine().Split()[0].Trim();

            Console.Out.Write("Inform the brand of the car:\n>>");
            brand = Console.In.ReadLine().Split()[0].Trim();

            Console.Out.Write("Inform the entrance time for the car (hh:mm:ss):\n>>");
            entrance_time.set_time();

            Console.Out.Write("Inform the exit time for the car (hh:mm:ss):\n>>");
            exit_time.set_time();

            Console.Out.WriteLine();
        }

        public void print_car_info()
        {
            Console.Out.WriteLine("--Plate:\n  >" + plate);

            Console.Out.WriteLine("--Brand:\n  >" + brand);

            Console.Out.Write("--Time of entrance:\n  >");
            entrance_time.print_time();
            Console.Out.WriteLine();

            Console.Out.Write("--Exit time:\n  >");
            exit_time.print_time();
            Console.Out.WriteLine();
        }

        public float get_parking_rate()
        {
            Time elapsed_time = entrance_time.subtract_time(exit_time);

            int hours = elapsed_time.get_hour();

            if(elapsed_time.get_min() > 14) // 15 minute grace period
            {
                hours += 1;
            }

            return (hours * hourly_rate);
        }
    }
}
