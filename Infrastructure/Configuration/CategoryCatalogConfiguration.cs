using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class CategoryCatalogConfiguration
    {
        public void Configure(EntityTypeBuilder<CategoryCatalog> builder)
        {
            builder.ToTable("categories_catalog");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(255);
            builder.HasMany(x => x.OptionQuestions)
                .WithOne(x => x.CategoryCatalog)
                .HasForeignKey(x => x.OptionCatalogId);
            builder.HasMany(x => x.CategoryOptions)
                .WithOne(x => x.CategoryCatalog)
                .HasForeignKey(x => x.CategoriesOptionsId);
        }
    }
}