using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersongemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersongemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersongemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersongemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersongemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersongemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersongemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersongemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 170, 3, 135, 155, 105, 30, 125, 75, 192, 12, 134, 39, 56, 52, 118, 209, 166, 148, 137, 239, 136, 25, 97, 72, 240, 7, 208, 10, 198, 90, 69, 28, 78, 239, 18, 48, 79, 155, 108, 99, 6, 93, 255, 148, 161, 120, 188, 35, 73, 5, 146, 97, 99, 49, 187, 30, 114, 148, 156, 166, 83, 72, 247, 5 }, new byte[] { 158, 45, 76, 105, 34, 241, 157, 255, 24, 8, 246, 155, 199, 11, 228, 193, 26, 185, 128, 55, 219, 85, 30, 118, 55, 42, 115, 17, 99, 118, 81, 90, 61, 144, 230, 93, 28, 61, 73, 63, 215, 255, 143, 241, 234, 181, 88, 175, 204, 8, 141, 60, 98, 19, 66, 136, 35, 250, 160, 217, 102, 233, 11, 28, 102, 221, 46, 124, 150, 7, 141, 19, 255, 120, 226, 60, 13, 116, 187, 123, 63, 197, 58, 168, 182, 29, 62, 62, 190, 196, 199, 36, 61, 81, 109, 167, 133, 138, 139, 222, 24, 4, 139, 16, 116, 15, 255, 57, 255, 247, 30, 186, 58, 155, 220, 33, 69, 37, 51, 71, 159, 164, 216, 241, 59, 83, 128, 214 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersongemId",
                table: "TB_ARMAS",
                column: "PersongemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersongemId",
                table: "TB_ARMAS",
                column: "PersongemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersongemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersongemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersongemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 124, 58, 138, 33, 149, 176, 133, 249, 86, 147, 5, 177, 164, 61, 145, 59, 43, 124, 172, 231, 111, 86, 113, 207, 40, 16, 217, 74, 6, 72, 196, 180, 225, 25, 0, 77, 217, 14, 152, 250, 194, 61, 6, 175, 195, 132, 9, 17, 108, 21, 47, 41, 120, 67, 34, 170, 51, 157, 46, 217, 172, 20, 121, 186 }, new byte[] { 168, 116, 240, 90, 35, 162, 193, 103, 232, 163, 142, 196, 200, 57, 253, 4, 60, 233, 124, 97, 158, 168, 18, 127, 233, 86, 39, 3, 153, 214, 12, 166, 115, 103, 176, 152, 240, 77, 20, 72, 215, 10, 180, 58, 246, 193, 123, 190, 100, 69, 56, 73, 232, 144, 247, 237, 246, 206, 153, 102, 80, 147, 93, 251, 197, 144, 40, 221, 133, 255, 207, 83, 17, 87, 244, 30, 154, 210, 205, 222, 167, 132, 71, 170, 67, 168, 188, 178, 141, 228, 113, 60, 174, 18, 223, 33, 78, 225, 144, 173, 202, 1, 189, 129, 158, 58, 168, 38, 63, 39, 2, 153, 46, 128, 164, 72, 241, 159, 72, 138, 184, 76, 222, 81, 179, 55, 13, 160 } });
        }
    }
}
