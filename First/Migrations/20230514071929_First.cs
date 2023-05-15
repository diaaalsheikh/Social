using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AGE = table.Column<int>(type: "int", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acounts", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acounts");
        }
    }
}
