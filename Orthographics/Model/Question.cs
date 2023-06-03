using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthographics
{
    internal class Question
    {
        private long questionId;
        private string type;
        private string image;
        private string rank;

        public Question(long questionId, string type, string image, string rank)
        {
            this.QuestionId = questionId;
            this.Type = type;
            this.Image = image;
            this.Rank = rank;
        }

        public long QuestionId { get => questionId; set => questionId = value; }
        public string Type { get => type; set => type = value; }
        public string Image { get => image; set => image = value; }
        public string Rank { get => rank; set => rank = value; }
    }
}
