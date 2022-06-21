using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rooms.DataAccess.Migrations
{
    public partial class UserV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "professional_area",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bed_type",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "has_air_conditioning",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_balcony",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_dishwasher",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_doorman",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_drying_machine",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_elevator",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_garden",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_heating",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_internet",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_parking",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_whashing_machine",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_accessibility",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_furnished",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "locality",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "num_roommate",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "room_pet",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "room_smoke",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "user_pet",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "user_smoke",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "user_vegan",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "roommate_gender",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bed_type",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_air_conditioning",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_balcony",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_dishwasher",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_doorman",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_drying_machine",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_elevator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_garden",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_heating",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_internet",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_parking",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_whashing_machine",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "is_accessibility",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "is_furnished",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "locality",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "num_roommate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "room_pet",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "room_smoke",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "user_pet",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "user_smoke",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "user_vegan",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "roommate_gender",
                table: "Rooms");

            migrationBuilder.AlterColumn<int>(
                name: "phone",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "professional_area",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
