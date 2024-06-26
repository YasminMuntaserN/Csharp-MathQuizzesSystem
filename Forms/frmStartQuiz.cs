using Guna.UI.WinForms;
using Quizes_System.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quizes_System.clsQuestion;

namespace Quizes_System.Forms
{
    public partial class frmStartQuiz : Form
    {
        private clsGame _GameInfo;

        public Dictionary<ctrlQuiz, int> Questions = new Dictionary<ctrlQuiz, int>();

        private int _NumberOfQuestions;

        private bool _timerFinished = false;

        public int NumberOfCorrectAnswers = 0;

        public frmStartQuiz(int numberOfQuestions, clsQuestion.enQuestionLevel Level, clsQuestion.enOperationType operationType, int Time)
        {
            _GameInfo = new clsGame(numberOfQuestions, operationType, Level, Time);
            _NumberOfQuestions = numberOfQuestions;
            InitializeComponent();
        }

        private ctrlQuiz _CreateEtchQuestion(int questionNumber)
        {
            ctrlQuiz Question = new ctrlQuiz();

            Question.LoadQuestion(_GameInfo.QuestionLevel, _GameInfo.OperationType, questionNumber);

            return Question;
        }

        private void _GeneratQuestions()
        {
            flpQuestions.Controls.Clear();
            int QuestionNumber = 1;
            ctrlQuiz question;
            for (int i = 0; i < _NumberOfQuestions; i++)
            {
                QuestionNumber = i + 1;
                question = _CreateEtchQuestion(QuestionNumber);

                Questions.Add(question, QuestionNumber);

                flpQuestions.Controls.Add(question);
            }
        }

        private void ResultMessageBox(int RightAnswer)
        {
            if (RightAnswer > _GameInfo.NumberOfQuestions / 2)
            {
                MessageBox.Show($"Great! You got {RightAnswer} / {_GameInfo.NumberOfQuestions} , Well done !", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"You didn't do well in this Quiz! You got {RightAnswer} / {_GameInfo.NumberOfQuestions} , Failed !", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FinishQuiz()
        {

            foreach (var kvp in Questions)
            {
                if (kvp.Key.checkRightAnswer()) NumberOfCorrectAnswers++;
            }

            lblScoure.Text = NumberOfCorrectAnswers.ToString();

            if (!(NumberOfCorrectAnswers > NumberOfCorrectAnswers / 2))
            {
                lblScoure.ForeColor = Color.Red;
            }

            ResultMessageBox(NumberOfCorrectAnswers);

            EndGame();

        }

        private void EndGame()
        {
            // Iterate over all controls in the FlowLayoutPanel
            foreach (Control control in flpQuestions.Controls)
            {
                if (control is ctrlQuiz)
                {
                    // Disable all radio buttons in the panels within the QuestionControl
                    foreach (Control panel in control.Controls)
                    {
                        if (panel is Panel)
                        {
                            foreach (Control radioButton in panel.Controls)
                            {
                                if (radioButton is RadioButton)
                                {
                                    radioButton.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }

        }

        private void btnFinishQuiz_Click(object sender, EventArgs e)
        {
            quizTimer.Stop();
            _timerFinished = true;
            FinishQuiz();
        }

        private void frmStartQuiz_Load(object sender, EventArgs e)
        {
            lblNumOfQuestion.Text = _NumberOfQuestions.ToString();
            _GeneratQuestions();

            if (_GameInfo.Timer > 0)
            {
                quizTimer.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid time in seconds.");
            }

            quizTimer.Interval = 1000; // 1 second intervals
            quizTimer.Tick += QuizTimer_Tick;
            quizTimer.Start();
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            if (_GameInfo.Timer > 0)
            {
                // Decrement the remaining time by 1 second
                _GameInfo.Timer--;

                //  display  the remaining time with time format
                TimeSpan timeSpan = TimeSpan.FromSeconds(_GameInfo.Timer);
                lblTimer.Text = timeSpan.ToString(@"mm\:ss");
            }
            else
            {
                quizTimer.Stop();
                _timerFinished = true;
                MessageBox.Show("Time's up!");
                FinishQuiz();
            }
        }

        private void btnReturnMaiMenu_Click(object sender, EventArgs e)
        {
            if (btnFinishQuiz.Checked || _timerFinished)
            {
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
                this.Hide();
                return;
            }
            if (MessageBox.Show("Are you sure you want to exit the quiz? Your answers will be lost.",
                "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                quizTimer.Stop();
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmMainMenu.Show();
                this.Hide();
            }
        }
    }
}
