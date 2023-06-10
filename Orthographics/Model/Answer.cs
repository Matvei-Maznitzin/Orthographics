using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthographics
{
    public class Answer
    {
        private long answerId;
        private string text;
        private bool isCorrect;
        private int index;
        private Question question;

        public Answer(long answerId, string text, bool isCorrect, int index)
        {
            this.answerId = answerId;
            this.text = text;
            this.isCorrect = isCorrect;
            this.index = index;
        }

        public long AnswerId { get => answerId; set => answerId = value; }
        public string Text { get => text; set => text = value; }
        public bool IsCorrect { get => isCorrect; set => isCorrect = value; }
        public int Index { get => index; set => index = value; }
        internal Question Question { get => question; set => question = value; }
    }
}
