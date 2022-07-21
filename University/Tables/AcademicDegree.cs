﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tables
{
    internal class AcademicDegree
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public List<Employee> Employees { get; set; } = new();

    }
}