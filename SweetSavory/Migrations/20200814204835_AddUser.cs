using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetSavory.Migrations
{
    public partial class AddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Treat_TreatId",
                table: "FlavorTreat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treat",
                table: "Treat");

            migrationBuilder.RenameTable(
                name: "Treat",
                newName: "Treats");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Treats",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treats",
                table: "Treats",
                column: "TreatId");

            migrationBuilder.CreateIndex(
                name: "IX_Treats_UserId",
                table: "Treats",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat",
                column: "TreatId",
                principalTable: "Treats",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreat_Treats_TreatId",
                table: "FlavorTreat");

            migrationBuilder.DropForeignKey(
                name: "FK_Treats_AspNetUsers_UserId",
                table: "Treats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treats",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_Treats_UserId",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Treats");

            migrationBuilder.RenameTable(
                name: "Treats",
                newName: "Treat");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treat",
                table: "Treat",
                column: "TreatId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreat_Treat_TreatId",
                table: "FlavorTreat",
                column: "TreatId",
                principalTable: "Treat",
                principalColumn: "TreatId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
