using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLogic.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Customer_Phonenumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Customer_Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Product_Description = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Product_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreFront",
                columns: table => new
                {
                    StoreFront_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreFront_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StoreFront_Address = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreFront", x => x.StoreFront_Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Orders_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<int>(type: "int", nullable: false),
                    StoreFront_Id = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(38,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Orders_PKey", x => x.Orders_Id);
                    table.ForeignKey(
                        name: "FKey_ToCustomer",
                        column: x => x.Customer_Id,
                        principalTable: "Customer",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FKey_ToStoreFront",
                        column: x => x.StoreFront_Id,
                        principalTable: "StoreFront",
                        principalColumn: "StoreFront_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LineItem",
                columns: table => new
                {
                    LineItem_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineItem_Quantity = table.Column<int>(type: "int", nullable: false),
                    Product_Id = table.Column<int>(type: "int", nullable: false),
                    StoreFront_Id = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItem", x => x.LineItem_Id);
                    table.ForeignKey(
                        name: "FK_LineItem_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Orders_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKey_ToProduct",
                        column: x => x.Product_Id,
                        principalTable: "Product",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FKey_ToStoreFront_LI",
                        column: x => x.StoreFront_Id,
                        principalTable: "StoreFront",
                        principalColumn: "StoreFront_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemsInOrder",
                columns: table => new
                {
                    ItemsInOrder_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineItem_Id = table.Column<int>(type: "int", nullable: false),
                    Orders_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsInOrder", x => x.ItemsInOrder_Id);
                    table.ForeignKey(
                        name: "FK__ItemsInOr__LineI__29221CFB",
                        column: x => x.LineItem_Id,
                        principalTable: "LineItem",
                        principalColumn: "LineItem_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__ItemsInOr__Order__2A164134",
                        column: x => x.Orders_Id,
                        principalTable: "Orders",
                        principalColumn: "Orders_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsInOrder_LineItem_Id",
                table: "ItemsInOrder",
                column: "LineItem_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsInOrder_Orders_Id",
                table: "ItemsInOrder",
                column: "Orders_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_OrdersId",
                table: "LineItem",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_Product_Id",
                table: "LineItem",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_StoreFront_Id",
                table: "LineItem",
                column: "StoreFront_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer_Id",
                table: "Orders",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreFront_Id",
                table: "Orders",
                column: "StoreFront_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsInOrder");

            migrationBuilder.DropTable(
                name: "LineItem");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "StoreFront");
        }
    }
}
