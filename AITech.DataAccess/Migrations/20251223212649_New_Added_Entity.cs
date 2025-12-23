using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AITech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class New_Added_Entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item1",
                table: "Chooses");

            migrationBuilder.DropColumn(
                name: "Item2",
                table: "Chooses");

            migrationBuilder.DropColumn(
                name: "Item3",
                table: "Chooses");

            migrationBuilder.CreateTable(
                name: "ChooseItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChooseItems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChooseItems");

            migrationBuilder.AddColumn<string>(
                name: "Item1",
                table: "Chooses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Item2",
                table: "Chooses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Item3",
                table: "Chooses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
