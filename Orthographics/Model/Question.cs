using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthographics
{
    public class Question
    {
        private long questionId;
        private string type;
        private string image;
        private double rank;
        private List<Answer> answers = new List<Answer>();
        private List<QuestionItem> items = new List<QuestionItem>();

        public Question(long questionId, string type, string image, double rank)
        {
            this.QuestionId = questionId;
            this.Type = type;
            this.Image = image;
            this.Rank = rank;
        }

        public long QuestionId { get => questionId; set => questionId = value; }
        public string Type { get => type; set => type = value; }
        public string Image { get => image; set => image = value; }
        public double Rank { get => rank; set => rank = value; }
        public List<Answer> Answers { get => answers; set => answers = value; }
        public List<QuestionItem> Items { get => items; set => items = value; }
    }
}
