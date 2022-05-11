using System;
using System.Collections.Generic;

namespace EntityFrameworkEdDb.Models
{
    public partial class Major
    {
        public Major()
        {
            MajorClasses = new HashSet<MajorClass>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int MinSat { get; set; }

        public virtual ICollection<MajorClass> MajorClasses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
