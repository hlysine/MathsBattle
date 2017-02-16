using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class HPTransfer : Card 
    {
        public override int Cost
        {
            get
            {
                return 40;
            }
        }

        public override string Info
        {
            get
            {
                return "Attack 20 HP and recover 20 HP in 4 seconds";
            }
        }

        public override string Name
        {
            get
            {
                return "HP Transfer";
            }
        }

        public override void Action(Player from, Player to) 
        {
            TimedEvent te = new GameObjects.TimedEvent("HP Transfer", 20, 200); 
            te.OnTick += sender =>
            { 
                from.HP += 1;
                to.HP -= 1;
            };
            from.Effects.Add(te);
            te.Start();
        }
    }
}
