using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
{
    public void Configure(EntityTypeBuilder<Survey> builder)
    {
        builder.ToTable("surveys");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(255);
        builder.Property(x => x.ComponentHtml).HasMaxLength(20);
        builder.Property(x => x.ComponentReact).HasMaxLength(20);
        builder.Property(x => x.Description);
        builder.Property(x => x.Instruction);
        builder.HasMany(x => x.Chapters)
            .WithOne(x => x.Survey)
            .HasForeignKey(x => x.SurveyId);
        builder.HasMany(x => x.SumaryOptions)
            .WithOne(x => x.Survey)
            .HasForeignKey(x => x.IdSurvey);
    }
} 