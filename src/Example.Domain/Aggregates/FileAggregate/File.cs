using Example.Enums;
using System;
using Volo.Abp.Domain.Entities;

namespace Example.Domain.Aggregates.FileAggregate;
public class File : AggregateRoot<Guid>
{
    public File(Guid id, byte[] blob, string name, string extension)
    {
        Id = id;
        Blob = blob;
        Name = name;
        Extension = extension;

        Invariants();
    }

    public byte[] Blob { get; protected set; }
    public string Name { get; protected set; }
    public string Extension { get; protected set; }
    public FileType Type { get; protected set; }

    public void Invariants()
    {
        //examples of business validations

        if (Blob.Length == 0)
            throw new ArgumentNullException(nameof(Blob));

        if (string.IsNullOrEmpty(Name))
            throw new ArgumentNullException(nameof(Name));

        if (string.IsNullOrEmpty(Extension))
            throw new ArgumentNullException(nameof(Extension));
    }
}
