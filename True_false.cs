using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXam__Csharp
{
    internal class True_false : Question
    {
        public True_false(string header, string body, int mark) : base(header, body, mark) //    Constructor  >>  Question
        {

        }
        public override void ShowQuestion()
        {
            Console.WriteLine($"[True/False] {Header}: {Body}");
        }
    }
}