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

            PlayerPossition = DieRoll;
        }
    }
}
