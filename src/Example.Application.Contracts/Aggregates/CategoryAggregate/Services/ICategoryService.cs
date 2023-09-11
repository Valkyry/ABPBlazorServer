using Example.Aggregates.CategoryAggregate.DTOs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Example.Aggregates.CategoryAggregate.Services;
public interface ICategoryService : IApplicationService
{
    Task<List<CategoryDto>> GetCategoriesAsync(CancellationToken cancellationToken);
}
