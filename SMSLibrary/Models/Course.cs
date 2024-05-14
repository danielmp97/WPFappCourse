﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SMSLibrary.Models;

public partial class Course
{
    public string CourseCode { get; set; } = null!;

    public string CourseTitle { get; set; } = null!;

    public int TotalCourseHours { get; set; }

    public string School { get; set; } = null!;

    public string Department { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    public String ToString() { 
        return "CourseCode: " + CourseCode + " CourseTitle: " + CourseTitle;
    }
}
