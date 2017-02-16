using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class QuickHeal : Card 
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
                return "Heals 10 HP in 2 seconds"; 
            }
        }

        public override string Name
        {
            get
            {
                return "Quick Heal";
            }
        }

        public override void Action(Player from, Player to) 
        {
            TimedEvent te = new GameObjects.TimedEvent("Quick Heal", 10, 200);
            te.OnTick += sender =>
            {
                from.HP += 1;
            };
            from.Effects.Add(te);
            te.Start();
        }
    }
}
