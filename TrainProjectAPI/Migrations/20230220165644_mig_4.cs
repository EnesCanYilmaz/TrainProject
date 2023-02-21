using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wagons_Trains_TrainId",
                table: "Wagons");

            migrationBuilder.DropIndex(
                name: "IX_Wagons_TrainId",
                table: "Wagons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Wagons_TrainId",
                table: "Wagons",
                column: "TrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wagons_Trains_TrainId",
                table: "Wagons",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
