using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SumaryOption
    {
         public int Id { get; set; }
        public int IdSurvey { get; set; }
        public string? CodeNumber { get; set; }
        public int IdQuestion { get; set; }
        public string? ValueR { get; set; }

        public Survey Survey { get; set; } = null!;
        public Question Question { get; set; } = null!;
    }
}