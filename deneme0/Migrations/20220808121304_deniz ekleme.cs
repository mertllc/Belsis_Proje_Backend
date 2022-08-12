using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme0.Migrations
{
    public partial class denizekleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DenizinDB",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Jobtitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DenizinDB", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DenizinDB");
        }
    }
}
