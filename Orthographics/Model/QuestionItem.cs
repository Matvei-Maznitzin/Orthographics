using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthographics
{
    public class QuestionItem
    {
        private long itemId;
        private string text;
        private int index;
        private Question question;

        public QuestionItem(long itemId, string text, int index)
        {
            this.ItemId = itemId;
            this.Text = text;
            this.Index = index;
        }

        public long ItemId { get => itemId; set => itemId = value; }
        public string Text { get => text; set => text = value; }
        public int Index { get => index; set => index = value; }
        internal Question Question { get => question; set => question = value; }
    }
}
