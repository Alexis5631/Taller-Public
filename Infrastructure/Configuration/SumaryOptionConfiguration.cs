using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class SumaryOptionConfiguration : IEntityTypeConfiguration<SumaryOption>
{
    public void Configure(EntityTypeBuilder<SumaryOption> builder)
    {
        builder.ToTable("sumaryoptions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CodeNumber).HasMaxLength(20);
        builder.Property(x => x.ValueR);
        builder.HasOne(x => x.Survey)
            .WithMany(x => x.SumaryOptions)
            .HasForeignKey(x => x.IdSurvey);
        builder.HasOne(x => x.Question)
            .WithMany(x => x.SumaryOptions)
            .HasForeignKey(x => x.IdQuestion);
    }
} 