using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRater.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    title = table.Column<string>(nullable: true),
                    episode_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    opening_crawl = table.Column<string>(nullable: true),
                    director = table.Column<string>(nullable: true),
                    producer = table.Column<string>(nullable: true),
                    release_date = table.Column<string>(nullable: true),
                    created = table.Column<DateTime>(nullable: false),
                    edited = table.Column<DateTime>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    numberOfVotes = table.Column<int>(nullable: false),
                    avg = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.episode_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
