using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class VDbinfo
    {
        public string Db { get; set; }
        public string Schema { get; set; }
        public string Table { get; set; }
        public string TableType { get; set; }
        public int? ColumnNumber { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public int? MaxLength { get; set; }
        public byte? Precision { get; set; }
        public int? NumericScale { get; set; }
        public string IsNullable { get; set; }
        public string ColumnDefault { get; set; }
        public string IdentityCol { get; set; }
        public string DataTypeConcat { get; set; }
    }
}
