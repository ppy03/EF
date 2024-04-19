using System.ComponentModel.DataAnnotations.Schema;

namespace Code_First.Models
{
    public class SinhVien
    {
       
            public int id { get; set; }
            public string tenSinhVien { get; set; }
            public int age { get; set; }
            public int lopId { get; set; }
            [ForeignKey(nameof(lopId))]
            public Lop lop { get; set; }
       
    }
}
