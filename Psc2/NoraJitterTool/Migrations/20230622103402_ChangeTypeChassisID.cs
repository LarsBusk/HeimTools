using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoraJitterTool.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTypeChassisID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestSystem",
                columns: table => new
                {
                    TestSystemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChassisId = table.Column<long>(type: "bigint", nullable: false),
                    SystemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSystem", x => x.TestSystemId);
                });

            migrationBuilder.CreateTable(
                name: "TestSetup",
                columns: table => new
                {
                    TestSetupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoraVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CsvFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExcludeFromSummary = table.Column<bool>(type: "bit", nullable: false),
                    NoDelayedResults = table.Column<bool>(type: "bit", nullable: false),
                    PhysicalPC = table.Column<bool>(type: "bit", nullable: false),
                    PlatformVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TestSystemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSetup", x => x.TestSetupId);
                    table.ForeignKey(
                        name: "FK_TestSetup_TestSystem_TestSystemId",
                        column: x => x.TestSystemId,
                        principalTable: "TestSystem",
                        principalColumn: "TestSystemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Delays",
                columns: table => new
                {
                    DelaysId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Delay = table.Column<int>(type: "int", nullable: false),
                    TimeBetweenSamples = table.Column<int>(type: "int", nullable: false),
                    TestSetupId = table.Column<int>(type: "int", nullable: false),
                    SampleNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SampleDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OpcServerTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delays", x => x.DelaysId);
                    table.ForeignKey(
                        name: "FK_Delays_TestSetup_TestSetupId",
                        column: x => x.TestSetupId,
                        principalTable: "TestSetup",
                        principalColumn: "TestSetupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Delays_TestSetupId",
                table: "Delays",
                column: "TestSetupId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSetup_TestSystemId",
                table: "TestSetup",
                column: "TestSystemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delays");

            migrationBuilder.DropTable(
                name: "TestSetup");

            migrationBuilder.DropTable(
                name: "TestSystem");
        }
    }
}
