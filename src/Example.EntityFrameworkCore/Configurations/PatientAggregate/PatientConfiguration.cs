using Example.Domain.Aggregates.PatientAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Example.Configurations.PatientAggregate;
public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.ToTable(nameof(Patient));

        builder.Property<Guid>(e => e.Id)
            .ValueGeneratedNever();
        builder.HasKey(e => e.Id);

        builder.HasOne(row => row.Category)
            .WithOne(row => row.Patient)
            .HasForeignKey<Patient>(row => row.CategoryId)
            .IsRequired(false);

        builder.HasMany(row => row.FileStores)
            .WithOne()
            .HasForeignKey(row => row.PatientId)
            .OnDelete(DeleteBehavior.Cascade)
            .Metadata.PrincipalToDependent.SetPropertyAccessMode(PropertyAccessMode.Field);

        builder.HasIndex(row => row.NationalId);
        builder.HasIndex(row => row.CategoryId);
    }
}
