using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Course
    {
        //member variables
        public string destination;
        public int score;

        //constructor
        public Course()
        {
            destination = "";
            score = 0;
        }
        //member methods
                       
        public void FollowCourse()
        {
            Console.WriteLine("Congratulations - you have arrived at " + destination + ".\n");
            Console.WriteLine("Which attraction would you like to visit: reptiles, polar bears, big cats, wolves, , ?");
            destination = Console.ReadLine();

            switch (destination)
            {
                case "The Zoo":
                    Console.WriteLine("Make sure you see the Big Cats! Good luck finding the hidden treasure at " + destination + ".");
                    GoToZoo();
                    break;
                case "Boerner Botanical Gardens":
                    Console.WriteLine("Be sure to stop and smell the roses! Good luck finding the hidden treasure at " + destination + ".");
                    GoToGardens();
                    break;
                case "Miller Park":
                    Console.WriteLine("Have a ball! Good luck finding the hidden treasure at " + destination + ".");
                    GoToMillerPark();
                    break;
                case "The Lakefront":
                    Console.WriteLine("Fun times ahead! Good luck finding the hidden treasure at " + destination + ".");
                    GoToLakefront();
                    break;
                default:
                    Console.WriteLine("Not a valid destination.");
                    FollowCourse();
                    break;
            }
           
        }

        public void GoToZoo()
        {

        }

        public void GoToGardens()
        {

        }

        public void GoToMillerPark()
        {

        }

        public void GoToLakefront()
        {

        }

    }
}
