using System;
using System.Collections.Generic;
using ETX.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETX.Context;

public partial class EtxContext : DbContext
{
    public EtxContext()
    {
    }

    public EtxContext(DbContextOptions<EtxContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agreement> Agreements { get; set; }

    public virtual DbSet<AgreementDet> AgreementDets { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Hall> Halls { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<StockCard> StockCards { get; set; }

    public virtual DbSet<StockConsumptionRate> StockConsumptionRates { get; set; }

    public virtual DbSet<StockGroup> StockGroups { get; set; }

    public virtual DbSet<StockKind> StockKinds { get; set; }

    public virtual DbSet<StockOrder> StockOrders { get; set; }

    public virtual DbSet<StockOrderKind> StockOrderKinds { get; set; }

    public virtual DbSet<StockOrderTra> StockOrderTras { get; set; }

    public virtual DbSet<StockOrderTraDet> StockOrderTraDets { get; set; }

    public virtual DbSet<StockSubGroup> StockSubGroups { get; set; }

    public virtual DbSet<StockTemplate> StockTemplates { get; set; }

    public virtual DbSet<StockTemplateDet> StockTemplateDets { get; set; }

    public virtual DbSet<StockTra> StockTras { get; set; }

    public virtual DbSet<StockType> StockTypes { get; set; }

    public virtual DbSet<StockUnitType> StockUnitTypes { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<StorageUserCor> StorageUserCors { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPersonCor> UserPersonCors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433; Database=ETX; Trusted_Connection=True; TrustServerCertificate=True; User Id=SA;Password=00205026");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agreement>(entity =>
        {
            entity.ToTable("Agreement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AgreementDet>(entity =>
        {
            entity.ToTable("AgreementDet");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.Formula)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.MastId).HasColumnName("Mast_ID");
            entity.Property(e => e.StockCardId).HasColumnName("StockCard_ID");

            entity.HasOne(d => d.Mast).WithMany(p => p.AgreementDets)
                .HasForeignKey(d => d.MastId)
                .HasConstraintName("FK_AgreementDet_Agreement");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("Brand");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Client_1");

            entity.ToTable("Client");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.AdditionalGroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Additional_Group_Name");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate)
                .HasColumnType("date")
                .HasColumnName("Birth_Date");
            entity.Property(e => e.CityId).HasColumnName("City_ID");
            entity.Property(e => e.CoordinateX)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Coordinate_X");
            entity.Property(e => e.CoordinateY)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Coordinate_Y");
            entity.Property(e => e.CountyId).HasColumnName("County_ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Group_Name");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.MuhCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Muh_Code");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OccupationId).HasColumnName("Occupation_ID");
            entity.Property(e => e.PersonName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Person_Name");
            entity.Property(e => e.PersonSurname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Person_Surname");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone2)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("Phone_2");
            entity.Property(e => e.ResponsibleName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Responsible_Name");
            entity.Property(e => e.SpecialKey).HasColumnName("Special_Key");
            entity.Property(e => e.Ssn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SSN");
            entity.Property(e => e.TaxAdministration)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Tax_Administration");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("((1))")
                .HasComment("1-kisi, 2-tuzel")
                .HasColumnName("Type_");
        });

        modelBuilder.Entity<Hall>(entity =>
        {
            entity.ToTable("Hall");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ActivityStaff");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Account_No");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AgreementEnd)
                .HasColumnType("date")
                .HasColumnName("Agreement_End");
            entity.Property(e => e.BankBranchId).HasColumnName("Bank_Branch_ID");
            entity.Property(e => e.BankId).HasColumnName("Bank_ID");
            entity.Property(e => e.BirthCity).HasColumnName("Birth_City");
            entity.Property(e => e.BirthCounty).HasColumnName("Birth_County");
            entity.Property(e => e.BirthDate)
                .HasColumnType("date")
                .HasColumnName("Birth_Date");
            entity.Property(e => e.BlodKind).HasColumnName("Blod_Kind");
            entity.Property(e => e.BodySizeType).HasColumnName("BodySize_Type");
            entity.Property(e => e.BsCount).HasColumnName("BS_Count");
            entity.Property(e => e.CarPlate)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Car_Plate");
            entity.Property(e => e.CardNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Card_No");
            entity.Property(e => e.ChildCount).HasColumnName("Child_Count");
            entity.Property(e => e.DiplomaRegNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Diploma_Reg_No");
            entity.Property(e => e.DisableExp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Disable_Exp");
            entity.Property(e => e.DisablePercent).HasColumnName("Disable_Percent");
            entity.Property(e => e.DiscountType).HasColumnName("Discount_Type");
            entity.Property(e => e.DrivingLicence).HasColumnName("Driving_Licence");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.EducationKind).HasColumnName("Education_Kind");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Entegrekey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTEGREKEY");
            entity.Property(e => e.EverDrug).HasColumnName("Ever_Drug");
            entity.Property(e => e.FatherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Father_Name");
            entity.Property(e => e.FirmId).HasColumnName("Firm_ID");
            entity.Property(e => e.ForeignPerson).HasColumnName("Foreign_Person");
            entity.Property(e => e.GrDay).HasColumnName("Gr_Day");
            entity.Property(e => e.Group2Id).HasColumnName("Group2_ID");
            entity.Property(e => e.GroupId).HasColumnName("Group_ID");
            entity.Property(e => e.GroupResponsibleId).HasColumnName("Group_Responsible_ID");
            entity.Property(e => e.Iban)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.InformType).HasColumnName("Inform_Type");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.JobWhenQuit)
                .HasColumnType("text")
                .HasColumnName("Job_When_Quit");
            entity.Property(e => e.KepEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Kep_Email");
            entity.Property(e => e.KeyboardFailPercent).HasColumnName("Keyboard_Fail_Percent");
            entity.Property(e => e.KeyboardPress).HasColumnName("Keyboard_Press");
            entity.Property(e => e.KindId)
                .HasComment("1-sgk çalışanı, stajyer, aday memur (işkur elemanı vb),  geçici ")
                .HasColumnName("Kind_ID");
            entity.Property(e => e.LastSalaryPeriod).HasColumnName("Last_Salary_Period");
            entity.Property(e => e.LawDisableId).HasColumnName("Law_Disable_ID");
            entity.Property(e => e.LawId).HasColumnName("Law_ID");
            entity.Property(e => e.LeftDate)
                .HasColumnType("date")
                .HasColumnName("Left_Date");
            entity.Property(e => e.LeftReasonId).HasColumnName("Left_Reason_ID");
            entity.Property(e => e.LeftSgDate)
                .HasColumnType("date")
                .HasColumnName("Left_SG_Date");
            entity.Property(e => e.Merriage).HasDefaultValueSql("((0))");
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Mobile_Phone");
            entity.Property(e => e.MobilePhoneCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Mobile_Phone_Code");
            entity.Property(e => e.MotherName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Mother_Name");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NeedAssessment).HasColumnName("Need_Assessment");
            entity.Property(e => e.NeedPdks)
                .HasDefaultValueSql("('1')")
                .HasColumnName("Need_PDKS");
            entity.Property(e => e.NewSalary).HasColumnName("New_Salary");
            entity.Property(e => e.NewSalaryStartDate)
                .HasColumnType("date")
                .HasColumnName("New_Salary_Start_Date");
            entity.Property(e => e.OccupationId).HasColumnName("Occupation_ID");
            entity.Property(e => e.Phone)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PhoneCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Phone_Code");
            entity.Property(e => e.PlasiyerCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Plasiyer_Code");
            entity.Property(e => e.PremiumBase).HasColumnName("Premium_Base");
            entity.Property(e => e.PremiumBaseSalary).HasColumnName("Premium_Base_Salary");
            entity.Property(e => e.PremiumBaseSalaryExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Premium_Base_Salary_Exp");
            entity.Property(e => e.PremiumClacType)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Premium_Clac_Type");
            entity.Property(e => e.PremiumRateType).HasColumnName("Premium_Rate_Type");
            entity.Property(e => e.ProfessionId).HasColumnName("Profession_ID");
            entity.Property(e => e.ProfessionsNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Professions_No");
            entity.Property(e => e.Reality).HasComment("asalet durumu 0-yedek 1-asil personel, personel değerlendirme alanıda 1 olacak");
            entity.Property(e => e.SalaryExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Salary_Exp");
            entity.Property(e => e.SalaryKind)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Salary_Kind");
            entity.Property(e => e.SalaryPayrollControl).HasColumnName("Salary_Payroll_Control");
            entity.Property(e => e.SeveranceEndDate)
                .HasColumnType("date")
                .HasColumnName("Severance_End_Date");
            entity.Property(e => e.SeveranceExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Severance_Exp");
            entity.Property(e => e.SeveranceInsertDate)
                .HasColumnType("datetime")
                .HasColumnName("Severance_Insert_Date");
            entity.Property(e => e.SeveranceInsertUser).HasColumnName("Severance_Insert_User");
            entity.Property(e => e.SeveranceStartDate)
                .HasColumnType("date")
                .HasColumnName("Severance_Start_Date");
            entity.Property(e => e.ShiftType)
                .HasComment("0- full, 1- part time")
                .HasColumnName("Shift_Type");
            entity.Property(e => e.SoldieringMonth).HasColumnName("Soldiering_Month");
            entity.Property(e => e.SoldieringYear).HasColumnName("Soldiering_Year");
            entity.Property(e => e.SpecialKey).HasColumnName("Special_Key");
            entity.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SSN");
            entity.Property(e => e.StageEnd)
                .HasColumnType("date")
                .HasColumnName("Stage_End");
            entity.Property(e => e.StageKind).HasColumnName("Stage_Kind");
            entity.Property(e => e.StageStart)
                .HasColumnType("date")
                .HasColumnName("Stage_Start");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("Start_Date");
            entity.Property(e => e.StartExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Start_Exp");
            entity.Property(e => e.StartJobReferance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Start_Job_Referance");
            entity.Property(e => e.StartSalary).HasColumnName("Start_Salary");
            entity.Property(e => e.StartSalaryNpayroll)
                .HasComment("bordrosuz")
                .HasColumnName("Start_Salary_NPayroll");
            entity.Property(e => e.StartSalaryPrime).HasColumnName("Start_Salary_Prime");
            entity.Property(e => e.StartSalarySbt).HasColumnName("Start_Salary_SBT");
            entity.Property(e => e.StartSalarySg).HasColumnName("Start_Salary_SG");
            entity.Property(e => e.StartSgDate)
                .HasComment("sgk başlangıç tarihi")
                .HasColumnType("date")
                .HasColumnName("Start_SG_Date");
            entity.Property(e => e.StartShiftExSalary).HasColumnName("Start_Shift_Ex_Salary");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TitleId).HasColumnName("Title_ID");
            entity.Property(e => e.UnitId).HasColumnName("Unit_ID");
            entity.Property(e => e.UnitResponsibleId).HasColumnName("Unit_Responsible_ID");
            entity.Property(e => e.UseCarPark).HasColumnName("Use_Car_Park");
            entity.Property(e => e.WorkPlaceId).HasColumnName("WorkPlace_ID");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BillDate)
                .HasColumnType("date")
                .HasColumnName("Bill_Date");
            entity.Property(e => e.BillInsertDate)
                .HasColumnType("datetime")
                .HasColumnName("Bill_Insert_Date");
            entity.Property(e => e.BillInsertUser).HasColumnName("Bill_Insert_User");
            entity.Property(e => e.BillNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Bill_No");
            entity.Property(e => e.ClientId).HasColumnName("Client_ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("Date_");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.Exp)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FromStorageId).HasColumnName("From_Storage_ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.KindId).HasColumnName("Kind_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TId).HasColumnName("T_ID");
            entity.Property(e => e.TName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("T_Name");
            entity.Property(e => e.ToStorageId).HasColumnName("To_Storage_ID");
        });

        modelBuilder.Entity<StockCard>(entity =>
        {
            entity.ToTable("StockCard");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BrandId).HasColumnName("Brand_ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsumptionRateId).HasColumnName("Consumption_Rate_ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.Exp)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.GroupId).HasColumnName("Group_ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Kg).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.KindId)
                .HasComment("1 stok 0 işlem")
                .HasColumnName("Kind_ID");
            entity.Property(e => e.Lt).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Piece).HasDefaultValueSql("((1))");
            entity.Property(e => e.SeriesNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Series_No");
            entity.Property(e => e.SubGroupId).HasColumnName("Sub_Group_ID");
            entity.Property(e => e.TypeId).HasColumnName("Type_ID");
            entity.Property(e => e.UnitId).HasColumnName("Unit_ID");
            entity.Property(e => e.UnitPrice).HasColumnName("Unit_Price");
            entity.Property(e => e.VatIncluded).HasColumnName("Vat_Included");
            entity.Property(e => e.VatRate).HasColumnName("Vat_Rate");
            entity.Property(e => e.Volume).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<StockConsumptionRate>(entity =>
        {
            entity.ToTable("StockConsumptionRate");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockGroup>(entity =>
        {
            entity.ToTable("StockGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockKind>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Stock_Kind");

            entity.ToTable("StockKind");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.IoType)
                .HasDefaultValueSql("((1))")
                .HasComment("1-giriş, 2-çıkış, 3-transfer")
                .HasColumnName("IO_Type");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockOrder>(entity =>
        {
            entity.ToTable("StockOrder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AgreementId).HasColumnName("Agreement_ID");
            entity.Property(e => e.Approve).HasDefaultValueSql("((2))");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("Approve_Date");
            entity.Property(e => e.ApproveExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Approve_Exp");
            entity.Property(e => e.ApproveUser).HasColumnName("Approve_User");
            entity.Property(e => e.AttendeeCount).HasColumnName("Attendee_Count");
            entity.Property(e => e.Block).HasColumnName("Block_");
            entity.Property(e => e.BlockDate)
                .HasColumnType("datetime")
                .HasColumnName("Block_Date");
            entity.Property(e => e.BlockExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Block_Exp");
            entity.Property(e => e.BlockUser).HasColumnName("Block_User");
            entity.Property(e => e.ClientId).HasColumnName("Client_ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("Date_");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("Delivery_Date");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.Exp)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.HallId).HasColumnName("Hall_ID");
            
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date")
                .ValueGeneratedOnAdd();
            
            
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.KindId).HasColumnName("Kind_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PayPeriod).HasColumnName("Pay_Period");
            entity.Property(e => e.PayType).HasColumnName("Pay_Type");
            entity.Property(e => e.PlasiyerPersonId).HasColumnName("Plasiyer_Person_ID");
            entity.Property(e => e.RequestStorageId).HasColumnName("Request_Storage_ID");
            entity.Property(e => e.Transfer).HasColumnName("Transfer_");
            entity.Property(e => e.TransferDate)
                .HasColumnType("datetime")
                .HasColumnName("Transfer_Date");
            entity.Property(e => e.TransferErr)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Transfer_Err");
            entity.Property(e => e.TransferFisNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Transfer_Fis_No");
            entity.Property(e => e.TransferUser).HasColumnName("Transfer_User");
        });

        modelBuilder.Entity<StockOrderKind>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StockOrderType");

            entity.ToTable("StockOrderKind");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockOrderTra>(entity =>
        {
            entity.ToTable("StockOrderTra");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CancelDate)
                .HasColumnType("datetime")
                .HasColumnName("Cancel_Date");
            entity.Property(e => e.CancelExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Cancel_Exp");
            entity.Property(e => e.CancelUser).HasColumnName("Cancel_User");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.MastId).HasColumnName("Mast_ID");
            entity.Property(e => e.OrjUnitPrice).HasColumnName("Orj_Unit_Price");
            entity.Property(e => e.StockCardId).HasColumnName("Stock_Card_ID");
            entity.Property(e => e.TotalPrice).HasColumnName("Total_Price");
            entity.Property(e => e.TotalVat).HasColumnName("Total_Vat");
            entity.Property(e => e.UnitPrice).HasColumnName("Unit_Price");

            entity.HasOne(d => d.Mast).WithMany(p => p.StockOrderTras)
                .HasForeignKey(d => d.MastId)
                .HasConstraintName("FK_StockOrderTra_StockOrder");
        });

        modelBuilder.Entity<StockOrderTraDet>(entity =>
        {
            entity.ToTable("StockOrderTraDet");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Approve).HasDefaultValueSql("((1))");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("Approve_Date");
            entity.Property(e => e.ApproveExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Approve_Exp");
            entity.Property(e => e.ApproveUser).HasColumnName("Approve_User");
            entity.Property(e => e.DeliverDate)
                .HasColumnType("datetime")
                .HasColumnName("Deliver_Date");
            entity.Property(e => e.DeliverExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Deliver_Exp");
            entity.Property(e => e.DelivererName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deliverer_Name");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.RecepientName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Recepient_Name");
            entity.Property(e => e.StorageId).HasColumnName("Storage_ID");
            entity.Property(e => e.TraId).HasColumnName("Tra_ID");
            entity.Property(e => e.Type).HasColumnName("Type_");

            entity.HasOne(d => d.Tra).WithMany(p => p.StockOrderTraDets)
                .HasForeignKey(d => d.TraId)
                .HasConstraintName("FK_StockOrderTraDet_StockOrderTra");
        });

        modelBuilder.Entity<StockSubGroup>(entity =>
        {
            entity.ToTable("StockSubGroup");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.GroupId).HasColumnName("Group_ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockTemplate>(entity =>
        {
            entity.ToTable("StockTemplate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.Exp)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasColumnName("Type_ID");
        });

        modelBuilder.Entity<StockTemplateDet>(entity =>
        {
            entity.HasKey(e => new { e.MastId, e.StockCardId });

            entity.ToTable("StockTemplateDet");

            entity.Property(e => e.MastId).HasColumnName("Mast_ID");
            entity.Property(e => e.StockCardId).HasColumnName("StockCard_ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");

            entity.HasOne(d => d.Mast).WithMany(p => p.StockTemplateDets)
                .HasForeignKey(d => d.MastId)
                .HasConstraintName("FK_StockTemplateDet_StockTemplate");
        });

        modelBuilder.Entity<StockTra>(entity =>
        {
            entity.ToTable("StockTra");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Approve)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("Approve_Date");
            entity.Property(e => e.ApproveExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Approve_Exp");
            entity.Property(e => e.ApproveUser).HasColumnName("Approve_User");
            entity.Property(e => e.CancelDate)
                .HasColumnType("datetime")
                .HasColumnName("Cancel_Date");
            entity.Property(e => e.CancelExp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Cancel_Exp");
            entity.Property(e => e.CancelUser).HasColumnName("Cancel_User");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("Date_");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.ExpireDate)
                .HasColumnType("date")
                .HasColumnName("Expire_Date");
            entity.Property(e => e.FromStorageId).HasColumnName("From_Storage_ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.MastId)
                .HasComment("stok fişleri")
                .HasColumnName("Mast_ID");
            entity.Property(e => e.NQuantity).HasColumnName("N_Quantity");
            entity.Property(e => e.OQuantity).HasColumnName("O_Quantity");
            entity.Property(e => e.PartyNo).HasColumnName("Party_No");
            entity.Property(e => e.StockCardId).HasColumnName("Stock_Card_ID");
            entity.Property(e => e.TId).HasColumnName("T_ID");
            entity.Property(e => e.TName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("T_Name");
            entity.Property(e => e.ToStorageId).HasColumnName("To_Storage_ID");
            entity.Property(e => e.UnitPrice).HasColumnName("Unit_Price");
            entity.Property(e => e.UnitType).HasColumnName("Unit_Type");
            entity.Property(e => e.VatRate).HasColumnName("Vat_Rate");

            entity.HasOne(d => d.Mast).WithMany(p => p.StockTras)
                .HasForeignKey(d => d.MastId)
                .HasConstraintName("FK_StockTra_Stocks");
        });

        modelBuilder.Entity<StockType>(entity =>
        {
            entity.ToTable("StockType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockUnitType>(entity =>
        {
            entity.ToTable("StockUnitType");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Storage>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RelatedStorageId).HasColumnName("Related_Storage_ID");
            entity.Property(e => e.Type)
                .HasComment("1-ana depo, 0 - tali depo")
                .HasColumnName("Type_");
        });

        modelBuilder.Entity<StorageUserCor>(entity =>
        {
            entity.HasKey(e => new { e.StorageId, e.UserId });

            entity.ToTable("StorageUserCor");

            entity.Property(e => e.StorageId).HasColumnName("Storage_ID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ActivityUser");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcceptJobOnNewPage).HasColumnName("Accept_Job_OnNewPage");
            entity.Property(e => e.AccrualPaymentKind)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AccrualPayment_Kind");
            entity.Property(e => e.Admin)
                .IsRequired()
                .HasDefaultValueSql("('0')")
                .HasColumnName("Admin_");
            entity.Property(e => e.CanApproveMedulaPriceCut).HasColumnName("Can_Approve_Medula_Price_Cut");
            entity.Property(e => e.CanApproveNm).HasColumnName("Can_Approve_NM");
            entity.Property(e => e.CanCancelComplateFinancetra).HasColumnName("Can_Cancel_Complate_Financetra");
            entity.Property(e => e.CanCancelInventoryapprove).HasColumnName("Can_Cancel_inventoryapprove");
            entity.Property(e => e.CanCancelPenaltyapproveedit).HasColumnName("Can_Cancel_penaltyapproveedit");
            entity.Property(e => e.CanCheckVehicleBuySell).HasColumnName("Can_Check_VehicleBuySell");
            entity.Property(e => e.CanDeleteAllStockOrderTrns).HasColumnName("Can_Delete_All_Stock_Order_Trns");
            entity.Property(e => e.CanDeleteQualityDoc).HasColumnName("Can_Delete_Quality_Doc");
            entity.Property(e => e.CanDoGoOut).HasColumnName("Can_Do_Go_Out");
            entity.Property(e => e.CanEditEdumeetdefineedit).HasColumnName("Can_Edit_edumeetdefineedit");
            entity.Property(e => e.CanEditInsertedShift).HasColumnName("Can_Edit_Inserted_Shift");
            entity.Property(e => e.CanEditInvSpecial).HasColumnName("Can_Edit_Inv_Special");
            entity.Property(e => e.CanEditLawsuitedit).HasColumnName("Can_Edit_Lawsuitedit");
            entity.Property(e => e.CanEditPassUnitCor).HasColumnName("Can_Edit_PassUnitCor");
            entity.Property(e => e.CanEditVehiclecheckedit).HasColumnName("Can_Edit_vehiclecheckedit");
            entity.Property(e => e.CanInsertPacsReport).HasColumnName("Can_Insert_Pacs_Report");
            entity.Property(e => e.CanLockShiftAssessment).HasColumnName("Can_Lock_Shift_Assessment");
            entity.Property(e => e.CanOpenClosedActivity).HasColumnName("Can_Open_Closed_Activity");
            entity.Property(e => e.CanPersonFireReq).HasColumnName("Can_Person_Fire_Req");
            entity.Property(e => e.CanQualityDocRevisionReq).HasColumnName("Can_Quality_Doc_Revision_Req");
            entity.Property(e => e.CanReadNightmanagerreport).HasColumnName("Can_Read_nightmanagerreport");
            entity.Property(e => e.CanRequestDiscount).HasColumnName("Can_Request_Discount");
            entity.Property(e => e.CanSeeAllDiscountPatients).HasColumnName("Can_See_All_Discount_Patients");
            entity.Property(e => e.CanSeeAllDuties).HasColumnName("Can_See_All_Duties");
            entity.Property(e => e.CanSeeAllMessages).HasColumnName("Can_See_All_Messages");
            entity.Property(e => e.CanSeeAllPasswords).HasColumnName("Can_See_All_Passwords");
            entity.Property(e => e.CanSeeCheckCode).HasColumnName("Can_See_Check_Code");
            entity.Property(e => e.CanSeeDoctorContract).HasColumnName("Can_See_Doctor_Contract");
            entity.Property(e => e.CanSeeDutyDetail).HasColumnName("Can_See_Duty_Detail");
            entity.Property(e => e.CanSeeMessageDetail).HasColumnName("Can_See_Message_Detail");
            entity.Property(e => e.CanSeeNmDrInfo).HasColumnName("Can_See_NM_Dr_Info");
            entity.Property(e => e.CanSeeNmInjections).HasColumnName("Can_See_NM_Injections");
            entity.Property(e => e.CanSeeNmPatients).HasColumnName("Can_See_NM_Patients");
            entity.Property(e => e.CanSeeNmPersons).HasColumnName("Can_See_NM_Persons");
            entity.Property(e => e.CanSeeReportEdumeetsituationedit).HasColumnName("Can_See_Report_edumeetsituationedit");
            entity.Property(e => e.CanSeeSalary).HasColumnName("Can_See_Salary");
            entity.Property(e => e.CanSeeUnitDuties).HasColumnName("Can_See_Unit_Duties");
            entity.Property(e => e.CanSeeUnitMessages).HasColumnName("Can_See_Unit_Messages");
            entity.Property(e => e.CanSendSmsOnActivity).HasColumnName("Can_Send_SMS_On_Activity");
            entity.Property(e => e.CanTakeGipPrice).HasColumnName("Can_Take_Gip_Price");
            entity.Property(e => e.CanUnlockAccuralPayment).HasColumnName("Can_Unlock_Accural_Payment");
            entity.Property(e => e.CanUnlockSalarycalc).HasColumnName("Can_Unlock_Salarycalc");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CollectionKind)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Collection_Kind");
            entity.Property(e => e.DutyOnNewPage).HasColumnName("Duty_OnNewPage");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.LastSeen)
                .HasColumnType("datetime")
                .HasColumnName("Last_Seen");
            entity.Property(e => e.MedCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Med_Code");
            entity.Property(e => e.MessageOnNewPage).HasColumnName("Message_OnNewPage");
            entity.Property(e => e.NeedSmsCheck).HasColumnName("Need_Sms_Check");
            entity.Property(e => e.NoticeOnNewPage).HasColumnName("Notice_OnNewPage");
            entity.Property(e => e.OldPassword)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Old_Password");
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PasswordEditDate)
                .HasColumnType("date")
                .HasColumnName("Password_Edit_Date");
            entity.Property(e => e.PersonId).HasColumnName("Person_ID");
            entity.Property(e => e.SmsCheckCode).HasColumnName("Sms_Check_Code");
            entity.Property(e => e.SmsCheckDate)
                .HasColumnType("datetime")
                .HasColumnName("Sms_Check_Date");
            entity.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SSN");
            entity.Property(e => e.SurgerySsmAuthorized).HasColumnName("Surgery_SSM_Authorized");
        });

        modelBuilder.Entity<UserPersonCor>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.PersonId });

            entity.ToTable("UserPersonCor");

            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.PersonId).HasColumnName("Person_ID");
            entity.Property(e => e.EditDate)
                .HasColumnType("datetime")
                .HasColumnName("Edit_Date");
            entity.Property(e => e.EditUser).HasColumnName("Edit_User");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("End_Date");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Insert_Date");
            entity.Property(e => e.InsertUser).HasColumnName("Insert_User");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Start_Date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
