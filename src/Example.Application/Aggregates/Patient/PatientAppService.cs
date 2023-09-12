using Example.Aggregates.PatientAggregate.DTOs.Patient;
using Example.Aggregates.PatientAggregate.DTOs.Patient.Forms;
using Example.Aggregates.PatientAggregate.Services;
using System;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Example.Aggregates.Patient;
public class PatientAppService : CrudAppService<Domain.Aggregates.PatientAggregate.Patient, PatientDto, Guid, PagedAndSortedResultRequestDto, CreateOrUpdatePatientDto>, IPatientAppService
{
    public PatientAppService(IRepository<Domain.Aggregates.PatientAggregate.Patient, Guid> repository) : base(repository)
    {
    }

    public Task<PatientDto> AdvanceSearchAsync(AdvanceSearchPatientDto advanceSearchPatientDto, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
