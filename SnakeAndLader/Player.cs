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
        
            DieCount++;
            PlayerPossition += DieRoll;
            Console.WriteLine("Die Rolled No:" + DieRoll + "\nPlayer Possition : " + PlayerPossition);

            int Option=random.Next(0, 3);

            if(PlayerPossition<100)
            {
                switch (Option)
                {
                    //no play
                    case 0: Console.WriteLine("No Play :\nPlayer Possition " + PlayerPossition); break;
                    case 1:  //lader
                        PlayerPossition += DieRoll;
                        Console.WriteLine("lader : \nPlayer Possition " + PlayerPossition); break;
                    case 2: // snake
                        PlayerPossition -= DieRoll;
                        Console.WriteLine("Snake : \nPlayer Possition " + PlayerPossition); break;
                }
            }

            if (PlayerPossition < 0)
                PlayerPossition = 0;
            else if (PlayerPossition > 100) 
                PlayerPossition -= DieRoll;

            return PlayerPossition;
        }
    }
}
