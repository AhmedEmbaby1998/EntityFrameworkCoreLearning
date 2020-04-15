using Microsoft.EntityFrameworkCore.Migrations;

namespace Samor.Migrations
{
    public partial class renmae : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hourse_Samorais_SamoraiId",
                table: "Hourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samorais_SamoraiId",
                table: "Quotes");

            migrationBuilder.DropForeignKey(
                name: "FK_SamoraiBattle_Battle_BattleId",
                table: "SamoraiBattle");

            migrationBuilder.DropForeignKey(
                name: "FK_SamoraiBattle_Samorais_SamoraiId",
                table: "SamoraiBattle");

            migrationBuilder.DropForeignKey(
                name: "FK_Samorais_Clans_ClanId",
                table: "Samorais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Samorais",
                table: "Samorais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SamoraiBattle",
                table: "SamoraiBattle");

            migrationBuilder.RenameTable(
                name: "Samorais",
                newName: "Samories");

            migrationBuilder.RenameTable(
                name: "SamoraiBattle",
                newName: "SamoraiBattles");

            migrationBuilder.RenameIndex(
                name: "IX_Samorais_ClanId",
                table: "Samories",
                newName: "IX_Samories_ClanId");

            migrationBuilder.RenameIndex(
                name: "IX_SamoraiBattle_SamoraiId",
                table: "SamoraiBattles",
                newName: "IX_SamoraiBattles_SamoraiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Samories",
                table: "Samories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SamoraiBattles",
                table: "SamoraiBattles",
                columns: new[] { "BattleId", "SamoraiId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Hourse_Samories_SamoraiId",
                table: "Hourse",
                column: "SamoraiId",
                principalTable: "Samories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samories_SamoraiId",
                table: "Quotes",
                column: "SamoraiId",
                principalTable: "Samories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SamoraiBattles_Battle_BattleId",
                table: "SamoraiBattles",
                column: "BattleId",
                principalTable: "Battle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SamoraiBattles_Samories_SamoraiId",
                table: "SamoraiBattles",
                column: "SamoraiId",
                principalTable: "Samories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Samories_Clans_ClanId",
                table: "Samories",
                column: "ClanId",
                principalTable: "Clans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hourse_Samories_SamoraiId",
                table: "Hourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samories_SamoraiId",
                table: "Quotes");

            migrationBuilder.DropForeignKey(
                name: "FK_SamoraiBattles_Battle_BattleId",
                table: "SamoraiBattles");

            migrationBuilder.DropForeignKey(
                name: "FK_SamoraiBattles_Samories_SamoraiId",
                table: "SamoraiBattles");

            migrationBuilder.DropForeignKey(
                name: "FK_Samories_Clans_ClanId",
                table: "Samories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Samories",
                table: "Samories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SamoraiBattles",
                table: "SamoraiBattles");

            migrationBuilder.RenameTable(
                name: "Samories",
                newName: "Samorais");

            migrationBuilder.RenameTable(
                name: "SamoraiBattles",
                newName: "SamoraiBattle");

            migrationBuilder.RenameIndex(
                name: "IX_Samories_ClanId",
                table: "Samorais",
                newName: "IX_Samorais_ClanId");

            migrationBuilder.RenameIndex(
                name: "IX_SamoraiBattles_SamoraiId",
                table: "SamoraiBattle",
                newName: "IX_SamoraiBattle_SamoraiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Samorais",
                table: "Samorais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SamoraiBattle",
                table: "SamoraiBattle",
                columns: new[] { "BattleId", "SamoraiId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Hourse_Samorais_SamoraiId",
                table: "Hourse",
                column: "SamoraiId",
                principalTable: "Samorais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samorais_SamoraiId",
                table: "Quotes",
                column: "SamoraiId",
                principalTable: "Samorais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SamoraiBattle_Battle_BattleId",
                table: "SamoraiBattle",
                column: "BattleId",
                principalTable: "Battle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SamoraiBattle_Samorais_SamoraiId",
                table: "SamoraiBattle",
                column: "SamoraiId",
                principalTable: "Samorais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Samorais_Clans_ClanId",
                table: "Samorais",
                column: "ClanId",
                principalTable: "Clans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
