using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace University.Tables
{
    internal class Group
    {
        [Key]
        public string Name { get; set; }

        public List<Student> students { get; set; }
    }
}
