using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taofitAPI.Migrations
{
    /// <inheritdoc />
    public partial class columnsfixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "calory",
                table: "Foods",
                newName: "Calory");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Foods",
                newName: "FoodId");

            migrationBuilder.AlterColumn<string>(
                name: "MealName",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FoodName",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "Calory",
                table: "Foods",
                newName: "calory");

            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "Foods",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "MealName",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FoodName",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
