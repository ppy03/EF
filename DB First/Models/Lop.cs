using System;
using System.Collections.Generic;

namespace DB_First.Models;

public partial class Lop
{
    public int Id { get; set; }

    public string Ten { get; set; }

    public int? KhoaId { get; set; }

    public virtual Khoa Khoa { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
