using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class v101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TIPO_DOC",
                table: "CLIENT",
                newName: "tipo_doc");

            migrationBuilder.RenameColumn(
                name: "SEGUNDO_NOMBRE",
                table: "CLIENT",
                newName: "segundo_nombre");

            migrationBuilder.RenameColumn(
                name: "SEGUNDO_APELLIDO",
                table: "CLIENT",
                newName: "segundo_apellido");

            migrationBuilder.RenameColumn(
                name: "PRIMER_NOMBRE",
                table: "CLIENT",
                newName: "primer_nombre");

            migrationBuilder.RenameColumn(
                name: "PRIMER_APELLIDO",
                table: "CLIENT",
                newName: "primer_apellido");

            migrationBuilder.RenameColumn(
                name: "DIRECCION",
                table: "CLIENT",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "CORREO",
                table: "CLIENT",
                newName: "correo");

            migrationBuilder.RenameColumn(
                name: "CELULAR",
                table: "CLIENT",
                newName: "celular");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CLIENT",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipo_doc",
                table: "CLIENT",
                newName: "TIPO_DOC");

            migrationBuilder.RenameColumn(
                name: "segundo_nombre",
                table: "CLIENT",
                newName: "SEGUNDO_NOMBRE");

            migrationBuilder.RenameColumn(
                name: "segundo_apellido",
                table: "CLIENT",
                newName: "SEGUNDO_APELLIDO");

            migrationBuilder.RenameColumn(
                name: "primer_nombre",
                table: "CLIENT",
                newName: "PRIMER_NOMBRE");

            migrationBuilder.RenameColumn(
                name: "primer_apellido",
                table: "CLIENT",
                newName: "PRIMER_APELLIDO");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "CLIENT",
                newName: "DIRECCION");

            migrationBuilder.RenameColumn(
                name: "correo",
                table: "CLIENT",
                newName: "CORREO");

            migrationBuilder.RenameColumn(
                name: "celular",
                table: "CLIENT",
                newName: "CELULAR");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CLIENT",
                newName: "ID");
        }
    }
}
