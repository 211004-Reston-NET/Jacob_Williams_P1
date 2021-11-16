using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLogic.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__ItemsInOr__LineI__29221CFB",
                table: "ItemsInOrder");

            migrationBuilder.DropForeignKey(
                name: "FK__ItemsInOr__Order__2A164134",
                table: "ItemsInOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_LineItem_Orders_OrdersId",
                table: "LineItem");

            migrationBuilder.DropIndex(
                name: "IX_LineItem_OrdersId",
                table: "LineItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsInOrder",
                table: "ItemsInOrder");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "LineItem");

            migrationBuilder.RenameTable(
                name: "ItemsInOrder",
                newName: "ItemsInOrders");

            migrationBuilder.RenameColumn(
                name: "Orders_Id",
                table: "ItemsInOrders",
                newName: "OrdersId");

            migrationBuilder.RenameColumn(
                name: "LineItem_Id",
                table: "ItemsInOrders",
                newName: "LineItemId");

            migrationBuilder.RenameColumn(
                name: "ItemsInOrder_Id",
                table: "ItemsInOrders",
                newName: "ItemsInOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsInOrder_Orders_Id",
                table: "ItemsInOrders",
                newName: "IX_ItemsInOrders_OrdersId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsInOrder_LineItem_Id",
                table: "ItemsInOrders",
                newName: "IX_ItemsInOrders_LineItemId");

            migrationBuilder.AlterColumn<double>(
                name: "Product_Price",
                table: "Product",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsInOrders",
                table: "ItemsInOrders",
                column: "ItemsInOrderId");

            migrationBuilder.CreateTable(
                name: "LineItemsOrder",
                columns: table => new
                {
                    LineItemsLineItemId = table.Column<int>(type: "int", nullable: false),
                    OrdersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItemsOrder", x => new { x.LineItemsLineItemId, x.OrdersId });
                    table.ForeignKey(
                        name: "FK_LineItemsOrder_LineItem_LineItemsLineItemId",
                        column: x => x.LineItemsLineItemId,
                        principalTable: "LineItem",
                        principalColumn: "LineItem_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineItemsOrder_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Orders_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineItemsOrder_OrdersId",
                table: "LineItemsOrder",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsInOrders_LineItem_LineItemId",
                table: "ItemsInOrders",
                column: "LineItemId",
                principalTable: "LineItem",
                principalColumn: "LineItem_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsInOrders_Orders_OrdersId",
                table: "ItemsInOrders",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Orders_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsInOrders_LineItem_LineItemId",
                table: "ItemsInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsInOrders_Orders_OrdersId",
                table: "ItemsInOrders");

            migrationBuilder.DropTable(
                name: "LineItemsOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsInOrders",
                table: "ItemsInOrders");

            migrationBuilder.RenameTable(
                name: "ItemsInOrders",
                newName: "ItemsInOrder");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "ItemsInOrder",
                newName: "Orders_Id");

            migrationBuilder.RenameColumn(
                name: "LineItemId",
                table: "ItemsInOrder",
                newName: "LineItem_Id");

            migrationBuilder.RenameColumn(
                name: "ItemsInOrderId",
                table: "ItemsInOrder",
                newName: "ItemsInOrder_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsInOrders_OrdersId",
                table: "ItemsInOrder",
                newName: "IX_ItemsInOrder_Orders_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsInOrders_LineItemId",
                table: "ItemsInOrder",
                newName: "IX_ItemsInOrder_LineItem_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Product_Price",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "OrdersId",
                table: "LineItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsInOrder",
                table: "ItemsInOrder",
                column: "ItemsInOrder_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_OrdersId",
                table: "LineItem",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK__ItemsInOr__LineI__29221CFB",
                table: "ItemsInOrder",
                column: "LineItem_Id",
                principalTable: "LineItem",
                principalColumn: "LineItem_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__ItemsInOr__Order__2A164134",
                table: "ItemsInOrder",
                column: "Orders_Id",
                principalTable: "Orders",
                principalColumn: "Orders_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LineItem_Orders_OrdersId",
                table: "LineItem",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Orders_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
