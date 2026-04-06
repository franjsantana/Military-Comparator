using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilitaryComparator.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    FlagImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArmoredVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleType = table.Column<int>(type: "INTEGER", nullable: false),
                    Length = table.Column<double>(type: "REAL", nullable: false),
                    Width = table.Column<double>(type: "REAL", nullable: false),
                    Height = table.Column<double>(type: "REAL", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: false),
                    Engine = table.Column<string>(type: "TEXT", nullable: false),
                    EnginePower = table.Column<int>(type: "INTEGER", nullable: false),
                    Transmission = table.Column<string>(type: "TEXT", nullable: false),
                    MaxSpeedRoad = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxSpeedOffRoad = table.Column<int>(type: "INTEGER", nullable: false),
                    Suspension = table.Column<string>(type: "TEXT", nullable: false),
                    Range = table.Column<int>(type: "INTEGER", nullable: false),
                    MainArmament = table.Column<string>(type: "TEXT", nullable: false),
                    SecondaryArmament = table.Column<string>(type: "TEXT", nullable: false),
                    Armor = table.Column<string>(type: "TEXT", nullable: false),
                    TotalProduced = table.Column<int>(type: "INTEGER", nullable: false),
                    NationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmoredVehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArmoredVehicles_Nations_NationId",
                        column: x => x.NationId,
                        principalTable: "Nations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrewMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    ArmoredVehicleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrewMembers_ArmoredVehicles_ArmoredVehicleId",
                        column: x => x.ArmoredVehicleId,
                        principalTable: "ArmoredVehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArmoredVehicles_NationId",
                table: "ArmoredVehicles",
                column: "NationId");

            migrationBuilder.CreateIndex(
                name: "IX_CrewMembers_ArmoredVehicleId",
                table: "CrewMembers",
                column: "ArmoredVehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrewMembers");

            migrationBuilder.DropTable(
                name: "ArmoredVehicles");

            migrationBuilder.DropTable(
                name: "Nations");
        }
    }
}
