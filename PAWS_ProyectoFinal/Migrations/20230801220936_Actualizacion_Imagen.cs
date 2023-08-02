using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PAWS_ProyectoFinal.Migrations
{
    public partial class Actualizacion_Imagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenProducto",
                table: "Producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenProducto",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
