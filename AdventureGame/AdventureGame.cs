using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class AdventureGame
    {
        //member variables
        public Player1 player1;
        public Player2 player2;
        public Destination destination;
        public Course course;

        //constructor
        public AdventureGame()
        {
            player1 = new Player1();
            player2 = new Player2();
            destination = new Destination();
            course = new Course();
        }

        //member methods
    }

}
