using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineProdajaKarata.Data.Migrations
{
    /// <inheritdoc />
    public partial class PrvaMigracijaBazePodataka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Karta",
                columns: table => new
                {
                    IdKarte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDUser = table.Column<int>(type: "int", nullable: false),
                    IDManifestacije = table.Column<int>(type: "int", nullable: false),
                    KodKarte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumKupovine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karta", x => x.IdKarte);
                });

            migrationBuilder.CreateTable(
                name: "KupljenaMjesta",
                columns: table => new
                {
                    IDMjesta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKarte = table.Column<int>(type: "int", nullable: false),
                    BrojReda = table.Column<int>(type: "int", nullable: false),
                    BrojKolone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupljenaMjesta", x => x.IDMjesta);
                });

            migrationBuilder.CreateTable(
                name: "Manifestacija",
                columns: table => new
                {
                    IDManifestacije = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivManifestacije = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumVrijeme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kategorija = table.Column<int>(type: "int", nullable: false),
                    MjestoOdrzavanja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrajanjeManifestacije = table.Column<int>(type: "int", nullable: false),
                    OpisManifestacije = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CijenaKarte = table.Column<double>(type: "float", nullable: false),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manifestacija", x => x.IDManifestacije);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IDUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojKupljenihKarata = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IDUser);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Karta");

            migrationBuilder.DropTable(
                name: "KupljenaMjesta");

            migrationBuilder.DropTable(
                name: "Manifestacija");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
