using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore_Ef_CodeFirst.Migrations
{
    public partial class Initial002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Categoria_CategoriaId",
                table: "Livro");

            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Categoria_CategoriaId1",
                table: "Livro");

            migrationBuilder.DropIndex(
                name: "IX_Livro_CategoriaId1",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "CategoriaId1",
                table: "Livro");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataEntrada",
                value: new DateTime(2021, 12, 25, 15, 37, 38, 378, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Categoria_CategoriaId",
                table: "Livro",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Categoria_CategoriaId",
                table: "Livro");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId1",
                table: "Livro",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataEntrada",
                value: new DateTime(2021, 12, 23, 23, 2, 13, 265, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.CreateIndex(
                name: "IX_Livro_CategoriaId1",
                table: "Livro",
                column: "CategoriaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Categoria_CategoriaId",
                table: "Livro",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Categoria_CategoriaId1",
                table: "Livro",
                column: "CategoriaId1",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
