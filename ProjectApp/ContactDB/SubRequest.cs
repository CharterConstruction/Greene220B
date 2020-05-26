using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class SubRequest
    {
        public int SubRequestKey { get; set; }
        public int SubmissionKey { get; set; }
        public string Class { get; set; }
        public string Method { get; set; }
        public string ParamJson { get; set; }
        public string TargetClass { get; set; }
        public bool IsValidClass { get; set; }
        public bool IsValidMethod { get; set; }
        public bool IsValidParameterJson { get; set; }
        public bool IsValidSubRequest { get; set; }
        public string Data { get; set; }
        public int ResultCount { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
        public int ValidationTimeInMs { get; set; }
        public int DataRetrievalTimeInMs { get; set; }
    }
}
