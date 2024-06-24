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
    public partial class ctrlQuiz : UserControl
    {
        private clsQuestion _QuestionInfo;

        public ctrlQuiz()
        {
            InitializeComponent();
        }

        private void _FillOptionsInRadioButtons()
        {
            List<int> options = clsQuestion.GenerateOptions(_QuestionInfo.RightAnswer);

            if (options.Count >= 4)
            {
                rbOption1.Text = options[0].ToString();
                rbOption2.Text = options[1].ToString();
                rbOption3.Text = options[2].ToString();
                rbOption4.Text = options[3].ToString();
            }
        }

        public void LoadQuestion(clsQuestion.enQuestionLevel questionLevel ,clsQuestion.enOperationTypeType operationType ,int QuestionNumber)
        {
            _QuestionInfo = clsQuestion.GenerateQuestion(questionLevel, operationType);
            lblNum1.Text= _QuestionInfo.Num1.ToString();
            lblNum2.Text = _QuestionInfo.Num2.ToString();
            lblOperation.Text = clsQuestion.GetOperationName(_QuestionInfo.OperationType).ToString();
            lblQuestionNumber.Text = "Q"+QuestionNumber.ToString();
            _FillOptionsInRadioButtons();
        }
    }
}
