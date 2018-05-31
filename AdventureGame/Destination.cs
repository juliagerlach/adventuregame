using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Destination
    {
        //member variables
        public string destination;

        //constructor
        public Destination()
        {
            destination = "";
        }
        //member methods

        public void ChooseDestination()
        {
            Console.WriteLine("Your mission is to find a secret treasure hidden in a popular public place. The choices you make will determine if you find the treasure. Which of these destinations would you like to explore: The Zoo, Boerner Botanical Gardens, Miller Park, or the Lakefront?");
            destination = Console.ReadLine();

            switch (destination)
            {
                case "The Zoo":
                    Console.WriteLine("Make sure you see the Big Cats! Good luck finding the hidden treasure at " + destination + ". Press any key to continue.");
                    Console.ReadLine();
                    break;
                case "Boerner Botanical Gardens":
                    Console.WriteLine("Be sure to stop and smell the roses! Good luck finding the hidden treasure at " + destination + ". Press any key to continue.");
                    Console.ReadLine();
                    break;
                case "Miller Park":
                    Console.WriteLine("Have a ball! Good luck finding the hidden treasure at " + destination + ". Press any key to continue.");
                    Console.ReadLine();
                    break;
                case "The Lakefront":
                    Console.WriteLine("Fun times ahead! Good luck finding the hidden treasure at " + destination + ". Press any key to continue.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Not a valid destination. Press any key to continue.");
                    Console.ReadLine();
                    ChooseDestination();
                    break;
            }

        }

    }
}
