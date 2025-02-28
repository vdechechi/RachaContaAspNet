using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RachaConta.Migrations
{
    /// <inheritdoc />
    public partial class Populando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Praia Carnaval 2025" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Vinicius" },
                    { 2, "Gabriel" },
                    { 3, "Murilo" },
                    { 4, "Jonas" },
                    { 5, "Miguel" },
                    { 6, "Fernando" },
                    { 7, "Gustavo" },
                    { 8, "Joao" },
                    { 9, "Jose" },
                    { 10, "Sergio" }
                });

            migrationBuilder.InsertData(
                table: "DiasEvento",
                columns: new[] { "Id", "Data", "EventoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Saldos",
                columns: new[] { "Id", "PessoaId", "Valor" },
                values: new object[,]
                {
                    { 1, 2, 850.00m },
                    { 2, 3, 300.00m },
                    { 3, 4, 100.00m },
                    { 4, 1, -50.00m },
                    { 5, 5, -16.67m }
                });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "Id", "DiaEventoId", "Nome", "ValorTotal" },
                values: new object[,]
                {
                    { 1, 1, "Mercado 1", 850.00m },
                    { 2, 3, "Adega", 400.00m }
                });

            migrationBuilder.InsertData(
                table: "EventoPessoas",
                columns: new[] { "Id", "DiaEventoId", "PessoaId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 3 },
                    { 3, 1, 4 },
                    { 4, 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "CompraParticipantes",
                columns: new[] { "Id", "CompraId", "PessoaId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 3 },
                    { 3, 2, 1 },
                    { 4, 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "Divisoes",
                columns: new[] { "Id", "CompraId", "CredorId", "DevedorId", "Valor" },
                values: new object[,]
                {
                    { 1, 1, 2, 3, 85.00m },
                    { 2, 1, 2, 4, 85.00m },
                    { 3, 2, 3, 1, 50.00m },
                    { 4, 2, 4, 5, 16.67m }
                });

            migrationBuilder.InsertData(
                table: "Pagamentos",
                columns: new[] { "Id", "CompraId", "PaganteId", "Valor" },
                values: new object[,]
                {
                    { 1, 1, 2, 850.00m },
                    { 2, 2, 3, 300.00m },
                    { 3, 2, 4, 100.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompraParticipantes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompraParticipantes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompraParticipantes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompraParticipantes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiasEvento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiasEvento",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiasEvento",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Divisoes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Divisoes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Divisoes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Divisoes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventoPessoas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventoPessoas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventoPessoas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventoPessoas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pagamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pagamentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pagamentos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pessoas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiasEvento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiasEvento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
