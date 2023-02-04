using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            
            Console.WriteLine("Player Possition: "+player.PlayerPossition);
            player.Playing();

            Console.ReadLine();
        }
    }
}
