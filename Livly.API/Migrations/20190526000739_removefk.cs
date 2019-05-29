using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livly.API.Migrations
{
    public partial class removefk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Restaurants_RestaurantId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_RestaurantId",
                table: "Orders");

            //migrationBuilder.AddColumn<int>(
            //    name: "CustomersId",
            //    table: "Orders",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "RestaurantsId",
            //    table: "Orders",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Orders_CustomersId",
            //    table: "Orders",
            //    column: "CustomersId");

            //    migrationBuilder.CreateIndex(
            //        name: "IX_Orders_RestaurantsId",
            //        table: "Orders",
            //        column: "RestaurantsId");

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_Orders_Customers_CustomersId",
            //        table: "Orders",
            //        column: "CustomersId",
            //        principalTable: "Customers",
            //        principalColumn: "Id",
            //        onDelete: ReferentialAction.Restrict);

            //    migrationBuilder.AddForeignKey(
            //        name: "FK_Orders_Restaurants_RestaurantsId",
            //        table: "Orders",
            //        column: "RestaurantsId",
            //        principalTable: "Restaurants",
            //        principalColumn: "Id",
            //        onDelete: ReferentialAction.Restrict);
            //}

            //protected override void Down(MigrationBuilder migrationBuilder)
            //{
            //    migrationBuilder.DropForeignKey(
            //        name: "FK_Orders_Customers_CustomersId",
            //        table: "Orders");

            //    migrationBuilder.DropForeignKey(
            //        name: "FK_Orders_Restaurants_RestaurantsId",
            //        table: "Orders");

            //    migrationBuilder.DropIndex(
            //        name: "IX_Orders_CustomersId",
            //        table: "Orders");

            //    migrationBuilder.DropIndex(
            //        name: "IX_Orders_RestaurantsId",
            //        table: "Orders");

            //    migrationBuilder.DropColumn(
            //        name: "CustomersId",
            //        table: "Orders");

            //    migrationBuilder.DropColumn(
            //        name: "RestaurantsId",
            //        table: "Orders");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedTo = table.Column<string>(nullable: true),
                    LoginId = table.Column<string>(nullable: true),
                    LoginPassword = table.Column<string>(nullable: true),
                    OrdersAssigned = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RestaurantId",
                table: "Orders",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Restaurants_RestaurantId",
                table: "Orders",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
