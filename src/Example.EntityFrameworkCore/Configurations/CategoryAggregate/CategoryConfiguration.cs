using Example.Domain.Aggregates.CategoryAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Example.Configurations.CategoryAggregate;
public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category));  

        builder.Property<Guid>(e => e.Id)
            .ValueGeneratedNever();
        builder.HasKey(e => e.Id);
    }
}
