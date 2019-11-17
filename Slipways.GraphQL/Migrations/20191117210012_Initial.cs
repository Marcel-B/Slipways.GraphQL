using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace com.b_velop.Slipways.GraphQL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Waters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Shortname = table.Column<string>(nullable: true),
                    Longname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slipways",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WaterFk = table.Column<Guid>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Postalcode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Costs = table.Column<decimal>(nullable: false),
                    Pro = table.Column<string>(nullable: true),
                    Contra = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slipways", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slipways_Waters_WaterFk",
                        column: x => x.WaterFk,
                        principalTable: "Waters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    Shortname = table.Column<string>(nullable: true),
                    Longname = table.Column<string>(nullable: true),
                    Km = table.Column<double>(nullable: false),
                    Agency = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    WaterFk = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stations_Waters_WaterFk",
                        column: x => x.WaterFk,
                        principalTable: "Waters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Waters",
                columns: new[] { "Id", "Longname", "Shortname" },
                values: new object[,]
                {
                    { new Guid("ffa035bd-4c18-4a12-9bc7-5e66fc29e149"), "ALLER", "ALLER" },
                    { new Guid("28e2b1b8-e353-4174-99a5-816229c68bd1"), "RUHR", "RUHR" },
                    { new Guid("c486d5cb-772b-41b8-90f4-fc382cc8414b"), "ROTHENSEER-VERBINDUNGSKANAL", "RVK" },
                    { new Guid("9752610e-8cf8-4ef9-b820-666df89a720a"), "RHEINSBERGER GEWÄSSER", "RBG" },
                    { new Guid("30081c46-bbe9-4ac7-894c-4852476d66e5"), "RHEIN-HERNE-KANAL", "RHK" },
                    { new Guid("a88ea916-5e6c-4d83-83a9-1d4fdfef25ec"), "RHEIN", "RHEIN" },
                    { new Guid("acb1b45d-4161-4c4a-a518-c508ed5a03b5"), "POTSDAMER HAVEL", "PHv" },
                    { new Guid("8eb3c12d-029c-48f7-8995-d04f2d76f815"), "PINNAU", "PINNAU" },
                    { new Guid("fb88f5b1-2248-45ca-bd47-1a2213b82fd3"), "PEENE", "PEENE" },
                    { new Guid("1a23b4ab-db97-4f74-bce9-151db100b0b0"), "PAREYER VERBINDUNGSKANAL", "PVK" },
                    { new Guid("7314670d-020b-4c64-9870-84d5e2eb0ba4"), "RUTHENSTROM", "Ruthenstrom" },
                    { new Guid("0c5ecb8f-5c72-4e55-82c5-cff6a068f5a4"), "OSTSEE", "OSTSEE" },
                    { new Guid("529fc755-8b44-44be-a56f-0d751b82e76a"), "ORLICE", "Orlice" },
                    { new Guid("3883de67-ab59-458a-9de1-1e1026e27bf0"), "ORKE", "ORKE" },
                    { new Guid("aabc9e69-6dae-4f35-9250-8427eaedf15c"), "ORANIENBURGER KANAL", "OrK" },
                    { new Guid("e9f60b79-5fde-4026-b6a2-fb27112135e7"), "OHRE", "EGER" },
                    { new Guid("6ce9c61c-ab43-4084-bd62-9ad5e2ab6cf9"), "ODER", "ODER" },
                    { new Guid("89658af6-0df5-42bf-b550-5923fadc6f33"), "OBERE HAVEL-WASSERSTRASSE", "OHW" },
                    { new Guid("1a191392-64f3-408e-87f0-b91e10545b57"), "NORDSEE", "NORDSEE" },
                    { new Guid("e5c5d288-6a87-42ec-81c1-d58f1a6fcf1b"), "NORD-OSTSEE-KANAL", "Nord-Ostsee-Kanal" },
                    { new Guid("5963233a-8e39-459e-931c-e27c057a49b6"), "NIEGRIPPER VERBINDUNGSKANAL", "NVK" },
                    { new Guid("bac6f0b5-34e1-4425-a1d6-05624aa72fdd"), "OSTE", "OSTE" },
                    { new Guid("c821c96d-eebc-4f9c-8bd8-2aa4a304fb23"), "RÜDERSDORFER GEWÄSSER", "RÜG" },
                    { new Guid("b61e88e8-9c3e-4ffa-8265-3c1053df076e"), "SAALE", "SAALE" },
                    { new Guid("2f810727-4e7b-40ac-8356-ad1477d49150"), "SAAR", "SAAR" },
                    { new Guid("744e0bc7-0946-41ea-bc82-d0cea5cbf4c1"), "WESTODER", "WOD" },
                    { new Guid("f965ecf6-2057-479d-a571-3f4e30c1e493"), "WESER", "WESER" },
                    { new Guid("1e045f5d-abab-4826-85ea-b9c3fcafc271"), "WESEL-DATTELN-KANAL", "WDK" },
                    { new Guid("808af9be-2074-40a7-96b1-17973bd59449"), "WERRA", "WERRA" },
                    { new Guid("f1c53a5e-5205-4f4b-8463-c9c074919477"), "WERBELLINER GEWÄSSER", "WbG" },
                    { new Guid("d30e6e98-5a25-40af-a625-be880ef69a9b"), "WENTOW-GEWÄSSER", "WtG" },
                    { new Guid("63e486cf-7366-4c56-8d33-1f5f1874434b"), "WARNOW", "WARNOW" },
                    { new Guid("2b224064-51d8-451c-806a-836f4d7e707a"), "VLATAVA", "MOLDAU" },
                    { new Guid("7bd20795-fa24-4a48-ac2a-5c5c8510ea97"), "VERBINDUNGSKANAL HOHENSAATEN", "VKH" },
                    { new Guid("f68a87eb-4812-4075-a29c-82831687c30f"), "UNTERE HAVEL-WASSERSTRASSE", "UHW" },
                    { new Guid("3a151fd0-81a0-4b01-a439-d2aa553b0b38"), "TREENE", "TREENE" },
                    { new Guid("e47bbf30-f087-49dc-a85d-f097d829a39a"), "TRAVE", "TRAVE" },
                    { new Guid("177835d3-9d2a-42ef-88fd-a572ba3df9ca"), "TEMPLINER GEWÄSSER", "TlG" },
                    { new Guid("def28f4a-9a97-4659-85f4-7a0f47ec3309"), "TELTOWKANAL", "TeK" },
                    { new Guid("10415159-e774-4431-8de1-5ce83324718f"), "STÖR-WASSERSTRASSE", "STW" },
                    { new Guid("87724dc3-a0e4-4fe3-af64-0c174951d58e"), "STÖR", "STÖR" },
                    { new Guid("c309f510-67ec-4d13-912d-f703231458cc"), "STORKOWER GEWAESSER", "SKG" },
                    { new Guid("450a71cf-f2db-4932-96d9-33afcb7e1272"), "STICHKANAL HILDESHEIM", "SKH" },
                    { new Guid("512a905c-fbd5-4e1f-ad61-caba44d8b0f9"), "SPREE-ODER-WASSERSTRASSE", "SOW" },
                    { new Guid("714b47c3-c63b-426f-accc-bcb7ebdde0e3"), "SCHWINGE", "Schwinge" },
                    { new Guid("262436f8-2a32-434b-9d19-90d1922daadc"), "SCHWEDTER QUERFAHRT", "SQF" },
                    { new Guid("9e207d14-f5a8-43b0-b7b0-1d4c484e5444"), "NEUHAUSER SPEISEKANAL", "NSK" },
                    { new Guid("afc18147-790a-4af0-bffa-a54156c6ba7c"), "NECKAR", "NECKAR" },
                    { new Guid("8c8c8518-d59b-4512-b75c-36a67f95c260"), "MÜRITZ-HAVEL-WASSERSTRASSE", "MHW" },
                    { new Guid("e54e5839-5fc8-4494-9360-8989442a2242"), "MÜRITZ-ELDE-WASSERSTRASSE", "MEW" },
                    { new Guid("e9b9cd69-3073-4002-a0f6-37c2153c53ec"), "HAMME", "HAMME" },
                    { new Guid("966076cc-19e7-4922-921d-aad15d5164b1"), "FULDA", "FULDA" },
                    { new Guid("fea68b1b-7080-428d-9180-3a2fabf95d71"), "FREIBURGER HAFENPRIEL", "Freiburger Hafenpriel" },
                    { new Guid("637cbed8-f8a3-41a4-a649-cfed2613c6cb"), "FINOWKANAL", "FiK" },
                    { new Guid("1836bb37-423e-444b-bf2e-df21fed87fb1"), "ESTE", "ESTE" },
                    { new Guid("ed0e2086-7425-4d2d-b372-d9b219d5638b"), "EMS", "EMS" },
                    { new Guid("7eef13f6-e9be-4ca4-8f03-30c4aa75e493"), "ELK", "ELBE-LÜBECK-KANAL" },
                    { new Guid("f5d543c2-b584-40e4-afa0-19435627e3ff"), "ELBESEITENKANAL", "ESK" },
                    { new Guid("b35aa52d-9188-4489-8189-73f4e6b9841e"), "ELBE-HAVEL-KANAL", "EHK" },
                    { new Guid("de3724fd-80a8-46f9-8b5b-db378a84048c"), "ELBE", "ELBE" },
                    { new Guid("e2b58ea1-969f-4f72-a2a6-429c7fdd8f37"), "EIDER", "EIDER" },
                    { new Guid("afc35e3e-2400-4e4d-82d1-c11e3b3274d2"), "EDER", "EDER" },
                    { new Guid("c23322c5-ad2a-4050-9e64-e377341617a9"), "DYHRSSENMOOR", "DYHRSSENMOOR" },
                    { new Guid("96423534-6b1a-4af8-93d7-6f99af296ecd"), "DORTMUND-EMS-KANAL", "DEK" },
                    { new Guid("d19708ca-ac42-4ad4-8d62-e85722f946f6"), "DONAU", "DONAU" },
                    { new Guid("75a1d3e7-c6e7-4b50-85e9-c74ca31b0b5f"), "DIEMEL", "DIEMEL" },
                    { new Guid("28cdf699-e727-447b-b3ee-9d10f8b2a5b2"), "DATTELN-HAMM-KANAL", "DHK" },
                    { new Guid("ba4ac402-5733-4608-acd0-bc1edfd1a157"), "DAHME-WASSERSTRASSE", "DAW" },
                    { new Guid("fadeb941-fe23-40f4-b1cd-5c949dc8372f"), "BÜTZFLETHER SÜDERELBE", "Bützflether Süderelbe" },
                    { new Guid("3a2495f2-4581-43c1-8061-426525b1815a"), "BODENSEE", "BODENSEE" },
                    { new Guid("be09d030-9c00-4a2d-83cf-222a469b317a"), "BERLIN-SPANDAUER-SCHIFFFAHRTSKANAL", "BSK" },
                    { new Guid("fb9b6f64-a7a6-4744-a12f-5bdf31e6f0af"), "HAVEL-ODER-WASSERSTRASSE", "HOW" },
                    { new Guid("c656debb-f595-41af-8234-48f3c4c19a51"), "WISCHHAFENER SÜDERELBE", "Wischhafener Süderelbe" },
                    { new Guid("d54f6551-d1f2-4856-a873-86a6e17eebb4"), "HAVELKANAL", "HvK" },
                    { new Guid("90398d4a-b576-431d-ad9a-3a632a333daa"), "ILM", "ILM" },
                    { new Guid("de958aa1-aa8c-482b-8d76-11c9b8c68c47"), "MÜGGELSPREE", "MGS" },
                    { new Guid("aae1f1d4-f79f-4c3a-83d5-debffd711981"), "MOSEL", "MOSEL" },
                    { new Guid("09a03b1f-9ece-4086-94d8-462f98985851"), "MITTELLANDKANAL", "MLK" },
                    { new Guid("a8aca94c-fe23-43e0-93a7-39a6614b5d87"), "MALZER KANAL", "MZK" },
                    { new Guid("5f6f4fcf-e1cb-472e-8fd3-f331875e5153"), "MAIN-DONAU-KANAL", "MDK" },
                    { new Guid("2f14ff08-2c57-4da3-9c69-2978efd4ac6e"), "MAIN", "MAIN" },
                    { new Guid("5980613c-07da-44b7-bda4-5de17f9c20e5"), "LÜHE", "LÜHE" },
                    { new Guid("40c51e0c-d21c-492a-bbab-e9af3acc0187"), "LYCHENER GEWÄSSER", "LyG" },
                    { new Guid("171de910-9dbe-4b30-a4d7-a79e231fc411"), "LESUM", "LESUM" },
                    { new Guid("821630fc-d361-458f-b69c-2115a1c10b24"), "LEINE", "LEINE" },
                    { new Guid("48052b97-14e6-43a6-b096-7e7b4e95ee66"), "LEDA", "LEDA" },
                    { new Guid("d7818e64-186b-435f-a871-cdb9f75d4459"), "LANDWEHRKANAL", "LWK" },
                    { new Guid("fd74ae1f-78c3-4efa-8449-6ecc1fb482ab"), "LAHN", "LAHN" },
                    { new Guid("283901d1-24a4-4e8e-94f6-3fa3dfb4720a"), "KÜSTENKANAL", "KÜSTENKANAL" },
                    { new Guid("2e1a8e9d-983f-445b-8f31-270510396d90"), "KRÜCKAU", "KRÜCKAU" },
                    { new Guid("dcc5eb65-dee4-4bd5-a61b-80d3dfa54c41"), "KLEINES HAFF", "KLEINES HAFF" },
                    { new Guid("b22c66a1-fedc-4822-83c7-5918ef35d35d"), "JIZERA", "Jizera" },
                    { new Guid("a237b616-e51b-4c6c-8fe2-ef485b0a3879"), "JADE", "JADE" },
                    { new Guid("2063f11b-3b00-41a6-baea-2de71e34e5da"), "ITTER ZUR EDER", "ITTER EDER" },
                    { new Guid("aa74ebd7-e4b1-4ea4-83e2-989d94b90d6a"), "ITTER ZUR DIEMEL", "ITTER_DIEMEL" },
                    { new Guid("0f4ceb73-146d-474e-8232-3cabbccc27e7"), "ILMENAU", "ILMENAU" },
                    { new Guid("0bc5bdb3-7e62-4c28-b4d3-fd4d3e7580c8"), "HUNTE", "HUNTE" },
                    { new Guid("4f626d5c-3e9d-4fe4-839a-df9eb0262ba0"), "WÜMME", "WÜMME" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Slipways_WaterFk",
                table: "Slipways",
                column: "WaterFk");

            migrationBuilder.CreateIndex(
                name: "IX_Stations_WaterFk",
                table: "Stations",
                column: "WaterFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slipways");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Waters");
        }
    }
}
