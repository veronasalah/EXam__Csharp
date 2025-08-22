using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EXam__Csharp
{
    internal class MCQ_Question : Question
    {
        // to stroe more than option in array 
        public string[] Choices { get; set; }

        public MCQ_Question(string header, string body, int mark, string[] choices)
            : base(header, body, mark)
        {
            Choices = choices;
        }
        // override 34an abstractt clas parent lmazm a7ot override 34an a2dr edit fhe method 

        public override void ShowQuestion()
        {
            Console.WriteLine($"[MCQ] {Header}: {Body}");

            //for to know choce kman w i =0 da awl ind feh 
            for (int i = 0; i < Choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            }
        }
    }
}