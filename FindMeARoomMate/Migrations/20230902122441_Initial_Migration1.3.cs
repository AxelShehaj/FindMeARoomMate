using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FindMeARoomMate.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Migration13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DormitoryStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DormitoryId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DormitoryStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DormitoryStudents_Dormitories_DormitoryId",
                        column: x => x.DormitoryId,
                        principalTable: "Dormitories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DormitoryStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DormitoryStudents_DormitoryId",
                table: "DormitoryStudents",
                column: "DormitoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DormitoryStudents_StudentId",
                table: "DormitoryStudents",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DormitoryStudents");
        }
    }
}
