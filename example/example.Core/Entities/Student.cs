using System;
using System.Collections.Generic;
using System.Text;

namespace example.Core.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
