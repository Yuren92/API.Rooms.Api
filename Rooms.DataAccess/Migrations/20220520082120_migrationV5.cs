using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rooms.DataAccess.Migrations
{
    public partial class migrationV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "can_smoke",
                table: "Rooms",
                newName: "room_smoke");

            migrationBuilder.RenameColumn(
                name: "can_pets",
                table: "Rooms",
                newName: "room_pet");

            migrationBuilder.RenameColumn(
                name: "can_couple",
                table: "Rooms",
                newName: "room_couples");

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "has_private_bath",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "has_private_view",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "room_couples",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "roommate_gender",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "roommate_gender",
                table: "Rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "has_private_view",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "has_private_bath",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_private_view",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "room_couples",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "roommate_gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "has_private_view",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "room_smoke",
                table: "Rooms",
                newName: "can_smoke");

            migrationBuilder.RenameColumn(
                name: "room_pet",
                table: "Rooms",
                newName: "can_pets");

            migrationBuilder.RenameColumn(
                name: "room_couples",
                table: "Rooms",
                newName: "can_couple");

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "roommate_gender",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
