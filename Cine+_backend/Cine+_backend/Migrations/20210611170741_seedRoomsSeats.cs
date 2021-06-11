using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cine__backend.Migrations
{
    public partial class seedRoomsSeats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("0efd796a-6fab-49a6-8f8c-e1c6694cbf8d"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("561bd9f1-f639-4d47-97f9-2fe17a24c1cd"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("731c6aa3-da3e-467b-be26-c64040516cbd"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("7586cd40-b8ed-4934-b1a9-add3f54cca81"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("76e5648d-f6ce-4c8e-8b57-bf857522d84f"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("b1b5ff9b-834e-4742-ba55-6c82574d683a"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("bcda5d63-6f89-4a33-abdc-bac32ffa51b1"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("d015d12d-e3cd-4d63-9d29-c20688ba15a7"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("204e0b1f-4127-4c8b-b6ee-6a2b95bceca4"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("30160a59-c633-4471-b0db-366bb9fcd0eb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5192a3ab-2aa1-4f1a-bc94-6351723ad339"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("631bbec2-de09-4d3e-acd2-5e8740daac02"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6d875347-b4df-4f64-9475-8b10fb9f5597"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9074a790-64ae-4d9b-94cb-4358b8855722"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9666c8bd-0192-4acf-b860-59ccd6bbc7c0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a97b0883-7b2c-4829-a8f6-4ae2d09b2210"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b8fab495-6bb4-4117-b21c-7aa5b98dbe9f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b95f0c4c-0c3f-41e2-88ef-40c9c2da368b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d30f8b7f-c419-4c44-9d44-3256c4c7e9a0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e35856ec-0fc6-4f6e-92fe-fdfa0f9f7a8e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e4575e86-ab2f-453f-a611-53a98d82f33f"));

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Seats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ClubMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a1c8e241-34bc-4ddb-b0a5-85ea60564933"), "Actor" },
                    { new Guid("c5bde257-e32a-4863-83c5-aeaa96aaa36d"), "Director" },
                    { new Guid("e8eed591-fa67-416d-9bfd-979dc03dc7ab"), "Productor" },
                    { new Guid("c1706b1a-2e4a-4a7a-98a0-ed149f8179a5"), "Asistente de dirección" },
                    { new Guid("0c05ff25-7a41-4033-941b-7afcfc792346"), "Productor Ejecutivo" },
                    { new Guid("5a99e2cb-cc54-45a1-9ca7-f24d9d8b28aa"), "Guionista" },
                    { new Guid("4ee44104-6a3a-498e-84f2-cd814f2032b0"), "Diseñador de Vestuario" },
                    { new Guid("40aba767-8c86-4be4-9867-23f8ec65de20"), "Técnico de Sonido" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e81c4cce-5031-45ce-b1ea-c1287172807a"), "Erótico" },
                    { new Guid("f34952bf-f2d9-461b-94da-63543a928b87"), "Aventura" },
                    { new Guid("dfde672e-ae28-46e9-b414-4701a84abbbe"), "Ciencia Ficción" },
                    { new Guid("fbc22ae8-8742-4a07-9932-ea82cae038af"), "Ficción" },
                    { new Guid("ca8e89a2-2772-4fab-bd24-e50aa5fa0ea2"), "Documental" },
                    { new Guid("ec3c15bc-16a9-4913-b855-046054a78487"), "Hístorico" },
                    { new Guid("718dbd90-e2c9-4f3d-a697-a6485cafc5e0"), "Musical" },
                    { new Guid("1e9e494a-def9-43a5-8a1b-97b9b43047ea"), "Terror" },
                    { new Guid("6a4a9cdf-8352-4d4e-8037-f86d42b0085c"), "Suspenso" },
                    { new Guid("d543aeae-b978-4d34-bdfa-3e14a6580adf"), "Romántica" },
                    { new Guid("e84cfb0c-9b0a-474e-9038-4d65acf727e0"), "Comedia" },
                    { new Guid("92df19e8-e452-46f0-8804-e6e83eb11de8"), "Drama" },
                    { new Guid("cc6170e2-f391-4f7a-8c43-455e4d9f0546"), "Tragicomedia" }
                });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Name", "PercentOfPriceIncrement" },
                values: new object[,]
                {
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), "Platea Baja", 10 },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), "Platea Alta", 0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), "Sala 1" },
                    { new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), "Sala 2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("7d55cfcc-ae0e-4c0a-ad15-f7adfc471166"), "C2" },
                    { new Guid("c2144afd-b1c2-4b6a-8e79-d6ecbfd22eae"), "C1" },
                    { new Guid("b2212667-0eec-4d72-a9a0-d428070b82ed"), "B3" },
                    { new Guid("a522cdf8-d173-4af4-837b-fa55e903aaab"), "B2" },
                    { new Guid("a376ceee-2b96-4d3b-82da-fa84e6caedbe"), "B1" },
                    { new Guid("a3bcd9ce-5b4e-4015-b6d3-f44163095a40"), "A3" },
                    { new Guid("0fc4105f-78e5-4f22-8835-16366df00ede"), "G2" },
                    { new Guid("45ce6cfe-db09-4c7b-a98d-3dfe46bc8604"), "A1" },
                    { new Guid("55de74bc-ef6c-4ce9-9234-5827a9793569"), "H2" },
                    { new Guid("562e1436-4af1-4e6e-aa20-f55b19243792"), "H1" },
                    { new Guid("b2d9b2b5-f01e-4a15-abfe-6d5819c3f9aa"), "G1" },
                    { new Guid("7f046953-8767-4547-9fbe-97a2d9f040e7"), "C3" },
                    { new Guid("26ba53e9-4fa4-4a8c-ba0c-c735e63804c8"), "A2" },
                    { new Guid("efc46fa5-3f4f-4fbe-86bd-b85aab424310"), "D1" },
                    { new Guid("bfbe5ed1-ddfc-42b0-b5db-00e9e31a2427"), "H2" },
                    { new Guid("e41ea046-2b1d-486a-b379-f8cf713d641f"), "D3" },
                    { new Guid("2c89f98a-f9a4-409e-bbf2-f478f96ed60b"), "E1" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("b1c6e479-f06f-4bc5-9dd6-bb8cd52300ab"), "E2" },
                    { new Guid("a7342338-6d6e-44b2-ac6b-f9c0716b150a"), "E3" },
                    { new Guid("af2e3756-4892-4e2d-89bf-f0a8575ed75e"), "F1" },
                    { new Guid("bad88dba-35c7-486f-a77a-40fe9efb818d"), "F2" },
                    { new Guid("4324db59-8bc7-4e6f-9a50-eaba6464a77e"), "F3" },
                    { new Guid("433b9103-6bfa-4d90-9630-0be04c6f9340"), "G1" },
                    { new Guid("3da2bcee-a029-4c9c-879e-fb69b8ccb96d"), "G2" },
                    { new Guid("c72cdc99-df9c-4160-a20c-c36b3219e70a"), "G3" },
                    { new Guid("4c278584-0e00-4c55-af75-c1f5c1200cff"), "H1" },
                    { new Guid("ca4ade3e-087e-4759-a062-44601bbd9a01"), "F2" },
                    { new Guid("622b3c1d-92a2-4816-b784-01256faaa4e7"), "H3" },
                    { new Guid("1a351ade-b513-47c1-900a-3d2d9aa9203f"), "A1" },
                    { new Guid("020b690f-21c2-4772-9115-7b94a316a169"), "D2" },
                    { new Guid("d9ff3aca-cc71-4fd5-8c20-3bb03a75b7d7"), "F1" },
                    { new Guid("071e0714-25ce-4e57-baa5-c0463f415052"), "H1" },
                    { new Guid("f5789940-0be6-4880-b825-a33ad7fd0074"), "E1" },
                    { new Guid("6f93ab29-6a0a-4872-bb5c-baeffaa081d6"), "A3" },
                    { new Guid("3c7ffefa-5ac5-42a5-a2f3-08cef72ad726"), "B1" },
                    { new Guid("feabfc35-7976-4ff3-ae55-32d8a0bfd417"), "B2" },
                    { new Guid("60090208-1030-434d-b027-9bcb84331c44"), "B3" },
                    { new Guid("516722ab-8eea-4ebf-b1eb-7516ac699620"), "C1" },
                    { new Guid("45c514e9-90d4-454a-a1ed-c4b2ae80b75a"), "C2" },
                    { new Guid("982f8cbd-75d3-4a0a-8e28-9536e868c548"), "C3" },
                    { new Guid("773feea3-0898-4197-8c6f-4a15890a9e64"), "D1" },
                    { new Guid("eae3791d-de5d-4c8e-ad07-4fc0373ec39c"), "D2" },
                    { new Guid("50e186aa-62fb-437f-9cdd-7aa8ace72c24"), "D3" },
                    { new Guid("8cd28f80-1cc4-4bfd-aa90-0ab9d58b769c"), "E1" },
                    { new Guid("7fdec753-9e0c-4846-9237-ce77b8b5790b"), "E2" },
                    { new Guid("b810590e-bf9d-4476-a834-ed947128ac82"), "E3" },
                    { new Guid("ce60181d-c5b8-4a59-a479-b5cf78e302e5"), "F1" },
                    { new Guid("e21e6208-a540-4dd4-bcd2-c30f6e5d3c5a"), "E2" },
                    { new Guid("6baaf99f-3430-47bf-a3b6-28d924f87d60"), "F2" },
                    { new Guid("832f70d8-6b47-41bc-89d0-9e24809d6d63"), "G1" },
                    { new Guid("a2dd8bec-3453-4984-a82f-1ae60e58abb4"), "G2" },
                    { new Guid("39501a9f-5aab-498d-a87d-314ba2bfbfff"), "G3" },
                    { new Guid("d37cc7e3-0a33-495c-9250-cab725ff0d22"), "B1" },
                    { new Guid("d923813b-d492-476a-8d14-1bcab360aacd"), "H2" },
                    { new Guid("48d629b0-01a9-4e09-b769-d3ea86e46762"), "H3" },
                    { new Guid("8e8612a1-701c-4d7c-9dc7-41f7f310b537"), "A1" },
                    { new Guid("16a7e420-4a7e-4296-b8cc-b3618a25274c"), "A2" },
                    { new Guid("df7453b3-76d7-48cc-aca4-46649001225f"), "B1" },
                    { new Guid("d57e18b9-4722-4c3a-a97e-42d9b4e085f7"), "B2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("2f51f68d-1d83-4722-a0b4-331cee0f610e"), "C1" },
                    { new Guid("8ac1ff32-1223-48c6-905b-c1d46fc66da8"), "C2" },
                    { new Guid("d501224f-a7fa-488c-9bb6-5bae85caa5a8"), "D1" },
                    { new Guid("8b844dbb-c23d-4ad0-b6ef-3a6711d10e03"), "D2" },
                    { new Guid("c08e4dbd-f980-4940-ab52-93d7b2ae52ab"), "F3" },
                    { new Guid("09b344bd-295a-4043-8d12-d453b70c2ee8"), "B2" },
                    { new Guid("8e1d6878-7ddb-4ebc-af87-b5a8fa3b1dfe"), "F1" },
                    { new Guid("de0d7a08-72db-4585-ac47-59b5763075e8"), "C2" },
                    { new Guid("26df5422-adea-4f3a-a9bf-247cff51b203"), "D1" },
                    { new Guid("9a7e96b1-5633-4f2f-9d8b-578daa64c934"), "D2" },
                    { new Guid("7355ff82-a06e-4315-81a2-2c4cc282ecd5"), "D3" },
                    { new Guid("3c445b92-ae41-47d5-8eca-2fa795b4df07"), "D4" },
                    { new Guid("210d7681-63dc-4a21-b425-828c1ba955a9"), "E1" },
                    { new Guid("f9017914-192f-4ebe-9eac-448e20e56431"), "E2" },
                    { new Guid("11244fb4-8d05-4b20-a76d-03c393e5acfa"), "E3" },
                    { new Guid("79808e5b-e5ff-4aab-aaca-54e0043bc0be"), "F1" },
                    { new Guid("62f012fe-6c7e-4615-ab50-4cb029c47299"), "F2" },
                    { new Guid("ebe0a269-4c84-477c-b225-907039095f86"), "A1" },
                    { new Guid("233d2378-6108-48e8-acea-58eea44fff24"), "B1" },
                    { new Guid("2b327e6c-7f40-47b2-a0a7-a4513c957b62"), "B2" },
                    { new Guid("5a5a46cc-d84b-475d-af3e-aa8146530005"), "C1" },
                    { new Guid("867cef07-7897-474a-b302-86d5fd93f0f6"), "C2" },
                    { new Guid("2c79677a-54fc-48eb-af9a-5dfd0b725e60"), "C5" },
                    { new Guid("58cf0b53-499d-4697-bead-bb5c3f7def90"), "C3" },
                    { new Guid("dd11c2ff-7cc8-4c33-a0d9-f70fa15cf055"), "D2" },
                    { new Guid("ab8f6499-b6b6-4d70-84f8-cc2444a4f375"), "D3" },
                    { new Guid("51f6662f-6346-489f-9bba-fe9b57f5b2cf"), "D4" },
                    { new Guid("e7c12cac-9b93-435c-8efd-32032cb89e44"), "E1" },
                    { new Guid("0fa311fd-c8dd-46d7-84cc-2a72a7474fec"), "E2" },
                    { new Guid("ab053029-bdea-44d1-829c-81e45cfeb5fc"), "E3" },
                    { new Guid("95295813-4446-4c3d-a885-fd91a87e10a4"), "E4" },
                    { new Guid("4a07c3c0-173c-4ecd-9f31-bfb2d2070bbc"), "E5" },
                    { new Guid("137ee7d0-4f7d-4202-896c-fdb32347b56c"), "F1" },
                    { new Guid("e5cb7305-95cf-4d99-b62d-a6c7a8671697"), "F2" },
                    { new Guid("1c1b304f-e4b6-4e4b-9dae-c967d6716c75"), "F3" },
                    { new Guid("d5f58cb4-4592-42c3-ac92-7eed18f47001"), "F4" },
                    { new Guid("8cf78681-c05b-477d-967e-c46b0ed5c04a"), "F5" },
                    { new Guid("ca07b02b-44a1-4b55-a63b-3648a7c387a1"), "F6" },
                    { new Guid("8a5a6695-b4e9-462d-9e30-8716d83689f4"), "D1" },
                    { new Guid("4c6caf08-3a8f-4685-9dc0-883df1eafe1c"), "C1" },
                    { new Guid("6cea942b-b69d-492c-be25-b5c50003f238"), "C4" },
                    { new Guid("3da0f393-0c7c-4547-b287-0c60f06c7d10"), "C2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("53807f00-ee2e-424d-b5df-6da00eacc397"), "C3" },
                    { new Guid("ea86cd55-a362-4976-a36d-4353ea77662a"), "D1" },
                    { new Guid("c2612812-c34b-45a4-8648-d0eb042cd85c"), "D2" },
                    { new Guid("bb6580ed-4c10-49a5-8342-a6dd64675f1d"), "D3" },
                    { new Guid("1a6601f8-ed86-4e62-9cdb-9f381e1a58bc"), "D4" },
                    { new Guid("2e6aec08-280f-4433-b29a-97379874df42"), "E1" },
                    { new Guid("8375380b-7e2a-4753-bbd0-e13d88819899"), "E2" },
                    { new Guid("3c9c422a-c9ba-4516-9a18-38e7fdbbf2a3"), "E3" },
                    { new Guid("02989bfb-384b-4d8b-ae90-f6a145171125"), "E4" },
                    { new Guid("ebaa2ee7-dc5c-4ae4-a7c8-569cfb873b7a"), "E5" },
                    { new Guid("25707334-2771-4ba7-bc54-b8504fdf8113"), "A2" },
                    { new Guid("64dd8d2d-ea78-42d8-9ad1-55bb57e8501d"), "F2" },
                    { new Guid("847c470f-7a9e-4e15-9d18-affc31bba7ff"), "F3" },
                    { new Guid("392f2dae-e83f-4f6d-9197-b885719ad15f"), "F4" },
                    { new Guid("8285c55a-8973-46ef-9263-51eff2c9a7c1"), "C3" },
                    { new Guid("dad8790c-4f24-4d84-b187-6b7f2a6b7957"), "F5" },
                    { new Guid("ed8c8480-95e0-4742-a711-d739f974e688"), "A1" },
                    { new Guid("6de85aa6-40ce-4181-94ea-9f5dd7e33d04"), "A2" },
                    { new Guid("ea8009cb-0d95-494d-beb5-45ba1a0a46ad"), "A3" },
                    { new Guid("5b2912ff-281b-4eec-a303-4f1d02d3502c"), "A4" },
                    { new Guid("022ea692-979a-45b3-a087-29098e45330e"), "A5" },
                    { new Guid("6dc1c4a4-cee9-4b94-a29a-abb50cca2dda"), "A6" },
                    { new Guid("11151982-206d-4aa6-8885-eff090bea441"), "A7" },
                    { new Guid("99d3a7a7-3527-4d24-be1f-e8744dbe187a"), "B1" },
                    { new Guid("b51884dd-7d32-4351-94cf-87b9034e9677"), "B2" },
                    { new Guid("d827bc5a-ba91-43e7-84f5-792483a22c02"), "B3" },
                    { new Guid("0a686aa1-a069-4275-b91c-26837cf6ce60"), "B4" },
                    { new Guid("6833789c-5ce4-4dbf-a142-f1909531d180"), "B5" },
                    { new Guid("317191c6-55b0-4cf1-bbae-b4ca2db34ed1"), "B6" },
                    { new Guid("2f178fe9-6e63-4cc7-adc4-0585874b806c"), "C1" },
                    { new Guid("80a4e015-ca62-4a29-a3ca-34545f34c662"), "F6" },
                    { new Guid("99d43bee-0327-40ef-9a43-ea96002c3723"), "A1" },
                    { new Guid("98d8c234-5735-48f4-84ba-6dddfbb02c47"), "D4" },
                    { new Guid("66b203b8-6036-4eb0-ae67-93d4355e73aa"), "F5" },
                    { new Guid("fcb2684a-7157-4e8f-bf16-bcf54be4d561"), "F1" },
                    { new Guid("78874282-21a6-4f50-8b85-785e8ff139c1"), "F2" },
                    { new Guid("7f46d1d5-5f0b-46c4-a2da-00308de741e7"), "G1" },
                    { new Guid("cf7e88fd-0b21-4bf1-925c-0a4946ad6b8e"), "G2" },
                    { new Guid("c9ed4a72-0cf5-4fe6-90c3-191923d96de5"), "H1" },
                    { new Guid("3a46fa27-b203-49fd-ae25-65e346608461"), "H2" },
                    { new Guid("f86ee463-a2ec-41dd-9812-4a1784913db0"), "A1" },
                    { new Guid("7388bf59-2863-4ae2-ba4b-40a73f78516d"), "A2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("a0e76617-ea75-432a-8067-44c453d5812e"), "A3" },
                    { new Guid("0c7eb907-0260-49c7-998f-3c0cb5a44637"), "B1" },
                    { new Guid("cd1c8873-bc6d-4106-97cc-fe2c25691d2d"), "B2" },
                    { new Guid("8ef717c4-83e9-4ed0-b239-99bf73353bfa"), "B3" },
                    { new Guid("588b484f-7432-49db-8fd8-d19d6749c1be"), "C1" },
                    { new Guid("0601348f-967d-4860-9044-6fd12d69f3e3"), "C2" },
                    { new Guid("19365994-48b4-4d91-8503-6f7448384e65"), "C3" },
                    { new Guid("2a81a63a-bf2b-4a2d-9a29-3bae8519eab6"), "D1" },
                    { new Guid("48f7bae9-4906-4411-aaa9-47be97f91659"), "D2" },
                    { new Guid("8942659c-744c-4020-9fd3-779c0a1899f1"), "D3" },
                    { new Guid("83295888-41df-4cb0-ae64-4e6229e03db9"), "E1" },
                    { new Guid("8cad47bf-5324-4ec9-a9fc-346586b7eec8"), "E2" },
                    { new Guid("e24d2ebf-3b2b-4266-8b34-9dfeb40a2b23"), "E3" },
                    { new Guid("782c966a-7a1c-4a5e-83ae-1c50027a53a1"), "F1" },
                    { new Guid("85fb65d6-bd00-4a7c-82ad-f538bbb968d5"), "F2" },
                    { new Guid("5fd8a54e-2dbf-4bf7-8977-342b55ea295e"), "F3" },
                    { new Guid("20bb300a-ef07-45c7-a377-ec7add3b8bbc"), "G1" },
                    { new Guid("88405cf1-cb7b-42c4-bcb9-92e1352478c5"), "G2" },
                    { new Guid("6ffac553-12b7-4536-b579-748f8638c39a"), "G3" },
                    { new Guid("076d2388-ddf2-42cb-9237-6b32de9f27bd"), "H1" },
                    { new Guid("f808ea78-68af-4874-83fd-59de46f786a7"), "H2" },
                    { new Guid("a1121531-487c-4195-b633-6d3e691e4516"), "E2" },
                    { new Guid("861b2a82-c523-4054-be73-291ad3334bb6"), "E1" },
                    { new Guid("320b966c-9659-4551-b982-f9240238b335"), "D2" },
                    { new Guid("80ea5166-47e4-4fe5-aa3e-88eb50a1b263"), "D1" },
                    { new Guid("9bf8b859-8463-45bc-bc00-4fb9852946b5"), "A1" },
                    { new Guid("82ffa3a4-7b9f-48b2-9292-594d3afb0fb3"), "A2" },
                    { new Guid("39aad775-bd72-4670-9882-3bc52f47f958"), "A3" },
                    { new Guid("f1e614b7-a43e-48f9-9d9d-01c2ad528c0d"), "B1" },
                    { new Guid("0bfe6df5-b815-4609-a184-1f4f7105c336"), "B2" },
                    { new Guid("43882b12-47ac-4e25-a9a6-35d87f43bc38"), "B3" },
                    { new Guid("aadbae44-c884-488b-90b8-6ab4c8e14691"), "C1" },
                    { new Guid("ce34e910-c956-4ecf-abd5-a635eae9b66a"), "C2" },
                    { new Guid("414ed8e0-8281-4c72-b7d4-99d390419c71"), "C3" },
                    { new Guid("ec2e2bd7-0811-4407-8150-0f9065d7b38a"), "D1" },
                    { new Guid("85288913-84c2-49c4-9efc-4ddf5214458f"), "D2" },
                    { new Guid("2675a275-d3b7-4a74-be0d-9f87dcfa8bcf"), "D3" },
                    { new Guid("9a574991-6f74-4527-86be-9d44ab4dc1a4"), "E1" },
                    { new Guid("fd7c0d35-ea51-4aba-9df4-48386197e3a5"), "E2" },
                    { new Guid("66f20df1-4017-410d-bb23-aa022894742f"), "H3" },
                    { new Guid("5ed5fce4-4277-46e1-bd60-b8598ae6caf7"), "E3" },
                    { new Guid("a733c870-7105-4c4d-900e-b8d9f119dcfb"), "F2" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("6e12e9d7-1767-4a06-b655-5bd0e81bc5a1"), "F3" },
                    { new Guid("d55110c4-f7c7-4bc3-befd-61af97b851ac"), "G1" },
                    { new Guid("7338c9af-4baf-4ecb-ac63-db76c971695b"), "G2" },
                    { new Guid("74e80a24-3703-41c6-a701-c83e95c69762"), "G3" },
                    { new Guid("98a676d4-e17c-4a5f-b593-0f832577b9f9"), "H1" },
                    { new Guid("d714adfe-2f1f-449c-a9b1-bc3a8e90518d"), "H2" },
                    { new Guid("9f71236f-c862-487c-89c6-d55a1f0925bd"), "H3" },
                    { new Guid("dd8b651f-9261-4f11-b2a8-c8732627c6dd"), "A1" },
                    { new Guid("3776d35f-423b-48b4-bd73-af052080c658"), "A2" },
                    { new Guid("b02e2592-7bf7-44df-87d2-8b73dee9baf2"), "B1" },
                    { new Guid("175f4f14-a569-400a-b104-d585b940c6e2"), "B2" },
                    { new Guid("a6523fd3-d265-4550-ab56-4990d919f4b7"), "C1" },
                    { new Guid("e8e8ce3c-12fc-4de1-b4f0-2cc40ad90f01"), "C2" },
                    { new Guid("2a71c046-e1ad-43af-869a-53b0c8ce8860"), "F1" },
                    { new Guid("c69ec72f-5302-4b23-ab95-8054142cc175"), "F6" },
                    { new Guid("ac01ee48-5025-4bf3-9ce5-3743283cf839"), "A1" },
                    { new Guid("a0807c45-852e-44ab-966a-32a4cb897e4f"), "B2" },
                    { new Guid("37f2ef7b-42a5-4ee6-b49e-449ab658fe6b"), "C4" },
                    { new Guid("aeaae4f2-0b2e-4bde-be5a-a595e92f8cdc"), "C5" },
                    { new Guid("48307de8-e18b-4c44-a52d-988f47b10aaa"), "D1" },
                    { new Guid("a0871758-cca9-4b5a-b752-165b6edd1ab0"), "D2" },
                    { new Guid("93be28d7-b657-4922-a903-e88aeca9df9c"), "D3" },
                    { new Guid("de82104b-b89a-427b-9f65-2991399d6f48"), "D4" },
                    { new Guid("0f116965-4e71-415e-bb3a-49466dcbd0c4"), "E1" },
                    { new Guid("bc10dc69-9912-4628-a9a0-76ab47e5fbdf"), "E2" },
                    { new Guid("47bf2775-392b-4a7c-9db7-e22168323684"), "E3" },
                    { new Guid("99311d9e-8f78-4428-a6bb-8c303bb94493"), "F1" },
                    { new Guid("cd98a5bd-dc1d-4d59-8038-a25c04cddaad"), "F2" },
                    { new Guid("fb6da476-a78c-409c-b823-dc418a1474ce"), "A1" },
                    { new Guid("fac396ea-d384-46b8-a55d-16086deb131a"), "B1" },
                    { new Guid("98d00b71-b3d8-400d-ac9f-9c8f560dedb4"), "B2" },
                    { new Guid("dcb1b561-1e43-4791-9c8c-6c9eb4855925"), "C1" },
                    { new Guid("919a4b2f-f01d-4dd4-8628-cf5751687bc8"), "C2" },
                    { new Guid("3f765733-99f0-4db4-b484-b51b381728c9"), "C3" },
                    { new Guid("0822bda0-b4b5-4b5c-9269-f485b29ce010"), "D1" },
                    { new Guid("a4d416d0-86f6-45f6-836c-4f7b6f4a1fb4"), "D2" },
                    { new Guid("763e13b6-ed49-44e2-bede-bcfee1310312"), "D3" },
                    { new Guid("99180973-56f4-4923-bca4-95d18af83d4c"), "E1" },
                    { new Guid("b6d7adff-3010-4d29-b492-5bec1c1d3786"), "E2" },
                    { new Guid("3bcef9ca-e1ed-40c0-af6e-35433ee810be"), "E3" },
                    { new Guid("142cc9ef-27ec-4ff4-b005-c36c2b906c98"), "E4" },
                    { new Guid("beb1d6d4-30f1-44e2-8c32-b562ce38b017"), "E5" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { new Guid("bfc63d52-e532-483e-847d-6640cf7cfbe4"), "F1" },
                    { new Guid("ad622444-83f3-4d5b-afc1-eb6437f26667"), "F2" },
                    { new Guid("f9951dba-4f06-4f23-acee-f9af0213c0cc"), "F3" },
                    { new Guid("e7d0e339-a5d1-4305-87c1-cc67f9d89bcc"), "F4" },
                    { new Guid("ca8ab09a-7d57-4c6c-b6ba-6ffc001fcf31"), "C3" },
                    { new Guid("4af44081-6bbd-4773-9578-a2c8db3228c1"), "B1" },
                    { new Guid("145f640d-23af-4e21-b80b-8d1eaf98ee3c"), "C2" },
                    { new Guid("bdaac794-5efc-4368-85e1-6f0d80252aac"), "B6" },
                    { new Guid("25460d59-b67a-4ef7-aeed-7ba7135bd36b"), "C1" },
                    { new Guid("e902b0e5-3665-46c3-bc74-00a300ceb0d6"), "C2" },
                    { new Guid("e48e0f62-5281-423d-9d59-3fda3cc4befe"), "C3" },
                    { new Guid("83d52b6f-ef11-4f98-b909-2cf49ddd4d17"), "D1" },
                    { new Guid("b2e14c36-88c9-4349-8db2-eb3513c91474"), "D2" },
                    { new Guid("f840b3f9-ea32-4072-ba7a-b1db31e78bd6"), "D3" },
                    { new Guid("e820a32d-0f9b-4f58-a9c1-dc555f6a4297"), "D4" },
                    { new Guid("e644cc3b-8150-499f-ae54-9cfee06b5e91"), "E1" },
                    { new Guid("f84f0372-e984-4a63-8019-2b384a1eac06"), "E2" },
                    { new Guid("28cf79d2-fab2-4c9c-a8b0-d24d38de6121"), "E3" },
                    { new Guid("ed81ed1d-5070-4bba-b975-b4f704bd416a"), "E4" },
                    { new Guid("c7166123-9bca-4f58-9600-41a8a8c6c9bc"), "E5" },
                    { new Guid("5473a64b-8c2d-4fd6-b7f2-67744d0a6c33"), "F1" },
                    { new Guid("b511687c-a71a-47c4-aa59-e0e8ccc9ae7c"), "C1" },
                    { new Guid("8509ec95-02be-4f0d-8d70-660f24f02e3d"), "F3" },
                    { new Guid("03dec408-ac14-4824-98ca-67a09715e60f"), "F2" },
                    { new Guid("17a6e2fc-dd21-46ae-a0b2-0d43180492ec"), "F5" },
                    { new Guid("04eb82d3-f680-479d-964d-a5ddf18d8d76"), "B5" },
                    { new Guid("a65d84f3-f143-4b96-91a5-ed88acac61b0"), "B4" },
                    { new Guid("8e2d0c9e-2bb2-402d-baff-9348a58783b8"), "B3" },
                    { new Guid("c9955c0d-f99e-49b3-9b0e-0226116494dc"), "B2" },
                    { new Guid("bf73b832-3339-45a8-88f0-bedcfaa6b823"), "B1" },
                    { new Guid("f58338e6-c24b-4c51-98a4-e1ee444a715c"), "A7" },
                    { new Guid("6943a7c8-acee-434a-a31a-cc240ec90bb4"), "F4" },
                    { new Guid("1e3c43a3-a0e0-4a0a-874e-b1ead3aff860"), "A6" },
                    { new Guid("57989c7c-8c83-4651-b805-0cce99645ae6"), "A4" },
                    { new Guid("6d73d86b-5cbd-4c22-a3b3-2d65a2fe0a6b"), "A3" },
                    { new Guid("050b2ea9-3900-4120-bc6e-5a2fe1f59760"), "A2" },
                    { new Guid("fbb1d11e-518e-4548-a91a-6e1eae347cf8"), "A1" },
                    { new Guid("eeddff4f-4d1f-4bed-91a8-8c2e69da6e3e"), "F6" },
                    { new Guid("5a5c005b-8ea2-41c3-b5a0-3c7dae385cd8"), "A5" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec"), "Sección 2" },
                    { new Guid("a606975f-710c-40a6-9f20-5c5b29c31990"), "Sección 1" },
                    { new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866"), "Sección 3" }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("9bf8b859-8463-45bc-bc00-4fb9852946b5"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("9a7e96b1-5633-4f2f-9d8b-578daa64c934"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("7355ff82-a06e-4315-81a2-2c4cc282ecd5"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3c445b92-ae41-47d5-8eca-2fa795b4df07"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("210d7681-63dc-4a21-b425-828c1ba955a9"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("f9017914-192f-4ebe-9eac-448e20e56431"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("11244fb4-8d05-4b20-a76d-03c393e5acfa"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("79808e5b-e5ff-4aab-aaca-54e0043bc0be"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("62f012fe-6c7e-4615-ab50-4cb029c47299"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f86ee463-a2ec-41dd-9812-4a1784913db0"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("7388bf59-2863-4ae2-ba4b-40a73f78516d"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a0e76617-ea75-432a-8067-44c453d5812e"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0c7eb907-0260-49c7-998f-3c0cb5a44637"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("cd1c8873-bc6d-4106-97cc-fe2c25691d2d"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8ef717c4-83e9-4ed0-b239-99bf73353bfa"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("588b484f-7432-49db-8fd8-d19d6749c1be"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0601348f-967d-4860-9044-6fd12d69f3e3"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("19365994-48b4-4d91-8503-6f7448384e65"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("2a81a63a-bf2b-4a2d-9a29-3bae8519eab6"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("48f7bae9-4906-4411-aaa9-47be97f91659"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8942659c-744c-4020-9fd3-779c0a1899f1"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("83295888-41df-4cb0-ae64-4e6229e03db9"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8cad47bf-5324-4ec9-a9fc-346586b7eec8"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e24d2ebf-3b2b-4266-8b34-9dfeb40a2b23"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("782c966a-7a1c-4a5e-83ae-1c50027a53a1"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("85fb65d6-bd00-4a7c-82ad-f538bbb968d5"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("5fd8a54e-2dbf-4bf7-8977-342b55ea295e"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("20bb300a-ef07-45c7-a377-ec7add3b8bbc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("88405cf1-cb7b-42c4-bcb9-92e1352478c5"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("6ffac553-12b7-4536-b579-748f8638c39a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("26df5422-adea-4f3a-a9bf-247cff51b203"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("076d2388-ddf2-42cb-9237-6b32de9f27bd"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2c79677a-54fc-48eb-af9a-5dfd0b725e60"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8285c55a-8973-46ef-9263-51eff2c9a7c1"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("df7453b3-76d7-48cc-aca4-46649001225f"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d57e18b9-4722-4c3a-a97e-42d9b4e085f7"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2f51f68d-1d83-4722-a0b4-331cee0f610e"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8ac1ff32-1223-48c6-905b-c1d46fc66da8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d501224f-a7fa-488c-9bb6-5bae85caa5a8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8b844dbb-c23d-4ad0-b6ef-3a6711d10e03"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("f5789940-0be6-4880-b825-a33ad7fd0074"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("e21e6208-a540-4dd4-bcd2-c30f6e5d3c5a"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d9ff3aca-cc71-4fd5-8c20-3bb03a75b7d7"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ca4ade3e-087e-4759-a062-44601bbd9a01"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b2d9b2b5-f01e-4a15-abfe-6d5819c3f9aa"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("0fc4105f-78e5-4f22-8835-16366df00ede"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("562e1436-4af1-4e6e-aa20-f55b19243792"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("55de74bc-ef6c-4ce9-9234-5827a9793569"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ed8c8480-95e0-4742-a711-d739f974e688"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6de85aa6-40ce-4181-94ea-9f5dd7e33d04"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ea8009cb-0d95-494d-beb5-45ba1a0a46ad"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("5b2912ff-281b-4eec-a303-4f1d02d3502c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("022ea692-979a-45b3-a087-29098e45330e"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6dc1c4a4-cee9-4b94-a29a-abb50cca2dda"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("11151982-206d-4aa6-8885-eff090bea441"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("99d3a7a7-3527-4d24-be1f-e8744dbe187a"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b51884dd-7d32-4351-94cf-87b9034e9677"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d827bc5a-ba91-43e7-84f5-792483a22c02"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("0a686aa1-a069-4275-b91c-26837cf6ce60"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6833789c-5ce4-4dbf-a142-f1909531d180"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("317191c6-55b0-4cf1-bbae-b4ca2db34ed1"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2f178fe9-6e63-4cc7-adc4-0585874b806c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3da0f393-0c7c-4547-b287-0c60f06c7d10"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6cea942b-b69d-492c-be25-b5c50003f238"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f808ea78-68af-4874-83fd-59de46f786a7"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("66f20df1-4017-410d-bb23-aa022894742f"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fb6da476-a78c-409c-b823-dc418a1474ce"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a7342338-6d6e-44b2-ac6b-f9c0716b150a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("af2e3756-4892-4e2d-89bf-f0a8575ed75e"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("bad88dba-35c7-486f-a77a-40fe9efb818d"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("4324db59-8bc7-4e6f-9a50-eaba6464a77e"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("433b9103-6bfa-4d90-9630-0be04c6f9340"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3da2bcee-a029-4c9c-879e-fb69b8ccb96d"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("c72cdc99-df9c-4160-a20c-c36b3219e70a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("4c278584-0e00-4c55-af75-c1f5c1200cff"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("bfbe5ed1-ddfc-42b0-b5db-00e9e31a2427"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("622b3c1d-92a2-4816-b784-01256faaa4e7"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ebe0a269-4c84-477c-b225-907039095f86"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("233d2378-6108-48e8-acea-58eea44fff24"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2b327e6c-7f40-47b2-a0a7-a4513c957b62"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("5a5a46cc-d84b-475d-af3e-aa8146530005"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("867cef07-7897-474a-b302-86d5fd93f0f6"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("58cf0b53-499d-4697-bead-bb5c3f7def90"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8a5a6695-b4e9-462d-9e30-8716d83689f4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("dd11c2ff-7cc8-4c33-a0d9-f70fa15cf055"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ab8f6499-b6b6-4d70-84f8-cc2444a4f375"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("51f6662f-6346-489f-9bba-fe9b57f5b2cf"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("e7c12cac-9b93-435c-8efd-32032cb89e44"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("0fa311fd-c8dd-46d7-84cc-2a72a7474fec"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ab053029-bdea-44d1-829c-81e45cfeb5fc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("95295813-4446-4c3d-a885-fd91a87e10a4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("4a07c3c0-173c-4ecd-9f31-bfb2d2070bbc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("137ee7d0-4f7d-4202-896c-fdb32347b56c"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("e5cb7305-95cf-4d99-b62d-a6c7a8671697"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("1c1b304f-e4b6-4e4b-9dae-c967d6716c75"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d5f58cb4-4592-42c3-ac92-7eed18f47001"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b1c6e479-f06f-4bc5-9dd6-bb8cd52300ab"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2c89f98a-f9a4-409e-bbf2-f478f96ed60b"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("e41ea046-2b1d-486a-b379-f8cf713d641f"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("020b690f-21c2-4772-9115-7b94a316a169"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fac396ea-d384-46b8-a55d-16086deb131a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("98d00b71-b3d8-400d-ac9f-9c8f560dedb4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("dcb1b561-1e43-4791-9c8c-6c9eb4855925"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("919a4b2f-f01d-4dd4-8628-cf5751687bc8"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("3f765733-99f0-4db4-b484-b51b381728c9"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0822bda0-b4b5-4b5c-9269-f485b29ce010"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a4d416d0-86f6-45f6-836c-4f7b6f4a1fb4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("763e13b6-ed49-44e2-bede-bcfee1310312"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("98d8c234-5735-48f4-84ba-6dddfbb02c47"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("99180973-56f4-4923-bca4-95d18af83d4c"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("b6d7adff-3010-4d29-b492-5bec1c1d3786"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("3bcef9ca-e1ed-40c0-af6e-35433ee810be"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("142cc9ef-27ec-4ff4-b005-c36c2b906c98"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("beb1d6d4-30f1-44e2-8c32-b562ce38b017"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("16a7e420-4a7e-4296-b8cc-b3618a25274c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("bfc63d52-e532-483e-847d-6640cf7cfbe4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f9951dba-4f06-4f23-acee-f9af0213c0cc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e7d0e339-a5d1-4305-87c1-cc67f9d89bcc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("66b203b8-6036-4eb0-ae67-93d4355e73aa"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("c69ec72f-5302-4b23-ab95-8054142cc175"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("45ce6cfe-db09-4c7b-a98d-3dfe46bc8604"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("26ba53e9-4fa4-4a8c-ba0c-c735e63804c8"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a3bcd9ce-5b4e-4015-b6d3-f44163095a40"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a376ceee-2b96-4d3b-82da-fa84e6caedbe"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a522cdf8-d173-4af4-837b-fa55e903aaab"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b2212667-0eec-4d72-a9a0-d428070b82ed"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("c2144afd-b1c2-4b6a-8e79-d6ecbfd22eae"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("7d55cfcc-ae0e-4c0a-ad15-f7adfc471166"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("7f046953-8767-4547-9fbe-97a2d9f040e7"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("efc46fa5-3f4f-4fbe-86bd-b85aab424310"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ad622444-83f3-4d5b-afc1-eb6437f26667"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8e8612a1-701c-4d7c-9dc7-41f7f310b537"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("cd98a5bd-dc1d-4d59-8038-a25c04cddaad"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("99311d9e-8f78-4428-a6bb-8c303bb94493"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f84f0372-e984-4a63-8019-2b384a1eac06"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("28cf79d2-fab2-4c9c-a8b0-d24d38de6121"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ed81ed1d-5070-4bba-b975-b4f704bd416a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("c7166123-9bca-4f58-9600-41a8a8c6c9bc"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("5473a64b-8c2d-4fd6-b7f2-67744d0a6c33"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("03dec408-ac14-4824-98ca-67a09715e60f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8509ec95-02be-4f0d-8d70-660f24f02e3d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("6943a7c8-acee-434a-a31a-cc240ec90bb4"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("17a6e2fc-dd21-46ae-a0b2-0d43180492ec"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("eeddff4f-4d1f-4bed-91a8-8c2e69da6e3e"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("99d43bee-0327-40ef-9a43-ea96002c3723"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("25707334-2771-4ba7-bc54-b8504fdf8113"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6f93ab29-6a0a-4872-bb5c-baeffaa081d6"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3c7ffefa-5ac5-42a5-a2f3-08cef72ad726"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("feabfc35-7976-4ff3-ae55-32d8a0bfd417"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("60090208-1030-434d-b027-9bcb84331c44"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("516722ab-8eea-4ebf-b1eb-7516ac699620"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("45c514e9-90d4-454a-a1ed-c4b2ae80b75a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("982f8cbd-75d3-4a0a-8e28-9536e868c548"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("773feea3-0898-4197-8c6f-4a15890a9e64"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("eae3791d-de5d-4c8e-ad07-4fc0373ec39c"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("50e186aa-62fb-437f-9cdd-7aa8ace72c24"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8cd28f80-1cc4-4bfd-aa90-0ab9d58b769c"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("7fdec753-9e0c-4846-9237-ce77b8b5790b"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b810590e-bf9d-4476-a834-ed947128ac82"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ce60181d-c5b8-4a59-a479-b5cf78e302e5"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6baaf99f-3430-47bf-a3b6-28d924f87d60"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("c08e4dbd-f980-4940-ab52-93d7b2ae52ab"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("832f70d8-6b47-41bc-89d0-9e24809d6d63"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e644cc3b-8150-499f-ae54-9cfee06b5e91"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e820a32d-0f9b-4f58-a9c1-dc555f6a4297"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f840b3f9-ea32-4072-ba7a-b1db31e78bd6"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("b2e14c36-88c9-4349-8db2-eb3513c91474"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("82ffa3a4-7b9f-48b2-9292-594d3afb0fb3"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("39aad775-bd72-4670-9882-3bc52f47f958"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f1e614b7-a43e-48f9-9d9d-01c2ad528c0d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0bfe6df5-b815-4609-a184-1f4f7105c336"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("43882b12-47ac-4e25-a9a6-35d87f43bc38"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("aadbae44-c884-488b-90b8-6ab4c8e14691"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ce34e910-c956-4ecf-abd5-a635eae9b66a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("414ed8e0-8281-4c72-b7d4-99d390419c71"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ec2e2bd7-0811-4407-8150-0f9065d7b38a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("85288913-84c2-49c4-9efc-4ddf5214458f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("2675a275-d3b7-4a74-be0d-9f87dcfa8bcf"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("9a574991-6f74-4527-86be-9d44ab4dc1a4"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fd7c0d35-ea51-4aba-9df4-48386197e3a5"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("5ed5fce4-4277-46e1-bd60-b8598ae6caf7"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a2dd8bec-3453-4984-a82f-1ae60e58abb4"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("2a71c046-e1ad-43af-869a-53b0c8ce8860"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("6e12e9d7-1767-4a06-b655-5bd0e81bc5a1"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("d55110c4-f7c7-4bc3-befd-61af97b851ac"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("7338c9af-4baf-4ecb-ac63-db76c971695b"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("74e80a24-3703-41c6-a701-c83e95c69762"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("98a676d4-e17c-4a5f-b593-0f832577b9f9"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("d714adfe-2f1f-449c-a9b1-bc3a8e90518d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("9f71236f-c862-487c-89c6-d55a1f0925bd"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ac01ee48-5025-4bf3-9ce5-3743283cf839"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("4af44081-6bbd-4773-9578-a2c8db3228c1"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a0807c45-852e-44ab-966a-32a4cb897e4f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("25460d59-b67a-4ef7-aeed-7ba7135bd36b"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e902b0e5-3665-46c3-bc74-00a300ceb0d6"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e48e0f62-5281-423d-9d59-3fda3cc4befe"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("83d52b6f-ef11-4f98-b909-2cf49ddd4d17"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a733c870-7105-4c4d-900e-b8d9f119dcfb"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8cf78681-c05b-477d-967e-c46b0ed5c04a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("39501a9f-5aab-498d-a87d-314ba2bfbfff"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d923813b-d492-476a-8d14-1bcab360aacd"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("7f46d1d5-5f0b-46c4-a2da-00308de741e7"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("cf7e88fd-0b21-4bf1-925c-0a4946ad6b8e"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("c9ed4a72-0cf5-4fe6-90c3-191923d96de5"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("3a46fa27-b203-49fd-ae25-65e346608461"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fbb1d11e-518e-4548-a91a-6e1eae347cf8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("050b2ea9-3900-4120-bc6e-5a2fe1f59760"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("6d73d86b-5cbd-4c22-a3b3-2d65a2fe0a6b"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("57989c7c-8c83-4651-b805-0cce99645ae6"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("5a5c005b-8ea2-41c3-b5a0-3c7dae385cd8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("1e3c43a3-a0e0-4a0a-874e-b1ead3aff860"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f58338e6-c24b-4c51-98a4-e1ee444a715c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("bf73b832-3339-45a8-88f0-bedcfaa6b823"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("c9955c0d-f99e-49b3-9b0e-0226116494dc"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8e2d0c9e-2bb2-402d-baff-9348a58783b8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a65d84f3-f143-4b96-91a5-ed88acac61b0"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("04eb82d3-f680-479d-964d-a5ddf18d8d76"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("bdaac794-5efc-4368-85e1-6f0d80252aac"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("b511687c-a71a-47c4-aa59-e0e8ccc9ae7c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("145f640d-23af-4e21-b80b-8d1eaf98ee3c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ca8ab09a-7d57-4c6c-b6ba-6ffc001fcf31"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("37f2ef7b-42a5-4ee6-b49e-449ab658fe6b"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("aeaae4f2-0b2e-4bde-be5a-a595e92f8cdc"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("48307de8-e18b-4c44-a52d-988f47b10aaa"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a0871758-cca9-4b5a-b752-165b6edd1ab0"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("93be28d7-b657-4922-a903-e88aeca9df9c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("de82104b-b89a-427b-9f65-2991399d6f48"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0f116965-4e71-415e-bb3a-49466dcbd0c4"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("bc10dc69-9912-4628-a9a0-76ab47e5fbdf"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("47bf2775-392b-4a7c-9db7-e22168323684"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("78874282-21a6-4f50-8b85-785e8ff139c1"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fcb2684a-7157-4e8f-bf16-bcf54be4d561"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a1121531-487c-4195-b633-6d3e691e4516"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("861b2a82-c523-4054-be73-291ad3334bb6"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("48d629b0-01a9-4e09-b769-d3ea86e46762"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("1a351ade-b513-47c1-900a-3d2d9aa9203f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d37cc7e3-0a33-495c-9250-cab725ff0d22"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("09b344bd-295a-4043-8d12-d453b70c2ee8"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("4c6caf08-3a8f-4685-9dc0-883df1eafe1c"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("de0d7a08-72db-4585-ac47-59b5763075e8"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("53807f00-ee2e-424d-b5df-6da00eacc397"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ea86cd55-a362-4976-a36d-4353ea77662a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("c2612812-c34b-45a4-8648-d0eb042cd85c"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("bb6580ed-4c10-49a5-8342-a6dd64675f1d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("1a6601f8-ed86-4e62-9cdb-9f381e1a58bc"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2e6aec08-280f-4433-b29a-97379874df42"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8375380b-7e2a-4753-bbd0-e13d88819899"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3c9c422a-c9ba-4516-9a18-38e7fdbbf2a3"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("071e0714-25ce-4e57-baa5-c0463f415052"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("02989bfb-384b-4d8b-ae90-f6a145171125"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8e1d6878-7ddb-4ebc-af87-b5a8fa3b1dfe"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("64dd8d2d-ea78-42d8-9ad1-55bb57e8501d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") }
                });

            migrationBuilder.InsertData(
                table: "SeatSectionLevelRooms",
                columns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                values: new object[,]
                {
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("847c470f-7a9e-4e15-9d18-affc31bba7ff"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("392f2dae-e83f-4f6d-9197-b885719ad15f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("dad8790c-4f24-4d84-b187-6b7f2a6b7957"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("80a4e015-ca62-4a29-a3ca-34545f34c662"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("dd8b651f-9261-4f11-b2a8-c8732627c6dd"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("3776d35f-423b-48b4-bd73-af052080c658"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("b02e2592-7bf7-44df-87d2-8b73dee9baf2"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("175f4f14-a569-400a-b104-d585b940c6e2"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a6523fd3-d265-4550-ab56-4990d919f4b7"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e8e8ce3c-12fc-4de1-b4f0-2cc40ad90f01"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("80ea5166-47e4-4fe5-aa3e-88eb50a1b263"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("320b966c-9659-4551-b982-f9240238b335"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ebaa2ee7-dc5c-4ae4-a7c8-569cfb873b7a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") },
                    { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ca07b02b-44a1-4b55-a63b-3648a7c387a1"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("0c05ff25-7a41-4033-941b-7afcfc792346"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("40aba767-8c86-4be4-9867-23f8ec65de20"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("4ee44104-6a3a-498e-84f2-cd814f2032b0"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("5a99e2cb-cc54-45a1-9ca7-f24d9d8b28aa"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("a1c8e241-34bc-4ddb-b0a5-85ea60564933"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("c1706b1a-2e4a-4a7a-98a0-ed149f8179a5"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("c5bde257-e32a-4863-83c5-aeaa96aaa36d"));

            migrationBuilder.DeleteData(
                table: "FilmRols",
                keyColumn: "Id",
                keyValue: new Guid("e8eed591-fa67-416d-9bfd-979dc03dc7ab"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1e9e494a-def9-43a5-8a1b-97b9b43047ea"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6a4a9cdf-8352-4d4e-8037-f86d42b0085c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("718dbd90-e2c9-4f3d-a697-a6485cafc5e0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("92df19e8-e452-46f0-8804-e6e83eb11de8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ca8e89a2-2772-4fab-bd24-e50aa5fa0ea2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cc6170e2-f391-4f7a-8c43-455e4d9f0546"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d543aeae-b978-4d34-bdfa-3e14a6580adf"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dfde672e-ae28-46e9-b414-4701a84abbbe"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e81c4cce-5031-45ce-b1ea-c1287172807a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("e84cfb0c-9b0a-474e-9038-4d65acf727e0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ec3c15bc-16a9-4913-b855-046054a78487"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f34952bf-f2d9-461b-94da-63543a928b87"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fbc22ae8-8742-4a07-9932-ea82cae038af"));

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("020b690f-21c2-4772-9115-7b94a316a169"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("022ea692-979a-45b3-a087-29098e45330e"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("02989bfb-384b-4d8b-ae90-f6a145171125"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("03dec408-ac14-4824-98ca-67a09715e60f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("04eb82d3-f680-479d-964d-a5ddf18d8d76"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("050b2ea9-3900-4120-bc6e-5a2fe1f59760"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0601348f-967d-4860-9044-6fd12d69f3e3"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("071e0714-25ce-4e57-baa5-c0463f415052"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("076d2388-ddf2-42cb-9237-6b32de9f27bd"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0822bda0-b4b5-4b5c-9269-f485b29ce010"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("09b344bd-295a-4043-8d12-d453b70c2ee8"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("0a686aa1-a069-4275-b91c-26837cf6ce60"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0bfe6df5-b815-4609-a184-1f4f7105c336"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0c7eb907-0260-49c7-998f-3c0cb5a44637"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("0f116965-4e71-415e-bb3a-49466dcbd0c4"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("0fa311fd-c8dd-46d7-84cc-2a72a7474fec"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("0fc4105f-78e5-4f22-8835-16366df00ede"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("11151982-206d-4aa6-8885-eff090bea441"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("11244fb4-8d05-4b20-a76d-03c393e5acfa"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("137ee7d0-4f7d-4202-896c-fdb32347b56c"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("142cc9ef-27ec-4ff4-b005-c36c2b906c98"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("145f640d-23af-4e21-b80b-8d1eaf98ee3c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("16a7e420-4a7e-4296-b8cc-b3618a25274c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("175f4f14-a569-400a-b104-d585b940c6e2"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("17a6e2fc-dd21-46ae-a0b2-0d43180492ec"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("19365994-48b4-4d91-8503-6f7448384e65"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("1a351ade-b513-47c1-900a-3d2d9aa9203f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("1a6601f8-ed86-4e62-9cdb-9f381e1a58bc"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("1c1b304f-e4b6-4e4b-9dae-c967d6716c75"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("1e3c43a3-a0e0-4a0a-874e-b1ead3aff860"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("20bb300a-ef07-45c7-a377-ec7add3b8bbc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("210d7681-63dc-4a21-b425-828c1ba955a9"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("233d2378-6108-48e8-acea-58eea44fff24"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("25460d59-b67a-4ef7-aeed-7ba7135bd36b"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("25707334-2771-4ba7-bc54-b8504fdf8113"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("2675a275-d3b7-4a74-be0d-9f87dcfa8bcf"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("26ba53e9-4fa4-4a8c-ba0c-c735e63804c8"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("26df5422-adea-4f3a-a9bf-247cff51b203"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("28cf79d2-fab2-4c9c-a8b0-d24d38de6121"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("2a71c046-e1ad-43af-869a-53b0c8ce8860"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("2a81a63a-bf2b-4a2d-9a29-3bae8519eab6"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2b327e6c-7f40-47b2-a0a7-a4513c957b62"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2c79677a-54fc-48eb-af9a-5dfd0b725e60"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2c89f98a-f9a4-409e-bbf2-f478f96ed60b"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2e6aec08-280f-4433-b29a-97379874df42"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2f178fe9-6e63-4cc7-adc4-0585874b806c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("2f51f68d-1d83-4722-a0b4-331cee0f610e"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("317191c6-55b0-4cf1-bbae-b4ca2db34ed1"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("320b966c-9659-4551-b982-f9240238b335"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("3776d35f-423b-48b4-bd73-af052080c658"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("37f2ef7b-42a5-4ee6-b49e-449ab658fe6b"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("392f2dae-e83f-4f6d-9197-b885719ad15f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("39501a9f-5aab-498d-a87d-314ba2bfbfff"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("39aad775-bd72-4670-9882-3bc52f47f958"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("3a46fa27-b203-49fd-ae25-65e346608461"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("3bcef9ca-e1ed-40c0-af6e-35433ee810be"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3c445b92-ae41-47d5-8eca-2fa795b4df07"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3c7ffefa-5ac5-42a5-a2f3-08cef72ad726"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3c9c422a-c9ba-4516-9a18-38e7fdbbf2a3"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3da0f393-0c7c-4547-b287-0c60f06c7d10"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("3da2bcee-a029-4c9c-879e-fb69b8ccb96d"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("3f765733-99f0-4db4-b484-b51b381728c9"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("414ed8e0-8281-4c72-b7d4-99d390419c71"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("4324db59-8bc7-4e6f-9a50-eaba6464a77e"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("433b9103-6bfa-4d90-9630-0be04c6f9340"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("43882b12-47ac-4e25-a9a6-35d87f43bc38"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("45c514e9-90d4-454a-a1ed-c4b2ae80b75a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("45ce6cfe-db09-4c7b-a98d-3dfe46bc8604"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("47bf2775-392b-4a7c-9db7-e22168323684"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("48307de8-e18b-4c44-a52d-988f47b10aaa"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("48d629b0-01a9-4e09-b769-d3ea86e46762"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("48f7bae9-4906-4411-aaa9-47be97f91659"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("4a07c3c0-173c-4ecd-9f31-bfb2d2070bbc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("4af44081-6bbd-4773-9578-a2c8db3228c1"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("4c278584-0e00-4c55-af75-c1f5c1200cff"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("4c6caf08-3a8f-4685-9dc0-883df1eafe1c"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("50e186aa-62fb-437f-9cdd-7aa8ace72c24"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("516722ab-8eea-4ebf-b1eb-7516ac699620"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("51f6662f-6346-489f-9bba-fe9b57f5b2cf"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("53807f00-ee2e-424d-b5df-6da00eacc397"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("5473a64b-8c2d-4fd6-b7f2-67744d0a6c33"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("55de74bc-ef6c-4ce9-9234-5827a9793569"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("562e1436-4af1-4e6e-aa20-f55b19243792"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("57989c7c-8c83-4651-b805-0cce99645ae6"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("588b484f-7432-49db-8fd8-d19d6749c1be"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("58cf0b53-499d-4697-bead-bb5c3f7def90"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("5a5a46cc-d84b-475d-af3e-aa8146530005"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("5a5c005b-8ea2-41c3-b5a0-3c7dae385cd8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("5b2912ff-281b-4eec-a303-4f1d02d3502c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("5ed5fce4-4277-46e1-bd60-b8598ae6caf7"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("5fd8a54e-2dbf-4bf7-8977-342b55ea295e"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("60090208-1030-434d-b027-9bcb84331c44"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("622b3c1d-92a2-4816-b784-01256faaa4e7"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("62f012fe-6c7e-4615-ab50-4cb029c47299"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("64dd8d2d-ea78-42d8-9ad1-55bb57e8501d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("66b203b8-6036-4eb0-ae67-93d4355e73aa"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("66f20df1-4017-410d-bb23-aa022894742f"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6833789c-5ce4-4dbf-a142-f1909531d180"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("6943a7c8-acee-434a-a31a-cc240ec90bb4"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6baaf99f-3430-47bf-a3b6-28d924f87d60"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6cea942b-b69d-492c-be25-b5c50003f238"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("6d73d86b-5cbd-4c22-a3b3-2d65a2fe0a6b"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6dc1c4a4-cee9-4b94-a29a-abb50cca2dda"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6de85aa6-40ce-4181-94ea-9f5dd7e33d04"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("6e12e9d7-1767-4a06-b655-5bd0e81bc5a1"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("6f93ab29-6a0a-4872-bb5c-baeffaa081d6"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("6ffac553-12b7-4536-b579-748f8638c39a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("7338c9af-4baf-4ecb-ac63-db76c971695b"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("7355ff82-a06e-4315-81a2-2c4cc282ecd5"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("7388bf59-2863-4ae2-ba4b-40a73f78516d"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("74e80a24-3703-41c6-a701-c83e95c69762"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("763e13b6-ed49-44e2-bede-bcfee1310312"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("773feea3-0898-4197-8c6f-4a15890a9e64"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("782c966a-7a1c-4a5e-83ae-1c50027a53a1"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("78874282-21a6-4f50-8b85-785e8ff139c1"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("79808e5b-e5ff-4aab-aaca-54e0043bc0be"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("7d55cfcc-ae0e-4c0a-ad15-f7adfc471166"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("7f046953-8767-4547-9fbe-97a2d9f040e7"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("7f46d1d5-5f0b-46c4-a2da-00308de741e7"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("7fdec753-9e0c-4846-9237-ce77b8b5790b"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("80a4e015-ca62-4a29-a3ca-34545f34c662"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("80ea5166-47e4-4fe5-aa3e-88eb50a1b263"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8285c55a-8973-46ef-9263-51eff2c9a7c1"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("82ffa3a4-7b9f-48b2-9292-594d3afb0fb3"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("83295888-41df-4cb0-ae64-4e6229e03db9"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("832f70d8-6b47-41bc-89d0-9e24809d6d63"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8375380b-7e2a-4753-bbd0-e13d88819899"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("83d52b6f-ef11-4f98-b909-2cf49ddd4d17"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("847c470f-7a9e-4e15-9d18-affc31bba7ff"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8509ec95-02be-4f0d-8d70-660f24f02e3d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("85288913-84c2-49c4-9efc-4ddf5214458f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("85fb65d6-bd00-4a7c-82ad-f538bbb968d5"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("861b2a82-c523-4054-be73-291ad3334bb6"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("867cef07-7897-474a-b302-86d5fd93f0f6"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("88405cf1-cb7b-42c4-bcb9-92e1352478c5"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8942659c-744c-4020-9fd3-779c0a1899f1"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8a5a6695-b4e9-462d-9e30-8716d83689f4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8ac1ff32-1223-48c6-905b-c1d46fc66da8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8b844dbb-c23d-4ad0-b6ef-3a6711d10e03"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8cad47bf-5324-4ec9-a9fc-346586b7eec8"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8cd28f80-1cc4-4bfd-aa90-0ab9d58b769c"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8cf78681-c05b-477d-967e-c46b0ed5c04a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8e1d6878-7ddb-4ebc-af87-b5a8fa3b1dfe"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8e2d0c9e-2bb2-402d-baff-9348a58783b8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("8e8612a1-701c-4d7c-9dc7-41f7f310b537"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("8ef717c4-83e9-4ed0-b239-99bf73353bfa"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("919a4b2f-f01d-4dd4-8628-cf5751687bc8"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("93be28d7-b657-4922-a903-e88aeca9df9c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("95295813-4446-4c3d-a885-fd91a87e10a4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("982f8cbd-75d3-4a0a-8e28-9536e868c548"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("98a676d4-e17c-4a5f-b593-0f832577b9f9"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("98d00b71-b3d8-400d-ac9f-9c8f560dedb4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("98d8c234-5735-48f4-84ba-6dddfbb02c47"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("99180973-56f4-4923-bca4-95d18af83d4c"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("99311d9e-8f78-4428-a6bb-8c303bb94493"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("99d3a7a7-3527-4d24-be1f-e8744dbe187a"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("99d43bee-0327-40ef-9a43-ea96002c3723"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("9a574991-6f74-4527-86be-9d44ab4dc1a4"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("9a7e96b1-5633-4f2f-9d8b-578daa64c934"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("9bf8b859-8463-45bc-bc00-4fb9852946b5"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("9f71236f-c862-487c-89c6-d55a1f0925bd"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a0807c45-852e-44ab-966a-32a4cb897e4f"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a0871758-cca9-4b5a-b752-165b6edd1ab0"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a0e76617-ea75-432a-8067-44c453d5812e"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a1121531-487c-4195-b633-6d3e691e4516"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a2dd8bec-3453-4984-a82f-1ae60e58abb4"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a376ceee-2b96-4d3b-82da-fa84e6caedbe"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a3bcd9ce-5b4e-4015-b6d3-f44163095a40"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a4d416d0-86f6-45f6-836c-4f7b6f4a1fb4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a522cdf8-d173-4af4-837b-fa55e903aaab"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a6523fd3-d265-4550-ab56-4990d919f4b7"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a65d84f3-f143-4b96-91a5-ed88acac61b0"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("a733c870-7105-4c4d-900e-b8d9f119dcfb"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("a7342338-6d6e-44b2-ac6b-f9c0716b150a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("aadbae44-c884-488b-90b8-6ab4c8e14691"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ab053029-bdea-44d1-829c-81e45cfeb5fc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ab8f6499-b6b6-4d70-84f8-cc2444a4f375"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ac01ee48-5025-4bf3-9ce5-3743283cf839"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ad622444-83f3-4d5b-afc1-eb6437f26667"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("aeaae4f2-0b2e-4bde-be5a-a595e92f8cdc"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("af2e3756-4892-4e2d-89bf-f0a8575ed75e"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("b02e2592-7bf7-44df-87d2-8b73dee9baf2"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b1c6e479-f06f-4bc5-9dd6-bb8cd52300ab"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b2212667-0eec-4d72-a9a0-d428070b82ed"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b2d9b2b5-f01e-4a15-abfe-6d5819c3f9aa"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("b2e14c36-88c9-4349-8db2-eb3513c91474"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("b511687c-a71a-47c4-aa59-e0e8ccc9ae7c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b51884dd-7d32-4351-94cf-87b9034e9677"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("b6d7adff-3010-4d29-b492-5bec1c1d3786"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("b810590e-bf9d-4476-a834-ed947128ac82"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("bad88dba-35c7-486f-a77a-40fe9efb818d"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("bb6580ed-4c10-49a5-8342-a6dd64675f1d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("bc10dc69-9912-4628-a9a0-76ab47e5fbdf"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("bdaac794-5efc-4368-85e1-6f0d80252aac"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("beb1d6d4-30f1-44e2-8c32-b562ce38b017"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("bf73b832-3339-45a8-88f0-bedcfaa6b823"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("bfbe5ed1-ddfc-42b0-b5db-00e9e31a2427"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("bfc63d52-e532-483e-847d-6640cf7cfbe4"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("c08e4dbd-f980-4940-ab52-93d7b2ae52ab"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("c2144afd-b1c2-4b6a-8e79-d6ecbfd22eae"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("c2612812-c34b-45a4-8648-d0eb042cd85c"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("c69ec72f-5302-4b23-ab95-8054142cc175"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("c7166123-9bca-4f58-9600-41a8a8c6c9bc"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("c72cdc99-df9c-4160-a20c-c36b3219e70a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("c9955c0d-f99e-49b3-9b0e-0226116494dc"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("c9ed4a72-0cf5-4fe6-90c3-191923d96de5"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ca07b02b-44a1-4b55-a63b-3648a7c387a1"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ca4ade3e-087e-4759-a062-44601bbd9a01"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ca8ab09a-7d57-4c6c-b6ba-6ffc001fcf31"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("cd1c8873-bc6d-4106-97cc-fe2c25691d2d"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("cd98a5bd-dc1d-4d59-8038-a25c04cddaad"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ce34e910-c956-4ecf-abd5-a635eae9b66a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ce60181d-c5b8-4a59-a479-b5cf78e302e5"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("cf7e88fd-0b21-4bf1-925c-0a4946ad6b8e"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d37cc7e3-0a33-495c-9250-cab725ff0d22"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d501224f-a7fa-488c-9bb6-5bae85caa5a8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("d55110c4-f7c7-4bc3-befd-61af97b851ac"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d57e18b9-4722-4c3a-a97e-42d9b4e085f7"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d5f58cb4-4592-42c3-ac92-7eed18f47001"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("d714adfe-2f1f-449c-a9b1-bc3a8e90518d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d827bc5a-ba91-43e7-84f5-792483a22c02"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d923813b-d492-476a-8d14-1bcab360aacd"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("d9ff3aca-cc71-4fd5-8c20-3bb03a75b7d7"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("dad8790c-4f24-4d84-b187-6b7f2a6b7957"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("dcb1b561-1e43-4791-9c8c-6c9eb4855925"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("dd11c2ff-7cc8-4c33-a0d9-f70fa15cf055"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("dd8b651f-9261-4f11-b2a8-c8732627c6dd"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("de0d7a08-72db-4585-ac47-59b5763075e8"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("de82104b-b89a-427b-9f65-2991399d6f48"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("df7453b3-76d7-48cc-aca4-46649001225f"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("e21e6208-a540-4dd4-bcd2-c30f6e5d3c5a"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e24d2ebf-3b2b-4266-8b34-9dfeb40a2b23"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("e41ea046-2b1d-486a-b379-f8cf713d641f"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e48e0f62-5281-423d-9d59-3fda3cc4befe"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("e5cb7305-95cf-4d99-b62d-a6c7a8671697"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e644cc3b-8150-499f-ae54-9cfee06b5e91"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("e7c12cac-9b93-435c-8efd-32032cb89e44"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e7d0e339-a5d1-4305-87c1-cc67f9d89bcc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e820a32d-0f9b-4f58-a9c1-dc555f6a4297"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e8e8ce3c-12fc-4de1-b4f0-2cc40ad90f01"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("e902b0e5-3665-46c3-bc74-00a300ceb0d6"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ea8009cb-0d95-494d-beb5-45ba1a0a46ad"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ea86cd55-a362-4976-a36d-4353ea77662a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("eae3791d-de5d-4c8e-ad07-4fc0373ec39c"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ebaa2ee7-dc5c-4ae4-a7c8-569cfb873b7a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ebe0a269-4c84-477c-b225-907039095f86"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ec2e2bd7-0811-4407-8150-0f9065d7b38a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("ed81ed1d-5070-4bba-b975-b4f704bd416a"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("ed8c8480-95e0-4742-a711-d739f974e688"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("eeddff4f-4d1f-4bed-91a8-8c2e69da6e3e"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("efc46fa5-3f4f-4fbe-86bd-b85aab424310"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f1e614b7-a43e-48f9-9d9d-01c2ad528c0d"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("f5789940-0be6-4880-b825-a33ad7fd0074"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f58338e6-c24b-4c51-98a4-e1ee444a715c"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f808ea78-68af-4874-83fd-59de46f786a7"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f840b3f9-ea32-4072-ba7a-b1db31e78bd6"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f84f0372-e984-4a63-8019-2b384a1eac06"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f86ee463-a2ec-41dd-9812-4a1784913db0"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("f9017914-192f-4ebe-9eac-448e20e56431"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("f9951dba-4f06-4f23-acee-f9af0213c0cc"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fac396ea-d384-46b8-a55d-16086deb131a"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fb6da476-a78c-409c-b823-dc418a1474ce"), new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fbb1d11e-518e-4548-a91a-6e1eae347cf8"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fcb2684a-7157-4e8f-bf16-bcf54be4d561"), new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"), new Guid("fd7c0d35-ea51-4aba-9df4-48386197e3a5"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "SeatSectionLevelRooms",
                keyColumns: new[] { "LevelId", "RoomId", "SeatId", "SectionId" },
                keyValues: new object[] { new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"), new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"), new Guid("feabfc35-7976-4ff3-ae55-32d8a0bfd417"), new Guid("a606975f-710c-40a6-9f20-5c5b29c31990") });

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("2e717f8f-d3a7-4c75-8670-b835feb39256"));

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: new Guid("cffb41a5-88f2-41fc-b9ad-497df0688776"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("57859737-b41c-4772-9998-ea00a46d0b9b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b7252a80-a875-40ec-91b6-fed1023a66cb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("020b690f-21c2-4772-9115-7b94a316a169"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("022ea692-979a-45b3-a087-29098e45330e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("02989bfb-384b-4d8b-ae90-f6a145171125"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03dec408-ac14-4824-98ca-67a09715e60f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("04eb82d3-f680-479d-964d-a5ddf18d8d76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("050b2ea9-3900-4120-bc6e-5a2fe1f59760"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0601348f-967d-4860-9044-6fd12d69f3e3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("071e0714-25ce-4e57-baa5-c0463f415052"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("076d2388-ddf2-42cb-9237-6b32de9f27bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0822bda0-b4b5-4b5c-9269-f485b29ce010"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09b344bd-295a-4043-8d12-d453b70c2ee8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0a686aa1-a069-4275-b91c-26837cf6ce60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bfe6df5-b815-4609-a184-1f4f7105c336"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c7eb907-0260-49c7-998f-3c0cb5a44637"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f116965-4e71-415e-bb3a-49466dcbd0c4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fa311fd-c8dd-46d7-84cc-2a72a7474fec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0fc4105f-78e5-4f22-8835-16366df00ede"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11151982-206d-4aa6-8885-eff090bea441"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11244fb4-8d05-4b20-a76d-03c393e5acfa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("137ee7d0-4f7d-4202-896c-fdb32347b56c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("142cc9ef-27ec-4ff4-b005-c36c2b906c98"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("145f640d-23af-4e21-b80b-8d1eaf98ee3c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16a7e420-4a7e-4296-b8cc-b3618a25274c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("175f4f14-a569-400a-b104-d585b940c6e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17a6e2fc-dd21-46ae-a0b2-0d43180492ec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("19365994-48b4-4d91-8503-6f7448384e65"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a351ade-b513-47c1-900a-3d2d9aa9203f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a6601f8-ed86-4e62-9cdb-9f381e1a58bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1c1b304f-e4b6-4e4b-9dae-c967d6716c75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e3c43a3-a0e0-4a0a-874e-b1ead3aff860"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("20bb300a-ef07-45c7-a377-ec7add3b8bbc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("210d7681-63dc-4a21-b425-828c1ba955a9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("233d2378-6108-48e8-acea-58eea44fff24"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25460d59-b67a-4ef7-aeed-7ba7135bd36b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25707334-2771-4ba7-bc54-b8504fdf8113"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2675a275-d3b7-4a74-be0d-9f87dcfa8bcf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26ba53e9-4fa4-4a8c-ba0c-c735e63804c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26df5422-adea-4f3a-a9bf-247cff51b203"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28cf79d2-fab2-4c9c-a8b0-d24d38de6121"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a71c046-e1ad-43af-869a-53b0c8ce8860"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a81a63a-bf2b-4a2d-9a29-3bae8519eab6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b327e6c-7f40-47b2-a0a7-a4513c957b62"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c79677a-54fc-48eb-af9a-5dfd0b725e60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c89f98a-f9a4-409e-bbf2-f478f96ed60b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e6aec08-280f-4433-b29a-97379874df42"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f178fe9-6e63-4cc7-adc4-0585874b806c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2f51f68d-1d83-4722-a0b4-331cee0f610e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("317191c6-55b0-4cf1-bbae-b4ca2db34ed1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("320b966c-9659-4551-b982-f9240238b335"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3776d35f-423b-48b4-bd73-af052080c658"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37f2ef7b-42a5-4ee6-b49e-449ab658fe6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("392f2dae-e83f-4f6d-9197-b885719ad15f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39501a9f-5aab-498d-a87d-314ba2bfbfff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39aad775-bd72-4670-9882-3bc52f47f958"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a46fa27-b203-49fd-ae25-65e346608461"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3bcef9ca-e1ed-40c0-af6e-35433ee810be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c445b92-ae41-47d5-8eca-2fa795b4df07"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c7ffefa-5ac5-42a5-a2f3-08cef72ad726"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3c9c422a-c9ba-4516-9a18-38e7fdbbf2a3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3da0f393-0c7c-4547-b287-0c60f06c7d10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3da2bcee-a029-4c9c-879e-fb69b8ccb96d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3f765733-99f0-4db4-b484-b51b381728c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("414ed8e0-8281-4c72-b7d4-99d390419c71"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4324db59-8bc7-4e6f-9a50-eaba6464a77e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("433b9103-6bfa-4d90-9630-0be04c6f9340"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43882b12-47ac-4e25-a9a6-35d87f43bc38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45c514e9-90d4-454a-a1ed-c4b2ae80b75a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45ce6cfe-db09-4c7b-a98d-3dfe46bc8604"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("47bf2775-392b-4a7c-9db7-e22168323684"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48307de8-e18b-4c44-a52d-988f47b10aaa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48d629b0-01a9-4e09-b769-d3ea86e46762"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48f7bae9-4906-4411-aaa9-47be97f91659"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a07c3c0-173c-4ecd-9f31-bfb2d2070bbc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4af44081-6bbd-4773-9578-a2c8db3228c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c278584-0e00-4c55-af75-c1f5c1200cff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c6caf08-3a8f-4685-9dc0-883df1eafe1c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50e186aa-62fb-437f-9cdd-7aa8ace72c24"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("516722ab-8eea-4ebf-b1eb-7516ac699620"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("51f6662f-6346-489f-9bba-fe9b57f5b2cf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53807f00-ee2e-424d-b5df-6da00eacc397"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5473a64b-8c2d-4fd6-b7f2-67744d0a6c33"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55de74bc-ef6c-4ce9-9234-5827a9793569"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("562e1436-4af1-4e6e-aa20-f55b19243792"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("57989c7c-8c83-4651-b805-0cce99645ae6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("588b484f-7432-49db-8fd8-d19d6749c1be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("58cf0b53-499d-4697-bead-bb5c3f7def90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a5a46cc-d84b-475d-af3e-aa8146530005"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5a5c005b-8ea2-41c3-b5a0-3c7dae385cd8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b2912ff-281b-4eec-a303-4f1d02d3502c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5ed5fce4-4277-46e1-bd60-b8598ae6caf7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5fd8a54e-2dbf-4bf7-8977-342b55ea295e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60090208-1030-434d-b027-9bcb84331c44"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("622b3c1d-92a2-4816-b784-01256faaa4e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62f012fe-6c7e-4615-ab50-4cb029c47299"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("64dd8d2d-ea78-42d8-9ad1-55bb57e8501d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66b203b8-6036-4eb0-ae67-93d4355e73aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66f20df1-4017-410d-bb23-aa022894742f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6833789c-5ce4-4dbf-a142-f1909531d180"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6943a7c8-acee-434a-a31a-cc240ec90bb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6baaf99f-3430-47bf-a3b6-28d924f87d60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6cea942b-b69d-492c-be25-b5c50003f238"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d73d86b-5cbd-4c22-a3b3-2d65a2fe0a6b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6dc1c4a4-cee9-4b94-a29a-abb50cca2dda"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6de85aa6-40ce-4181-94ea-9f5dd7e33d04"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e12e9d7-1767-4a06-b655-5bd0e81bc5a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f93ab29-6a0a-4872-bb5c-baeffaa081d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ffac553-12b7-4536-b579-748f8638c39a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7338c9af-4baf-4ecb-ac63-db76c971695b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7355ff82-a06e-4315-81a2-2c4cc282ecd5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7388bf59-2863-4ae2-ba4b-40a73f78516d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74e80a24-3703-41c6-a701-c83e95c69762"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("763e13b6-ed49-44e2-bede-bcfee1310312"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("773feea3-0898-4197-8c6f-4a15890a9e64"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("782c966a-7a1c-4a5e-83ae-1c50027a53a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78874282-21a6-4f50-8b85-785e8ff139c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("79808e5b-e5ff-4aab-aaca-54e0043bc0be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7d55cfcc-ae0e-4c0a-ad15-f7adfc471166"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f046953-8767-4547-9fbe-97a2d9f040e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f46d1d5-5f0b-46c4-a2da-00308de741e7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7fdec753-9e0c-4846-9237-ce77b8b5790b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80a4e015-ca62-4a29-a3ca-34545f34c662"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80ea5166-47e4-4fe5-aa3e-88eb50a1b263"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8285c55a-8973-46ef-9263-51eff2c9a7c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("82ffa3a4-7b9f-48b2-9292-594d3afb0fb3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83295888-41df-4cb0-ae64-4e6229e03db9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("832f70d8-6b47-41bc-89d0-9e24809d6d63"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8375380b-7e2a-4753-bbd0-e13d88819899"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83d52b6f-ef11-4f98-b909-2cf49ddd4d17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("847c470f-7a9e-4e15-9d18-affc31bba7ff"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8509ec95-02be-4f0d-8d70-660f24f02e3d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85288913-84c2-49c4-9efc-4ddf5214458f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85fb65d6-bd00-4a7c-82ad-f538bbb968d5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("861b2a82-c523-4054-be73-291ad3334bb6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("867cef07-7897-474a-b302-86d5fd93f0f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("88405cf1-cb7b-42c4-bcb9-92e1352478c5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8942659c-744c-4020-9fd3-779c0a1899f1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8a5a6695-b4e9-462d-9e30-8716d83689f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ac1ff32-1223-48c6-905b-c1d46fc66da8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b844dbb-c23d-4ad0-b6ef-3a6711d10e03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8cad47bf-5324-4ec9-a9fc-346586b7eec8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8cd28f80-1cc4-4bfd-aa90-0ab9d58b769c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8cf78681-c05b-477d-967e-c46b0ed5c04a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e1d6878-7ddb-4ebc-af87-b5a8fa3b1dfe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e2d0c9e-2bb2-402d-baff-9348a58783b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e8612a1-701c-4d7c-9dc7-41f7f310b537"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ef717c4-83e9-4ed0-b239-99bf73353bfa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("919a4b2f-f01d-4dd4-8628-cf5751687bc8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("93be28d7-b657-4922-a903-e88aeca9df9c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95295813-4446-4c3d-a885-fd91a87e10a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("982f8cbd-75d3-4a0a-8e28-9536e868c548"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98a676d4-e17c-4a5f-b593-0f832577b9f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98d00b71-b3d8-400d-ac9f-9c8f560dedb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("98d8c234-5735-48f4-84ba-6dddfbb02c47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99180973-56f4-4923-bca4-95d18af83d4c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99311d9e-8f78-4428-a6bb-8c303bb94493"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99d3a7a7-3527-4d24-be1f-e8744dbe187a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99d43bee-0327-40ef-9a43-ea96002c3723"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a574991-6f74-4527-86be-9d44ab4dc1a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a7e96b1-5633-4f2f-9d8b-578daa64c934"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9bf8b859-8463-45bc-bc00-4fb9852946b5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9f71236f-c862-487c-89c6-d55a1f0925bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0807c45-852e-44ab-966a-32a4cb897e4f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0871758-cca9-4b5a-b752-165b6edd1ab0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0e76617-ea75-432a-8067-44c453d5812e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a1121531-487c-4195-b633-6d3e691e4516"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a2dd8bec-3453-4984-a82f-1ae60e58abb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a376ceee-2b96-4d3b-82da-fa84e6caedbe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a3bcd9ce-5b4e-4015-b6d3-f44163095a40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4d416d0-86f6-45f6-836c-4f7b6f4a1fb4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a522cdf8-d173-4af4-837b-fa55e903aaab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6523fd3-d265-4550-ab56-4990d919f4b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a65d84f3-f143-4b96-91a5-ed88acac61b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a733c870-7105-4c4d-900e-b8d9f119dcfb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7342338-6d6e-44b2-ac6b-f9c0716b150a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aadbae44-c884-488b-90b8-6ab4c8e14691"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab053029-bdea-44d1-829c-81e45cfeb5fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab8f6499-b6b6-4d70-84f8-cc2444a4f375"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac01ee48-5025-4bf3-9ce5-3743283cf839"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad622444-83f3-4d5b-afc1-eb6437f26667"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aeaae4f2-0b2e-4bde-be5a-a595e92f8cdc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("af2e3756-4892-4e2d-89bf-f0a8575ed75e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b02e2592-7bf7-44df-87d2-8b73dee9baf2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1c6e479-f06f-4bc5-9dd6-bb8cd52300ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2212667-0eec-4d72-a9a0-d428070b82ed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2d9b2b5-f01e-4a15-abfe-6d5819c3f9aa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b2e14c36-88c9-4349-8db2-eb3513c91474"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b511687c-a71a-47c4-aa59-e0e8ccc9ae7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b51884dd-7d32-4351-94cf-87b9034e9677"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b6d7adff-3010-4d29-b492-5bec1c1d3786"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b810590e-bf9d-4476-a834-ed947128ac82"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bad88dba-35c7-486f-a77a-40fe9efb818d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bb6580ed-4c10-49a5-8342-a6dd64675f1d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc10dc69-9912-4628-a9a0-76ab47e5fbdf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bdaac794-5efc-4368-85e1-6f0d80252aac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("beb1d6d4-30f1-44e2-8c32-b562ce38b017"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bf73b832-3339-45a8-88f0-bedcfaa6b823"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bfbe5ed1-ddfc-42b0-b5db-00e9e31a2427"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bfc63d52-e532-483e-847d-6640cf7cfbe4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c08e4dbd-f980-4940-ab52-93d7b2ae52ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2144afd-b1c2-4b6a-8e79-d6ecbfd22eae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2612812-c34b-45a4-8648-d0eb042cd85c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c69ec72f-5302-4b23-ab95-8054142cc175"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c7166123-9bca-4f58-9600-41a8a8c6c9bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c72cdc99-df9c-4160-a20c-c36b3219e70a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9955c0d-f99e-49b3-9b0e-0226116494dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c9ed4a72-0cf5-4fe6-90c3-191923d96de5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca07b02b-44a1-4b55-a63b-3648a7c387a1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca4ade3e-087e-4759-a062-44601bbd9a01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ca8ab09a-7d57-4c6c-b6ba-6ffc001fcf31"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd1c8873-bc6d-4106-97cc-fe2c25691d2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd98a5bd-dc1d-4d59-8038-a25c04cddaad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce34e910-c956-4ecf-abd5-a635eae9b66a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce60181d-c5b8-4a59-a479-b5cf78e302e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf7e88fd-0b21-4bf1-925c-0a4946ad6b8e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d37cc7e3-0a33-495c-9250-cab725ff0d22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d501224f-a7fa-488c-9bb6-5bae85caa5a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d55110c4-f7c7-4bc3-befd-61af97b851ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d57e18b9-4722-4c3a-a97e-42d9b4e085f7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d5f58cb4-4592-42c3-ac92-7eed18f47001"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d714adfe-2f1f-449c-a9b1-bc3a8e90518d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d827bc5a-ba91-43e7-84f5-792483a22c02"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d923813b-d492-476a-8d14-1bcab360aacd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d9ff3aca-cc71-4fd5-8c20-3bb03a75b7d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dad8790c-4f24-4d84-b187-6b7f2a6b7957"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dcb1b561-1e43-4791-9c8c-6c9eb4855925"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd11c2ff-7cc8-4c33-a0d9-f70fa15cf055"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd8b651f-9261-4f11-b2a8-c8732627c6dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de0d7a08-72db-4585-ac47-59b5763075e8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de82104b-b89a-427b-9f65-2991399d6f48"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("df7453b3-76d7-48cc-aca4-46649001225f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e21e6208-a540-4dd4-bcd2-c30f6e5d3c5a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e24d2ebf-3b2b-4266-8b34-9dfeb40a2b23"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e41ea046-2b1d-486a-b379-f8cf713d641f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e48e0f62-5281-423d-9d59-3fda3cc4befe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5cb7305-95cf-4d99-b62d-a6c7a8671697"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e644cc3b-8150-499f-ae54-9cfee06b5e91"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e7c12cac-9b93-435c-8efd-32032cb89e44"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e7d0e339-a5d1-4305-87c1-cc67f9d89bcc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e820a32d-0f9b-4f58-a9c1-dc555f6a4297"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e8e8ce3c-12fc-4de1-b4f0-2cc40ad90f01"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e902b0e5-3665-46c3-bc74-00a300ceb0d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea8009cb-0d95-494d-beb5-45ba1a0a46ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea86cd55-a362-4976-a36d-4353ea77662a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eae3791d-de5d-4c8e-ad07-4fc0373ec39c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebaa2ee7-dc5c-4ae4-a7c8-569cfb873b7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebe0a269-4c84-477c-b225-907039095f86"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec2e2bd7-0811-4407-8150-0f9065d7b38a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed81ed1d-5070-4bba-b975-b4f704bd416a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed8c8480-95e0-4742-a711-d739f974e688"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eeddff4f-4d1f-4bed-91a8-8c2e69da6e3e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("efc46fa5-3f4f-4fbe-86bd-b85aab424310"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f1e614b7-a43e-48f9-9d9d-01c2ad528c0d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f5789940-0be6-4880-b825-a33ad7fd0074"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f58338e6-c24b-4c51-98a4-e1ee444a715c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f808ea78-68af-4874-83fd-59de46f786a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f840b3f9-ea32-4072-ba7a-b1db31e78bd6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f84f0372-e984-4a63-8019-2b384a1eac06"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f86ee463-a2ec-41dd-9812-4a1784913db0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9017914-192f-4ebe-9eac-448e20e56431"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9951dba-4f06-4f23-acee-f9af0213c0cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fac396ea-d384-46b8-a55d-16086deb131a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb6da476-a78c-409c-b823-dc418a1474ce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fbb1d11e-518e-4548-a91a-6e1eae347cf8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fcb2684a-7157-4e8f-bf16-bcf54be4d561"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd7c0d35-ea51-4aba-9df4-48386197e3a5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("feabfc35-7976-4ff3-ae55-32d8a0bfd417"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("931bdce6-c9b3-4327-ad3c-8ac6b65bd866"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("a606975f-710c-40a6-9f20-5c5b29c31990"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("b9aa2119-4ddb-4a0a-b5eb-3e7ce7a127ec"));

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ClubMembers");

            migrationBuilder.InsertData(
                table: "FilmRols",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d015d12d-e3cd-4d63-9d29-c20688ba15a7"), "Actor" },
                    { new Guid("731c6aa3-da3e-467b-be26-c64040516cbd"), "Director" },
                    { new Guid("561bd9f1-f639-4d47-97f9-2fe17a24c1cd"), "Productor" },
                    { new Guid("76e5648d-f6ce-4c8e-8b57-bf857522d84f"), "Asistente de dirección" },
                    { new Guid("7586cd40-b8ed-4934-b1a9-add3f54cca81"), "Productor Ejecutivo" },
                    { new Guid("b1b5ff9b-834e-4742-ba55-6c82574d683a"), "Guionista" },
                    { new Guid("0efd796a-6fab-49a6-8f8c-e1c6694cbf8d"), "Diseñador de Vestuario" },
                    { new Guid("bcda5d63-6f89-4a33-abdc-bac32ffa51b1"), "Técnico de Sonido" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a97b0883-7b2c-4829-a8f6-4ae2d09b2210"), "Aventura" },
                    { new Guid("b95f0c4c-0c3f-41e2-88ef-40c9c2da368b"), "Ciencia Ficción" },
                    { new Guid("b8fab495-6bb4-4117-b21c-7aa5b98dbe9f"), "Ficción" },
                    { new Guid("631bbec2-de09-4d3e-acd2-5e8740daac02"), "Documental" },
                    { new Guid("d30f8b7f-c419-4c44-9d44-3256c4c7e9a0"), "Hístorico" },
                    { new Guid("204e0b1f-4127-4c8b-b6ee-6a2b95bceca4"), "Romántica" },
                    { new Guid("e4575e86-ab2f-453f-a611-53a98d82f33f"), "Terror" },
                    { new Guid("6d875347-b4df-4f64-9475-8b10fb9f5597"), "Suspenso" },
                    { new Guid("30160a59-c633-4471-b0db-366bb9fcd0eb"), "Musical" },
                    { new Guid("9074a790-64ae-4d9b-94cb-4358b8855722"), "Comedia" },
                    { new Guid("9666c8bd-0192-4acf-b860-59ccd6bbc7c0"), "Drama" },
                    { new Guid("e35856ec-0fc6-4f6e-92fe-fdfa0f9f7a8e"), "Tragicomedia" },
                    { new Guid("5192a3ab-2aa1-4f1a-bc94-6351723ad339"), "Erótico" }
                });
        }
    }
}
