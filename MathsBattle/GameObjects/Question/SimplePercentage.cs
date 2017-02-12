using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Question
{
    public class SimplePercentage : QuestionGenerator
    {
        public override Question Generate(int? seed = null)
        {
            Random rnd;
            if (seed == null)
            {
                rnd = new Random((int)DateTime.Now.Ticks);
            }
            else
            {
                rnd = new Random(seed.GetValueOrDefault());
            }

            int baseNum = rnd.Next(10, 100);
            int change = rnd.Next(1, 20);
            string qStr = baseNum.ToString() + " × " + (change * 10).ToString() + "% = ?";
            List<string> ans = new List<string>();
            ans.Add((baseNum * change * 10f / 100).ToString());
            ans.Add((baseNum * change * 10f / 100 + (rnd.Next(2) == 1 ? -rnd.Next(10, 200) / 10f : rnd.Next(10, 200) / 10f)).ToString());
            ans.Add((baseNum * change * 10f / 100 + (rnd.Next(2) == 1 ? -rnd.Next(10, 200) / 10f : rnd.Next(10, 200) / 10f)).ToString());
            ans.Add((baseNum * change * 10f / 100 + (rnd.Next(2) == 1 ? -rnd.Next(10, 200) / 10f : rnd.Next(10, 200) / 10f)).ToString());
            return new Question(qStr, ans, (baseNum * change * 10f / 100).ToString());
        }
    }
}
