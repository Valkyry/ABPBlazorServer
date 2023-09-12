using Example.Aggregates.PatientAggregate.DTOs.Patient;
using Example.Aggregates.PatientAggregate.DTOs.Patient.Forms;
using System;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Example.Aggregates.PatientAggregate.Services;
public interface IPatientAppService : ICrudAppService<PatientDto, Guid, PagedAndSortedResultRequestDto, CreateOrUpdatePatientDto>
{
    Task<PatientDto> AdvanceSearchAsync(AdvanceSearchPatientDto advanceSearchPatientDto, CancellationToken cancellationToken);
}
