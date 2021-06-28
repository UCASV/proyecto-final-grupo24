using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_POO_DB.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CABIN",
                columns: table => new
                {
                    Cabin_number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email_cabin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    Adress_cabin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CABIN__243A3277D917687E", x => x.Cabin_number);
                });

            migrationBuilder.CreateTable(
                name: "POSITION",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSITION", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TYPE_EMPLOYEE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_employee = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TYPE_EMPLOYEE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Password_user = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    institutional_mail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Addres_user = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Name_user = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Lastname_user = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    id_type_employee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Id_type_employee",
                        column: x => x.id_type_employee,
                        principalTable: "TYPE_EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CITIZEN",
                columns: table => new
                {
                    Dui = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Name_citizen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    lastname_citizen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Address_citizen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: true),
                    Email_citizen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Institutional_identifier = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Id_position = table.Column<int>(type: "int", nullable: true),
                    Id_employee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CITIZEN__C0317D901DD7CD0F", x => x.Dui);
                    table.ForeignKey(
                        name: "FK_Id_employee_citizen",
                        column: x => x.Id_employee,
                        principalTable: "EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Id_position",
                        column: x => x.Id_position,
                        principalTable: "POSITION",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "REGISTRY",
                columns: table => new
                {
                    Cabin_number = table.Column<int>(type: "int", nullable: false),
                    Id_employee = table.Column<int>(type: "int", nullable: false),
                    Date_hour = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registry", x => new { x.Cabin_number, x.Id_employee });
                    table.ForeignKey(
                        name: "FK_Cabin_number_registry",
                        column: x => x.Cabin_number,
                        principalTable: "CABIN",
                        principalColumn: "Cabin_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Id_employee_registry",
                        column: x => x.Id_employee,
                        principalTable: "EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "APPOINTMENT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_hour = table.Column<DateTime>(type: "datetime", nullable: true),
                    Cabin_number = table.Column<int>(type: "int", nullable: true),
                    Id_employee = table.Column<int>(type: "int", nullable: true),
                    Dui_citizen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPOINTMENT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cabin_number",
                        column: x => x.Cabin_number,
                        principalTable: "CABIN",
                        principalColumn: "Cabin_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dui_citizen",
                        column: x => x.Dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "Dui",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Id_employee",
                        column: x => x.Id_employee,
                        principalTable: "EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DISEASE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dui_citizen = table.Column<int>(type: "int", nullable: true),
                    Disease = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DISEASE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dui_citizen_disease",
                        column: x => x.Dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "Dui",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VACCINATION_PROCESS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Row_date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    Vaccination_date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    Seconddose_date_time = table.Column<DateTime>(type: "datetime", nullable: true),
                    Seconddose_cabin = table.Column<int>(type: "int", nullable: true),
                    id_employee = table.Column<int>(type: "int", nullable: true),
                    Dui_citizen = table.Column<int>(type: "int", nullable: true),
                    Cabin_number = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VACCINATION_PROCESS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cabin_number_process",
                        column: x => x.Cabin_number,
                        principalTable: "CABIN",
                        principalColumn: "Cabin_number",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dui_citizen_process",
                        column: x => x.Dui_citizen,
                        principalTable: "CITIZEN",
                        principalColumn: "Dui",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Id_employee_process",
                        column: x => x.id_employee,
                        principalTable: "EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SECONDARY_EFFECT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_process = table.Column<int>(type: "int", nullable: true),
                    Secondary_effect = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Effect_minutes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECONDARY_EFFECT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Id_process",
                        column: x => x.Id_process,
                        principalTable: "VACCINATION_PROCESS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_Cabin_number",
                table: "APPOINTMENT",
                column: "Cabin_number");

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_Dui_citizen",
                table: "APPOINTMENT",
                column: "Dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_APPOINTMENT_Id_employee",
                table: "APPOINTMENT",
                column: "Id_employee");

            migrationBuilder.CreateIndex(
                name: "IX_CITIZEN_Id_employee",
                table: "CITIZEN",
                column: "Id_employee");

            migrationBuilder.CreateIndex(
                name: "IX_CITIZEN_Id_position",
                table: "CITIZEN",
                column: "Id_position");

            migrationBuilder.CreateIndex(
                name: "IX_DISEASE_Dui_citizen",
                table: "DISEASE",
                column: "Dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_EMPLOYEE_id_type_employee",
                table: "EMPLOYEE",
                column: "id_type_employee");

            migrationBuilder.CreateIndex(
                name: "IX_REGISTRY_Id_employee",
                table: "REGISTRY",
                column: "Id_employee");

            migrationBuilder.CreateIndex(
                name: "IX_SECONDARY_EFFECT_Id_process",
                table: "SECONDARY_EFFECT",
                column: "Id_process");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINATION_PROCESS_Cabin_number",
                table: "VACCINATION_PROCESS",
                column: "Cabin_number");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINATION_PROCESS_Dui_citizen",
                table: "VACCINATION_PROCESS",
                column: "Dui_citizen");

            migrationBuilder.CreateIndex(
                name: "IX_VACCINATION_PROCESS_id_employee",
                table: "VACCINATION_PROCESS",
                column: "id_employee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPOINTMENT");

            migrationBuilder.DropTable(
                name: "DISEASE");

            migrationBuilder.DropTable(
                name: "REGISTRY");

            migrationBuilder.DropTable(
                name: "SECONDARY_EFFECT");

            migrationBuilder.DropTable(
                name: "VACCINATION_PROCESS");

            migrationBuilder.DropTable(
                name: "CABIN");

            migrationBuilder.DropTable(
                name: "CITIZEN");

            migrationBuilder.DropTable(
                name: "EMPLOYEE");

            migrationBuilder.DropTable(
                name: "POSITION");

            migrationBuilder.DropTable(
                name: "TYPE_EMPLOYEE");
        }
    }
}
