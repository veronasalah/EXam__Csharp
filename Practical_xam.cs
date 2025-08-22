using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXam__Csharp
{
    internal class Practical_xam : exam
    {
        public Practical_xam(string title, int time, int numOfQuestions)
        : base(title, time, numOfQuestions)
        {
        }
        // force to enter mcq bs ana call constructor by3rf mscq bs 
        public void AddQuestion(MCQ_Question q)
        {
            Questions.Add(q);
        }
    }
}