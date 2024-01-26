using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class Person
{
    public short Id { get; set; }

    public string Ssn { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    /// <summary>
    /// 1-sgk çalışanı, stajyer, aday memur (işkur elemanı vb),  geçici 
    /// </summary>
    public byte? KindId { get; set; }

    public DateTime? BirthDate { get; set; }

    public byte? BirthCity { get; set; }

    public short? BirthCounty { get; set; }

    public bool Gender { get; set; }

    public byte? DrivingLicence { get; set; }

    public byte? BlodKind { get; set; }

    public short? ProfessionId { get; set; }

    public short? OccupationId { get; set; }

    public short? UnitId { get; set; }

    public byte? GroupId { get; set; }

    public short? WorkPlaceId { get; set; }

    public byte? FirmId { get; set; }

    /// <summary>
    /// sgk başlangıç tarihi
    /// </summary>
    public DateTime? StartSgDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? LeftDate { get; set; }

    public short? LeftReasonId { get; set; }

    public byte? Soldiering { get; set; }

    public byte? SoldieringMonth { get; set; }

    public short? SoldieringYear { get; set; }

    public string? PhoneCode { get; set; }

    public string? Phone { get; set; }

    public string? MobilePhoneCode { get; set; }

    public string? MobilePhone { get; set; }

    public string? Email { get; set; }

    public byte? City { get; set; }

    public short? County { get; set; }

    public string? Address { get; set; }

    public bool Disable { get; set; }

    public double? DisablePercent { get; set; }

    public string? DisableExp { get; set; }

    public byte? DiscountType { get; set; }

    public byte? InformType { get; set; }

    /// <summary>
    /// 0- full, 1- part time
    /// </summary>
    public bool ShiftType { get; set; }

    public bool ForeignPerson { get; set; }

    public short? KeyboardPress { get; set; }

    public double? KeyboardFailPercent { get; set; }

    public byte? Travellable { get; set; }

    /// <summary>
    /// asalet durumu 0-yedek 1-asil personel, personel değerlendirme alanıda 1 olacak
    /// </summary>
    public bool Reality { get; set; }

    public int? SpecialKey { get; set; }

    public short? InsertUser { get; set; }

    public DateTime InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public double? StartSalary { get; set; }

    public double? StartSalarySg { get; set; }

    public double? StartShiftExSalary { get; set; }

    public double? StartSalaryPrime { get; set; }

    public string? StartExp { get; set; }

    /// <summary>
    /// bordrosuz
    /// </summary>
    public double? StartSalaryNpayroll { get; set; }

    public double? StartSalarySbt { get; set; }

    public string? SalaryExp { get; set; }

    public byte? GrDay { get; set; }

    public int? LastSalaryPeriod { get; set; }

    public string? Entegrekey { get; set; }

    public short? BankId { get; set; }

    public short? BankBranchId { get; set; }

    public string? AccountNo { get; set; }

    public string? Iban { get; set; }

    public string? SalaryKind { get; set; }

    public bool? Active { get; set; }

    public bool? Merriage { get; set; }

    public byte? ChildCount { get; set; }

    public byte? BsCount { get; set; }

    public DateTime? AgreementEnd { get; set; }

    public bool? NeedPdks { get; set; }

    public byte? LawId { get; set; }

    public byte? LawDisableId { get; set; }

    public DateTime? LeftSgDate { get; set; }

    public byte? BodySizeType { get; set; }

    public string? CarPlate { get; set; }

    public byte? Group2Id { get; set; }

    public short? UnitResponsibleId { get; set; }

    public short? GroupResponsibleId { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public byte? TitleId { get; set; }

    public double? SalaryPayrollControl { get; set; }

    public byte? StageKind { get; set; }

    public DateTime? StageStart { get; set; }

    public DateTime? StageEnd { get; set; }

    public double? NewSalary { get; set; }

    public DateTime? NewSalaryStartDate { get; set; }

    public byte? Smoke { get; set; }

    public byte? Drug { get; set; }

    public byte? EverDrug { get; set; }

    public string? DiplomaRegNo { get; set; }

    public string? ProfessionsNo { get; set; }

    public string? JobWhenQuit { get; set; }

    public string? StartJobReferance { get; set; }

    public short? EducationKind { get; set; }

    public string? CardNo { get; set; }

    public bool PremiumBase { get; set; }

    public double? PremiumBaseSalary { get; set; }

    public string? PremiumBaseSalaryExp { get; set; }

    public bool? PremiumRateType { get; set; }

    public byte? PremiumClacType { get; set; }

    public bool? UseCarPark { get; set; }

    public string? PlasiyerCode { get; set; }

    public bool? NeedAssessment { get; set; }

    public DateTime? SeveranceStartDate { get; set; }

    public DateTime? SeveranceEndDate { get; set; }

    public string? SeveranceExp { get; set; }

    public short? SeveranceInsertUser { get; set; }

    public DateTime? SeveranceInsertDate { get; set; }

    public string? KepEmail { get; set; }
}
