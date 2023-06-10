using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orthographics.Controls.Quiz
{
    public partial class InsertMissingQuiz : UserControl
    {
        Question question;
        public InsertMissingQuiz(Question question)
        {
            InitializeComponent();
            this.question = question;
            textQuestionLabel.Text = question.Items[0].Text;
            for (int i = 1; i < question.Items.Count; i++)
            {
                Label label = new Label();
                TextBox textBox = new TextBox();
                textBox.Tag = question.Items[i].Index;
                label.Text = question.Items[i].Text;
                label.Tag = question.Items[i].Index;
                questionFlowLayoutPanel.Controls.Add(label);
                if (i < question.Items.Count - 1)
                    questionFlowLayoutPanel.Controls.Add(textBox);
            }
        }

        private void answerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
