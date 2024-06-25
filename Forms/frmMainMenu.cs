using Quizes_System.Forms;
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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private byte _GetValueOfTimer()
        {
            switch( cbTimer.Text )
            {
                case "1:00":
                    return 1;
                case "2:00":
                    return 2;
                case "5:00":
                    return 5;
                case "10:00":
                    return 10;
                case "15:00":
                    return 15;
                case "30:00":
                    return 30;
            };
            return 1;
        }
       
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            clsQuestion.enOperationType Operation = clsQuestion.GetOperationType(cbOperation.Text);
            clsQuestion.enQuestionLevel level = clsQuestion.GetLevel(cbLevel.Text);

            byte Timer = _GetValueOfTimer();

            this.Hide();

            frmStartQuiz Quiz = new frmStartQuiz
                                   (Convert.ToInt32(numaricNumberOfQuestions.Value),
                                   level,Operation, (Timer*60));

            Quiz.ShowDialog();
        }
    }
}
