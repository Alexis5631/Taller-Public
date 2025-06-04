using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Question
    {
         public long Id { get; set; }
        public long ChapterId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? QuestionNumber { get; set; }
        public string? ResponseType { get; set; }
        public string? CommentQuestion { get; set; }
        public string QuestionText { get; set; } = null!;

        public Chapter Chapter { get; set; } = null!;
        public ICollection<SubQuestion> SubQuestions { get; set; } = new List<SubQuestion>();
        public ICollection<SumaryOption> SumaryOptions { get; set; } = new List<SumaryOption>();
    }
}