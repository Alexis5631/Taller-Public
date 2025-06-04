using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SubQuestion
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? SubQuestionId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? SubQuestionNumber { get; set; }
        public string? CommentSubQuestion { get; set; }
        public string SubQuestionText { get; set; } = null!;

        public Question? Question { get; set; }
        public ICollection<OptionQuestion> OptionQuestions { get; set; } = new List<OptionQuestion>();
    }
}