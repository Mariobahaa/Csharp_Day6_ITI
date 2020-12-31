using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    abstract class Question
    {
        public String Head { get;  }

        public decimal Marks { get;  } 

        public bool Answered { get; set; } = false;

        //protected AnswerList Choices { get; }

        public Answer answer { get; }


        public Question(String h, decimal m, String ans){
            Head = h;
            Marks = m;
            answer = new Answer(ans);
        }
    }
}
