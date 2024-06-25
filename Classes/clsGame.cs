using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quizes_System.clsQuestion;

namespace Quizes_System.Classes
{
    public class clsGame
    {

        public int NumberOfQuestions { get; set; }

        public int NumOfRightAnswer{ get; set; }

        public clsQuestion.enOperationType OperationType;

        public clsQuestion.enQuestionLevel QuestionLevel;

        public int Timer {  get; set; } 


        public clsGame(int numberOfQuestions,  enOperationType operationType, enQuestionLevel questionLevel, int timer)
        {
            NumberOfQuestions = numberOfQuestions;
            this.OperationType = operationType;
            this.QuestionLevel = questionLevel;
            Timer = timer;
        }   
    }
}
