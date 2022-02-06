// Kyle Zapalac, 06-Feb-2022, GAME-1343 (SP 2022)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_SpeedCamera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare objects and variables
            Car c1 = new Car();
            Car c2 = new Car();
            Car c3 = new Car();
            int speedLimit = 0;

            // begin input
            Console.WriteLine("===========================================\n");

            // get speed limit from user
            Console.Write("Enter the speed limit: ");
            speedLimit = int.Parse(Console.ReadLine());
            c1.limit = speedLimit;
            c2.limit = speedLimit;  
            c3.limit = speedLimit;

            // get attributes for car #1 from user
            Console.Write("\nEnter the first car's MAKE: ");
            c1.make = Console.ReadLine();
            Console.Write("Enter the first car's MODEL: ");
            c1.model = Console.ReadLine();
            Console.Write("Enter the first car's SPEED: ");
            c1.speed = int.Parse(Console.ReadLine());

            // get attributes for car #2 from user
            Console.Write("\nEnter the second car's MAKE: ");
            c2.make = Console.ReadLine();
            Console.Write("Enter the second car's MODEL: ");
            c2.model = Console.ReadLine();
            Console.Write("Enter the second car's SPEED: ");
            c2.speed = int.Parse(Console.ReadLine());

            // get attributes for car #3 from user
            Console.Write("\nEnter the third car's MAKE: ");
            c3.make = Console.ReadLine();
            Console.Write("Enter the third car's MODEL: ");
            c3.model = Console.ReadLine();
            Console.Write("Enter the third car's SPEED: ");
            c3.speed = int.Parse(Console.ReadLine());

            // end input/begin output
            Console.WriteLine("\n===========================================\n");

            Console.WriteLine("The speed limit is: " + speedLimit + "\n");

            Console.WriteLine("\nCar Observed: "+ c1.make + ", " + c1.model + ", Traveling " + c1.speed + "mph");
            c1.speedCheck();

            Console.WriteLine("\nCar Observed: " + c2.make + ", " + c2.model + ", Traveling " + c2.speed + "mph");
            c2.speedCheck();

            Console.WriteLine("\nCar Observed: " + c3.make + ", " + c3.model + ", Traveling " + c3.speed + "mph");
            c3.speedCheck();

            // end output
            Console.WriteLine("\n===========================================\n");
        }
    }

    public class Car
    {
        // declare properties
        public string make;
        public string model;
        public int speed;
        public int limit;
        private int demerits = 0;

        // create method to analyze speed and print demerits accordingly
        public void speedCheck()
        {
            if(speed<=limit)
            {
                Console.WriteLine("Speed Check: OK");
            }
            else
            {
                demerits = (speed - limit) / 5;

                if (demerits >= 10)
                {
                    Console.WriteLine("Speed Check: " + demerits + " demerits <LICENSE REVOKED>");
                }
                else
                {
                    Console.WriteLine("Speed Check: " + demerits + " demerits");
                }
            }
        }
    }
}
