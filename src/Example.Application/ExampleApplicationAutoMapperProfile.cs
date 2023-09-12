using AutoMapper;
using Example.Aggregates.CategoryAggregate.DTOs;
using Example.Aggregates.PatientAggregate.DTOs.Patient;
using Example.Aggregates.PatientAggregate.DTOs.Patient.Forms;
using Example.Domain.Aggregates.CategoryAggregate;
using Example.Domain.Aggregates.PatientAggregate;

namespace Example;

public class ExampleApplicationAutoMapperProfile : Profile
{
    public ExampleApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Category, CategoryDto>();
        CreateMap<Patient, PatientDto>()
            .ForMember(row => row.Person, dest => dest.MapFrom(x => $"{x.FirstName} {x.LastName}"));
        CreateMap<CreateOrUpdatePatientDto, Patient>();
    }
}
