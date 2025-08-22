using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXam__Csharp
{
    internal class subject

    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }// feh lap tany ? nullable da visual 19
        //34an 2adr arbot exam b sibject w da user definded dta type mn no3 class
        public exam Exam { get; set; }

        public subject(int id, string name)

        {
            SubjectId = id;
            SubjectName = name;
        }

        //lazm a3ml method ta5od amt7an w t5zno hwa subject kda wd7na fr2 ben exam as clas daat typoew paremter byt3rf 
        public void CreateExam(exam examParam)
        {
            this.Exam = examParam;
        }
        public override string ToString()
        {
            return $"Subject: {SubjectName} (ID: {SubjectId})";
        }

    }
}