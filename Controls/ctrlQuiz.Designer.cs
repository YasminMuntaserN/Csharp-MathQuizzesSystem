using Guna.UI2.WinForms.Suite;
using System.Drawing;
using System.Windows.Forms;

namespace Quizes_System
{
    partial class ctrlQuiz
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.pOption4 = new Guna.UI2.WinForms.Guna2Panel();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.pbOption4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pOption3 = new Guna.UI2.WinForms.Guna2Panel();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.pbOption3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pOption2 = new Guna.UI2.WinForms.Guna2Panel();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.pbOption2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pOption1 = new Guna.UI2.WinForms.Guna2Panel();
            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.pbOption1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pOption4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption4)).BeginInit();
            this.pOption3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption3)).BeginInit();
            this.pOption2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption2)).BeginInit();
            this.pOption1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNum1.Location = new System.Drawing.Point(34, 42);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(62, 37);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "500";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNum2.Location = new System.Drawing.Point(117, 42);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(61, 37);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "700";
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblOperation.Location = new System.Drawing.Point(84, 42);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(36, 37);
            this.lblOperation.TabIndex = 2;
            this.lblOperation.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(173, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = " =";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 15.8F, System.Drawing.FontStyle.Bold);
            this.lblQuestionNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestionNumber.Location = new System.Drawing.Point(-1, -1);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(63, 37);
            this.lblQuestionNumber.TabIndex = 4;
            this.lblQuestionNumber.Text = "Q12";
            // 
            // pOption4
            // 
            this.pOption4.AutoRoundedCorners = true;
            this.pOption4.BackColor = System.Drawing.Color.Transparent;
            this.pOption4.BorderColor = System.Drawing.Color.Transparent;
            this.pOption4.BorderRadius = 20;
            this.pOption4.BorderThickness = 2;
            this.pOption4.Controls.Add(this.rbOption4);
            this.pOption4.Controls.Add(this.pbOption4);
            this.pOption4.Location = new System.Drawing.Point(3, 220);
            this.pOption4.Name = "pOption4";
            this.pOption4.Size = new System.Drawing.Size(244, 42);
            this.pOption4.TabIndex = 28;
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.BackColor = System.Drawing.Color.Transparent;
            this.rbOption4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption4.Location = new System.Drawing.Point(8, 4);
            this.rbOption4.Name = "rbOption4";
            this.rbOption4.Size = new System.Drawing.Size(118, 35);
            this.rbOption4.TabIndex = 11;
            this.rbOption4.TabStop = true;
            this.rbOption4.Tag = "4";
            this.rbOption4.Text = "Option4";
            this.rbOption4.UseVisualStyleBackColor = false;
            // 
            // pbOption4
            // 
            this.pbOption4.BackColor = System.Drawing.Color.Transparent;
            this.pbOption4.FillColor = System.Drawing.Color.Transparent;
            this.pbOption4.ImageRotate = 0F;
            this.pbOption4.Location = new System.Drawing.Point(181, 4);
            this.pbOption4.Name = "pbOption4";
            this.pbOption4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbOption4.Size = new System.Drawing.Size(44, 32);
            this.pbOption4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOption4.TabIndex = 10;
            this.pbOption4.TabStop = false;
            // 
            // pOption3
            // 
            this.pOption3.AutoRoundedCorners = true;
            this.pOption3.BackColor = System.Drawing.Color.Transparent;
            this.pOption3.BorderColor = System.Drawing.Color.Transparent;
            this.pOption3.BorderRadius = 20;
            this.pOption3.BorderThickness = 2;
            this.pOption3.Controls.Add(this.rbOption3);
            this.pOption3.Controls.Add(this.pbOption3);
            this.pOption3.Location = new System.Drawing.Point(3, 175);
            this.pOption3.Name = "pOption3";
            this.pOption3.Size = new System.Drawing.Size(244, 42);
            this.pOption3.TabIndex = 27;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.BackColor = System.Drawing.Color.Transparent;
            this.rbOption3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption3.Location = new System.Drawing.Point(8, 4);
            this.rbOption3.Name = "rbOption3";
            this.rbOption3.Size = new System.Drawing.Size(118, 35);
            this.rbOption3.TabIndex = 11;
            this.rbOption3.TabStop = true;
            this.rbOption3.Tag = "3";
            this.rbOption3.Text = "Option3";
            this.rbOption3.UseVisualStyleBackColor = false;
            // 
            // pbOption3
            // 
            this.pbOption3.BackColor = System.Drawing.Color.Transparent;
            this.pbOption3.FillColor = System.Drawing.Color.Transparent;
            this.pbOption3.ImageRotate = 0F;
            this.pbOption3.Location = new System.Drawing.Point(181, 4);
            this.pbOption3.Name = "pbOption3";
            this.pbOption3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbOption3.Size = new System.Drawing.Size(44, 32);
            this.pbOption3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOption3.TabIndex = 10;
            this.pbOption3.TabStop = false;
            // 
            // pOption2
            // 
            this.pOption2.AutoRoundedCorners = true;
            this.pOption2.BackColor = System.Drawing.Color.Transparent;
            this.pOption2.BorderColor = System.Drawing.Color.Transparent;
            this.pOption2.BorderRadius = 20;
            this.pOption2.BorderThickness = 2;
            this.pOption2.Controls.Add(this.rbOption2);
            this.pOption2.Controls.Add(this.pbOption2);
            this.pOption2.Location = new System.Drawing.Point(3, 127);
            this.pOption2.Name = "pOption2";
            this.pOption2.Size = new System.Drawing.Size(244, 42);
            this.pOption2.TabIndex = 26;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.BackColor = System.Drawing.Color.Transparent;
            this.rbOption2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption2.Location = new System.Drawing.Point(8, 4);
            this.rbOption2.Name = "rbOption2";
            this.rbOption2.Size = new System.Drawing.Size(118, 35);
            this.rbOption2.TabIndex = 11;
            this.rbOption2.TabStop = true;
            this.rbOption2.Tag = "2";
            this.rbOption2.Text = "Option2";
            this.rbOption2.UseVisualStyleBackColor = false;
            // 
            // pbOption2
            // 
            this.pbOption2.BackColor = System.Drawing.Color.Transparent;
            this.pbOption2.FillColor = System.Drawing.Color.Transparent;
            this.pbOption2.ImageRotate = 0F;
            this.pbOption2.Location = new System.Drawing.Point(181, 4);
            this.pbOption2.Name = "pbOption2";
            this.pbOption2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbOption2.Size = new System.Drawing.Size(44, 32);
            this.pbOption2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOption2.TabIndex = 10;
            this.pbOption2.TabStop = false;
            // 
            // pOption1
            // 
            this.pOption1.AutoRoundedCorners = true;
            this.pOption1.BackColor = System.Drawing.Color.Transparent;
            this.pOption1.BorderColor = System.Drawing.Color.Transparent;
            this.pOption1.BorderRadius = 20;
            this.pOption1.BorderThickness = 2;
            this.pOption1.Controls.Add(this.rbOption1);
            this.pOption1.Controls.Add(this.pbOption1);
            this.pOption1.Location = new System.Drawing.Point(3, 82);
            this.pOption1.Name = "pOption1";
            this.pOption1.Size = new System.Drawing.Size(244, 42);
            this.pOption1.TabIndex = 25;
            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.BackColor = System.Drawing.Color.Transparent;
            this.rbOption1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOption1.Location = new System.Drawing.Point(8, 3);
            this.rbOption1.Name = "rbOption1";
            this.rbOption1.Size = new System.Drawing.Size(118, 35);
            this.rbOption1.TabIndex = 12;
            this.rbOption1.TabStop = true;
            this.rbOption1.Tag = "1";
            this.rbOption1.Text = "Option1";
            this.rbOption1.UseVisualStyleBackColor = false;
            // 
            // pbOption1
            // 
            this.pbOption1.BackColor = System.Drawing.Color.Transparent;
            this.pbOption1.FillColor = System.Drawing.Color.Transparent;
            this.pbOption1.ImageRotate = 0F;
            this.pbOption1.Location = new System.Drawing.Point(181, 4);
            this.pbOption1.Name = "pbOption1";
            this.pbOption1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbOption1.Size = new System.Drawing.Size(44, 32);
            this.pbOption1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOption1.TabIndex = 10;
            this.pbOption1.TabStop = false;
            // 
            // ctrlQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pOption4);
            this.Controls.Add(this.pOption3);
            this.Controls.Add(this.pOption2);
            this.Controls.Add(this.pOption1);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "ctrlQuiz";
            this.Size = new System.Drawing.Size(245, 292);
            this.pOption4.ResumeLayout(false);
            this.pOption4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption4)).EndInit();
            this.pOption3.ResumeLayout(false);
            this.pOption3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption3)).EndInit();
            this.pOption2.ResumeLayout(false);
            this.pOption2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption2)).EndInit();
            this.pOption1.ResumeLayout(false);
            this.pOption1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestionNumber;
        private Guna.UI2.WinForms.Guna2Panel pOption4;
        private RadioButton rbOption4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbOption4;
        private Guna.UI2.WinForms.Guna2Panel pOption3;
        private RadioButton rbOption3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbOption3;
        private Guna.UI2.WinForms.Guna2Panel pOption2;
        private RadioButton rbOption2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbOption2;
        private Guna.UI2.WinForms.Guna2Panel pOption1;
        private RadioButton rbOption1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbOption1;
    }
}
