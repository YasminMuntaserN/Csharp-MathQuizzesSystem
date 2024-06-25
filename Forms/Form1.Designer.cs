namespace Quizes_System
{
    partial class Form1
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
            this.btnFinishQuiz = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ctrlQuiz6 = new Quizes_System.ctrlQuiz();
            this.ctrlQuiz5 = new Quizes_System.ctrlQuiz();
            this.ctrlQuiz4 = new Quizes_System.ctrlQuiz();
            this.ctrlQuiz3 = new Quizes_System.ctrlQuiz();
            this.ctrlQuiz2 = new Quizes_System.ctrlQuiz();
            this.ctrlQuiz1 = new Quizes_System.ctrlQuiz();
            this.SuspendLayout();
            // 
            // btnFinishQuiz
            // 
            this.btnFinishQuiz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinishQuiz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinishQuiz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinishQuiz.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinishQuiz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinishQuiz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinishQuiz.ForeColor = System.Drawing.Color.White;
            this.btnFinishQuiz.Location = new System.Drawing.Point(827, 93);
            this.btnFinishQuiz.Name = "btnFinishQuiz";
            this.btnFinishQuiz.Size = new System.Drawing.Size(180, 45);
            this.btnFinishQuiz.TabIndex = 6;
            this.btnFinishQuiz.Text = "Finsh Quiz";
            this.btnFinishQuiz.Click += new System.EventHandler(this.btnFinishQuiz_Click);
            // 
            // ctrlQuiz6
            // 
            this.ctrlQuiz6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlQuiz6.Location = new System.Drawing.Point(578, 312);
            this.ctrlQuiz6.Name = "ctrlQuiz6";
            this.ctrlQuiz6.Size = new System.Drawing.Size(243, 272);
            this.ctrlQuiz6.TabIndex = 5;
            // 
            // ctrlQuiz5
            // 
            this.ctrlQuiz5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlQuiz5.Location = new System.Drawing.Point(293, 324);
            this.ctrlQuiz5.Name = "ctrlQuiz5";
            this.ctrlQuiz5.Size = new System.Drawing.Size(243, 268);
            this.ctrlQuiz5.TabIndex = 4;
            // 
            // ctrlQuiz4
            // 
            this.ctrlQuiz4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlQuiz4.Location = new System.Drawing.Point(12, 324);
            this.ctrlQuiz4.Name = "ctrlQuiz4";
            this.ctrlQuiz4.Size = new System.Drawing.Size(243, 268);
            this.ctrlQuiz4.TabIndex = 3;
            // 
            // ctrlQuiz3
            // 
            this.ctrlQuiz3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlQuiz3.Location = new System.Drawing.Point(578, 0);
            this.ctrlQuiz3.Name = "ctrlQuiz3";
            this.ctrlQuiz3.Size = new System.Drawing.Size(243, 265);
            this.ctrlQuiz3.TabIndex = 2;
            // 
            // ctrlQuiz2
            // 
            this.ctrlQuiz2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlQuiz2.Location = new System.Drawing.Point(293, 0);
            this.ctrlQuiz2.Name = "ctrlQuiz2";
            this.ctrlQuiz2.Size = new System.Drawing.Size(243, 265);
            this.ctrlQuiz2.TabIndex = 1;
            // 
            // ctrlQuiz1
            // 
            this.ctrlQuiz1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlQuiz1.Location = new System.Drawing.Point(12, 0);
            this.ctrlQuiz1.Name = "ctrlQuiz1";
            this.ctrlQuiz1.Size = new System.Drawing.Size(243, 265);
            this.ctrlQuiz1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 640);
            this.Controls.Add(this.btnFinishQuiz);
            this.Controls.Add(this.ctrlQuiz6);
            this.Controls.Add(this.ctrlQuiz5);
            this.Controls.Add(this.ctrlQuiz4);
            this.Controls.Add(this.ctrlQuiz3);
            this.Controls.Add(this.ctrlQuiz2);
            this.Controls.Add(this.ctrlQuiz1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlQuiz ctrlQuiz1;
        private ctrlQuiz ctrlQuiz2;
        private ctrlQuiz ctrlQuiz3;
        private ctrlQuiz ctrlQuiz4;
        private ctrlQuiz ctrlQuiz5;
        private ctrlQuiz ctrlQuiz6;
        private Guna.UI2.WinForms.Guna2GradientButton btnFinishQuiz;
    }
}

