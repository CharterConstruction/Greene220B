using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Notes
    {
        public int ProjectKey { get; set; }
        public int NoteKey { get; set; }
        public string Note { get; set; }
        public DateTime NoteDate { get; set; }

        public virtual Projects ProjectKeyNavigation { get; set; }
    }
}
