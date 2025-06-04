using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class OptionQuestionConfiguration : IEntityTypeConfiguration<OptionQuestion>
{
    public void Configure(EntityTypeBuilder<OptionQuestion> builder)
    {
        builder.ToTable("option_questions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NumberOption).HasMaxLength(20);
        builder.Property(x => x.CommentOptionRes);
        builder.HasOne(x => x.SubQuestion)
            .WithMany(x => x.OptionQuestions)
            .HasForeignKey(x => x.SubQuestionId);
        builder.HasOne(x => x.CategoryCatalog)
            .WithMany(x => x.OptionQuestions)
            .HasForeignKey(x => x.OptionCatalogId);
        builder.HasMany(x => x.CategoryOptions)
            .WithOne(x => x.OptionQuestion)
            .HasForeignKey(x => x.CatelogOptionsId);
    }
} 