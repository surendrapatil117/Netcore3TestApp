using System;
using System.Collections.Generic;

#nullable disable

namespace Netcore3TestApp.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string RollNo { get; set; }
        public string Standard { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }
    }
}
