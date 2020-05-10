using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class ProjectNotes
    {
        public int ProjectKey { get; set; }
        public int NoteKey { get; set; }

        public virtual Projects ProjectKeyNavigation { get; set; }
    }
}
