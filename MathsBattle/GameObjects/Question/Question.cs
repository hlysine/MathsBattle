using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBattle.GameObjects.Question
{
    public struct Question
    {
        public string QuestionStr { get; set; }
        public List<string> AnsStr { get; set; }
        public string CorrectAns { get; set; }

        public Question(string Question, List<string> Ans, string _CorrectAns)
        {
            QuestionStr = Question;
            AnsStr = Ans;
            CorrectAns = _CorrectAns;
            if (!AnsStr.Contains(CorrectAns))
            {
                throw new ArgumentException("There is not an answer that is correct.", "CorrectAns");
            }
        }
    }

    public abstract class QuestionGenerator
    {
        public abstract Question Generate(int? seed = null);
        public static Question Generate(int? seed = null, List<Type> qType = null)
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
            if (qType == null)
            {
                Type[] listOfBs = (from domainAssembly in AppDomain.CurrentDomain.GetAssemblies()
                                   from assemblyType in domainAssembly.GetExportedTypes()
                                   where assemblyType.IsSubclassOf(typeof(QuestionGenerator))
                                   select assemblyType).ToArray();
                int i = rnd.Next(listOfBs.Length);
                object[] param = { rnd.Next() };
                return (Question)listOfBs[i].GetMethod("Generate").Invoke(Activator.CreateInstance(listOfBs[i]), param);
            }
            else
            {
                int i = rnd.Next(qType.Count);
                object[] param = { rnd.Next() };
                return (Question)qType[i].GetMethod("Generate").Invoke(Activator.CreateInstance(qType[i]), param);
            }
        }
    }

}
