using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Chapter
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long SurveyId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? ComponentHtml { get; set; }
        public string? ComponentReact { get; set; }
        public string ChapterNumber { get; set; } = null!;
        public string ChapterTitle { get; set; } = null!;

        public Survey Survey { get; set; } = null!;
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}