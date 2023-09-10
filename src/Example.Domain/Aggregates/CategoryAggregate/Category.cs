using System;
using Volo.Abp.Domain.Entities;

namespace Example.Domain.Aggregates.CategoryAggregate;
public class Category : AggregateRoot<Guid>
{
    public Category(Guid id, string name)
    {
        Id = id;
        Name = name;

        Invariant();
    }

    public string Name { get; protected set; }


    public void Invariant()
    {
        if (string.IsNullOrEmpty(Name))
            throw new ArgumentNullException(nameof(Name));
    }
}
