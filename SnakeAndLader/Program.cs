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
            Player player1 = new Player();
            Player player2 = new Player();

            int PlayerPossition_1 = 0,PlayerPossition_2 = 0;
            Console.WriteLine("Enter the player 1 name ");
            string player_One= Console.ReadLine();

            Console.WriteLine("Enter the player 2 name ");
            string player_Two= Console.ReadLine();
            
            while (PlayerPossition_1 < 120 && PlayerPossition_2 < 120)
            {
                
                Console.WriteLine($"-------------------- {player_One} Playing ");
                PlayerPossition_1 = player1.Playing(PlayerPossition_1);
                if (PlayerPossition_1 == 100)
                {
                    Console.WriteLine("Player 1 Win"); break;
                }
                
                Console.WriteLine($"-------------------- {player_Two} Playing ");
                PlayerPossition_2 = player2.Playing(PlayerPossition_2);
                if (PlayerPossition_2 == 100)
                {
                    Console.WriteLine("Player 2 Win"); break;
                }
            }

            Console.ReadLine();
        }
    }
}
