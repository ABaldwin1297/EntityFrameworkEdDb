using System;
using System.Collections.Generic;

namespace EntityFrameworkEdDb.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Classes = new HashSet<Class>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public int YearsExperience { get; set; }
        public bool IsTenured { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
