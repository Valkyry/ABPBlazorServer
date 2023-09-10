using System;

namespace Example.Builders.Aggregates.Category;

public class CategoryBuilder
{
    private Guid _id = Guid.Empty;
    private string? _name = string.Empty;

    public CategoryBuilder WithId(Guid id)
    {
        _id = id;

        return this;
    }

    public CategoryBuilder WithName(string name)
    {
        _name = name;

        return this;
    }

    public CategoryBuilder WithoutName()
    {
        _name = null;

        return this;
    }

    public Domain.Aggregates.CategoryAggregate.Category Build()
    {
        return new(_id, _name);
    }
}

