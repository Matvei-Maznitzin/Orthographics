using Orthographics.Controls;
using Orthographics.Controls.Quiz;
using Orthographics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Orthographics
{
    public partial class GameControl : UserControl
    {
        Control parent;
        long userId;
        List<Theory> theories;
        int theoryIndex = -1;
        List<Question> currentQuestions = new List<Question>();
        Question currentQuestion;

        public GameControl(Control parent, long userId)
        {
            InitializeComponent();
            this.parent = parent;
            this.userId = userId;
            theories = DataBaseController.GetAllTheory();
            ShowNextStep();
        }

        private void ShowNextStep()
        {
            bool theoryStep = false;
            while (currentQuestions.Count == 0 && theoryIndex < theories.Count)
            {
                theoryIndex++;
                currentQuestions = DataBaseController.GetNextUserQuestions(userId, theories[theoryIndex].TheoryId);
                theoryStep = true;
            }

            this.splitContainer.Panel1.Controls.Clear();
            if (theoryStep)
            {
                TheoryControl tc = new TheoryControl(theories[theoryIndex].Path);
                tc.Dock = DockStyle.Fill;
                tc.Margin = new Padding(10);
                this.splitContainer.Panel1.Controls.Add(tc);
            }
            else
            {
                currentQuestion = currentQuestions.First();
                currentQuestions.Remove(currentQuestion);
                UserControl quiz = null;
                switch (currentQuestion.Type)
                {
                    case "InsertMissing":
                        quiz = new InsertMissingQuiz(currentQuestion);
                        break;
                    case "SingleSelect":
                        quiz = new SingleSelectQuiz(currentQuestion);
                        break;
                    case "MultipleSelect":
                        quiz = new MultipleSelectQuiz(currentQuestion);
                        break;
                }
                quiz.Dock = DockStyle.Fill;
                quiz.Margin = new Padding(10);
                this.splitContainer.Panel1.Controls.Add(quiz);
            }

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            ShowNextStep();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
