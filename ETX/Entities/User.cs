using System;
using System.Collections.Generic;

namespace ETX.Entities;

public partial class User
{
    public short Id { get; set; }

    public string Code { get; set; } = null!;

    public short PersonId { get; set; }

    public string Password { get; set; } = null!;

    public bool Active { get; set; }

    public short? InsertUser { get; set; }

    public DateTime? InsertDate { get; set; }

    public short? EditUser { get; set; }

    public DateTime? EditDate { get; set; }

    public DateTime PasswordEditDate { get; set; }

    public string? OldPassword { get; set; }

    public string? MedCode { get; set; }

    public bool? CanCancelPenaltyapproveedit { get; set; }

    public bool? CanEditEdumeetdefineedit { get; set; }

    public bool? CanSeeDoctorContract { get; set; }

    public bool? CanEditVehiclecheckedit { get; set; }

    public bool? CanReadNightmanagerreport { get; set; }

    public bool? CanSeeNmPersons { get; set; }

    public bool? CanSeeNmInjections { get; set; }

    public bool? CanSeeNmDrInfo { get; set; }

    public bool? CanSeeNmPatients { get; set; }

    public bool? CanOpenClosedActivity { get; set; }

    public bool? CanCancelInventoryapprove { get; set; }

    public bool? CanApproveNm { get; set; }

    public bool? CanDeleteQualityDoc { get; set; }

    public bool? NeedSmsCheck { get; set; }

    public short? SmsCheckCode { get; set; }

    public bool? CanSeeCheckCode { get; set; }

    public DateTime? SmsCheckDate { get; set; }

    public bool? CanDoGoOut { get; set; }

    public bool? CanSeeAllPasswords { get; set; }

    public bool? CanEditPassUnitCor { get; set; }

    public bool? Admin { get; set; }

    public bool? CanEditInvSpecial { get; set; }

    public bool? AcceptJobOnNewPage { get; set; }

    public bool? NoticeOnNewPage { get; set; }

    public bool? MessageOnNewPage { get; set; }

    public bool? DutyOnNewPage { get; set; }

    public bool? CanSeeDutyDetail { get; set; }

    public bool? CanSeeMessageDetail { get; set; }

    public bool? CanSeeAllMessages { get; set; }

    public bool? CanSeeAllDuties { get; set; }

    public bool? CanSeeUnitMessages { get; set; }

    public bool? CanSeeUnitDuties { get; set; }

    public bool? CanLockShiftAssessment { get; set; }

    public bool? CanSendSmsOnActivity { get; set; }

    public bool? CanSeeReportEdumeetsituationedit { get; set; }

    public bool? CanQualityDocRevisionReq { get; set; }

    public bool? SurgerySsmAuthorized { get; set; }

    public bool? CanUnlockAccuralPayment { get; set; }

    public bool? CanApproveMedulaPriceCut { get; set; }

    public bool? CanInsertPacsReport { get; set; }

    public string? Ssn { get; set; }

    public string? CollectionKind { get; set; }

    public bool? CanCancelComplateFinancetra { get; set; }

    public bool? CanCheckVehicleBuySell { get; set; }

    public bool? CanEditLawsuitedit { get; set; }

    public bool? CanRequestDiscount { get; set; }

    public bool? CanSeeAllDiscountPatients { get; set; }

    public string? AccrualPaymentKind { get; set; }

    public bool? CanTakeGipPrice { get; set; }

    public bool? CanDeleteAllStockOrderTrns { get; set; }

    public DateTime? LastSeen { get; set; }

    public bool? CanSeeSalary { get; set; }

    public bool? CanUnlockSalarycalc { get; set; }

    public bool? CanPersonFireReq { get; set; }

    public bool? CanEditInsertedShift { get; set; }
}
