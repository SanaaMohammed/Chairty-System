using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SDProject.Migrations
{
    /// <inheritdoc />
    public partial class finalRelease1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Inspectors_InspectorId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Cases_MyCaseCaseId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_MyCaseCaseId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "MyCaseCaseId",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "CaseId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "InspectorId",
                table: "Cases",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CaseId",
                table: "Reports",
                column: "CaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Inspectors_InspectorId",
                table: "Cases",
                column: "InspectorId",
                principalTable: "Inspectors",
                principalColumn: "InspectorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Cases_CaseId",
                table: "Reports",
                column: "CaseId",
                principalTable: "Cases",
                principalColumn: "CaseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Inspectors_InspectorId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Cases_CaseId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_CaseId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CaseId",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "MyCaseCaseId",
                table: "Reports",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InspectorId",
                table: "Cases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_MyCaseCaseId",
                table: "Reports",
                column: "MyCaseCaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Inspectors_InspectorId",
                table: "Cases",
                column: "InspectorId",
                principalTable: "Inspectors",
                principalColumn: "InspectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Cases_MyCaseCaseId",
                table: "Reports",
                column: "MyCaseCaseId",
                principalTable: "Cases",
                principalColumn: "CaseId");
        }
    }
}
