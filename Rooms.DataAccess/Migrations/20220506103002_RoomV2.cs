using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rooms.DataAccess.Migrations
{
    public partial class RoomV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "about_tenant",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "max_age",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "min_age",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "num_bath",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "num_roommate",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "num_rooms",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "room_size",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "only_woman",
                table: "Rooms",
                newName: "is_accessibility");

            migrationBuilder.RenameColumn(
                name: "only_men",
                table: "Rooms",
                newName: "has_private_bath");

            migrationBuilder.RenameColumn(
                name: "is_vegan",
                table: "Rooms",
                newName: "has_parking");

            migrationBuilder.RenameColumn(
                name: "has_terrace",
                table: "Rooms",
                newName: "has_heating");

            migrationBuilder.AddColumn<bool>(
                name: "has_balcony",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_dishwasher",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_doorman",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_drying_machine",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_garden",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "has_balcony",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "has_dishwasher",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "has_doorman",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "has_drying_machine",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "has_garden",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "is_accessibility",
                table: "Rooms",
                newName: "only_woman");

            migrationBuilder.RenameColumn(
                name: "has_private_bath",
                table: "Rooms",
                newName: "only_men");

            migrationBuilder.RenameColumn(
                name: "has_parking",
                table: "Rooms",
                newName: "is_vegan");

            migrationBuilder.RenameColumn(
                name: "has_heating",
                table: "Rooms",
                newName: "has_terrace");

            migrationBuilder.AddColumn<string>(
                name: "about_tenant",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "max_age",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "min_age",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "num_bath",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "num_roommate",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "num_rooms",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "room_size",
                table: "Rooms",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
