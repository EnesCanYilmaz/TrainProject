using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wagons_Trains_TrainId",
                table: "Wagons");

            migrationBuilder.AlterColumn<int>(
                name: "TrainId",
                table: "Wagons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Wagons_Trains_TrainId",
                table: "Wagons",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wagons_Trains_TrainId",
                table: "Wagons");

            migrationBuilder.AlterColumn<int>(
                name: "TrainId",
                table: "Wagons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Wagons_Trains_TrainId",
                table: "Wagons",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "TrainId");
        }
    }
}
