using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class ChapterConfiguration : IEntityTypeConfiguration<Chapter>
{
    public void Configure(EntityTypeBuilder<Chapter> builder)
    {
        builder.ToTable("chapters");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ChapterNumber).HasMaxLength(50);
        builder.Property(x => x.ChapterTitle).IsRequired();
        builder.Property(x => x.ComponentHtml).HasMaxLength(20);
        builder.Property(x => x.ComponentReact).HasMaxLength(20);
        builder.HasOne(x => x.Survey)
            .WithMany(x => x.Chapters)
            .HasForeignKey(x => x.SurveyId);
        builder.HasMany(x => x.Questions)
            .WithOne(x => x.Chapter)
            .HasForeignKey(x => x.ChapterId);
    }
} 