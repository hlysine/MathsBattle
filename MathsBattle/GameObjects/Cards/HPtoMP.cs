using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class HPtoMP : Card 
    {
        public override int Cost
        {
            get
            {
                return -20;
            }
        }

        public override string Info
        {
            get
            {
                return "Deduct 20 HP to get 20 MP";
            }
        }

        public override string Name
        {
            get
            {
                return "HP To MP";
            }
        }

        public override void Action(Player from, Player to) 
        {
            from.HP -= 20;
        }
    }
}
