using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class User120520240008 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOperationClaims_Users_UserId",
                table: "UserOperationClaims");

            migrationBuilder.DropIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new byte[] { 175, 198, 47, 227, 211, 103, 52, 64, 31, 40, 44, 113, 214, 121, 228, 163, 150, 23, 229, 57, 187, 46, 60, 134, 89, 12, 155, 160, 95, 243, 174, 89, 232, 150, 168, 76, 144, 189, 81, 174, 143, 170, 217, 13, 183, 92, 39, 235, 128, 217, 91, 31, 145, 71, 223, 38, 170, 131, 52, 88, 38, 28, 55, 65 }, new byte[] { 221, 39, 132, 141, 87, 197, 53, 178, 234, 192, 111, 104, 213, 136, 198, 241, 91, 139, 86, 253, 90, 80, 47, 47, 150, 210, 204, 61, 244, 179, 196, 230, 15, 174, 1, 47, 120, 88, 159, 202, 193, 4, 130, 160, 72, 95, 176, 50, 2, 219, 142, 89, 182, 57, 24, 252, 80, 149, 42, 135, 62, 72, 204, 51, 1, 47, 2, 232, 57, 48, 119, 191, 126, 165, 152, 214, 243, 111, 241, 252, 233, 235, 80, 24, 53, 41, 177, 254, 148, 116, 198, 144, 152, 154, 61, 53, 202, 137, 190, 171, 215, 230, 196, 239, 105, 189, 207, 236, 185, 63, 181, 30, 217, 167, 2, 135, 73, 206, 169, 175, 135, 62, 69, 224, 4, 133, 9, 199 }, true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 47, 158, 19, 251, 64, 70, 166, 164, 153, 61, 20, 193, 234, 0, 213, 127, 121, 226, 140, 131, 70, 90, 184, 116, 225, 59, 122, 249, 147, 2, 97, 9, 218, 182, 80, 41, 231, 136, 47, 46, 163, 126, 197, 170, 182, 34, 252, 201, 223, 226, 116, 49, 74, 34, 98, 173, 46, 41, 103, 229, 89, 201, 72, 202 }, new byte[] { 41, 54, 231, 38, 152, 210, 136, 228, 166, 196, 75, 252, 77, 216, 177, 18, 97, 222, 245, 244, 255, 108, 191, 14, 195, 50, 87, 45, 235, 104, 109, 49, 145, 34, 117, 15, 147, 106, 109, 167, 199, 89, 26, 109, 127, 83, 197, 172, 138, 99, 51, 210, 212, 183, 153, 138, 66, 157, 60, 23, 102, 1, 143, 139, 159, 74, 186, 188, 30, 61, 251, 165, 111, 11, 152, 147, 198, 209, 147, 222, 176, 241, 165, 118, 49, 38, 124, 46, 17, 164, 79, 144, 32, 196, 219, 139, 78, 244, 49, 156, 132, 150, 136, 23, 88, 107, 111, 97, 188, 54, 167, 46, 117, 137, 167, 6, 94, 62, 139, 80, 164, 10, 169, 38, 2, 249, 223, 254, 0 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 2, 97, 251, 3, 210, 159, 44, 116, 81, 183, 58, 130, 181, 170, 14, 80, 250, 6, 66, 252, 23, 179, 231, 60, 97, 104, 39, 166, 206, 189, 71, 176, 240, 103, 205, 229, 155, 100, 252, 24, 67, 139, 7, 30, 43, 218, 250, 207, 172, 41, 171, 244, 56, 3, 225, 158, 40, 171, 232, 106, 132, 22, 7, 108, 9 }, new byte[] { 58, 129, 41, 142, 86, 59, 33, 69, 90, 95, 196, 156, 67, 159, 11, 83, 17, 203, 51, 252, 11, 23, 14, 58, 112, 112, 4, 250, 71, 30, 148, 73, 179, 3, 187, 54, 95, 32, 88, 170, 215, 220, 179, 106, 127, 213, 38, 34, 27, 191, 248, 129, 191, 108, 112, 92, 251, 28, 112, 92, 251, 28, 218, 229, 106, 237, 14, 136, 37, 10, 197, 109, 86, 213, 110, 52, 141, 115, 89, 161, 115, 239, 128, 14, 132, 6, 224, 133, 176, 33, 13, 170, 240, 118, 5, 104, 167, 218, 141, 86, 74, 16, 7, 83, 1, 238, 243, 176, 28, 245, 214, 8, 181, 35, 242, 248, 89, 112, 231, 202, 135, 173, 88, 164, 184, 6, 151, 138, 226, 151, 120, 61, 153, 1 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 85, 24, 68, 1, 206, 21, 175, 251, 8, 53, 239, 63, 35, 243, 18, 228, 18, 238, 94, 235, 68, 9, 109, 28, 185, 4, 228, 117, 76, 77, 159, 176, 155, 228, 107, 180, 118, 78, 59, 162, 67, 245, 120, 105, 44, 17, 100, 246, 235, 134, 248, 43, 156, 201, 226, 196, 42, 176, 147, 40, 236, 8, 66 }, new byte[] { 136, 89, 10, 67, 60, 35, 43, 23, 236, 223, 132, 127, 105, 112, 216, 131, 171, 244, 148, 25, 103, 219, 135, 177, 158, 18, 247, 140, 245, 123, 214, 39, 33, 243, 153, 69, 220, 166, 82, 22, 49, 127, 94, 103, 1, 100, 185, 247, 136, 129, 171, 61, 159, 6, 170, 69, 239, 82, 127, 232, 141, 199, 3, 138, 156, 197, 248, 180, 104, 81, 180, 128, 151, 187, 151, 218, 42, 23, 176, 227, 232, 93, 47, 174, 91, 253, 93, 6, 153, 230, 192, 52, 56, 181, 68, 125, 71, 20, 45, 56, 6, 45, 83, 217, 232, 228, 39, 21, 124, 34, 219, 41, 3, 55, 224, 239, 238, 110, 114, 244, 24, 244, 203, 161, 119, 192, 250, 209 } });

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperationClaims_Users_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserOperationClaims_Users_OperationClaimId",
                table: "UserOperationClaims");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { new byte[0], new byte[0], false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[0], new byte[0] });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[0], new byte[0] });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[0], new byte[0] });

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserOperationClaims_Users_UserId",
                table: "UserOperationClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
