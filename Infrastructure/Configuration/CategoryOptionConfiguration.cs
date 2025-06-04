using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class CategoryOptionConfiguration : IEntityTypeConfiguration<CategoryOption>
    {
        public void Configure(EntityTypeBuilder<CategoryOption> builder)
        {
            builder.ToTable("category_options");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.CategoryCatalog)
                .WithMany(x => x.CategoryOptions)
                .HasForeignKey(x => x.CategoriesOptionsId);
            builder.HasOne(x => x.OptionQuestion)
                .WithMany(x => x.CategoryOptions)
                .HasForeignKey(x => x.CatelogOptionsId);
        }
    }
}