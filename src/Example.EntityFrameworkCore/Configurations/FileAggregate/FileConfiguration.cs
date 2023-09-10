using Example.Domain.Aggregates.FileAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Example.Configurations.FileAggregate;
public class FileConfiguration : IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.ToTable(nameof(File));

        builder.Property<Guid>(e => e.Id)
            .ValueGeneratedNever();
        builder.HasKey(e => e.Id);
    }
}
