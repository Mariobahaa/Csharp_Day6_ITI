using System;
using System.Collections.Generic;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {

            TrueFalseQuestion TF = new TrueFalseQuestion("q1head", 1, "q1body");
            ChooseOneQuestion CO = new ChooseOneQuestion("q2head", 2, "q2body");

            PracticeExam PE = new PracticeExam(1.5f, 2, new Question[] { TF, CO }, new Subject("C#", 1));
            FinalExam FE = new FinalExam(1.5f, 2, new Question[] { TF, CO }, new Subject("C#", 1));

            int choice;
            bool parsed;
            do
            {
                parsed = int.TryParse(Console.ReadLine(), out choice);
            } while (!parsed && (choice <= 0 || choice >2));
            if (choice == 1)
                PE.showExam();
            else if (choice == 2)
                FE.showExam();
        }
    }
}
