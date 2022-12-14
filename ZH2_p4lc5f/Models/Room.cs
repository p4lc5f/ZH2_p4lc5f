using System;
using System.Collections.Generic;

namespace ZH2_p4lc5f.Models;

public partial class Room
{
    public int RoomSk { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; } = new List<Lesson>();
}
