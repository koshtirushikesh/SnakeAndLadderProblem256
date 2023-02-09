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
            Player player_one = new Player();
            Player player_two = new Player();

            int PlayerPossition_1 = 0,PlayerPossition_2 = 0;
            Console.WriteLine("Enter the player 1 name ");
            string _player_One= Console.ReadLine();

            Console.WriteLine("Enter the player 2 name ");
            string _player_Two= Console.ReadLine();
            
            while (PlayerPossition_1 <= 100 && PlayerPossition_2 <= 100)
            {
                
                Console.WriteLine($"-------------------- {_player_One} Playing ");
                PlayerPossition_1 = player_one.Playing(PlayerPossition_1);
                if (PlayerPossition_1 == 100)
                {
                    Console.WriteLine("Player 1 Win");
                    Console.WriteLine("Die count to win: " + player_one.DieCount);
                    break;
                }
                
                Console.WriteLine($"-------------------- {_player_Two} Playing ");
                PlayerPossition_2 = player_two.Playing(PlayerPossition_2);
                if (PlayerPossition_2 == 100)
                {
                    Console.WriteLine("Player 2 Win");
                    Console.WriteLine("Die count to win: " +player_two.DieCount);
                    break;
                }
            }
            
            
            Console.ReadLine();
        }
    }
}
