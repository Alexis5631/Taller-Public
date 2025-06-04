using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CategoryCatalog
    {
         public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<OptionQuestion> OptionQuestions { get; set; } = new List<OptionQuestion>();
        public ICollection<CategoryOption> CategoryOptions { get; set; } = new List<CategoryOption>();
    }
}