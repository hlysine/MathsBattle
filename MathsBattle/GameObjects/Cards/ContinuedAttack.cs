using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class ContinuedAttack : Card
    {
        public override int Cost
        {
            get
            {
                return 30;
            }
        }

        public override string Info
        {
            get
            {
                return "30 MP: Attack 5 HP every 1 second for 12 seconds";
            }
        }

        public override string Name
        {
            get
            {
                return "Continued Attack";
            }
        }

        public override void Action(Player from, Player to)
        {
            TimedEvent te = new GameObjects.TimedEvent("Continued Attack", 12, 1000);
            te.OnTick += sender =>
            {
                to.HP -= 3;
            };
            to.Effects.Add(te);
            te.Start();
        }
    }
}
