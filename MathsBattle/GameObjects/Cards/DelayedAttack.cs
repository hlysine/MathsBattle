using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class DelayedAttack : Card
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
                return "Attack 50 HP after 3 seconds";
            }
        }

        public override string Name
        {
            get
            {
                return "Delayed Attack";
            }
        }

        public override void Action(Player from, Player to)
        {
            TimedEvent te = new GameObjects.TimedEvent("Delayed Attack", 3, 1000);
            te.OnFinished += sender =>
            {
                to.HP -= 50;
            };
            to.Effects.Add(te);
            te.Start();
        }
    }
}
