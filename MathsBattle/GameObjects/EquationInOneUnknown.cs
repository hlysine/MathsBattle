using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.Question
{
    public class EquationInOneUnknown : QuestionGenerator
    {
        List<Term> LeftTerms;
        List<Term> RightTerms;
        Random rnd;
        public int answer { get; set; }

        const int MinTerm = 2;
        const int MaxTerm = 5;
        const int MinAns = -50;
        const int MaxAns = 50;
        const int MinInt = -50;
        const int MaxInt = 50;

        private string GetLeft(string unknown)
        {
            string ret = "";
            for (int i = 0; i < LeftTerms.Count; i++)
            {
                ret += ((i > 0 && LeftTerms[i].Coefficient >= 0) ? "+" : "") + ((LeftTerms[i].Coefficient == 0 && LeftTerms[i].hasVariable) ? "" : LeftTerms[i].Coefficient.ToString()) + (LeftTerms[i].hasVariable ? unknown : "");
            }
            return ret;
        }

        private string GetRight(string unknown)
        {
            string ret = "";
            for (int i = 0; i < RightTerms.Count; i++)
            {
                ret += ((i > 0 && RightTerms[i].Coefficient >= 0) ? "+" : "") + ((RightTerms[i].Coefficient == 0 && RightTerms[i].hasVariable) ? "" : RightTerms[i].Coefficient.ToString()) + (RightTerms[i].hasVariable ? unknown : "");
            }
            return ret;
        }

        public override Question Generate(int? seed = null)
        {
            if (seed == null)
            {
                rnd = new Random(System.DateTime.Now.Millisecond);
            }
            else
            {
                rnd = new Random(seed.GetValueOrDefault());
            }
            //Preperation
            if (MinTerm < 1) throw new ArgumentOutOfRangeException("MinTerm", "Minimum Term Count is smaller than 1");
            LeftTerms = new List<Term>();
            RightTerms = new List<Term>();

            //Randomize equation terms
            int LeftTermCount = rnd.Next(MinTerm, MaxTerm);
            int RightTermCount = rnd.Next(MinTerm, MaxTerm);
            answer = rnd.Next(MinAns, MaxAns);

            for (int i = 1; i <= LeftTermCount; i++)
            {
                int c = rnd.Next(MinInt, MaxInt);
                LeftTerms.Add(new Term(c, c == 0 ? true : rnd.Next(2) == 0));
            }

            for (int i = 1; i <= RightTermCount; i++)
            {
                int c = rnd.Next(MinInt, MaxInt);
                RightTerms.Add(new Term(c, c == 0 ? true : rnd.Next(2) == 0));
            }

            //check the presence of unknown
            for (int i = 0; i < LeftTerms.Count; i++)
            {
                if (LeftTerms[i].hasVariable) goto valid;
            }

            for (int i = 0; i < RightTerms.Count; i++)
            {
                if (RightTerms[i].hasVariable) goto valid;
            }

            bool LeftGen = (rnd.Next(2) == 0);
            if (LeftGen)
            {
                int GenLoc = rnd.Next(LeftTerms.Count);
                LeftTerms[GenLoc].hasVariable = true;
            }
            else
            {
                int GenLoc = rnd.Next(RightTerms.Count);
                RightTerms[GenLoc].hasVariable = true;
            }

            valid:
            //Calculate the fix for the equation
            int LeftTotal = 0;
            for (int i = 0; i < LeftTerms.Count; i++)
            {
                LeftTotal += LeftTerms[i].GetValue(answer);
            }
            int RightTotal = 0;
            for (int i = 0; i < RightTerms.Count; i++)
            {
                RightTotal += RightTerms[i].GetValue(answer);
            }
            int Fixer = LeftTotal - RightTotal;
            if (Fixer != 0)
            {
                if (answer != 0)
                {
                    if (Fixer % answer == 0)
                    {
                        RightTerms.Add(new Term(Fixer / answer, true));
                    }
                    else
                    {
                        RightTerms.Add(new Term(Fixer, false));
                    }
                }
                else
                {
                    RightTerms.Add(new Term(Fixer, false));
                }
            }
            //output question
            string CorrectAns = answer.ToString();
            List<string> AnsStr = new List<string>();
            string QuestionStr = GetLeft("x") + "=" + GetRight("x");
            AnsStr.Add(CorrectAns);
            AnsStr.Add((answer + rnd.Next(-20, 20)).ToString());
            AnsStr.Add((answer + rnd.Next(-20, 20)).ToString());
            AnsStr.Add((answer + rnd.Next(-20, 20)).ToString());
            return new Question(QuestionStr, AnsStr, CorrectAns);
        }

        public class Term
        {
            public int Coefficient { get; set; }
            public bool hasVariable { get; set; }

            public Term(int value, bool X)
            {
                Coefficient = value;
                hasVariable = X;
            }

            public int GetValue(int unknownValue)
            {
                return Coefficient * (hasVariable ? unknownValue : 1);
            }
        }
    }
}
