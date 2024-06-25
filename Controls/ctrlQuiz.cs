using Guna.UI2.WinForms;
using Quizes_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using static Quizes_System.clsQuestion;

namespace Quizes_System
{
    public partial class ctrlQuiz : UserControl
    {
        public clsQuestion _QuestionInfo;


        public ctrlQuiz()
        {
            InitializeComponent();
        }

        private void _FillOptionsInRadioButtons()
        {
            List<double> options = clsQuestion.GenerateOptions(_QuestionInfo.RightAnswer);

            if (options.Count >= 4)
            {
                rbOption1.Text = options[0].ToString();
                rbOption2.Text = options[1].ToString();
                rbOption3.Text = options[2].ToString();
                rbOption4.Text = options[3].ToString();
            }
            rbOption1.Checked = false;
            rbOption2.Checked = false;
            rbOption3.Checked = false;
            rbOption4.Checked = false;
        }

        public void LoadQuestion(clsQuestion.enQuestionLevel questionLevel, clsQuestion.enOperationType operationType, int QuestionNumber)
        {
            _PreventCheckedMultipleChoice();
            _QuestionInfo = clsQuestion.GenerateQuestion(questionLevel, operationType);
            lblNum1.Text = _QuestionInfo.Num1.ToString();
            lblNum2.Text = _QuestionInfo.Num2.ToString();
            lblOperation.Text = clsQuestion.GetOperationName(_QuestionInfo.OperationType).ToString();
            lblQuestionNumber.Text = "Q" + QuestionNumber.ToString();
            _FillOptionsInRadioButtons();
        }

        private void AnswerEffects(byte radioButtonTag, clsQuestion.enResult result, bool AddBackColor = true)
        {
            //Here we subtract one from the radioButtonTag because Arrays start with index 0
            radioButtonTag -= 1;

            RadioButton[] radioButtons = { rbOption1, rbOption2, rbOption3, rbOption4 };
            Guna2Panel[] Panels = { pOption1, pOption2, pOption3, pOption4 };
            PictureBox[] PicturesBox = { pbOption1, pbOption2, pbOption3, pbOption4 };


            switch (result)
            {
                case enResult.right:
                    // We will need this variable AddBackColor only to highlight the correct answer without adding BackColor if the answer is wrong and we want to inform the user of the correct answer.
                    if (AddBackColor)
                    {
                        radioButtons[radioButtonTag].BackColor = Color.LightGreen;
                        Panels[radioButtonTag].FillColor = Color.LightGreen;
                    }
                    else
                    {
                        Panels[radioButtonTag].BorderColor = Color.DarkGray;
                    }
                    PicturesBox[radioButtonTag].Image = Resources.correct;
                    break;
                case enResult.wrong:
                    radioButtons[radioButtonTag].BackColor = Color.LightCoral;
                    Panels[radioButtonTag].FillColor = Color.LightCoral;
                    PicturesBox[radioButtonTag].Image = Resources.Wrong;
                    break;
            }
        }

        private byte GetRightOptionTag()
        {
            var CorrectOption = new[] { rbOption1, rbOption2, rbOption3, rbOption4 }
                         .FirstOrDefault(rb => rb.Text == _QuestionInfo.RightAnswer.ToString());

            return (CorrectOption != null) ? Convert.ToByte(CorrectOption.Tag) : (byte)0;
        }

        public bool checkRightAnswer()
        {
            bool RightAnswer = false;
            // here we get the first Option That Selected
            var selectedOption = new[] { rbOption1, rbOption2, rbOption3, rbOption4 }
                .FirstOrDefault(rb => rb.Checked);

            double choice =  0;

            if (selectedOption != null && Double.TryParse(selectedOption.Text, out choice))
            {
                if (choice == _QuestionInfo.RightAnswer)
                {
                    RightAnswer = true;
                    _QuestionInfo.result = clsQuestion.enResult.right;

                }
                else
                {
                    _QuestionInfo.result = clsQuestion.enResult.wrong;
                    AnswerEffects(GetRightOptionTag(), enResult.right, false);
                }
                AnswerEffects(Convert.ToByte(selectedOption.Tag), _QuestionInfo.result);
            }
            else
            {
                AnswerEffects(GetRightOptionTag(), enResult.right, false);
            }
            return RightAnswer;
        }

        private void _PreventCheckedMultipleChoice()
        {
            var radios = new[] { rbOption1, rbOption2, rbOption3, rbOption4 }.OfType<RadioButton>();
            foreach (var radio in radios)
            {
                radio.AutoCheck = false;
                radio.Click += (obj, arg) =>
                {
                    radio.Checked = true;
                    foreach (var r in radios)
                        if (r != radio)
                            r.Checked = false;
                };
            }
        }

    }
}
