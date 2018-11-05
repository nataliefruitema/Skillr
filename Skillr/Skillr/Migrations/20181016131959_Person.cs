using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Skillr.Migrations
{
    public partial class Person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    Insertion = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PersonAvailable = table.Column<bool>(nullable: false),
                    OnProjectUntil = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Skill = table.Column<string>(nullable: true),
                    SkillLevel = table.Column<string>(nullable: true),
                    Certificate = table.Column<bool>(nullable: false),
                    CertificateValidFrom = table.Column<DateTime>(nullable: false),
                    CertificateValidUntil = table.Column<DateTime>(nullable: false),
                    YearsExperience = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectNR = table.Column<string>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectDuration = table.Column<int>(nullable: false),
                    ProjectStartDate = table.Column<DateTime>(nullable: false),
                    ProjectEndDate = table.Column<DateTime>(nullable: false),
                    PersonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Projects_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_PersonID",
                table: "Projects",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
