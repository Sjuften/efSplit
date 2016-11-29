using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace entityFramework.App.Migrations
{
    public partial class datofbirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clan",
                columns: table => new
                {
                    ClanId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clan", x => x.ClanId);
                });

            migrationBuilder.CreateTable(
                name: "Ninja",
                columns: table => new
                {
                    NinjaId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ClanId = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NinjaType = table.Column<int>(nullable: false),
                    ServedInObiwan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ninja", x => x.NinjaId);
                    table.ForeignKey(
                        name: "FK_Ninja_Clan_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clan",
                        principalColumn: "ClanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NinjaEquipment",
                columns: table => new
                {
                    NinjaEquipmentId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    EquipmentType = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NinjaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NinjaEquipment", x => x.NinjaEquipmentId);
                    table.ForeignKey(
                        name: "FK_NinjaEquipment_Ninja_NinjaId",
                        column: x => x.NinjaId,
                        principalTable: "Ninja",
                        principalColumn: "NinjaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ninja_ClanId",
                table: "Ninja",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_NinjaEquipment_NinjaId",
                table: "NinjaEquipment",
                column: "NinjaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NinjaEquipment");

            migrationBuilder.DropTable(
                name: "Ninja");

            migrationBuilder.DropTable(
                name: "Clan");
        }
    }
}
