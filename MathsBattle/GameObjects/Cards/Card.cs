using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MathsBattle.GameObjects.Cards
{
    public abstract class Card
    {
        public abstract string Info { get; }
        public abstract string Name { get; }
        public abstract void Action(Player from,Player to);
        public abstract int Cost { get; }
    }
}