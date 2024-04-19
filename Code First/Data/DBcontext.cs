using Code_First.Models;
using Microsoft.EntityFrameworkCore;

namespace Code_First.Data
{
    public class DBcontext : DbContext
    {

        public DBcontext(DbContextOptions<DBcontext> options) : base(options) { }

        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Khoa>().HasData(
                    new Khoa { id = 1, tenKhoa = "Khoa công nghệ số" },
                    new Khoa { id = 2, tenKhoa = "Khoa điện - điện tử" },
                    new Khoa { id = 3, tenKhoa = "Khoa cơ khí" },
                    new Khoa { id = 4, tenKhoa = "Khoa xây dựng" }
                );
            modelBuilder.Entity<Lop>().HasData(

                    new Lop { id = 3, tenLop = "21T3", khoaId = 1 },
                    new Lop { id = 4, tenLop = "21D1", khoaId = 2 },
                    new Lop { id = 7, tenLop = "21C1", khoaId = 3 },
                    new Lop { id = 10, tenLop = "21XD1", khoaId = 4 }

                );
            modelBuilder.Entity<SinhVien>().HasData(
                    new SinhVien { id = 9, tenSinhVien = "Trần Ái Thương", age = 20, lopId = 3 },
                    new SinhVien { id = 10, tenSinhVien = "Đậu Nguyễn Ngọc Hân", age = 21, lopId = 3 },
                    new SinhVien { id = 11, tenSinhVien = "Lê Phước Đức", age = 19, lopId = 4 },
                    new SinhVien { id = 12, tenSinhVien = "Trần Văn Lượng", age = 20, lopId = 3 },
                    new SinhVien { id = 13, tenSinhVien = "Hồ Đăng Quốc Anh", age = 19, lopId = 4 },
                    new SinhVien { id = 14, tenSinhVien = "Vương Đình Khánh Linh", age = 18, lopId = 3 },
                    new SinhVien { id = 15, tenSinhVien = "Phan Lê Văn Minh", age = 18, lopId = 7 },
                    new SinhVien { id = 16, tenSinhVien = "Phạm Văn Bảo", age = 19, lopId = 10 }
                );
        }

    }

}
