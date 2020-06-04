using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class SystemCategories
    {
        public SystemCategories()
        {
            Systems = new HashSet<Systems>();
        }

        public int SystemCategoryKey { get; set; }
        public string SystemCategoryName { get; set; }
        public string SystemCategoryDescription { get; set; }

        public virtual ICollection<Systems> Systems { get; set; }
    }
}
