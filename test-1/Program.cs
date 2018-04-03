using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    class Program
    {

        public class Car
        {
            public string Color { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
        }

        public class Date
        {
            public string Month { get; set; }
            public int Day { get; set; }
            public int Year { get; set; }
        }

        static void Main(string[] args)
        {
            int numberOfDogs = 5;
            Console.WriteLine($"There are {numberOfDogs} running around the dog park.");

            int numberOfSammies = 3;
            Console.WriteLine($"{numberOfSammies} is the number of sandwiches I can eat when i'm hungry.");

            double dinnerDollars = 14.99;
            Console.WriteLine($"It costs ${dinnerDollars} for a nice dinner.");

            var myCar = new Car
            {
                Make = "Honda",
                Model = "Element",
                Color = "black"
            };
            Console.WriteLine($"My dream car is a  {myCar.Color} {myCar.Make} {myCar.Model}.");

            var currentDate = new Date
            {
                Month = "April",
                Day = 3,
                Year = 2018
            };
            Console.WriteLine($"The current date is {currentDate.Month} {currentDate.Day}rd {currentDate.Year}.");

            char firstLetter = 'J';
            Console.WriteLine($"The first letter in my name James is {firstLetter}.");

            int starAmount = 666;
            Console.WriteLine($"Ironically, there are {666} stars in the sky.");

            Console.ReadLine();

        }
    }
}
