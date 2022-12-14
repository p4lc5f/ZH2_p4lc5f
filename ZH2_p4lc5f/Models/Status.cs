﻿using System;
using System.Collections.Generic;

namespace ZH2_p4lc5f.Models;

public partial class Status
{
    public byte StatusId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();
}
