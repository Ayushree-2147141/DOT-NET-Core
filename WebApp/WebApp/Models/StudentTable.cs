using System;
using System.Collections.Generic;

namespace WebApp.Models;

public partial class StudentTable
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public int? CourseId { get; set; }
}
