using Example.Enums;
using System;

namespace Example.Aggregates.PatientAggregate.DTOs.Patient;
public record PatientDto
{

    public Guid Id { get; set; }
    public string Person { get; set; }
    public string MRN { get; set; }
    public PatientStatus Status { get; set; }
    public string NationalId { get; set; }
    public string DateOfBirth { get; set; }
}
