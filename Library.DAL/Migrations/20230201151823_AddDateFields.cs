using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddDateFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("144ce16c-fc48-4b0f-9fa6-ee0dd5a37c57"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("1aead3a0-baa6-4728-9f0f-8b086ba2a1f8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("1c4a8abb-fd2b-43c8-b32f-2682dfb5d786"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("5086caef-6329-4c19-8595-eb2e1d2d4d46"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("5ff705db-9064-48f4-aae8-f5120d312e57"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("7224ee1f-8b5e-4b8a-8504-4e971dcd4a2a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("b3499f51-94ea-43b6-8356-faeae528f8cd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("ba7624e8-aff1-4c2f-9078-ae5292b90e8d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("d6115b5d-c0b4-43f9-894e-d32d40702919"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("db1b0568-3a84-4034-87d8-e1cb2b557b0b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("097f6cb4-935e-46f0-85ad-33959ee2cc13"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("3d853318-f3ad-48e0-b2cd-8e096af24200"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("7d2b7f5a-e262-41aa-a940-485fad8e8481"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("8d74b6c0-8df9-49e6-9426-a4371e92309f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("af82a8ad-cf1a-459d-b1bd-03e6ce6e815d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("bb326b75-f233-4894-bd99-8c41ffdeade8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ce3a3338-2acb-4740-8a29-586fe4d9b489"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ce467e7f-60cb-4fce-84c3-f93a48087de4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e6e9e4eb-06c7-40c0-9369-c0a1a0156ffe"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("e724506a-e28f-4a3b-88e8-a0da6df0c4de"));

            migrationBuilder.AddColumn<long>(
                name: "CreateDate",
                table: "Books",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EditDate",
                table: "Books",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { new Guid("14963b13-badc-4d75-b61c-6ded1c02f3e3"), "Mikhail Lermontov" },
                    { new Guid("27204a7d-e7e6-41c3-a026-a0af7a5b0873"), "Nikolai Nekrasov" },
                    { new Guid("45cdeeb5-d782-413b-b259-11b1605f7982"), "Sergei Yesenin" },
                    { new Guid("6ae90f4e-3872-4baf-abb6-002b52339257"), "Fyodor Tyutchev" },
                    { new Guid("6ce1a558-ff07-46e5-9057-e8742f1b88ba"), "Anna Akhmatova" },
                    { new Guid("abfe92fb-f59f-4367-8c3b-16674eb3a67b"), "Alexander Blok" },
                    { new Guid("b0faee93-ae39-46f6-bee8-503f8d387f92"), "Vladimir Mayakovsky" },
                    { new Guid("c7b62640-b6fd-46d6-b431-eeace48d860e"), "Marina Tsvetaeva" },
                    { new Guid("e4f10c54-0451-4b4f-8d78-3fc27d62d170"), "Alexander Pushkin" },
                    { new Guid("eebb88d1-f23b-4dcf-83f0-e6cbda92798c"), "Lev Tolstoy" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { new Guid("26e246d3-dbce-4a2c-bcdb-acbbf976d6f8"), "History" },
                    { new Guid("2b6ecb9e-27eb-4869-b0a7-6871e4cace65"), "Biography" },
                    { new Guid("62b66edd-34c7-4b0d-ab36-e262048e8920"), "Comedy" },
                    { new Guid("9b890f57-358a-4877-953a-c197d459604b"), "Horror" },
                    { new Guid("9bb9484c-b14d-4e4a-a9a0-a3e1b58f5fbe"), "Detective" },
                    { new Guid("a9eb0a53-0699-4391-8bf9-e395010e5a80"), "Education" },
                    { new Guid("bdf06529-6d3d-4b5b-b509-e00175c9303a"), "Dystopian" },
                    { new Guid("d1d62042-bd6a-49a4-a846-7f63b78307d5"), "Adventure" },
                    { new Guid("df7422e6-6c6e-4c8a-85f8-083a715aa2fb"), "Romance" },
                    { new Guid("ff5257c4-bd95-4677-897f-311bb5618252"), "Fantasy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("14963b13-badc-4d75-b61c-6ded1c02f3e3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("27204a7d-e7e6-41c3-a026-a0af7a5b0873"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("45cdeeb5-d782-413b-b259-11b1605f7982"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("6ae90f4e-3872-4baf-abb6-002b52339257"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("6ce1a558-ff07-46e5-9057-e8742f1b88ba"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("abfe92fb-f59f-4367-8c3b-16674eb3a67b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("b0faee93-ae39-46f6-bee8-503f8d387f92"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("c7b62640-b6fd-46d6-b431-eeace48d860e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("e4f10c54-0451-4b4f-8d78-3fc27d62d170"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("eebb88d1-f23b-4dcf-83f0-e6cbda92798c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("26e246d3-dbce-4a2c-bcdb-acbbf976d6f8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("2b6ecb9e-27eb-4869-b0a7-6871e4cace65"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("62b66edd-34c7-4b0d-ab36-e262048e8920"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9b890f57-358a-4877-953a-c197d459604b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("9bb9484c-b14d-4e4a-a9a0-a3e1b58f5fbe"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("a9eb0a53-0699-4391-8bf9-e395010e5a80"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("bdf06529-6d3d-4b5b-b509-e00175c9303a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("d1d62042-bd6a-49a4-a846-7f63b78307d5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("df7422e6-6c6e-4c8a-85f8-083a715aa2fb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: new Guid("ff5257c4-bd95-4677-897f-311bb5618252"));

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "EditDate",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { new Guid("144ce16c-fc48-4b0f-9fa6-ee0dd5a37c57"), "Alexander Pushkin" },
                    { new Guid("1aead3a0-baa6-4728-9f0f-8b086ba2a1f8"), "Marina Tsvetaeva" },
                    { new Guid("1c4a8abb-fd2b-43c8-b32f-2682dfb5d786"), "Alexander Blok" },
                    { new Guid("5086caef-6329-4c19-8595-eb2e1d2d4d46"), "Lev Tolstoy" },
                    { new Guid("5ff705db-9064-48f4-aae8-f5120d312e57"), "Vladimir Mayakovsky" },
                    { new Guid("7224ee1f-8b5e-4b8a-8504-4e971dcd4a2a"), "Anna Akhmatova" },
                    { new Guid("b3499f51-94ea-43b6-8356-faeae528f8cd"), "Sergei Yesenin" },
                    { new Guid("ba7624e8-aff1-4c2f-9078-ae5292b90e8d"), "Mikhail Lermontov" },
                    { new Guid("d6115b5d-c0b4-43f9-894e-d32d40702919"), "Fyodor Tyutchev" },
                    { new Guid("db1b0568-3a84-4034-87d8-e1cb2b557b0b"), "Nikolai Nekrasov" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { new Guid("097f6cb4-935e-46f0-85ad-33959ee2cc13"), "Romance" },
                    { new Guid("3d853318-f3ad-48e0-b2cd-8e096af24200"), "Detective" },
                    { new Guid("7d2b7f5a-e262-41aa-a940-485fad8e8481"), "Fantasy" },
                    { new Guid("8d74b6c0-8df9-49e6-9426-a4371e92309f"), "Horror" },
                    { new Guid("af82a8ad-cf1a-459d-b1bd-03e6ce6e815d"), "Adventure" },
                    { new Guid("bb326b75-f233-4894-bd99-8c41ffdeade8"), "Dystopian" },
                    { new Guid("ce3a3338-2acb-4740-8a29-586fe4d9b489"), "Biography" },
                    { new Guid("ce467e7f-60cb-4fce-84c3-f93a48087de4"), "Comedy" },
                    { new Guid("e6e9e4eb-06c7-40c0-9369-c0a1a0156ffe"), "Education" },
                    { new Guid("e724506a-e28f-4a3b-88e8-a0da6df0c4de"), "History" }
                });
        }
    }
}
