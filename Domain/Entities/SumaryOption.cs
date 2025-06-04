using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SumaryOption
    {
        public long Id { get; set; }
        public long IdSurvey { get; set; }
        public string? CodeNumber { get; set; }
        public long IdQuestion { get; set; }
        public string? ValueR { get; set; }

        public Survey Survey { get; set; } = null!;
        public Question Question { get; set; } = null!;
    }
}