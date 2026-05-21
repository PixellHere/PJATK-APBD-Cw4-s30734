using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PJATK_APBD_Cw4_s30734.Migrations
{
    /// <inheritdoc />
    public partial class RenameComponentTypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentsTypes_ComponentTypesId",
                table: "Components");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComponentsTypes",
                table: "ComponentsTypes");

            migrationBuilder.RenameTable(
                name: "ComponentsTypes",
                newName: "ComponentTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComponentTypes",
                table: "ComponentTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentTypes_ComponentTypesId",
                table: "Components",
                column: "ComponentTypesId",
                principalTable: "ComponentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Components_ComponentTypes_ComponentTypesId",
                table: "Components");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComponentTypes",
                table: "ComponentTypes");

            migrationBuilder.RenameTable(
                name: "ComponentTypes",
                newName: "ComponentsTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComponentsTypes",
                table: "ComponentsTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Components_ComponentsTypes_ComponentTypesId",
                table: "Components",
                column: "ComponentTypesId",
                principalTable: "ComponentsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
