using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Question
{
    public class Triangle : QuestionGenerator
    {
        public override Question Generate(int? seed = null)
        {
            Random rnd;
            if(seed==null)
            {
                rnd = new Random((int)DateTime.Now.Ticks);
            }
            else
            {
                rnd = new Random(seed.GetValueOrDefault());
            }

            //Generate
            int a1, a2, a3;
            a1 = rnd.Next(1,10 );
          //  System.Threading.Thread.Sleep(1000);
            a2 = rnd.Next(1,10);
            a3 = rnd.Next(1, 10);

            string qStr = "Which of the following can form a triangle?";
            List<string> ans = new List<string>();
            ans.Add((a1.ToString() +","+ a2.ToString() +","+ a3.ToString()));
            ans.Add(((a1 - rnd.Next(1, 10)).ToString() + "," + (a2 - rnd.Next(1, 10)).ToString() + "," + (a3 - rnd.Next(1, 10)).ToString()));
            ans.Add(((a1 - rnd.Next(1, 10)).ToString() + "," + (a2 - rnd.Next(1, 10)).ToString() + "," + (a3 - rnd.Next(1, 10)).ToString()));
            ans.Add(((a1 - rnd.Next(1, 10)).ToString() + "," + (a2 - rnd.Next(1, 10)).ToString() + "," + (a3 - rnd.Next(1, 10)).ToString()));
            return new Question(qStr, ans, ((a1.ToString() + "," + a2.ToString() + "," + a3.ToString())));
        }
    }
}
