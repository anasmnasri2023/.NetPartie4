using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Data.Migrations
{
    /// <inheritdoc />
    public partial class correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_flightesFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_passengerId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "planetype",
                table: "Planes",
                newName: "MyPlaneType");

            migrationBuilder.RenameColumn(
                name: "salary",
                table: "Passengers",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "passportNumber",
                table: "Passengers",
                newName: "PassportNumber");

            migrationBuilder.RenameColumn(
                name: "fonction",
                table: "Passengers",
                newName: "Fonction");

            migrationBuilder.RenameColumn(
                name: "birthDate",
                table: "Passengers",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "flightDate",
                table: "Flights",
                newName: "FlightDate");

            migrationBuilder.RenameColumn(
                name: "destination",
                table: "Flights",
                newName: "Destination");

            migrationBuilder.RenameColumn(
                name: "departure",
                table: "Flights",
                newName: "Departure");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "Flights",
                newName: "MyPlanePlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_PlaneId",
                table: "Flights",
                newName: "IX_Flights_MyPlanePlaneId");

            migrationBuilder.RenameColumn(
                name: "flightesFlightId",
                table: "FlightPassenger",
                newName: "FlightesFlightId");

            migrationBuilder.RenameColumn(
                name: "passengerId",
                table: "FlightPassenger",
                newName: "PassengersId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_passengerId",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightesFlightId",
                table: "FlightPassenger",
                column: "FlightesFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersId",
                table: "FlightPassenger",
                column: "PassengersId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_MyPlanePlaneId",
                table: "Flights",
                column: "MyPlanePlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightesFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_MyPlanePlaneId",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "MyPlaneType",
                table: "Planes",
                newName: "planetype");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Passengers",
                newName: "salary");

            migrationBuilder.RenameColumn(
                name: "PassportNumber",
                table: "Passengers",
                newName: "passportNumber");

            migrationBuilder.RenameColumn(
                name: "Fonction",
                table: "Passengers",
                newName: "fonction");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Passengers",
                newName: "birthDate");

            migrationBuilder.RenameColumn(
                name: "FlightDate",
                table: "Flights",
                newName: "flightDate");

            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "Flights",
                newName: "destination");

            migrationBuilder.RenameColumn(
                name: "Departure",
                table: "Flights",
                newName: "departure");

            migrationBuilder.RenameColumn(
                name: "MyPlanePlaneId",
                table: "Flights",
                newName: "PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_MyPlanePlaneId",
                table: "Flights",
                newName: "IX_Flights_PlaneId");

            migrationBuilder.RenameColumn(
                name: "FlightesFlightId",
                table: "FlightPassenger",
                newName: "flightesFlightId");

            migrationBuilder.RenameColumn(
                name: "PassengersId",
                table: "FlightPassenger",
                newName: "passengerId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersId",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_passengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_flightesFlightId",
                table: "FlightPassenger",
                column: "flightesFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_passengerId",
                table: "FlightPassenger",
                column: "passengerId",
                principalTable: "Passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
