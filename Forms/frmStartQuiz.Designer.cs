namespace Quizes_System.Forms
{
    partial class frmStartQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.flpQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScoure = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblNumOfQuestion = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnFinishQuiz = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReturnMaiMenu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(10, -3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1413, 69);
            this.lblTitle.TabIndex = 333;
            this.lblTitle.Text = "Math Quiz ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpQuestions
            // 
            this.flpQuestions.AutoScroll = true;
            this.flpQuestions.Location = new System.Drawing.Point(22, 153);
            this.flpQuestions.Name = "flpQuestions";
            this.flpQuestions.Size = new System.Drawing.Size(1368, 514);
            this.flpQuestions.TabIndex = 0;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Location = new System.Drawing.Point(107, 101);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(128, 40);
            this.lblTimer.TabIndex = 335;
            this.lblTimer.Text = "00 : 00";
            // 
            // lblScoure
            // 
            this.lblScoure.AutoSize = true;
            this.lblScoure.BackColor = System.Drawing.Color.Transparent;
            this.lblScoure.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblScoure.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblScoure.Location = new System.Drawing.Point(1142, 100);
            this.lblScoure.Name = "lblScoure";
            this.lblScoure.Size = new System.Drawing.Size(36, 41);
            this.lblScoure.TabIndex = 337;
            this.lblScoure.Text = "0";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(1166, 100);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(59, 41);
            this.gunaLabel1.TabIndex = 338;
            this.gunaLabel1.Text = " / ";
            // 
            // lblNumOfQuestion
            // 
            this.lblNumOfQuestion.AutoSize = true;
            this.lblNumOfQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfQuestion.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumOfQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfQuestion.Location = new System.Drawing.Point(1207, 100);
            this.lblNumOfQuestion.Name = "lblNumOfQuestion";
            this.lblNumOfQuestion.Size = new System.Drawing.Size(67, 41);
            this.lblNumOfQuestion.TabIndex = 339;
            this.lblNumOfQuestion.Text = " 20";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(932, 101);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(204, 40);
            this.gunaLabel2.TabIndex = 334;
            this.gunaLabel2.Text = "Your Result :";
            // 
            // btnFinishQuiz
            // 
            this.btnFinishQuiz.BorderRadius = 20;
            this.btnFinishQuiz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinishQuiz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinishQuiz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinishQuiz.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinishQuiz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinishQuiz.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishQuiz.ForeColor = System.Drawing.Color.White;
            this.btnFinishQuiz.Location = new System.Drawing.Point(795, 716);
            this.btnFinishQuiz.Name = "btnFinishQuiz";
            this.btnFinishQuiz.Size = new System.Drawing.Size(188, 53);
            this.btnFinishQuiz.TabIndex = 340;
            this.btnFinishQuiz.Text = "Finish Quiz";
            this.btnFinishQuiz.Click += new System.EventHandler(this.btnFinishQuiz_Click);
            // 
            // btnReturnMaiMenu
            // 
            this.btnReturnMaiMenu.BorderRadius = 20;
            this.btnReturnMaiMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturnMaiMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturnMaiMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturnMaiMenu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturnMaiMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturnMaiMenu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMaiMenu.ForeColor = System.Drawing.Color.White;
            this.btnReturnMaiMenu.Location = new System.Drawing.Point(1000, 716);
            this.btnReturnMaiMenu.Name = "btnReturnMaiMenu";
            this.btnReturnMaiMenu.Size = new System.Drawing.Size(274, 51);
            this.btnReturnMaiMenu.TabIndex = 341;
            this.btnReturnMaiMenu.Text = "Return to Main Menu";
            this.btnReturnMaiMenu.Click += new System.EventHandler(this.btnReturnMaiMenu_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(35, 66);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1346, 31);
            this.guna2Separator1.TabIndex = 342;
            // 
            // frmStartQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 773);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnReturnMaiMenu);
            this.Controls.Add(this.btnFinishQuiz);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.lblNumOfQuestion);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblScoure);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.flpQuestions);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmStartQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Quiz";
            this.Load += new System.EventHandler(this.frmStartQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpQuestions;
        private System.Windows.Forms.Label lblTimer;
        private Guna.UI.WinForms.GunaLabel lblScoure;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblNumOfQuestion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnFinishQuiz;
        private Guna.UI2.WinForms.Guna2GradientButton btnReturnMaiMenu;
        private System.Windows.Forms.Timer quizTimer;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}