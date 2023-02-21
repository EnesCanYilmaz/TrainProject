using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class mig_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReservationRequests",
                table: "ReservationRequests");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ReservationRequests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ReservationRequests",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReservationRequests",
                table: "ReservationRequests",
                column: "Id");
        }
    }
}
