using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizes_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlQuiz1.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationType.mix,
                1);
            ctrlQuiz2.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationType.mix,
             2);
            ctrlQuiz3.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationType.mix,
             3);
            ctrlQuiz4.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationType.mix,
             4);
            ctrlQuiz5.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationType.mix,
             5);
            ctrlQuiz6.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationType.mix,
            6);
        }

        private void btnFinishQuiz_Click(object sender, EventArgs e)
        {
            ctrlQuiz1.checkRightAnswer();
            ctrlQuiz2.checkRightAnswer();
            ctrlQuiz3.checkRightAnswer();
            ctrlQuiz4.checkRightAnswer();
            ctrlQuiz5.checkRightAnswer();
            ctrlQuiz6.checkRightAnswer();

        }
    }
}
