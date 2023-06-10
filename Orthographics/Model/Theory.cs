using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orthographics.Model
{
    public class Theory
    {
        private long theoryId;
        private string chapter;
        private string path;

        private List<Question> questions;

        public Theory(long theoryId, string chapter, string path)
        {
            this.TheoryId = theoryId;
            this.Chapter = chapter;
            this.Path = path;
        }

        public long TheoryId { get => theoryId; set => theoryId = value; }
        public string Chapter { get => chapter; set => chapter = value; }
        public string Path { get => path; set => path = value; }
        internal List<Question> Questions { get => questions; set => questions = value; }
    }
}
