using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EXam__Csharp
{
    internal abstract class Question
    {
        public string Header { get; set; }  //? mfrod dy nullable 
        public string Body { get; set; }

        public int Mark { get; set; }

        // answers b2a 34an ykon feh related qustion answr 
        public answer[] AnswerList { get; set; }//array of answer 34an tt5zn feha 
        public answer RightAnswer { get; set; }




        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }
        //public   static Question CreateQuestionFromUser()
        //{
        //    Console.WriteLine("Enter Question Header:");
        //    string header = Console.ReadLine();

        //    Console.WriteLine("Enter Question Body:");
        //    string body = Console.ReadLine();

        //    Console.WriteLine("Enter Mark:");
        //    int mark = int.Parse(Console.ReadLine());// pase lanha readline bt2ra string lazm a3ml casting 

        //    if (type == 1)
        //    {
        //        return new MCQ_Question(header, body, mark);   // Child 1
        //    }
        //    else
        //    {
        //        return new True_False(header, body, mark);  // Child 2
        //    }
        //}
        //abstract not fully impmneted 34an kol child y3rf act behoivr bta3o zy cla shape 
        public abstract void ShowQuestion();
    }
}