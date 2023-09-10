using Example.Enums;
using System;
using Volo.Abp.Domain.Entities;

namespace Example.Domain.Aggregates.PatientAggregate;
public class Patient : AggregateRoot<Guid>
{
    #region constructor

    #endregion

    #region properties
    public string MRN { get; protected set; }
    public PatientStatus Status { get; protected set; }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public string NationalId { get; protected set; }
    public string AlternateIdNumber { get; protected set; }
    public DateTime DateOfBirth { get; protected set; }
    #endregion

    #region behaviours

    #endregion

    //#region Invariants
    //#endregion
}
