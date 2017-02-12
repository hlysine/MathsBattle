using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class ContinuedHealing : Card
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
                return "30 MP: Heal 5 HP every 1 second for 12 seconds";
            }
        }

        public override string Name
        {
            get
            {
                return "Continued Healing";
            }
        }

        public override void Action(Player from, Player to)
        {
            TimedEvent te = new GameObjects.TimedEvent("Continued Healing", 12, 1000);
            te.OnTick += sender => from.HP += 3;
            from.Effects.Add(te);
            te.Start();
        }
    }
}
