using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDCanxWebAPI.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BACs",
                columns: table => new
                {
                    PolicyRef = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DueDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Branch = table.Column<int>(type: "int", nullable: false),
                    ContinueDD = table.Column<bool>(type: "bit", nullable: false),
                    PaidBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangeDate = table.Column<bool>(type: "bit", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BACs", x => x.PolicyRef);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BACs");
        }
    }
}
