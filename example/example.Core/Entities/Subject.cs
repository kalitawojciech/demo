using System;
using System.Collections.Generic;
using System.Text;

namespace example.Core.Entities
{
    public class Subject : BaseEntity
    {
        public string SubjectName { get; set; }

        public Teacher Teacher { get; set; }

        public IEnumerable<Student> Students { get; set; }
    }
}
