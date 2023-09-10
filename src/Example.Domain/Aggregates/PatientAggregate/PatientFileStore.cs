using System;
using Volo.Abp.Domain.Entities;

namespace Example.Domain.Aggregates.PatientAggregate;
public class PatientFileStore : Entity<Guid>
{
    public PatientFileStore(Guid patientFileStoreId, Guid patientId, Guid fileId)
    {
        Id = patientFileStoreId;
        PatientId = patientId;
        FileId = fileId;
    }

    public Guid PatientId { get; protected set; }
    public Guid FileId { get; protected set; }

}
