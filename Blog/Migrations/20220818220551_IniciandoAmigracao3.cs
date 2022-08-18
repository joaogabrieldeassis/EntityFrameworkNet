using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
    public partial class IniciandoAmigracao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Post",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_UserId",
                table: "Post",
                newName: "IX_Post_AuthorId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 18, 22, 5, 51, 0, DateTimeKind.Utc).AddTicks(6964),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2022, 8, 18, 21, 30, 57, 936, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 18, 22, 5, 51, 0, DateTimeKind.Utc).AddTicks(6803),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2022, 8, 18, 21, 30, 57, 936, DateTimeKind.Utc).AddTicks(5928));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Post",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_AuthorId",
                table: "Post",
                newName: "IX_Post_UserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 18, 21, 30, 57, 936, DateTimeKind.Utc).AddTicks(6092),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2022, 8, 18, 22, 5, 51, 0, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 18, 21, 30, 57, 936, DateTimeKind.Utc).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2022, 8, 18, 22, 5, 51, 0, DateTimeKind.Utc).AddTicks(6803));
        }
    }
}
