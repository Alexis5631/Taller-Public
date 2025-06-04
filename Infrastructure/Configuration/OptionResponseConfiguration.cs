using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class OptionResponseConfiguration : IEntityTypeConfiguration<OptionResponse>
{
    public void Configure(EntityTypeBuilder<OptionResponse> builder)
    {
        builder.ToTable("options_response");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.OptionText);
    }
} 