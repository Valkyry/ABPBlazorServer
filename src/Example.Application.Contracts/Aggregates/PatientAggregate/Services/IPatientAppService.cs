using Example.Aggregates.PatientAggregate.DTOs.Patient;
using Example.Aggregates.PatientAggregate.DTOs.Patient.Forms;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Example.Aggregates.PatientAggregate.Services;
public interface IPatientAppService : IApplicationService
{
    Task<Guid> RegisterAsync(RegisterPatientDto dto, CancellationToken cancellationToken);
    Task UpdateAsync(UpdatePatientDto dto, CancellationToken cancellationToken);
    Task<PatientDto> GetAsync(Guid id, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    Task<List<PatientDto>> GetAllAsync(CancellationToken cancellationToken);
}
