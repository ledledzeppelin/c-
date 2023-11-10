using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace 餐厅管理系统.Migrations.ApplyDbMigrations
{
    public partial class apply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resapplys",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    account = table.Column<string>(nullable: true),
                    ResPicture = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Rate = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resapplys", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    DishId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DisPicture = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    RestaurantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.DishId);
                    table.ForeignKey(
                        name: "FK_Dish_Resapplys_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Resapplys",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RestaurantId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Resapplys_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Resapplys",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dish_RestaurantId",
                table: "Dish",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_RestaurantId",
                table: "Review",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dish");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Resapplys");
        }
    }
}
