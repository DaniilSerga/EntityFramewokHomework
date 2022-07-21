using System.ComponentModel.DataAnnotations.Schema;

namespace University.Tables
{
    [Table("Employees")]
    internal class Employee : Person
    {
        public string MobilePhone { get; set; }

        public decimal Salary { get; set; }

        public DateTime Birthday { get; set; }

        public AcademicDegree AcademicDegree { get; set; }
    }
}
