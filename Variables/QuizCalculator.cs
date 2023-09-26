using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Variables.Question_4
{
    internal class QuizCalculator
    {
        static int quiz_1;
        static int quiz_2;
        static int quiz_3;
        static int quiz_4;
        static int quiz_5;

        static int average;
        static void Main(string[] args)
        {
            Random random = new Random();
            quiz_1 = random.Next(0, 10);
            quiz_2 = random.Next(0, 10);
            quiz_3 = random.Next(0, 10);
            quiz_4 = random.Next(0, 10);
            quiz_5 = random.Next(0, 10);

            average = (quiz_1 + quiz_2 + quiz_3 + quiz_4 + quiz_5) / 5;

            Console.WriteLine("Quiz_1 : {0}, Quiz_2 : {1}, Quiz_3 : {2}, Quiz_4 : {3}, Quiz_5 : {4} ", quiz_1, quiz_2, quiz_3, quiz_4, quiz_5);
            Console.WriteLine("The Average is : {0}", average);

            Console.ReadLine();
        }
    }
}
