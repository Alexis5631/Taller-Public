using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.ToTable("questions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.QuestionNumber).HasMaxLength(10);
        builder.Property(x => x.ResponseType).HasMaxLength(10);
        builder.Property(x => x.QuestionText).IsRequired();
        builder.Property(x => x.CommentQuestion);
        builder.HasOne(x => x.Chapter)
            .WithMany(x => x.Questions)
            .HasForeignKey(x => x.ChapterId);
        builder.HasMany(x => x.SubQuestions)
            .WithOne(x => x.Question)
            .HasForeignKey("SubQuestionId");
        builder.HasMany(x => x.SumaryOptions)
            .WithOne(x => x.Question)
            .HasForeignKey(x => x.IdQuestion);
    }
} 