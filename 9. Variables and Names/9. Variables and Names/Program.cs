using System;

namespace _9._Variables_and_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int cars, drivers, passengers, cars_not_driven, cars_driven;
            double space_in_a_car, carpool_capacity, average_passengers_per_car;

            cars = 100;
            space_in_a_car = 4.0;
            drivers = 30;
            passengers = 90;
            cars_not_driven = cars - drivers;
            cars_driven = drivers;
            carpool_capacity = cars_driven * space_in_a_car;
            average_passengers_per_car = passengers / cars_driven;


            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + cars_not_driven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + average_passengers_per_car + " in each car.");
        }
    }
    }
}
