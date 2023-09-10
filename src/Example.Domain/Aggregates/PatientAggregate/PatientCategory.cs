using System;
using Volo.Abp.Domain.Entities;

namespace Example.Domain.Aggregates.PatientAggregate;
public class PatientCategory : Entity<Guid>
{
    public PatientCategory(Guid patientCategoryId, Guid categoryId, Guid patientId)
    {
        Id = patientCategoryId;
        CategoryId = categoryId;
        PatientId = patientId;
    }

    public Guid CategoryId { get; protected set; }
    public Guid PatientId { get; protected set; }
}
