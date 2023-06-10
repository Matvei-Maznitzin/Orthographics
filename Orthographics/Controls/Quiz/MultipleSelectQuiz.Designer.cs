namespace Orthographics.Controls
{
    partial class MultipleSelectQuiz
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
            this.answerButton = new System.Windows.Forms.Button();
            this.answersGroupBox = new System.Windows.Forms.GroupBox();
            this.textQuestionLabel = new System.Windows.Forms.Label();
            this.nameQuestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(562, 269);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(111, 40);
            this.answerButton.TabIndex = 7;
            this.answerButton.Text = "Ответить";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answersGroupBox
            // 
            this.answersGroupBox.Location = new System.Drawing.Point(27, 152);
            this.answersGroupBox.Name = "answersGroupBox";
            this.answersGroupBox.Size = new System.Drawing.Size(646, 100);
            this.answersGroupBox.TabIndex = 6;
            this.answersGroupBox.TabStop = false;
            // 
            // textQuestionLabel
            // 
            this.textQuestionLabel.Location = new System.Drawing.Point(24, 50);
            this.textQuestionLabel.Name = "textQuestionLabel";
            this.textQuestionLabel.Size = new System.Drawing.Size(649, 82);
            this.textQuestionLabel.TabIndex = 5;
            this.textQuestionLabel.Text = "Текст вопроса";
            // 
            // nameQuestionLabel
            // 
            this.nameQuestionLabel.AutoSize = true;
            this.nameQuestionLabel.Location = new System.Drawing.Point(24, 17);
            this.nameQuestionLabel.Name = "nameQuestionLabel";
            this.nameQuestionLabel.Size = new System.Drawing.Size(102, 13);
            this.nameQuestionLabel.TabIndex = 4;
            this.nameQuestionLabel.Text = "Название вопроса";
            // 
            // MultipleSelectQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.answersGroupBox);
            this.Controls.Add(this.textQuestionLabel);
            this.Controls.Add(this.nameQuestionLabel);
            this.Name = "MultipleSelectQuiz";
            this.Size = new System.Drawing.Size(702, 333);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.GroupBox answersGroupBox;
        private System.Windows.Forms.Label textQuestionLabel;
        private System.Windows.Forms.Label nameQuestionLabel;
    }
}
