using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orthographics.Controls
{
    public partial class MultipleSelectQuiz : UserControl
    {
        Question question;
        public MultipleSelectQuiz(Question question)
        {
            InitializeComponent();
            this.question = question;
            textQuestionLabel.Text = question.Items[0].Text;
            for (int i = 0; i < question.Answers.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Width = 450;
                //checkBox.Height = 50;
                checkBox.Tag = question.Answers[i].Index;
                checkBox.Text = question.Answers[i].Text;
                checkBox.Location = new Point(15, 20 * i + 10);
                answersGroupBox.Controls.Add(checkBox);
            }
        }

        private void answerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
