using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLot
{
    class Program
    {
        const int N = 5; // Number of cars

        static void Main(string[] args)
        {
            Car[] cars = new Car[N];

            for(int i=0; i<N; i++)
            {
                cars[i] = new Car();
                Console.Out.WriteLine("Car #" + (i + 1) + ":");
                cars[i].set_car_info(); // Set information for each car
            }

            for (int i = 0; i < N; i++)
            {
                Console.Out.WriteLine("\nCar #" + (i + 1) + ":");
                cars[i].print_car_info();
                Console.Out.WriteLine("--Parking rate:\n  >R$ " + cars[i].get_parking_rate().ToString("F2"));
            }

            Console.In.Read();
        }
    }
}
