using System;
using System.Collections.Generic;

namespace EntityFrameworkEdDb.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentClasses = new HashSet<StudentClass>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string StateCode { get; set; } = null!;
        public int? Sat { get; set; }
        public decimal Gpa { get; set; }
        public int? MajorId { get; set; }

        public virtual Major? Major { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
