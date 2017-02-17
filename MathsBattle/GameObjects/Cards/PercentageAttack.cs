using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class PercentageAttack : Card
    {
        public override int Cost
        {
            get
            {
                return 50;
            }
        }

        public override string Info
        {
            get
            {
                return "Continuously attack HP in a total rate of 50% for 5 seconds";
            }
        }

        public override string Name
        {
            get
            {
                return "Percentage Attack";
            }
        }

        public override void Action(Player from, Player to)
        {
            TimedEvent te = new GameObjects.TimedEvent("Percentage Attack", 10, 200);
            te.OnTick += sender =>
            {
                to.HP = (int)(to.HP * (1 - 0.5d / 10));
            };
            to.Effects.Add(te);
            te.Start();
        }
    }
}
