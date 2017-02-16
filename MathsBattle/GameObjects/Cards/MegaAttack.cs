using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class MegaAttack : Card
    {
        public override int Cost
        {
            get
            {
                return 20;
            }
        }

        public override string Info
        {
            get
            {
                return "Attack 40 HP";
            }
        }

        public override string Name
        {
            get
            {
                return "Mega Attack";
            }
        }

        public override void Action(Player from, Player to)
        {
            to.HP -= 40;
        }
    }
}
