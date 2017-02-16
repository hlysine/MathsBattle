using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class PercentageHeal : Card
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
                return "Continuously increase HP in a total rate of 50% for 5 seconds";
            }
        }

        public override string Name
        {
            get
            {
                return "Percentage Heal";
            }
        }

        public override void Action(Player from, Player to)
        {
            TimedEvent te = new GameObjects.TimedEvent("Percentage Heal", 10, 200);
            te.OnTick += sender =>
            {
                from.HP = (int)(from.HP * (1 + 0.5d / 10));
            };
            from.Effects.Add(te);
            te.Start();
        }
    }
}
