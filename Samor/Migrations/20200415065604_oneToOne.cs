using Microsoft.EntityFrameworkCore.Migrations;

namespace Samor.Migrations
{
    public partial class oneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hourse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SamoraiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hourse_Samorais_SamoraiId",
                        column: x => x.SamoraiId,
                        principalTable: "Samorais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hourse_SamoraiId",
                table: "Hourse",
                column: "SamoraiId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hourse");
        }
    }
}
