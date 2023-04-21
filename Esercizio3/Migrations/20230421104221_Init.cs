using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esercizio3.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ARTIST",
                columns: table => new
                {
                    Id_Artist = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ARTIST__FB56A910C00D5928", x => x.Id_Artist);
                });

            migrationBuilder.CreateTable(
                name: "CHARCATER",
                columns: table => new
                {
                    ID_Character = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHARCATE__DFFB2D56336DEC5F", x => x.ID_Character);
                });

            migrationBuilder.CreateTable(
                name: "MUSEUM",
                columns: table => new
                {
                    Id_Museum = table.Column<int>(type: "int", nullable: false),
                    MuseumName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MUSEUM__84BA0522D78E9BCF", x => x.Id_Museum);
                });

            migrationBuilder.CreateTable(
                name: "ARTWORK",
                columns: table => new
                {
                    ID_Artwork = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID_Museum = table.Column<int>(type: "int", nullable: false),
                    ID_Artist = table.Column<int>(type: "int", nullable: false),
                    ID_Character = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ARTWORK__36F32885CD63E055", x => x.ID_Artwork);
                    table.ForeignKey(
                        name: "FK__ARTWORK__ID_Arti__440B1D61",
                        column: x => x.ID_Artist,
                        principalTable: "ARTIST",
                        principalColumn: "Id_Artist");
                    table.ForeignKey(
                        name: "FK__ARTWORK__ID_Char__44FF419A",
                        column: x => x.ID_Character,
                        principalTable: "CHARCATER",
                        principalColumn: "ID_Character");
                    table.ForeignKey(
                        name: "FK__ARTWORK__ID_Muse__4316F928",
                        column: x => x.ID_Museum,
                        principalTable: "MUSEUM",
                        principalColumn: "Id_Museum");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ARTWORK_ID_Artist",
                table: "ARTWORK",
                column: "ID_Artist");

            migrationBuilder.CreateIndex(
                name: "IX_ARTWORK_ID_Character",
                table: "ARTWORK",
                column: "ID_Character");

            migrationBuilder.CreateIndex(
                name: "IX_ARTWORK_ID_Museum",
                table: "ARTWORK",
                column: "ID_Museum");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARTWORK");

            migrationBuilder.DropTable(
                name: "ARTIST");

            migrationBuilder.DropTable(
                name: "CHARCATER");

            migrationBuilder.DropTable(
                name: "MUSEUM");
        }
    }
}
