using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tables
{
    [Table("Parents")]
    internal class Parent : Person
    {
        public List<Student> Children { get; set; } = new();
    }
}
