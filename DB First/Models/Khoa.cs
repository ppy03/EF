using System;
using System.Collections.Generic;

namespace DB_First.Models;

public partial class Khoa
{
    public int Id { get; set; }

    public string Ten { get; set; }

    public virtual ICollection<Lop> Lops { get; set; } = new List<Lop>();
}
