
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Question
{
    public class PercentageChange : QuestionGenerator
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

            int bNum = rnd.Next(101);
            int change = rnd.Next(2) == 1 ? rnd.Next(-9, 0) : rnd.Next(1, 10);
            float ans = bNum * (1 + change / 10f);

            string QuestionStr = "Find " + bNum.ToString() + " changed by " + (change * 10).ToString() + "%.";
            List<string> AnsStr = new List<string>();
            AnsStr.Add(ans.ToString());
            AnsStr.Add((ans + (rnd.Next(2) == 1 ? -rnd.Next(10, 200) / 10f : rnd.Next(10, 200) / 10f)).ToString());
            AnsStr.Add((ans + (rnd.Next(2) == 1 ? -rnd.Next(10, 200) / 10f : rnd.Next(10, 200) / 10f)).ToString());
            AnsStr.Add((ans + (rnd.Next(2) == 1 ? -rnd.Next(10, 200) / 10f : rnd.Next(10, 200) / 10f)).ToString());
            string correctAns = ans.ToString();
            return new Question(QuestionStr, AnsStr, correctAns);
        }
    }
}
