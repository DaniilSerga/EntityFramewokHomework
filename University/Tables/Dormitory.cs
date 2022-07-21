using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tables
{
    internal class Dormitory
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string Address { get; set; }

        public List<Student> Students { get; set; } = new();
    }
}
