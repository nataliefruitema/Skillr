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
                    FirstName = table.Column<string>(maxLength: 15, nullable: false),
                    Insertion = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    PersonAvailable = table.Column<bool>(nullable: false),
                    OnProjectUntil = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectNR = table.Column<string>(nullable: false),
                    ProjectName = table.Column<string>(maxLength: 15, nullable: false),
                    ProjectDuration = table.Column<int>(nullable: false),
                    ProjectStartDate = table.Column<DateTime>(nullable: false),
                    ProjectEndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectsID = table.Column<int>(nullable: false),
                    PersonID = table.Column<int>(nullable: false),
                    SkillsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Manager_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Manager_Projects_ProjectsID",
                        column: x => x.ProjectsID,
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Skill = table.Column<string>(maxLength: 15, nullable: false),
                    SkillLevel = table.Column<string>(maxLength: 15, nullable: true),
                    Certificate = table.Column<bool>(nullable: false),
                    CertificateValidFrom = table.Column<DateTime>(nullable: false),
                    CertificateValidUntil = table.Column<DateTime>(nullable: false),
                    YearsExperience = table.Column<int>(nullable: false),
                    ManagerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Skills_Manager_ManagerID",
                        column: x => x.ManagerID,
                        principalTable: "Manager",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manager_PersonID",
                table: "Manager",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_ProjectsID",
                table: "Manager",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ManagerID",
                table: "Skills",
                column: "ManagerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
