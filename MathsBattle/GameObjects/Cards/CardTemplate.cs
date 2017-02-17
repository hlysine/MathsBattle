using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Cards
{
    public class CardTemplate : Card 
    {
        public override int Cost
        {
            get
            {
                return 20; //replace with custom value  player get 20MP for each correct answer
            }
        }

        public override string Info
        {
            get
            {
                return "A one-sentence description of what the card does"; //replace with custom value
            }
        }

        public override string Name
        {
            get
            {
                return "Name of Card"; //replace with custom value 1-3 words suggested
            }
        }

        public override void Action(Player from, Player to) //from is the one who use this card
        {



            //If this card has timed effect, add this section of code
            TimedEvent te = new GameObjects.TimedEvent("Continued Healing", 12, 1000); //parameters in bracket: ([effect name],[how many times will this effect repeat],[interval between each tick(in ms)])

            te.OnTick += sender =>
            { //what will this effect do every tick
                from.HP += 3;
            };

            te.OnFinished += sender =>
            { //what will this effect do after it ends (this will be done once only)

            };
            //who gets this effect (from or to)
            from.Effects.Add(te);

            //start effect
            te.Start();




            //if this card changes value of player, add this. You can change MP and HP or even cards for that player(not recommended)
            to.HP -= 40;
        }
    }
}
