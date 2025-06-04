using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OptionQuestion
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? OptionId { get; set; }
        public long? OptionCatalogId { get; set; }
        public long? OptionQuestionId { get; set; }
        public long? SubQuestionId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? CommentOptionRes { get; set; }
        public string? NumberOption { get; set; }

        public SubQuestion? SubQuestion { get; set; }
        public CategoryCatalog? CategoryCatalog { get; set; }
        public ICollection<CategoryOption> CategoryOptions { get; set; } = new List<CategoryOption>(); 
    }
}