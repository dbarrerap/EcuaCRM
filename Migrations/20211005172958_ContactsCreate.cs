using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationsAPI.Migrations
{
    public partial class ContactsCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Cliente_ClienteID",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_ClienteID",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.AddColumn<string>(
                name: "ClienteEmail",
                table: "Reservation",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Cliente",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Email");

            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstablishmentID = table.Column<int>(type: "int", nullable: true),
                    ProviderID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacto_Establishment_EstablishmentID",
                        column: x => x.EstablishmentID,
                        principalTable: "Establishment",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacto_Provider_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Provider",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ClienteEmail",
                table: "Reservation",
                column: "ClienteEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_EstablishmentID",
                table: "Contacto",
                column: "EstablishmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_ProviderID",
                table: "Contacto",
                column: "ProviderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Cliente_ClienteEmail",
                table: "Reservation",
                column: "ClienteEmail",
                principalTable: "Cliente",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Cliente_ClienteEmail",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_ClienteEmail",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "ClienteEmail",
                table: "Reservation");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Cliente",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_ClienteID",
                table: "Reservation",
                column: "ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Cliente_ClienteID",
                table: "Reservation",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
