using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureGame myAdventureGame = new AdventureGame();

            myAdventureGame.destination.ChooseDestination();
        }
    }
}
