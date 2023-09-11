using Example.Domain.Aggregates.CategoryAggregate;
using Example.Enums;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Example.Domain.Aggregates.PatientAggregate;
public class Patient : AggregateRoot<Guid>
{
    #region constructor
    protected Patient() { }

    public Patient(Guid id, string mrn, PatientStatus patientStatus, string firstName, string lastName, string nationalId, string alternateIdNumber, DateTime dateOfBirth, Guid categoryId)
    {
        Id = id;
        MRN = mrn;
        Status = patientStatus;
        FirstName = firstName;
        LastName = lastName;
        NationalId = nationalId;
        AlternateIdNumber = alternateIdNumber;
        DateOfBirth = dateOfBirth;
        CategoryId = categoryId;
    }
    #endregion

    #region properties
    public string MRN { get; protected set; }
    public PatientStatus Status { get; protected set; }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public string NationalId { get; protected set; }
    public string AlternateIdNumber { get; protected set; }
    public DateTime DateOfBirth { get; protected set; }
    public Guid CategoryId { get; protected set; }

    public Category Category { get; protected set; }

    private readonly List<PatientFileStore> fileStores = new();
    public List<PatientFileStore> FileStores => fileStores;
    #endregion

    #region behaviours

    public void AssignPatientFile(Guid patientFileStoreId, Guid patientId, Guid FileId)
    {
        PatientFileStore patientFileStore = new(patientFileStoreId, patientId, FileId);
        
        FileStores.Add(patientFileStore);
    }

    public void UpdatePatient(string mrn, PatientStatus patientStatus, string firstName, string lastName, string nationalId, string alternateIdNumber, DateTime dateOfBirth, Guid categoryId)
    {
        MRN = mrn;
        Status = patientStatus;
        FirstName = firstName;
        LastName = lastName;
        NationalId = nationalId;
        AlternateIdNumber = alternateIdNumber;
        DateOfBirth = dateOfBirth;
        CategoryId = categoryId;
    }

    #endregion

    //#region Invariants
    //#endregion
}
