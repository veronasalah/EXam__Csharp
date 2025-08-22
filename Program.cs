using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXam__Csharp
{
    class Program
    {  //function 34an ta5od mn user data w mian w code bta3y ykon proticive code 
        static exam CreateExamFromUser()
        {
            Console.WriteLine("Choose Exam Type (1: Final, 2: Practical): ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Exam Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Exam Time (minutes): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Questions: ");
            int numOfQ = int.Parse(Console.ReadLine());

            //exam examObj = examType == 1
            //    ? new Final_Exam(title, time, numOfQ)
            //    : new Practical_xam(title, time, numOfQ); visual 22
            //casting visual 2019
            exam examObj = examType == 1
                ? (exam)new Final_Exam(title, time, numOfQ)
                : (exam)new Practical_xam(title, time, numOfQ);

            // Loop to add questions
            for (int i = 0; i < numOfQ; i++)
            {
                Console.WriteLine($"\nQ{i + 1}: Choose Question Type (1: MCQ, 2: True/False): ");
                int qType = int.Parse(Console.ReadLine());

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Mark: ");
                int mark = int.Parse(Console.ReadLine());

                if (qType == 1) // MCQ
                {
                    Console.Write("How many options? ");
                    int optCount = int.Parse(Console.ReadLine());
                    string[] choices = new string[optCount];
                    answer[] answers = new answer[optCount];

                    for (int j = 0; j < optCount; j++)
                    {
                        Console.Write($"Option {j + 1}: ");
                        string opt = Console.ReadLine();
                        choices[j] = opt;
                        answers[j] = new answer(opt, j + 1);
                    }

                    Console.Write("Enter Right Answer Id: ");
                    int rightId = int.Parse(Console.ReadLine());
                    answer rightAnswer = answers[rightId - 1];

                    MCQ_Question mcq = new MCQ_Question(header, body, mark, choices);
                    mcq.AnswerList = answers;
                    mcq.RightAnswer = rightAnswer;
                    examObj.AddQuestion(mcq);
                }
                else // True/False
                {
                    True_false tf = new True_false(header, body, mark);
                    tf.AnswerList = new answer[]
                    {
                        new answer("True", 1),
                        new answer("False", 2)
                    };

                    Console.Write("Enter Right Answer (1=True, 2=False): ");
                    int rightId = int.Parse(Console.ReadLine());
                    tf.RightAnswer = tf.AnswerList[rightId - 1];

                    examObj.AddQuestion(tf);
                }
            }

            return examObj;
        }











        static void Main(string[] args)
        {
            subject sub = new subject(1, "OOP");
            exam ex = CreateExamFromUser();
            sub.CreateExam(ex);

            Console.WriteLine($"\n{sub}");
            Console.WriteLine($"Exam: {ex.Title}, Time: {ex.Time} min, Questions: {ex.NumOfQuestions}\n");


            foreach (var q in ex.Questions)
            {
                q.ShowQuestion();
                Console.WriteLine($"Correct Answer: {q.RightAnswer.Text}\n");
            }
        }
    }
}
