using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataManager.Migrations
{
    /// <inheritdoc />
    public partial class _2322 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Good",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CategoriesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Good", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Good_Category_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CategoriesId = table.Column<int>(type: "integer", nullable: false),
                    GoodsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Field_Category_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Field_Good_GoodsId",
                        column: x => x.GoodsId,
                        principalTable: "Good",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FieldDescribe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GoodId = table.Column<int>(type: "integer", nullable: false),
                    CategoriesId = table.Column<int>(type: "integer", nullable: false),
                    FieldId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    GoodsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldDescribe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FieldDescribe_Category_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FieldDescribe_Field_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Field",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FieldDescribe_Good_GoodsId",
                        column: x => x.GoodsId,
                        principalTable: "Good",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Field_CategoriesId",
                table: "Field",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Field_GoodsId",
                table: "Field",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_FieldDescribe_CategoriesId",
                table: "FieldDescribe",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_FieldDescribe_FieldId",
                table: "FieldDescribe",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_FieldDescribe_GoodsId",
                table: "FieldDescribe",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_Good_CategoriesId",
                table: "Good",
                column: "CategoriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FieldDescribe");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "Good");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
