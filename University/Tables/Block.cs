using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tables
{
    internal class Block
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public List<Student> Students { get; set; }

        public BlockType BlockType { get; set; }

        public Dormitory Dormitory { get; set; }
    }
}
