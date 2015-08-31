using System;
using UniumPr3Game.Core;

namespace UniumPr3Game.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new UserInteraction());
            game.Start();

            Console.ReadKey();
        }
    }
}
