using System;
using System.Collections.Generic;

namespace EntityFrameworkEdDb.Models
{
    public partial class StudentClass
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public string? ClassGradeValue { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual ClassGrade? ClassGradeValueNavigation { get; set; }
        public virtual Student Student { get; set; } = null!;
    }
}
