using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLader
{
    public class Player
    {
        internal int PlayerPossition = 0;
        internal int DieCount = 0;
        public int Playing(int PlayerPossition)
        {
            Random random = new Random();
            int DieRoll = random.Next(1, 7);
            Console.WriteLine("Player Possition: " + PlayerPossition);
            DieCount++;

            PlayerPossition += DieRoll;
            Console.WriteLine("Die Rolled No:" + DieRoll + "\nPlayer Possition : " + PlayerPossition);

            int Option =random.Next(0, 3);

            if(PlayerPossition<100)
            {
                switch (Option)
                {
                           //no play
                    case 0:Console.WriteLine("No Play :"); break;

                    case 1:  /*lader*/
                        PlayerPossition += DieRoll;
                        Console.WriteLine("lader :");
                        if (PlayerPossition < 100)
                        {
                            Console.WriteLine("Player Possition :" + PlayerPossition);
                            Console.WriteLine("Since Player got lader so player get one more chance:");
                            Playing(PlayerPossition);
                        }
                        
                        break;
                    case 2: /* snake*/ 
                        PlayerPossition -= DieRoll;
                        Console.WriteLine("Snake : ");
                        Console.WriteLine("Player Possition :" + PlayerPossition);
                        break;
                }
            }

            if (PlayerPossition < 0)
            {
                PlayerPossition = 0;
                Console.WriteLine("player going below so restarting from :" + PlayerPossition);
            } 
            else if (PlayerPossition > 100)
            {
                PlayerPossition -= DieRoll;
                Console.WriteLine("player going above 100 so start from same place : " + PlayerPossition);
            }

            return PlayerPossition;
        }
    }
}
