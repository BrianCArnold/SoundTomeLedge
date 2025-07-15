using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fixedServer.Migrations
{
    /// <inheritdoc />
    public partial class Fixup1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitleIgnorePrefix",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TitleIgnorePrefix",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
