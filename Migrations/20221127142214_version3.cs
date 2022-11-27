using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pagamento_prova.Migrations
{
    public partial class version3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Consumidor_ConsumidorId",
                table: "Pedido");

            migrationBuilder.AlterColumn<int>(
                name: "ConsumidorId",
                table: "Pedido",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Consumidor_ConsumidorId",
                table: "Pedido",
                column: "ConsumidorId",
                principalTable: "Consumidor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Consumidor_ConsumidorId",
                table: "Pedido");

            migrationBuilder.AlterColumn<int>(
                name: "ConsumidorId",
                table: "Pedido",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Consumidor_ConsumidorId",
                table: "Pedido",
                column: "ConsumidorId",
                principalTable: "Consumidor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
