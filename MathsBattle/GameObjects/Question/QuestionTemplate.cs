////(IMPORTANT) uncomment the whole page to start coding

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MathsBattle.GameObjects.Question
//{
//    public class QuestionTemplate : QuestionGenerator
//    {
//        public override Question Generate(int? seed = null)
//        {
//            // use this rnd variable for ALL randoms
//            Random rnd;
//            if (seed == null)
//            {
//                rnd = new Random((int)DateTime.Now.Ticks);
//            }
//            else
//            {
//                rnd = new Random(seed.GetValueOrDefault());
//            }

//            //write generating code here

//            string QuestionStr = "replace with your own question";//question string
//            List<string> AnsStr = new List<string>(); //limited to four answers (DONT PUT MORE THAN OR LESS THAN FOUR)
//            AnsStr.Add("ans1"); //replace with your own answer
//            AnsStr.Add("ans1"); //replace with your own answer
//            AnsStr.Add("ans1"); //replace with your own answer
//            AnsStr.Add("ans1"); //replace with your own answer
//            string correctAns = "replace with your own answer"; //this must be equal to one of the ansStr
//            return new Question(QuestionStr, AnsStr, correctAns);
//        }
//    }
//}
