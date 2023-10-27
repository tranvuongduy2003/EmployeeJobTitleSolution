using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeJobTitleLibrary.Models
{
    public class EmployeeDto
    {
        public string EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int? YearOfBirth { get; set; }

        public string? DepartmentName { get; set; }

        public string? JobTitleName { get; set; }
        public string? JobTitleDescription { get; set; }
    }
}
