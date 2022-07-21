using System.ComponentModel.DataAnnotations.Schema;

namespace University.Tables
{
    [Table("Students")]
    internal class Student : Person
    {
        public int Age { get; set; }

        public Dormitory Dormitory { get; set; }

        public Specialization Specialization { get; set; }

        public List<Discipline> Disciplines { get; set; } = new();

        public Group Group { get; set; }

        public EducationForm EducationalForm { get; set; }

        public List<Parent> Parents { get; set; } = new();

        public Scholarship Scholarship { get; set; }
    }
}
