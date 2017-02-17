
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Question
{
    public class BasicOperations : QuestionGenerator
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

            List<Term> t = new List<Term>();
            int r = 0;
            t.Add(new Term((Operator)r, r == 1 || r == 2 ? rnd.Next(100) : rnd.Next(-10, 11) * (10 ^ rnd.Next(1, 4))));

            //randomly generate 1 to 2 terms
            int count = rnd.Next(1, 3);
            for (int i = 1; i <= count; i++)
            {
                int r2 = rnd.Next(5);
                t.Add(new Term((Operator)r2, r2 == 1 || r2 == 2 ? rnd.Next(100) : rnd.Next(-10, 11) * (10 ^ rnd.Next(1, 4))));
            }

            string QuestionStr = "";
            for (int i = 0; i < t.Count; i++)
            {
                QuestionStr = QuestionStr + t[i].ToString();
            }
            QuestionStr = QuestionStr + "=?";

            float ans = 0;
            secCheck:
            //solve multiplication and division first
            bool hasSec = false;
            foreach (Term tr in t)
            {
                if (tr.OP == Operator.multiply || tr.OP == Operator.divide) hasSec = true;
            }
            while (hasSec)
            {
                for (int i = t.Count - 1; i > 0; i--)
                {
                    Term tr = t[i];
                    if (tr.OP == Operator.multiply || tr.OP == Operator.divide)
                    {
                        if (tr.OP == Operator.multiply)
                        {
                            t[i - 1].num = t[i - 1].num * tr.num;
                        }
                        else
                        {
                            t[i - 1].num = t[i - 1].num / tr.num;
                        }
                        t.RemoveAt(i);
                        break;
                    }
                }
                hasSec = false;
                foreach (Term tr in t)
                {
                    if (tr.OP == Operator.multiply || tr.OP == Operator.divide) hasSec = true;
                }
            }

            //solve the rest (addition and subtraction)
            for (int i = t.Count-1; i >0; i--)
            { 
                if (t[1].OP == Operator.plus)
                {
                    t[0].num = t[0].num + t[1].num;
                }
                else if (t[1].OP == Operator.minus)
                {
                    t[0].num = t[0].num - t[1].num;
                }
                else
                {
                    goto secCheck;
                }
            }
            ans = t[0].num;

            List<string> AnsStr = new List<string>();
            AnsStr.Add(ans.ToString());
            AnsStr.Add((ans + (rnd.Next(2) == 1 ? -rnd.Next(10, 200) / 10f : rnd.Next(10, 200) / 10f)).ToString());
            AnsStr.Add((ans + (rnd.Next(2) == 1 ? -rnd.Next(10, 200) / 10f : rnd.Next(10, 200) / 10f)).ToString());
            AnsStr.Add((ans + (rnd.Next(2) == 1 ? -rnd.Next(10, 200) / 10f : rnd.Next(10, 200) / 10f)).ToString());
            string correctAns = ans.ToString();
            return new Question(QuestionStr, AnsStr, correctAns);
        }

        private class Term
        {
            public Operator OP;
            public float num;

            public Term(Operator op, float _num)
            {
                OP = op;
                num = _num;
            }

            public override string ToString()
            {
                if (OP == Operator.plus)
                {
                    return "+" + num.ToString();
                }
                else if (OP == Operator.minus)
                {
                    return "-" + num.ToString();
                }
                else if (OP == Operator.multiply)
                {
                    return "×" + num.ToString();
                }
                else if (OP == Operator.divide)
                {
                    return "÷" + num.ToString();
                }
                else { return num.ToString(); }
            }
        }

        private enum Operator { none, plus, minus, multiply, divide }
    }
}
