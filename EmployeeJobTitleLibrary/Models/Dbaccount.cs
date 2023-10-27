using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeJobTitleLibrary.Models;

public partial class Dbaccount
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string AccountId { get; set; }

    public string AccountPassword { get; set; } = null!;

    public string? FullName { get; set; }

    public int? AccountRole { get; set; }
}
