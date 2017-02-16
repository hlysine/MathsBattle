using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class NormalAttack : Card
    {
        public override int Cost
        {
            get
            {
                return 10;
            }
        }

        public override string Info
        {
            get
            {
                return "Attack 20 HP";
            }
        }

        public override string Name
        {
            get
            {
                return "Normal Attack";
            }
        }

        public override void Action(Player from, Player to)
        {
            to.HP -= 20;
        }
    }
}
