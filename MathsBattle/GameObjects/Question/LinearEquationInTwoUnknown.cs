using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Question
{
    public class LinearEquationInTwoUnknown : QuestionGenerator
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
            int xAns = rnd.Next(-10, 10);
            int yAns = rnd.Next(-10, 10);
            internalOneEquationGenerator q1;
            internalOneEquationGenerator q2 = new internalOneEquationGenerator();
            string qs1;
            string qs2 = q2.Generate(xAns, yAns, rnd.Next());
            do
            {
                    q1 = new internalOneEquationGenerator();
                    qs1 = q1.Generate(xAns, yAns, rnd.Next());
            } while (EquationLeftTotal(q1, xAns, yAns) == EquationLeftTotal(q2, xAns, yAns));
            string qStr = qs1 + Environment.NewLine + qs2 ;
            List<string> ansList = new List<string>();
            ansList.Add("(" + xAns + ", " + yAns + ")");
            ansList.Add("(" + (xAns + rnd.Next(-10, 10)) + ", " + (yAns + rnd.Next(-10, 10)) + ")");
            ansList.Add("(" + (xAns + rnd.Next(-10, 10)) + ", " + (yAns + rnd.Next(-10, 10)) + ")");
            ansList.Add("(" + (xAns + rnd.Next(-10, 10)) + ", " + (yAns + rnd.Next(-10, 10)) + ")");
            return new Question(qStr, ansList, ansList[0]);
        }

        private int EquationLeftTotal(internalOneEquationGenerator q,int xAns,int yAns)
        {
            int LeftTotal = 0;
            for (int i = 0; i < q.LeftTerms.Count; i++)
            {
                LeftTotal += q.LeftTerms[i].GetValue(xAns, yAns);
            }
            return LeftTotal;
        }

        private class internalOneEquationGenerator
        {
            public List<Term> LeftTerms;
            public List<Term> RightTerms;
            Random rnd ;
            const int MinInt = -10;
            const int MaxInt = 10;


            private string GetLeft(string xTag, string yTag)
            {
                string ret = "";
                for (int i = 0; i < LeftTerms.Count; i++)
                {
                    ret += ((i > 0 && LeftTerms[i].Coefficient >= 0) ? "+" : "") + ((LeftTerms[i].Coefficient == 0 && LeftTerms[i].variable != Unknown.none) ? "" : LeftTerms[i].Coefficient.ToString()) + (LeftTerms[i].variable != Unknown.none ? LeftTerms[i].variable == Unknown.x ? xTag : yTag : "");
                }
                return ret;
            }

            private string GetRight(string xTag, string yTag)
            {
                string ret = "";
                for (int i = 0; i < RightTerms.Count; i++)
                {
                    ret += ((i > 0 && RightTerms[i].Coefficient >= 0) ? "+" : "") + ((RightTerms[i].Coefficient == 0 && RightTerms[i].variable != Unknown.none) ? "" : RightTerms[i].Coefficient.ToString()) + (RightTerms[i].variable != Unknown.none ? RightTerms[i].variable == Unknown.x ? xTag : yTag : "");
                }
                return ret;
            }

            public string Generate(int xAns,int yAns,int? seed = null) 
            { 
                if (seed == null)
                {
                    rnd = new Random(System.DateTime.Now.Millisecond);
                }
                else
                {
                    rnd = new Random(seed.GetValueOrDefault());
                }
                LeftTerms = new List<Term>();
                RightTerms = new List<Term>();

                //Randomize equation terms
                int LeftTermCount = 2;
                int RightTermCount = 2;


                for (int i = 1; i <= LeftTermCount; i++)
                {
                    int c = rnd.Next(MinInt, MaxInt);
                    LeftTerms.Add(new Term(c, c == 0 ? rnd.Next(2) == 0 ? Unknown.x : Unknown.y : (Unknown)rnd.Next(3)));
                }

                for (int i = 1; i <= RightTermCount; i++)
                {
                    int c = rnd.Next(MinInt, MaxInt);
                    RightTerms.Add(new Term(c, c == 0 ? rnd.Next(2) == 0 ? Unknown.x : Unknown.y : (Unknown)rnd.Next(3)));
                }

                bool hasX = false;
                bool hasY = false;
                //check the presence of unknown
                for (int i = 0; i < LeftTerms.Count; i++)
                {
                    if (LeftTerms[i].variable == Unknown.x) hasX = true;
                    if (LeftTerms[i].variable == Unknown.y) hasY = true;
                }

                for (int i = 0; i < RightTerms.Count; i++)
                {
                    if (RightTerms[i].variable == Unknown.x) hasX = true;
                    if (RightTerms[i].variable == Unknown.y) hasY = true;
                }
                if (!(hasX && hasY))
                {
                    bool LeftGen = (rnd.Next(2) == 0);
                    if (LeftGen)
                    {
                        int GenLoc = rnd.Next(LeftTerms.Count);
                        LeftTerms[GenLoc].variable = rnd.Next(2) == 0 ? Unknown.x : Unknown.y;
                    }
                    else
                    {
                        int GenLoc = rnd.Next(RightTerms.Count);
                        RightTerms[GenLoc].variable = rnd.Next(2) == 0 ? Unknown.x : Unknown.y;
                    }
                }
                //Calculate the fix for the equation
                int LeftTotal = 0;
                for (int i = 0; i < LeftTerms.Count; i++)
                {
                    LeftTotal += LeftTerms[i].GetValue(xAns, yAns);
                }
                int RightTotal = 0;
                for (int i = 0; i < RightTerms.Count; i++)
                {
                    RightTotal += RightTerms[i].GetValue(xAns, yAns);
                }
                int Fixer = LeftTotal - RightTotal;
                if (Fixer != 0)
                {
                    if (rnd.Next(2) == 0)
                    {
                        if (xAns != 0)
                        {
                            if (Fixer % xAns == 0)
                            {
                                RightTerms.Add(new Term(Fixer / xAns, Unknown.x));
                            }
                            else
                            {
                                RightTerms.Add(new Term(Fixer, Unknown.none));
                            }
                        }
                        else
                        {
                            RightTerms.Add(new Term(Fixer, Unknown.none));
                        }
                    }
                    else
                    {
                        if (yAns != 0)
                        {
                            if (Fixer % yAns == 0)
                            {
                                RightTerms.Add(new Term(Fixer / yAns, Unknown.y));
                            }
                            else
                            {
                                RightTerms.Add(new Term(Fixer, Unknown.none));
                            }
                        }
                        else
                        {
                            RightTerms.Add(new Term(Fixer, Unknown.none));
                        }
                    }
                }
                //output question
                string QuestionStr = GetLeft("x", "y") + "=" + GetRight("x", "y");
                return QuestionStr;
            }

            public class Term
            {
                public int Coefficient { get; set; }
                public Unknown variable { get; set; }

                public Term(int value, Unknown X)
                {
                    Coefficient = value;
                    variable = X;
                }

                public int GetValue(int xValue, int yValue)
                {
                    return Coefficient * (variable != Unknown.none ? variable == Unknown.x ? xValue : yValue : 1);
                }
            }

            public enum Unknown
            {
                none,
                x,
                y
            }
        }
    }
}
