using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CreateDatabase.DAL.Migrations
{
    public partial class AddtablestoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    UrlSlug = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    UrlSlug = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ShortDescription = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Meta = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    UrlSlug = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Published = table.Column<byte>(type: "smallint", nullable: false),
                    PostedOn = table.Column<byte>(type: "smallint", nullable: false),
                    Modified = table.Column<byte>(type: "smallint", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPosts_tblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPostTagMap",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_tblPostTagMap_tblPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "tblPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPostTagMap_tblTags_TagId",
                        column: x => x.TagId,
                        principalTable: "tblTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPosts_CategoryId",
                table: "tblPosts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostTagMap_PostId",
                table: "tblPostTagMap",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostTagMap_TagId",
                table: "tblPostTagMap",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPostTagMap");

            migrationBuilder.DropTable(
                name: "tblPosts");

            migrationBuilder.DropTable(
                name: "tblTags");

            migrationBuilder.DropTable(
                name: "tblCategory");
        }
    }
}
