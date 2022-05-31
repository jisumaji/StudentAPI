using System;
using System.Collections.Generic;

#nullable disable

namespace API_day_23_3.Models
{
    public partial class EmpsCopy
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int? Deptid { get; set; }
        public string Designation { get; set; }
        public string EmailId { get; set; }
    }
}
