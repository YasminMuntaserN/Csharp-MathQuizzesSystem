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
            if (RightAnswer >= _GameInfo.NumberOfQuestions)
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
                kvp.Key.checkRightAnswer();
            }
            lblScoure.Text = ctrlQuiz.Source.ToString();

            ResultMessageBox(ctrlQuiz.Source);

        }

        private void btnFinishQuiz_Click(object sender, EventArgs e) => FinishQuiz();

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

                MessageBox.Show("Time's up!");
                FinishQuiz();
            }
        }
    }
}
