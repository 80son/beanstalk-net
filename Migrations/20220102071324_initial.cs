using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace beanstalk_net.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreatedOn", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Finish YouTube video", new DateTime(2022, 1, 2, 7, 13, 24, 611, DateTimeKind.Utc).AddTicks(3802), new DateTime(2022, 1, 2, 7, 13, 24, 611, DateTimeKind.Utc).AddTicks(3802) },
                    { 2, "Go to the gym", new DateTime(2022, 1, 2, 7, 13, 24, 611, DateTimeKind.Utc).AddTicks(3802), new DateTime(2022, 1, 2, 7, 13, 24, 611, DateTimeKind.Utc).AddTicks(3802) },
                    { 3, "Go to the grocery market", new DateTime(2022, 1, 2, 7, 13, 24, 611, DateTimeKind.Utc).AddTicks(3802), new DateTime(2022, 1, 2, 7, 13, 24, 611, DateTimeKind.Utc).AddTicks(3802) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
