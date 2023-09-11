using System;

namespace Example.Aggregates.CategoryAggregate.DTOs;
public record CategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
