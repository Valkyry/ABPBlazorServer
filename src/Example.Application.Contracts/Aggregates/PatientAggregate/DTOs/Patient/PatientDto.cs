using Example.Enums;
using System;
using Volo.Abp.Application.Dtos;

namespace Example.Aggregates.PatientAggregate.DTOs.Patient;
public class PatientDto : EntityDto<Guid>
{
    public string MRN { get; set; }
    public PatientStatus Status { get; set; }
    public string Person { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalId { get; set; }
    public string AlternateIdNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Guid CategoryId { get; set; }
    public string AvatarUrl { get; set; }
}
