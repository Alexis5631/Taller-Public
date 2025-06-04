using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class SubQuestionConfiguration : IEntityTypeConfiguration<SubQuestion>
{
    public void Configure(EntityTypeBuilder<SubQuestion> builder)
    {
        builder.ToTable("sub_questions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.SubQuestionNumber).HasMaxLength(10);
        builder.Property(x => x.CommentSubQuestion);
        builder.Property(x => x.SubQuestionText).IsRequired();
        builder.HasMany(x => x.OptionQuestions)
            .WithOne(x => x.SubQuestion)
            .HasForeignKey(x => x.SubQuestionId);
    }
} 