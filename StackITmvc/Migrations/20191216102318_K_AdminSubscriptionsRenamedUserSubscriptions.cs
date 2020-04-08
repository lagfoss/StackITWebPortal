using Microsoft.EntityFrameworkCore.Migrations;

namespace StackITmvc.Migrations
{
    public partial class K_AdminSubscriptionsRenamedUserSubscriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "K_AdminSubscriptions");

            migrationBuilder.DropTable(
                name: "K_OperatorSubscriptions");

            migrationBuilder.DropTable(
                name: "K_Operator");

            migrationBuilder.CreateTable(
                name: "UserSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: true),
                    SubscriptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "SubscriptionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_SubscriptionId",
                table: "UserSubscriptions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscriptions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSubscriptions");

            migrationBuilder.CreateTable(
                name: "K_AdminSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    K_AdminId = table.Column<int>(type: "int", nullable: true),
                    SubscriptionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K_AdminSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_K_AdminSubscriptions_AspNetUsers_K_AdminId",
                        column: x => x.K_AdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_K_AdminSubscriptions_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "SubscriptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "K_Operator",
                columns: table => new
                {
                    K_OperatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K_Operator", x => x.K_OperatorId);
                    table.ForeignKey(
                        name: "FK_K_Operator_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "K_OperatorSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    K_OperatorId = table.Column<int>(type: "int", nullable: true),
                    SubscriptionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_K_OperatorSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_K_OperatorSubscriptions_K_Operator_K_OperatorId",
                        column: x => x.K_OperatorId,
                        principalTable: "K_Operator",
                        principalColumn: "K_OperatorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_K_OperatorSubscriptions_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "SubscriptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_K_AdminSubscriptions_K_AdminId",
                table: "K_AdminSubscriptions",
                column: "K_AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_K_AdminSubscriptions_SubscriptionId",
                table: "K_AdminSubscriptions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_K_Operator_CustomerId",
                table: "K_Operator",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_K_OperatorSubscriptions_K_OperatorId",
                table: "K_OperatorSubscriptions",
                column: "K_OperatorId");

            migrationBuilder.CreateIndex(
                name: "IX_K_OperatorSubscriptions_SubscriptionId",
                table: "K_OperatorSubscriptions",
                column: "SubscriptionId");
        }
    }
}
