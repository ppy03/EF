using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Code_First.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Khoas",
                columns: new[] { "id", "tenKhoa" },
                values: new object[,]
                {
                    { 1, "Khoa công nghệ số" },
                    { 2, "Khoa điện - điện tử" },
                    { 3, "Khoa cơ khí" },
                    { 4, "Khoa xây dựng" }
                });

            migrationBuilder.InsertData(
                table: "Lops",
                columns: new[] { "id", "khoaId", "tenLop" },
                values: new object[,]
                {
                    { 1, 1, "21T1" },
                    { 2, 1, "21T2" },
                    { 3, 1, "21T3" },
                    { 4, 2, "21D1" },
                    { 5, 2, "21D2" },
                    { 6, 2, "21D3" },
                    { 7, 3, "21C1" },
                    { 8, 3, "21C2" },
                    { 9, 3, "21C3" },
                    { 10, 4, "21XD1" },
                    { 11, 4, "21XD1" },
                    { 12, 4, "21XD1" }
                });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "id", "age", "lopId", "tenSinhVien" },
                values: new object[,]
                {
                    { 1, 20, 3, "Trần Công Quang Phú" },
                    { 2, 21, 1, "Phạm Thanh Trúc" },
                    { 3, 19, 5, "Lê Phước Đức" },
                    { 4, 22, 6, "Trần Văn Lượng" },
                    { 5, 19, 2, "Hồ Đăng Quốc Anh" },
                    { 6, 18, 3, "Trương Văn Lâm" },
                    { 7, 18, 7, "Phan Lê Văn Minh" },
                    { 8, 19, 12, "Phạm Văn Bảo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lops",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Khoas",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
