using Example.Aggregates.FileAggregate.DTOs;
using Example.Enums;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Example.Aggregates.FileAggregate.Services;
public interface IFileAppService : IApplicationService
{
    Task<List<FileDto>> GetPatientFilesAsync(CancellationToken cancellationToken);
    Task<Guid> UploadFileAsync(byte[] fileContent, string fileName, string fileExtension, FileType fileType, CancellationToken cancellationToken);
    Task DeleteFileAsync(Guid fileId, CancellationToken cancellationToken);
}
