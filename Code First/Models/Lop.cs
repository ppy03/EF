using System.ComponentModel.DataAnnotations.Schema;

namespace Code_First.Models
{
    public class Lop
    {
        public int id { get; set; }
        public string tenLop { get; set; }
        public int khoaId { get; set; }
        [ForeignKey(nameof(khoaId))]
        public Khoa khoa { get; set; }
    }
}
