using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CategoryOption
    {
        public long Id { get; set; }
        public long? CatelogOptionsId { get; set; }
        public long? CategoriesOptionsId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public CategoryCatalog? CategoryCatalog { get; set; }
        public OptionQuestion? OptionQuestion { get; set; }    
    }
}