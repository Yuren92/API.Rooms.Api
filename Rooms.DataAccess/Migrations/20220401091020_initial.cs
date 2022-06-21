using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rooms.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<int>(type: "int", nullable: true),
                    professional_area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    studies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_me = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    room_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    num_roommate = table.Column<int>(type: "int", nullable: false),
                    num_rooms = table.Column<int>(type: "int", nullable: false),
                    num_bath = table.Column<int>(type: "int", nullable: false),
                    bed_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    room_size = table.Column<double>(type: "float", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    number = table.Column<int>(type: "int", nullable: false),
                    floor_letter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    locality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postcode = table.Column<int>(type: "int", nullable: false),
                    is_furnished = table.Column<bool>(type: "bit", nullable: false),
                    has_air_conditioning = table.Column<bool>(type: "bit", nullable: false),
                    has_internet = table.Column<bool>(type: "bit", nullable: false),
                    has_elevator = table.Column<bool>(type: "bit", nullable: false),
                    has_whashing_machine = table.Column<bool>(type: "bit", nullable: false),
                    has_terrace = table.Column<bool>(type: "bit", nullable: false),
                    is_vegan = table.Column<bool>(type: "bit", nullable: false),
                    can_smoke = table.Column<bool>(type: "bit", nullable: false),
                    can_pets = table.Column<bool>(type: "bit", nullable: false),
                    can_couple = table.Column<bool>(type: "bit", nullable: false),
                    only_men = table.Column<bool>(type: "bit", nullable: false),
                    only_woman = table.Column<bool>(type: "bit", nullable: false),
                    min_age = table.Column<int>(type: "int", nullable: false),
                    max_age = table.Column<int>(type: "int", nullable: false),
                    about_tenant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rooms_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_userId",
                table: "Rooms",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
