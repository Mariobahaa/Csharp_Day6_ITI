﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class FinalExam : Exam
    {
        

        public override void showExam()
        {
            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.WriteLine($"Question {i}:");
                Console.WriteLine($"{questions[i].Head} ({questions[i].Marks} marks)");
               
                Console.WriteLine("");
            }

        }

        public FinalExam(float t, int n, Question[] q, Subject s) : base(t, n, q, s)
        {
            ;
        }
    }
}