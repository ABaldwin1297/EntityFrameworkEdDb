using System;
using System.Collections.Generic;

namespace EntityFrameworkEdDb.Models
{
    public partial class MajorClass
    {
        public int Id { get; set; }
        public int MajorId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual Major Major { get; set; } = null!;
    }
}
