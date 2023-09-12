using Example.Domain.Aggregates.PatientAggregate;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Example.Aggregates.PatientAggregate;

public interface IPatientRepository : IRepository<Patient, Guid>
{
    Task<List<PagedResult>>
}
