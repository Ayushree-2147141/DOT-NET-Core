using System;
using System.Collections.Generic;

namespace WebApp.Models;

public partial class Course
{
    public int Id { get; set; }

    public string CourseName { get; set; } = null!;

    public string CourseUrl { get; set; } = null!;
}
