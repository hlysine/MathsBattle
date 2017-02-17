using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Question
{
    public class TriangleInequality : QuestionGenerator
    {
        Random rnd;
        public override Question Generate(int? seed = null)
        {
            if (seed == null)
            {
                rnd = new Random((int)DateTime.Now.Ticks);
            }
            else
            {
                rnd = new Random(seed.GetValueOrDefault());
            }

            SetOfLine ans = ValidSet();
            SetOfLine i1 = InvalidSet();
            SetOfLine i2 = InvalidSet();
            SetOfLine i3 = InvalidSet();

            string QuestionStr = "Which of the following sets of lines can form a triangle?";
            List<string> AnsStr = new List<string>();
            AnsStr.Add(ans.ToString());
            AnsStr.Add(i1.ToString());
            AnsStr.Add(i2.ToString());
            AnsStr.Add(i3.ToString());
            string correctAns = ans.ToString();
            return new Question(QuestionStr, AnsStr, correctAns);
        }

        /// <summary>
        /// Generate a valid set of lines that can form a triangle
        /// </summary>
        /// <returns></returns>
        SetOfLine ValidSet()
        {
            int a = rnd.Next(1, 11);
            int b = rnd.Next(1, 11);
            int c = rnd.Next(Math.Max(a, b) - Math.Min(a, b) + 1, a + b);
            return new SetOfLine(a, b, c);
        }

        SetOfLine InvalidSet()
        {
            int a = rnd.Next(1, 11);
            int b = rnd.Next(1, 11);
            int c = rnd.Next(2) == 1 ? rnd.Next(a + b + 1, a + b + 21) : a == b ? rnd.Next(a + b + 1, a + b + 21) : rnd.Next(1, Math.Max(a, b) - Math.Min(a, b) + 1);
            return new SetOfLine(a, b, c);
        }

        private struct SetOfLine
        {
            public int A;
            public int B;
            public int C;
            public SetOfLine(int a, int b, int c)
            {
                A = a; B = b; C = c;
            }
            public override string ToString()
            {
                return A.ToString() + ", " + B.ToString() + ", " + C.ToString();
            }
            public bool isValid()
            {
                return A + B > C && A + C > B && B + C > A;
            }
        }
    }
}
