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
            ctrlQuiz1.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationTypeType.mix,
                1);
            ctrlQuiz2.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationTypeType.mix,
             2);
            ctrlQuiz3.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationTypeType.mix,
             3);
            ctrlQuiz4.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationTypeType.mix,
             4);
            ctrlQuiz5.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationTypeType.mix,
             5);
            ctrlQuiz6.LoadQuestion(clsQuestion.enQuestionLevel.Mix, clsQuestion.enOperationTypeType.mix,
            6);
        }
    }
}
