using System;
using System.Collections.Generic;

namespace EntityFrameworkEdDb.Models
{
    public partial class ClassGrade
    {
        public ClassGrade()
        {
            StudentClasses = new HashSet<StudentClass>();
        }

        public string Grade { get; set; } = null!;
        public decimal Gpa { get; set; }

        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
