using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXam__Csharp
{
    internal class Final_Exam : exam

    {
        public Final_Exam(string title, int time, int numOfQuestions) : base(title, time, numOfQuestions)
        {
        }
        public void AddQuestion(Question q)
        {
            Questions.Add(q);
        }

    }
}