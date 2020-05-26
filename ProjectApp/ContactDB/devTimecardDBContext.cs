using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace devTimecardDB
{
    public partial class devTimecardDBContext : DbContext
    {
        public devTimecardDBContext()
        {
        }

        public devTimecardDBContext(DbContextOptions<devTimecardDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CostCenter> CostCenter { get; set; }
        public virtual DbSet<Date> Date { get; set; }
        public virtual DbSet<DateView> DateView { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeJob> EmployeeJob { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobPhase> JobPhase { get; set; }
        public virtual DbSet<ManagerEmployee> ManagerEmployee { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<PayType> PayType { get; set; }
        public virtual DbSet<PayTypeGroup> PayTypeGroup { get; set; }
        public virtual DbSet<SmallJobsTimecardView> SmallJobsTimecardView { get; set; }
        public virtual DbSet<SubRequest> SubRequest { get; set; }
        public virtual DbSet<Submission> Submission { get; set; }
        public virtual DbSet<Template> Template { get; set; }
        public virtual DbSet<TemplateEmployee> TemplateEmployee { get; set; }
        public virtual DbSet<TemplatePhase> TemplatePhase { get; set; }
        public virtual DbSet<TimeEntry> TimeEntry { get; set; }
        public virtual DbSet<TimeEntryView> TimeEntryView { get; set; }
        public virtual DbSet<TimeOffBalance> TimeOffBalance { get; set; }
        public virtual DbSet<Timecard> Timecard { get; set; }
        public virtual DbSet<TimecardTimeEntryView> TimecardTimeEntryView { get; set; }
        public virtual DbSet<TimecardView> TimecardView { get; set; }
        public virtual DbSet<VDbinfo> VDbinfo { get; set; }
        public virtual DbSet<VEmployeeJob> VEmployeeJob { get; set; }
        public virtual DbSet<VManagerEmployee> VManagerEmployee { get; set; }
        public virtual DbSet<VManagerEmployeeTimeExportCsv> VManagerEmployeeTimeExportCsv { get; set; }
        public virtual DbSet<VTimeEntry> VTimeEntry { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SEA-DEVSQL;Initial Catalog=devTimecardDB;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyKey)
                    .HasName("PK_dbo.Company");

                entity.Property(e => e.CompanyKey)
                    .HasColumnName("Company_Key")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyAddress1)
                    .HasColumnName("Company_Address1")
                    .HasMaxLength(30);

                entity.Property(e => e.CompanyAddress2)
                    .HasColumnName("Company_Address2")
                    .HasMaxLength(30);

                entity.Property(e => e.CompanyCity)
                    .HasColumnName("Company_City")
                    .HasMaxLength(25);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasColumnName("Company_Code")
                    .HasMaxLength(3);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnName("Company_Name")
                    .HasMaxLength(30);

                entity.Property(e => e.CompanyState)
                    .HasColumnName("Company_State")
                    .HasMaxLength(2);

                entity.Property(e => e.CompanyZip)
                    .HasColumnName("Company_Zip")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CostCenter>(entity =>
            {
                entity.HasKey(e => e.CostCenterKey)
                    .HasName("PK_dbo.CostCenter");

                entity.Property(e => e.CostCenterKey)
                    .HasColumnName("CostCenter_Key")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterCode).HasColumnName("CostCenter_Code");

                entity.Property(e => e.CostCenterDescription).HasColumnName("CostCenter_Description");
            });

            modelBuilder.Entity<Date>(entity =>
            {
                entity.HasKey(e => e.DateKey)
                    .HasName("PK__Date__40DF45E395F420A0");

                entity.Property(e => e.DateKey).ValueGeneratedNever();

                entity.Property(e => e.Date1)
                    .HasColumnName("Date")
                    .HasColumnType("date");

                entity.Property(e => e.DaySuffix)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DowinMonth).HasColumnName("DOWInMonth");

                entity.Property(e => e.FirstDayOfMonth).HasColumnType("date");

                entity.Property(e => e.FirstDayOfNextMonth).HasColumnType("date");

                entity.Property(e => e.FirstDayOfNextYear).HasColumnType("date");

                entity.Property(e => e.FirstDayOfQuarter).HasColumnType("date");

                entity.Property(e => e.FirstDayOfYear).HasColumnType("date");

                entity.Property(e => e.HolidayText)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IsoweekOfYear).HasColumnName("ISOWeekOfYear");

                entity.Property(e => e.LastDayOfMonth).HasColumnType("date");

                entity.Property(e => e.LastDayOfQuarter).HasColumnType("date");

                entity.Property(e => e.LastDayOfYear).HasColumnType("date");

                entity.Property(e => e.Mmyyyy)
                    .IsRequired()
                    .HasColumnName("MMYYYY")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MonthYear)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QuarterName)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WeekDayName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DateView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DateView");

                entity.Property(e => e.ActualDate).HasColumnType("date");

                entity.Property(e => e.CurrentWeekEndDateKey).HasColumnName("Current_WeekEndDateKey");

                entity.Property(e => e.HolidayText).HasMaxLength(30);

                entity.Property(e => e.LongDateLabel)
                    .HasColumnName("LongDate_Label")
                    .HasMaxLength(30);

                entity.Property(e => e.PreviousWeekEndDateKey).HasColumnName("Previous_WeekEndDateKey");

                entity.Property(e => e.ShortDateLabel)
                    .HasColumnName("ShortDate_Label")
                    .HasMaxLength(30);

                entity.Property(e => e.WeekDayName).HasMaxLength(10);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeKey)
                    .HasName("PK_dbo.Employee");

                entity.Property(e => e.EmployeeKey)
                    .HasColumnName("Employee_Key")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.EmployeeAdUpn).HasColumnName("Employee_AD_UPN");

                entity.Property(e => e.EmployeeCode).HasColumnName("Employee_Code");

                entity.Property(e => e.EmployeeName).HasColumnName("Employee_Name");

                entity.Property(e => e.EmployeeStatus).HasColumnName("Employee_Status");

                entity.Property(e => e.EmployeeTeam).HasColumnName("Employee_Team");

                entity.Property(e => e.EmployeeTitle).HasColumnName("Employee_Title");

                entity.Property(e => e.EmployeeWorkersCompCode).HasColumnName("Employee_WorkersCompCode");

                entity.Property(e => e.TimecardAccess).HasColumnName("Timecard_Access");
            });

            modelBuilder.Entity<EmployeeJob>(entity =>
            {
                entity.Property(e => e.AddedByEmployeeKey).HasColumnName("AddedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.JobKey)
                    .HasName("PK_dbo.Job");

                entity.Property(e => e.JobKey)
                    .HasColumnName("Job_Key")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressFull).HasColumnName("Address_Full");

                entity.Property(e => e.AddressZipFull).HasColumnName("Address_Zip_Full");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.ContractAmount)
                    .HasColumnName("Contract_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.JobName).HasColumnName("Job_Name");

                entity.Property(e => e.JobNumber).HasColumnName("Job_Number");

                entity.Property(e => e.JobNumberName).HasColumnName("Job_NumberName");

                entity.Property(e => e.JobStatus).HasColumnName("Job_Status");
            });

            modelBuilder.Entity<JobPhase>(entity =>
            {
                entity.HasKey(e => e.PhaseKey)
                    .HasName("PK_dbo.JobPhase");

                entity.Property(e => e.PhaseKey)
                    .HasColumnName("Phase_Key")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");

                entity.Property(e => e.PhaseCode).HasColumnName("Phase_Code");

                entity.Property(e => e.PhaseDescription).HasColumnName("Phase_Description");

                entity.Property(e => e.PhaseDivCsiDescription).HasColumnName("Phase_Div_CSI_Description");

                entity.Property(e => e.PhaseDivision).HasColumnName("Phase_Division");
            });

            modelBuilder.Entity<ManagerEmployee>(entity =>
            {
                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.ManagerKey).HasColumnName("Manager_Key");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PayType>(entity =>
            {
                entity.HasKey(e => e.PayrollDepartmentCode)
                    .HasName("PK_dbo.PayType");

                entity.Property(e => e.PayrollDepartmentCode)
                    .HasColumnName("Payroll_Department_Code")
                    .HasMaxLength(128);

                entity.Property(e => e.ApprovalRequired).HasColumnName("Approval_Required");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.PayTypeDescription).HasColumnName("PayType_Description");

                entity.Property(e => e.PayTypeGroup).HasColumnName("PayType_Group");

                entity.Property(e => e.PayTypeGroupName).HasColumnName("PayType_GroupName");
            });

            modelBuilder.Entity<PayTypeGroup>(entity =>
            {
                entity.HasKey(e => e.PayTypeGroup1)
                    .HasName("PK_dbo.PayTypeGroup");

                entity.Property(e => e.PayTypeGroup1).HasColumnName("PayType_Group");

                entity.Property(e => e.PayTypeGroupName).HasColumnName("PayType_GroupName");
            });

            modelBuilder.Entity<SmallJobsTimecardView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SmallJobsTimecardView");

                entity.Property(e => e.AddedByEmployeeKey).HasColumnName("AddedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.EntryGroup).HasColumnName("Entry_Group");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");

                entity.Property(e => e.PayrollDepartmentCode)
                    .IsRequired()
                    .HasColumnName("Payroll_Department_Code")
                    .HasMaxLength(128);

                entity.Property(e => e.PhaseKey).HasColumnName("Phase_Key");

                entity.Property(e => e.RowLabel).HasColumnName("Row_Label");
            });

            modelBuilder.Entity<SubRequest>(entity =>
            {
                entity.HasKey(e => e.SubRequestKey)
                    .HasName("PK_dbo.SubRequest");

                entity.Property(e => e.IsValidParameterJson).HasColumnName("IsValidParameterJSON");

                entity.Property(e => e.ParamJson).HasColumnName("ParamJSON");
            });

            modelBuilder.Entity<Submission>(entity =>
            {
                entity.HasKey(e => e.SubmissionKey)
                    .HasName("PK_dbo.Submission");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.Json).HasColumnName("JSON");

                entity.Property(e => e.Upn).HasColumnName("UPN");

                entity.Property(e => e.ValidJson).HasColumnName("ValidJSON");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.HasKey(e => e.TemplateKey)
                    .HasName("PK_dbo.Template");

                entity.Property(e => e.AddedByEmployeeKey).HasColumnName("AddedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.TimecardTemplateName).HasColumnName("Timecard_Template_Name");
            });

            modelBuilder.Entity<TemplateEmployee>(entity =>
            {
                entity.HasKey(e => e.TemplateEmployeeKey)
                    .HasName("PK_dbo.TemplateEmployee");

                entity.Property(e => e.AddedByEmployeeKey).HasColumnName("AddedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");
            });

            modelBuilder.Entity<TemplatePhase>(entity =>
            {
                entity.HasKey(e => e.TimecardTemplateKey)
                    .HasName("PK_dbo.TemplatePhase");

                entity.Property(e => e.AddedByEmployeeKey).HasColumnName("AddedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");

                entity.Property(e => e.PayrollDepartmentCode).HasColumnName("Payroll_Department_Code");

                entity.Property(e => e.PayrollDepartmentKey).HasColumnName("Payroll_Department_Key");

                entity.Property(e => e.PhaseKey).HasColumnName("Phase_Key");
            });

            modelBuilder.Entity<TimeEntry>(entity =>
            {
                entity.HasKey(e => e.TimeEntryKey)
                    .HasName("PK_dbo.TimeEntry");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("Approve_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedByEmployeeKey).HasColumnName("ApprovedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.EnteredByEmployeeKey).HasColumnName("EnteredBy_Employee_Key");

                entity.Property(e => e.EntryGroup).HasColumnName("Entry_Group");

                entity.Property(e => e.EntryTime)
                    .HasColumnName("Entry_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");

                entity.Property(e => e.ModifiedByEmployeeKey).HasColumnName("ModifiedBy_Employee_Key");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("Modify_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayrollDepartmentCode).HasColumnName("Payroll_Department_Code");

                entity.Property(e => e.PayrollDepartmentKey).HasColumnName("Payroll_Department_Key");

                entity.Property(e => e.PhaseKey).HasColumnName("Phase_Key");

                entity.Property(e => e.RowLabel).HasColumnName("Row_Label");
            });

            modelBuilder.Entity<TimeEntryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TimeEntryView");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("Approve_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedByEmployeeKey).HasColumnName("ApprovedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.EnteredByEmployeeKey).HasColumnName("EnteredBy_Employee_Key");

                entity.Property(e => e.EntryGroup).HasColumnName("Entry_Group");

                entity.Property(e => e.EntryTime)
                    .HasColumnName("Entry_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");

                entity.Property(e => e.ModifiedByEmployeeKey).HasColumnName("ModifiedBy_Employee_Key");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("Modify_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayrollDepartmentCode)
                    .IsRequired()
                    .HasColumnName("Payroll_Department_Code");

                entity.Property(e => e.PayrollDepartmentKey).HasColumnName("Payroll_Department_Key");

                entity.Property(e => e.PhaseKey).HasColumnName("Phase_Key");

                entity.Property(e => e.QuickNote).IsRequired();

                entity.Property(e => e.RowLabel)
                    .IsRequired()
                    .HasColumnName("Row_Label");
            });

            modelBuilder.Entity<TimeOffBalance>(entity =>
            {
                entity.HasKey(e => e.EmployeeKey)
                    .HasName("PK_dbo.TimeOffBalance");

                entity.Property(e => e.EmployeeKey)
                    .HasColumnName("Employee_Key")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyCode).HasColumnName("Company_Code");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.EmployeeCode).HasColumnName("Employee_Code");

                entity.Property(e => e.HolidayBalance)
                    .HasColumnName("Holiday_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HolidayYtd)
                    .HasColumnName("Holiday_YTD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SickBalance)
                    .HasColumnName("Sick_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SickYtd)
                    .HasColumnName("Sick_YTD")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VacationBalance)
                    .HasColumnName("Vacation_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VacationYtd)
                    .HasColumnName("Vacation_YTD")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Timecard>(entity =>
            {
                entity.Property(e => e.AddedByEmployeeKey).HasColumnName("AddedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.EntryGroup).HasColumnName("Entry_Group");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");

                entity.Property(e => e.PayrollDepartmentCode).HasColumnName("Payroll_Department_Code");

                entity.Property(e => e.PhaseKey).HasColumnName("Phase_Key");

                entity.Property(e => e.RowLabel).HasColumnName("Row_Label");
            });

            modelBuilder.Entity<TimecardTimeEntryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TimecardTimeEntryView");

                entity.Property(e => e.AddedByEmployeeKey).HasColumnName("AddedBy_Employee_Key");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("Approve_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedByEmployeeKey).HasColumnName("ApprovedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.EnteredByEmployeeKey).HasColumnName("EnteredBy_Employee_Key");

                entity.Property(e => e.EntryGroup).HasColumnName("Entry_Group");

                entity.Property(e => e.EntryTime)
                    .HasColumnName("Entry_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");

                entity.Property(e => e.ModifiedByEmployeeKey).HasColumnName("ModifiedBy_Employee_Key");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("Modify_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayrollDepartmentCode).HasColumnName("Payroll_Department_Code");

                entity.Property(e => e.PayrollDepartmentKey).HasColumnName("Payroll_Department_Key");

                entity.Property(e => e.PhaseKey).HasColumnName("Phase_Key");

                entity.Property(e => e.QuickNote).IsRequired();

                entity.Property(e => e.RowLabel).HasColumnName("Row_Label");
            });

            modelBuilder.Entity<TimecardView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TimecardView");

                entity.Property(e => e.AddedByEmployeeKey).HasColumnName("AddedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.EntryGroup).HasColumnName("Entry_Group");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");

                entity.Property(e => e.PayrollDepartmentCode).HasColumnName("Payroll_Department_Code");

                entity.Property(e => e.PhaseKey).HasColumnName("Phase_Key");

                entity.Property(e => e.RowLabel).HasColumnName("Row_Label");
            });

            modelBuilder.Entity<VDbinfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDBInfo");

                entity.Property(e => e.ColumnDefault).HasMaxLength(4000);

                entity.Property(e => e.ColumnName).HasMaxLength(128);

                entity.Property(e => e.DataType).HasMaxLength(128);

                entity.Property(e => e.DataTypeConcat).HasMaxLength(191);

                entity.Property(e => e.Db)
                    .HasColumnName("DB")
                    .HasMaxLength(128);

                entity.Property(e => e.IdentityCol)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IsNullable)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Schema).HasMaxLength(128);

                entity.Property(e => e.Table).HasMaxLength(128);

                entity.Property(e => e.TableType).HasMaxLength(20);
            });

            modelBuilder.Entity<VEmployeeJob>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeJob");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");
            });

            modelBuilder.Entity<VManagerEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vManagerEmployee");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.ManagerKey).HasColumnName("Manager_Key");
            });

            modelBuilder.Entity<VManagerEmployeeTimeExportCsv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vManagerEmployeeTime_ExportCSV");

                entity.Property(e => e.BatchCode)
                    .IsRequired()
                    .HasColumnName("Batch Code")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCode).HasColumnName("Billing Code");

                entity.Property(e => e.BillingRate).HasColumnName("Billing Rate");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasColumnName("Company_Code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter).HasColumnName("Cost Center");

                entity.Property(e => e.CostType)
                    .HasColumnName("Cost Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CountyTaxCode).HasColumnName("County Tax Code");

                entity.Property(e => e.CrewNumber).HasColumnName("Crew Number");

                entity.Property(e => e.CurrentWeekEndDateKey).HasColumnName("Current_WeekEndDateKey");

                entity.Property(e => e.Date).HasMaxLength(4000);

                entity.Property(e => e.Department)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode).HasColumnName("Employee Code");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.EquipmentCode).HasColumnName("Equipment Code");

                entity.Property(e => e.EquipmentCostCategory).HasColumnName("Equipment Cost Category");

                entity.Property(e => e.EquipmentHours).HasColumnName("Equipment Hours");

                entity.Property(e => e.EquipmentWorkOrder).HasColumnName("Equipment Work Order");

                entity.Property(e => e.Job)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTaxCode).HasColumnName("Local Tax Code");

                entity.Property(e => e.ManagerKey).HasColumnName("Manager_Key");

                entity.Property(e => e.MessageLine).HasColumnName("Message Line");

                entity.Property(e => e.NewSickBalance).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PayRate).HasColumnName("Pay Rate");

                entity.Property(e => e.PayRateLevel).HasColumnName("Pay Rate Level");

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasColumnName("Pay Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SickBalance)
                    .HasColumnName("Sick_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SiteComponent).HasColumnName("Site Component");

                entity.Property(e => e.SiteEquipment).HasColumnName("Site Equipment");

                entity.Property(e => e.StateTaxCode).HasColumnName("State Tax Code");

                entity.Property(e => e.UnionPayGroup).HasColumnName("Union/pay group");

                entity.Property(e => e.VacationBalance)
                    .HasColumnName("Vacation_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WageCode).HasColumnName("Wage code");

                entity.Property(e => e.WorkOrder).HasColumnName("Work Order");

                entity.Property(e => e.WorkersComp)
                    .HasColumnName("Workers Comp")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VTimeEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTimeEntry");

                entity.Property(e => e.ApproveTime)
                    .HasColumnName("Approve_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovedByEmployeeKey).HasColumnName("ApprovedBy_Employee_Key");

                entity.Property(e => e.CompanyKey).HasColumnName("Company_Key");

                entity.Property(e => e.CostCenterKey).HasColumnName("CostCenter_Key");

                entity.Property(e => e.EmployeeKey).HasColumnName("Employee_Key");

                entity.Property(e => e.EnteredByEmployeeKey).HasColumnName("EnteredBy_Employee_Key");

                entity.Property(e => e.EntryGroup).HasColumnName("Entry_Group");

                entity.Property(e => e.EntryTime)
                    .HasColumnName("Entry_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.JobKey).HasColumnName("Job_Key");

                entity.Property(e => e.ModifiedByEmployeeKey).HasColumnName("ModifiedBy_Employee_Key");

                entity.Property(e => e.ModifyTime)
                    .HasColumnName("Modify_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayrollDepartmentCode)
                    .IsRequired()
                    .HasColumnName("Payroll_Department_Code");

                entity.Property(e => e.PayrollDepartmentKey).HasColumnName("Payroll_Department_Key");

                entity.Property(e => e.PhaseKey).HasColumnName("Phase_Key");

                entity.Property(e => e.QuickNote).IsRequired();

                entity.Property(e => e.RowLabel)
                    .IsRequired()
                    .HasColumnName("Row_Label");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
