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
        public void Playing()
        {
            Random random = new Random();
            int DieRoll = random.Next(1, 7);
            Console.WriteLine("Die Rolled No:"+DieRoll);
            PlayerPossition += DieRoll;
            
            int Option=random.Next(0, 3);

            if(PlayerPossition<100)
            {
                switch (Option)
                {
                    //no play
                    case 0: Console.WriteLine("No Play : Player Possition " + PlayerPossition); break;
                    case 1:  //lader
                        PlayerPossition += DieRoll;
                        Console.WriteLine("lader : Player Possition " + PlayerPossition); break;
                    case 2: // snake
                        PlayerPossition -= DieRoll;
                        Console.WriteLine("Snake : Player Possition " + PlayerPossition); break;
                }
            }

            if (PlayerPossition < 0)
                PlayerPossition = 0;
            else if (PlayerPossition > 100) 
                PlayerPossition -= DieRoll;
        }

        public void PlayingTillWin()
        {
            while(PlayerPossition<112)
            {
                Playing();

                if(PlayerPossition==100)
                {
                    Console.WriteLine("Player Win by reaching: "+PlayerPossition);
                    break;
                }

            }
            
        }
    }
}
