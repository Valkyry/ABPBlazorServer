using Example.Domain.Aggregates.PatientAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Example.Configurations.PatientAggregate;
public class PatientFileStoreConfiguration : IEntityTypeConfiguration<PatientFileStore>
{
    public void Configure(EntityTypeBuilder<PatientFileStore> builder)
    {
        builder.ToTable(nameof(PatientFileStore));

        builder.Property<Guid>(e => e.Id)
            .ValueGeneratedNever();
        builder.HasKey(e => e.Id);


        builder.HasIndex(row => row.FileId);
        builder.HasIndex(row => row.PatientId);
    }
}
