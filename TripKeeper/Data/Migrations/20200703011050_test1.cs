using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TripKeeper.Data.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DotAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Tractor = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DriversLicense = table.Column<bool>(nullable: false),
                    DotCard = table.Column<bool>(nullable: false),
                    ExtraLogBook = table.Column<bool>(nullable: false),
                    PitCard = table.Column<bool>(nullable: false),
                    Tablet = table.Column<bool>(nullable: false),
                    DvirBook = table.Column<bool>(nullable: false),
                    Registration = table.Column<bool>(nullable: false),
                    InsuranceCard = table.Column<bool>(nullable: false),
                    Ifta = table.Column<bool>(nullable: false),
                    LogBook = table.Column<bool>(nullable: false),
                    EldGuide = table.Column<bool>(nullable: false),
                    PermitBook = table.Column<bool>(nullable: false),
                    PostAccidentKit = table.Column<bool>(nullable: false),
                    BlankAccidentReport = table.Column<bool>(nullable: false),
                    OregonFuelPermit = table.Column<bool>(nullable: false),
                    DriverSignature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DotAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EndRouteCheck",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Tractor = table.Column<int>(nullable: false),
                    Epj = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Trailer = table.Column<string>(nullable: true),
                    RouteNumber = table.Column<int>(nullable: false),
                    LoadQualitySurvey = table.Column<string>(nullable: true),
                    TurnInBols = table.Column<string>(nullable: true),
                    TurnInAllPaperwork = table.Column<string>(nullable: true),
                    PalletJack = table.Column<string>(nullable: true),
                    ReturnMisPicks = table.Column<string>(nullable: true),
                    ClearTrailer = table.Column<string>(nullable: true),
                    SweepTrailer = table.Column<string>(nullable: true),
                    ReportTrailer = table.Column<string>(nullable: true),
                    RetunDvir = table.Column<string>(nullable: true),
                    ReportEquipmentDamages = table.Column<string>(nullable: true),
                    StrapsHanding = table.Column<string>(nullable: true),
                    TrailerShuttle = table.Column<string>(nullable: true),
                    TrailerLocation = table.Column<string>(nullable: true),
                    DriverSignature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndRouteCheck", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatorEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    RouteNumber = table.Column<int>(nullable: false),
                    Epj = table.Column<int>(nullable: false),
                    FluidLeaks = table.Column<string>(nullable: true),
                    Tires = table.Column<string>(nullable: true),
                    Forks = table.Column<string>(nullable: true),
                    HandGuards = table.Column<string>(nullable: true),
                    SafetyWarnings = table.Column<string>(nullable: true),
                    OperatorsManual = table.Column<string>(nullable: true),
                    PowerCord = table.Column<string>(nullable: true),
                    CapacityPlate = table.Column<string>(nullable: true),
                    ServiceBreak = table.Column<string>(nullable: true),
                    SteeringOperation = table.Column<string>(nullable: true),
                    DrivingControl = table.Column<string>(nullable: true),
                    HoistControl = table.Column<string>(nullable: true),
                    Horn = table.Column<string>(nullable: true),
                    LightsAlarms = table.Column<string>(nullable: true),
                    HourMeter = table.Column<string>(nullable: true),
                    BatteryIndicator = table.Column<string>(nullable: true),
                    ManualForks = table.Column<string>(nullable: true),
                    Wheels = table.Column<string>(nullable: true),
                    Maneuverability = table.Column<string>(nullable: true),
                    Handle = table.Column<string>(nullable: true),
                    ManualFluidLeaks = table.Column<string>(nullable: true),
                    ReleaseLever = table.Column<string>(nullable: true),
                    CracksWear = table.Column<string>(nullable: true),
                    HandTruckWheels = table.Column<string>(nullable: true),
                    DockCracks = table.Column<string>(nullable: true),
                    Bent = table.Column<string>(nullable: true),
                    MissingHardware = table.Column<string>(nullable: true),
                    Pins = table.Column<string>(nullable: true),
                    LiftHandleDamage = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Signature = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatorEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsTeamRoute = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    RouteNumber = table.Column<int>(nullable: false),
                    Tractor = table.Column<int>(nullable: false),
                    Trailer = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartMiles = table.Column<decimal>(nullable: true),
                    EndingMiles = table.Column<decimal>(nullable: true),
                    Inspections = table.Column<int>(nullable: false),
                    BHPU = table.Column<int>(nullable: false),
                    XDock = table.Column<int>(nullable: false),
                    HourlyYard = table.Column<decimal>(nullable: false),
                    Chains = table.Column<int>(nullable: false),
                    Delay = table.Column<decimal>(nullable: false),
                    Sleeper = table.Column<int>(nullable: false),
                    Meals = table.Column<int>(nullable: false),
                    Pallets = table.Column<int>(nullable: false),
                    RoadStops = table.Column<int>(nullable: false),
                    SuperStops = table.Column<int>(nullable: false),
                    Shuttle = table.Column<int>(nullable: false),
                    Temp = table.Column<string>(nullable: true),
                    MiscExpense = table.Column<decimal>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    Signature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DotAudit");

            migrationBuilder.DropTable(
                name: "EndRouteCheck");

            migrationBuilder.DropTable(
                name: "OperatorEquipment");

            migrationBuilder.DropTable(
                name: "Trip");
        }
    }
}
