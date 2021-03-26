using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLIENT",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRIMER_NOMBRE = table.Column<string>(maxLength: 30, nullable: false),
                    SEGUNDO_NOMBRE = table.Column<string>(maxLength: 30, nullable: true),
                    PRIMER_APELLIDO = table.Column<string>(maxLength: 30, nullable: false),
                    SEGUNDO_APELLIDO = table.Column<string>(maxLength: 30, nullable: true),
                    TIPO_DOC = table.Column<string>(maxLength: 10, nullable: false),
                    CELULAR = table.Column<string>(maxLength: 15, nullable: false),
                    DIRECCION = table.Column<string>(maxLength: 50, nullable: false),
                    CORREO = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENT");
        }
    }
}
