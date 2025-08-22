using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXam__Csharp
{
    internal class exam

    {

        public string Title { get; set; }
        public int Time { get; set; }
        public int NumOfQuestions { get; set; }
        // to add in exam som question 
        public List<Question> Questions { get; set; }
        //constructor 
        public exam(string title, int time, int numOfQuestions)
        {
            Title = title;
            Time = time;
            NumOfQuestions = numOfQuestions;
            Questions = new List<Question>();
        }
        //public exam(string title)
        //{
        //    Title = title;
        //    Questions = new List<Question>();
        //}

        //function add question 
        public void AddQuestion(Question q)
        {
            Questions.Add(q);
        }

    }
}