using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class Company
    {
        public int CompanyKey { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyZip { get; set; }
    }
}
