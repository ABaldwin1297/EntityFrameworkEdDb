using System;
using System.Collections.Generic;

namespace EntityFrameworkEdDb.Models
{
    public partial class Assignment
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public int ClassId { get; set; }

        public virtual Class Class { get; set; } = null!;
    }
}
