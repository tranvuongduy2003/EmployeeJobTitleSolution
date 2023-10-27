using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeJobTitleLibrary.Models;

public partial class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public int? YearOfBirth { get; set; }

    public string? DepartmentName { get; set; }

    public string? JobTitleId { get; set; }
    [ForeignKey("JobTitleId")]
    public virtual JobTitle? JobTitle { get; set; }
}
