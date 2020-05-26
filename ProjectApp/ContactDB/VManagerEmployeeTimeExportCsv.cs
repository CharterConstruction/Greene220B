using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class VManagerEmployeeTimeExportCsv
    {
        public string BatchCode { get; set; }
        public string EmployeeCode { get; set; }
        public string Department { get; set; }
        public string PayType { get; set; }
        public int? Hours { get; set; }
        public string Job { get; set; }
        public string Phase { get; set; }
        public string CostType { get; set; }
        public string Date { get; set; }
        public string MessageLine { get; set; }
        public int? PayRateLevel { get; set; }
        public int? WageCode { get; set; }
        public int? UnionPayGroup { get; set; }
        public string WorkersComp { get; set; }
        public int? StateTaxCode { get; set; }
        public int? CountyTaxCode { get; set; }
        public int? LocalTaxCode { get; set; }
        public int? EquipmentCode { get; set; }
        public int? EquipmentHours { get; set; }
        public int? Quantity { get; set; }
        public string CompanyCode { get; set; }
        public int? PayRate { get; set; }
        public int? EquipmentCostCategory { get; set; }
        public int? CrewNumber { get; set; }
        public int? CostCenter { get; set; }
        public int? WorkOrder { get; set; }
        public int? SiteEquipment { get; set; }
        public int? SiteComponent { get; set; }
        public int? Contract { get; set; }
        public int? EquipmentWorkOrder { get; set; }
        public int? BillingCode { get; set; }
        public int? BillingRate { get; set; }
        public int? EmployeeKey { get; set; }
        public decimal? SickBalance { get; set; }
        public decimal? NewSickBalance { get; set; }
        public decimal? VacationBalance { get; set; }
        public int? CurrentWeekEndDateKey { get; set; }
        public int? ManagerKey { get; set; }
    }
}
