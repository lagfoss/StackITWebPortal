using Microsoft.EntityFrameworkCore.Migrations;

namespace StackITmvc.Migrations
{
    public partial class KadminDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_K_AdminSubscriptions_K_Admin_K_AdminId",
                table: "K_AdminSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_K_AdminSubscriptions_AspNetUsers_UserId",
                table: "K_AdminSubscriptions");

            migrationBuilder.DropTable(
                name: "K_Admin");

            migrationBuilder.DropIndex(
                name: "IX_K_AdminSubscriptions_UserId",
                table: "K_AdminSubscriptions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "K_AdminSubscriptions");

            migrationBuilder.AddForeignKey(
                name: "FK_K_AdminSubscriptions_AspNetUsers_K_AdminId",
                table: "K_AdminSubscriptions",
                column: "K_AdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_K_AdminSubscriptions_AspNetUsers_K_AdminId",
                table: "K_AdminSubscriptions");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "K_AdminSubscriptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "K_Admin",
                columns: table => new
                {
                    K_AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K_Admin", x => x.K_AdminId);
                    table.ForeignKey(
                        name: "FK_K_Admin_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_K_AdminSubscriptions_UserId",
                table: "K_AdminSubscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_K_Admin_CustomerId",
                table: "K_Admin",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_K_AdminSubscriptions_K_Admin_K_AdminId",
                table: "K_AdminSubscriptions",
                column: "K_AdminId",
                principalTable: "K_Admin",
                principalColumn: "K_AdminId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_K_AdminSubscriptions_AspNetUsers_UserId",
                table: "K_AdminSubscriptions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
