using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolApi.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    SpeakerId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: false),
                    AreaOfSpec = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Province = table.Column<string>(nullable: false),
                    Employer = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.SpeakerId);
                });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "AreaOfSpec", "City", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "Province" },
                values: new object[,]
                {
                    { "45939895-ff50-4abf-bc81-9e476740c66f", "Mechanics", "Burnaby", "tomDay@gmail.com", "BC Hydro", "Tom", "Day", "778-859-3447", "BC" },
                    { "f1b078ed-34f5-49b5-83f5-da025620a078", "Biomechanics", "Burnaby", "fNight@gmail.com", "Lex Luthor", "Fred", "Night", "778-333-1465", "BC" },
                    { "35c190dd-bab4-4314-82af-726e2e1e7e72", "Flatulence", "Burnaby", "phillipKrak@gmail.com", "Beans R' Us", "Phil", "McKracken", "778-010-3111", "BC" },
                    { "4fd72a47-538a-4793-8a7d-d4dbc9cbdd6f", "Prostate Exams", "Burnaby", "getOuttaThere@gmail.com", "Uncle Bob", "Ben", "Dover", "778-859-6969", "BC" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");
        }
    }
}
