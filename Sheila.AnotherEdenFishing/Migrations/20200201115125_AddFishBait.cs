using Microsoft.EntityFrameworkCore.Migrations;

namespace Sheila.AnotherEdenFishing.Migrations
{
    public partial class AddFishBait : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FishBaitQuality",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishBaitQuality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FishBait",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    QualityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishBait", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FishBait_FishBaitQuality_QualityId",
                        column: x => x.QualityId,
                        principalTable: "FishBaitQuality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FishBait_QualityId",
                table: "FishBait",
                column: "QualityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FishBait");

            migrationBuilder.DropTable(
                name: "FishBaitQuality");
        }
    }
}
