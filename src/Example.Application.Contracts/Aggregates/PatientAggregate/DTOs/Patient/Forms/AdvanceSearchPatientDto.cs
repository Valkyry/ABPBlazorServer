using Example.Enums;

namespace Example.Aggregates.PatientAggregate.DTOs.Patient.Forms;
public record AdvanceSearchPatientDto
{
    public string Person { get; set; }
    public string MRN { get; set; }
    public PatientStatus Status { get; set; }
    public string NationalId { get; set; }
    public string DateOfBirth { get; set; }
}
