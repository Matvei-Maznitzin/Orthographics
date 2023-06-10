namespace Orthographics.Controls.Quiz
{
    partial class InsertMissingQuiz
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
            this.textQuestionLabel = new System.Windows.Forms.Label();
            this.nameQuestionLabel = new System.Windows.Forms.Label();
            this.questionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(561, 271);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(111, 40);
            this.answerButton.TabIndex = 10;
            this.answerButton.Text = "Ответить";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // textQuestionLabel
            // 
            this.textQuestionLabel.Location = new System.Drawing.Point(23, 52);
            this.textQuestionLabel.Name = "textQuestionLabel";
            this.textQuestionLabel.Size = new System.Drawing.Size(649, 82);
            this.textQuestionLabel.TabIndex = 9;
            this.textQuestionLabel.Text = "Текст вопроса";
            // 
            // nameQuestionLabel
            // 
            this.nameQuestionLabel.AutoSize = true;
            this.nameQuestionLabel.Location = new System.Drawing.Point(23, 18);
            this.nameQuestionLabel.Name = "nameQuestionLabel";
            this.nameQuestionLabel.Size = new System.Drawing.Size(102, 13);
            this.nameQuestionLabel.TabIndex = 8;
            this.nameQuestionLabel.Text = "Название вопроса";
            // 
            // questionFlowLayoutPanel
            // 
            this.questionFlowLayoutPanel.Location = new System.Drawing.Point(26, 137);
            this.questionFlowLayoutPanel.Name = "questionFlowLayoutPanel";
            this.questionFlowLayoutPanel.Size = new System.Drawing.Size(646, 100);
            this.questionFlowLayoutPanel.TabIndex = 11;
            // 
            // InsertMissingQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionFlowLayoutPanel);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.textQuestionLabel);
            this.Controls.Add(this.nameQuestionLabel);
            this.Name = "InsertMissingQuiz";
            this.Size = new System.Drawing.Size(709, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.Label textQuestionLabel;
        private System.Windows.Forms.Label nameQuestionLabel;
        private System.Windows.Forms.FlowLayoutPanel questionFlowLayoutPanel;
    }
}
