using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace com.b_velop.Slipways.GrQl.Migrations
{
    public partial class AddSlipways : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: new Guid("06448fd8-dcc1-4579-947a-8a7b18bc1aab"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 837, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: new Guid("8976ceb5-19d6-4f5c-a34d-a43801667b40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 837, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: new Guid("f5836f04-e23b-475a-a079-1e4f3c9c4d87"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 837, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("102a6d4b-bd31-4428-bc16-e6991a1a9a1d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 838, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("45a1882c-4822-4cd1-9621-cebda51bfa05"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 838, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("75ee4dd3-5933-4904-9020-5836ec757f02"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 838, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8baa7bf4-cb1d-4d5e-b3c8-ef190dac1c3c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 838, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d07683a9-2ffa-4763-a047-31214e8eb9c9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 838, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.InsertData(
                table: "Slipways",
                columns: new[] { "Id", "City", "Comment", "Contra", "Costs", "Created", "Latitude", "Longitude", "Name", "Postalcode", "Pro", "Rating", "Street", "Updated", "WaterFk" },
                values: new object[,]
                {
                    { new Guid("11acb81e-0b41-46aa-a079-18c13cde3f3d"), "Essen Kettwig", null, null, 0.00m, new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(9920), 51.359999999999999, 6.9355000000000002, "Zur Alten Fähre, Essen", "45219", null, -1, "Zur Alten Fähre 31", null, new Guid("28e2b1b8-e353-4174-99a5-816229c68bd1") },
                    { new Guid("c6e16aaa-733b-4e1e-ab0e-19bb82669e0d"), "Landesbergen", null, null, 0m, new DateTime(2019, 12, 5, 20, 30, 29, 836, DateTimeKind.Local).AddTicks(5480), 52.553400000000003, 9.1122999999999994, "Fährstraße 7, Landesbergen", "31628", null, -1, "Fährstraße 7", null, new Guid("f965ecf6-2057-479d-a571-3f4e30c1e493") },
                    { new Guid("600eebce-5dd4-4de1-9068-401744a74c01"), "Krefeld, Gellep-Stratum", null, null, 10m, new DateTime(2019, 12, 5, 20, 30, 29, 836, DateTimeKind.Local).AddTicks(5630), 51.336599999999997, 6.6900000000000004, "Crefelder Yachtclub", "47809", null, -1, "Bataverstraße", null, new Guid("a88ea916-5e6c-4d83-83a9-1d4fdfef25ec") },
                    { new Guid("f0caa49c-2d84-437a-a1f2-53f56a4e48fd"), "Alt-Walsum", null, null, 0m, new DateTime(2019, 12, 5, 20, 30, 29, 836, DateTimeKind.Local).AddTicks(5710), 51.526200000000003, 6.7000000000000002, "Rheinfähre Walsum", "47179", null, -1, "Rheinstraße", null, new Guid("a88ea916-5e6c-4d83-83a9-1d4fdfef25ec") },
                    { new Guid("bfd617fd-29c5-4614-b976-65320c0f5ecc"), "Krefeld, Gellep-Stratum", null, null, -1m, new DateTime(2019, 12, 5, 20, 30, 29, 836, DateTimeKind.Local).AddTicks(5730), 51.341200000000001, 6.6822999999999997, "Bootshaus Krekels", "47809", null, -1, "Bataverstraße", null, new Guid("a88ea916-5e6c-4d83-83a9-1d4fdfef25ec") },
                    { new Guid("4ea84c51-a84c-4aec-bd52-7c9fba0c0e92"), "Duisburg, Ruhrort", null, null, 10.00m, new DateTime(2019, 12, 5, 20, 30, 29, 836, DateTimeKind.Local).AddTicks(5740), 51.447400000000002, 6.7243000000000004, "Pontwert", "47059", null, -1, "Am Bört", null, new Guid("28e2b1b8-e353-4174-99a5-816229c68bd1") },
                    { new Guid("3ec52114-07df-4e6f-83e7-8cb0c6a5e7d7"), "Meppen, Altstadt", null, null, -1m, new DateTime(2019, 12, 5, 20, 30, 29, 836, DateTimeKind.Local).AddTicks(5750), 52.693600000000004, 7.2885, "An der Bleiche, Meppen", "49716", null, -1, "", null, new Guid("ed0e2086-7425-4d2d-b372-d9b219d5638b") },
                    { new Guid("18db0434-5d5e-48e4-8c4c-c7b25b3ed45f"), "Alt-Walsum", null, null, 0m, new DateTime(2019, 12, 5, 20, 30, 29, 836, DateTimeKind.Local).AddTicks(5760), 51.523800000000001, 6.7066999999999997, "Alter Fähranleger", "47179", null, -1, "Fährstraße", null, new Guid("a88ea916-5e6c-4d83-83a9-1d4fdfef25ec") },
                    { new Guid("9f232734-8907-4a21-9b76-de97feb54a3d"), "Baerl", null, null, 0m, new DateTime(2019, 12, 5, 20, 30, 29, 836, DateTimeKind.Local).AddTicks(5770), 51.4985, 6.7146999999999997, "Woltershof", "47199", null, -1, "Woltershofer Straße 18", null, new Guid("a88ea916-5e6c-4d83-83a9-1d4fdfef25ec") }
                });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("003200ab-d138-49d9-aa52-217817941f85"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("005dfdae-efcc-410a-bf1c-24096e0c2866"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("00c33ed9-6bea-45b4-8728-7edc7e43e2f3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("00e386ac-e35c-4a6e-80dd-f8cd8a9e7a62"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0309cd61-90c9-470e-99d4-2ee4fb2c5f84"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("04572010-1db2-4338-8562-b3dca5e715c5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("04790e03-4353-4e80-beef-b3ed439484bc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("04acd7e5-3cbc-4cdd-b4a9-f452e868f4d6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("04cbc946-8ee9-4521-ac52-557642cad52c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("05ca0e33-5c71-4368-b824-2243fcff656c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06219dd9-a2c4-463c-9619-623b3c026cbc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06b978dd-8c4d-48ac-a0c8-2c16681ed281"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06c498e3-786a-48be-83be-6a6293ea3b8c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06d86c6b-5ed0-475f-805a-a3ceb59af083"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06e6b715-eb03-46ce-adf4-6cafca6368eb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("070b1eb4-3872-4e07-b2e5-e25fd9251b93"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("07374faf-2039-4430-ae6d-adc0e0784c4b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("07830b68-c5b8-42dd-bf48-7176802130d0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("087b6386-0957-4b47-af7d-ecd62f6d63ce"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("09227288-8c72-4b12-88fe-8765d1b2b400"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("09370c05-1041-4395-a5d4-b8db6e59c4c8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("094b96e5-caeb-46d3-a8ee-d44182add069"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("09e15cf6-f155-4b76-b92f-6c260839121c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0a6fe221-9fc9-46e0-802f-9c367a32ed72"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0d0082cf-0b4b-4c8b-8e97-5d37b511916b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0d8233b8-36c9-4a24-ad77-a4e7c617932f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0e065a22-9a0b-4f1d-b813-22fe6321bb1a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0e0dbcc9-0a7d-494a-bc92-52e56a7fffe2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0e192297-1224-4465-b1c7-a476cc17f74d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0f7f58a8-411f-43d9-b42a-e897e63c4faa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0fab94c7-d51c-4b5a-a2ab-694c13efb024"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0fd56e0a-e32e-4b56-9cda-e0ce93d715c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("104fdc24-1dc6-4cb7-b44f-10bd02e13f40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1125a391-6586-4951-865f-3a2c72f2c81a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("116572da-c036-4486-ac18-a92932424e30"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12499527-9476-45ed-80a2-b2b729742414"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12847496-b0e9-4cb3-905c-b1b1c3c087db"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12a3037f-cbf3-49d3-8da5-77fb38730bba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12deef85-1779-4b4f-9ba6-8467dc9d9866"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12f63015-c66a-4e89-a69b-ddd069872d40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("133f0f6c-2ca1-4798-9360-5b5f417dd839"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("136febf6-1371-4118-a9b8-4275444bda5d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("13e91b77-90f3-41a5-a320-641748e9c311"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("14699a51-aaa5-4ae4-98a6-d35aa9a80ec3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("15859426-834c-429e-9c41-2e097b717b1d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16258271-ec03-4542-873c-1642c8b654c9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16508b11-4349-48f7-be51-1227b7888585"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16578824-88de-4700-ab09-f61dbb1182bd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16a780aa-475d-41dc-a8ec-20488415b6d7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16b9b4e7-be14-41fd-941e-6755c97276cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16d180c2-63aa-486b-8966-81a6041360bc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("17ea8bab-4e26-4c4a-8071-7e7e4f464e29"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("18216ff8-18aa-4a71-bd32-e7479ccc439d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("184200bc-cdb6-4116-a7cf-ac986c2d4fb8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("18e6fa6e-2564-4057-8503-05213e49e57a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("19cc3b9a-546b-43dd-96a3-b0bf903672d2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1b2e2996-c2ef-4d9c-9052-ced8cb7bc226"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1b51e55e-088a-44c3-a633-b1bee44422d7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1b8ac909-8377-4887-ab70-748de2dd9775"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1c80e441-a1d7-400c-b569-e038c9876a4f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1cc71bb2-99e5-4479-8ae9-8375568ed22c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1ce53a59-33b9-40dc-9b17-3cd2a2414607"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1d26e504-7f9e-480a-b52c-5932be6549ab"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1e51195c-f9d7-4cff-9db1-d92bb855005c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1ebd0f94-cc06-445c-8e73-43fe2b8c72dc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1ed983c3-114c-4fcc-a1db-61d336cf045f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1edc5fa4-88af-47f5-95a4-0e77a06fe8b1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1f1bbed7-c1fa-45b4-90d3-df94b50ad631"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1fa822e6-fb0c-4331-83f1-749972046dca"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1faa9b2c-c269-4662-af70-ef11da27cc1c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("200363fc-cdc5-4c22-a271-a25d1ba880ed"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("213a585d-d665-4be7-96a4-78a992b9614d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2203fce7-9d1e-4586-84ab-0797468863a1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("220ff4c6-83da-4a1b-9c13-dfee5a2a8798"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("227b83f7-1302-4d7e-8d70-899036ff4ce2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("227e53ca-4dd9-482b-be62-52fdc62a4b4e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("22b7dcb3-8c42-4f71-9191-49143ba3a828"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("22fd01e0-090b-476b-80aa-f4586e259785"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23045f8b-e7e8-4534-8162-b7dba81764db"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23517de9-9b81-4a34-ab82-adff6443c235"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23636a08-775b-4101-a1af-1b57fb466d81"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23721dfd-9b89-4b69-af80-063229917f27"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23af9b02-5c82-4f6e-acb8-f92a06e5e4da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("24440872-5bd2-4fb3-8554-907b49816c49"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("244cae8b-ce75-4c2d-a66e-cb804f8335a2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("24c6a014-864b-4d53-bd05-0b49106f5412"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("24ce3282-39dd-4f2f-ba80-9676e59de7c7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("25530a3e-d0a8-456f-b7ea-6a3886843279"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("25582d3f-dc5f-4c70-bd08-e84fd13201ca"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("259dcb4a-2366-45a6-a448-b06a8941ae16"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("25ca1bef-4f8e-4523-89f5-7d8593e46370"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("26259e8f-7d2d-47e0-8851-0257542b63b3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("26656fda-cacf-4e92-9935-3ae6e717fe5b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("27dfd137-3b88-42e8-9baf-6bee76e0717c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("27eed51b-c0a4-417e-926b-bb4194bfb341"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2813f196-3404-4ac2-92be-e288fe1607af"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2852b9ab-d30e-4d04-ae06-3e946f48a0b1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("28ec91e8-90c0-44d1-8fd2-b0b64c00c43b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2ae6cc12-5491-4f59-94c5-ccdbcb7474c8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2c68509c-bf1e-4866-9ec4-b26b231e5e04"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2c95f83d-4669-4553-a18d-3f493176d34d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2cb8ae5b-c5c9-4fa8-bac0-bb724f2754f4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2d1fa45a-8928-4ad0-b564-e74f7189681c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2d93f2be-6d57-4716-a775-92fb5a63f88f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2d9f473e-f2b6-4f50-bb4d-96362230a976"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2e1d458b-f78f-41dc-bebd-e0512578610a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2eacef2f-7a8f-413a-a2c7-f1da4cf22742"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2ee12b9a-f7fd-4856-82b9-6bdd850c2bba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2f025389-fac8-4557-94d3-7d0428878c86"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2f1080ba-97a2-40b3-af4e-3ac3d53d27de"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2f56e265-cd67-4ea1-8529-549b6ccf273a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2ff6379d-d168-4022-8da0-16846d45ef9b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("30739ff3-9d71-4e38-991c-0f7a2f54ed2d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3079c709-9d83-4c59-bf91-6bed2d5ea372"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("308c39b6-475f-42c3-857f-7cf257426fa1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("308f5979-4ab8-48ab-b618-081aa285559e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("30bff0df-8333-49ec-8fd7-a2d4c0db1cb1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("314945d6-b499-40cf-bb21-d76cf4547e3a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("314ef522-a060-4033-ba14-8169dd26bb8d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3199ce09-cd9b-4be2-82bc-f03bb81438e5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3244d787-f884-40ae-9752-ad3507309edc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("32807065-b887-49f0-935a-80033e5f3cb0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("32b997c2-d97c-452a-a5c1-ee4592a15b4c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33092c28-201a-4210-89c9-ce68cad61ed1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33193e2b-1203-4681-a23d-f87b9fab4b60"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33bdec83-6184-4ca5-a075-f44185aef302"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33ceb441-23bc-4ca6-9fcd-ac35d41ef117"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33e0bce0-13df-4ffc-be9d-f1a79e795e1c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3404a6e5-8dfe-42b1-90f6-c0c3741b6ac8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("340707f4-5d35-4898-8b34-95ea3f4206b3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("355b02d2-c578-46d9-a56b-8046d470cb95"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("36243256-7786-4e69-922f-50785d8904bf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("36e85829-2fb3-41a0-8a1b-aa9e76431b47"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("36f80081-9353-4ab1-8e61-07a5509f1cea"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("38414157-862e-428a-ae2c-77ff79871227"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("38497786-6c29-47f4-93de-d96001629496"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("391bbba5-83d4-4791-b07e-65ab29b423f6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3944c1fd-39f5-47b1-bb6e-323db05d70e8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3954300d-f112-4fe6-8d0a-b06496372e36"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3988cd01-1c7c-4bd3-a8ce-d324f73f346d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3a24863b-fdec-455c-82da-ea8c7ae6f97a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3a8ed45f-28e7-4263-8437-d926c6a194f4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ad4013f-644b-47f5-a641-44b332bfecb2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3adf88fd-fd7a-41d0-84f5-1143c98a6564"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3af7d65c-c732-49e9-be05-fe3b5f88657c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3bec53ca-444e-4014-a7b0-07b3591e954b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3bfcf759-27b3-4042-b59a-f6c8ed9e533e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3c7cfb10-c866-404b-b11c-0d79986f865a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3cd46cc7-b94d-424f-a860-c389dd9992a4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3d276f8d-a38c-407b-9727-b2a77b06284b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3d43a8d7-e599-4fc4-bf62-65eb0794685e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3de69bf8-dcbb-4afb-a15b-a8683a6a689c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3de8ea26-ab29-4e46-adad-06198ba2e0b7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3dec3921-6f01-4801-b648-a7f3ee33acd3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3eba7da6-fbd6-431c-91d3-522ec49275f0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ed90357-4b01-4119-b1c5-bd2c62871e7b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ef81fc0-33dc-4f67-8bb8-3f66975292d5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3f0b6b74-80a9-4576-a3cb-ea967dfc349f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3f3b4445-9a6a-44c3-8575-d86ce30e2de0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3f8ceb6d-e95d-46e6-b523-3d15fe706049"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ff99b92-4396-4fa7-af73-02b9c015dcad"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ffddb2c-4c17-47d1-a7de-e1663d4031b7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("414dd4ee-b38b-489f-a1fe-19b1d62f3202"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("427318d0-ee8d-4d9b-89f1-e8a8685b5d8c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("42805eb1-aca9-4f32-a373-24a9cf839aed"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("42b865fb-5dd8-4204-a7aa-260704d69e21"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("42ecae60-eeb3-4b41-9721-46b3f12d04b8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("438b565e-f293-43c8-8771-377e555ed5ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("43ca90f5-3b4c-4b35-86ac-cab0fe1c2ce5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4457a320-1f99-4352-8a43-ff24109d99ea"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("44bb934c-4250-4e1b-ad70-0fbd8bb3eadd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("44f7e955-c97d-45c8-9ed7-19406806fb4c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4520c1a8-174c-4b95-9ca3-fe1e3f9d874a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("45634232-36ac-416c-806d-5f64201dae2c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("45721a68-566c-4e2a-a6c7-a7595982a779"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4626f6bc-494b-4a51-8c10-b47a32e87790"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4627475d-ccda-4d53-8f13-28527c49eaf5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("46644438-83d6-4da8-a2a1-1deb2cb67561"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("46a3350b-f3e6-4f5d-a297-2652c43bfac8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("46d8ed02-73fd-4958-8e2e-006c047d0576"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("46e61953-4bdd-4045-a14e-a83948514c8a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("470acd2a-f3e7-4fd2-96b0-e90344ee51bf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("47174d8f-1b8e-4599-8a59-b580dd55bc87"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 830, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("478f21e9-906b-4c6f-a009-b5eabb052746"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("47d3e815-c556-4e1b-93de-9fe07329fb00"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("48780245-36f2-453e-b430-5fa838851d6d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("48f2661f-f9cb-4093-9d57-da2418ed656e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("492f85b8-e5c6-439e-8e14-08ca78f10dce"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("497c29ee-32b2-4535-ac5f-3881a106c793"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a0061f0-7355-4a95-9c70-f05c8920d790"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a2501bf-cb57-46bb-87d3-d6808286b31b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a4daad2-0e96-4070-914e-a1c4f6b7a3e5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a69e82e-97a3-4573-8aeb-b695c1eaa0b1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a904d59-d48f-4878-af7b-cbd955f342e0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4ae7098c-116d-42c4-8044-1db0af0f57ee"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4b348b56-b08c-4522-9042-49c1edb45d0d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4b386a6a-996e-4a4a-a440-15d6b40226d4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4c00a166-7d6d-48d7-b4dc-673b96b4041e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4c7d796a-39f2-4f26-97a9-3aad01713e29"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4c8282c1-c9c5-40c2-b379-95495ce0deee"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4d00c13e-e689-4dfc-85e6-a3fc8596ac8b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4dbce62d-a015-4011-afcd-423bb8d4b7a1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4dd743e9-3040-4f11-8c7c-d5c5789d80b4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4de8a51c-4c6a-4334-92dd-0b1cbb8e0573"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4e4fac1a-6fb4-4ce2-a041-bdc4a668d95d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4e6a3d17-1855-4458-b3fc-e71921a4da7b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4e7a6cfa-7548-4f7f-a97a-eb0694881003"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4ed5f6da-b7a0-4431-ab1f-1a26e69a21bc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4ee515f9-8cfb-4835-8460-8dde0b978fbe"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4eec6b25-6b02-4448-b5db-10843c8d6175"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4ef9dd9c-b32b-43fc-bc5e-3849d4ab7ecc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("501aa608-ea81-4690-a491-6602114c14af"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("503ad891-c9de-428c-b682-434510ed9de8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("506e6b03-1209-4650-8b3b-3cd2d4724b5f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("50a449ba-af4c-42c7-b2c4-9a3eda37e1e3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5140295e-b93e-4081-a920-642d89c7ca8b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("516c4814-d70b-47bf-99bf-a76844b94e5e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("516fbf8c-dc08-4808-b39b-1fa65a462180"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("522286e2-b2b3-4d0d-9a11-01b3ea418c76"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5287a3e1-c540-4ab1-b52e-880d124cbc43"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("53088d32-226a-49b7-962d-a5879c3aba29"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5310aed3-784c-4290-bfff-806c75b831d9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("531da758-b2f5-471d-9d9f-a78576081079"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("532d8718-6ec7-4f12-bb2f-bde2dec50182"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5389b878-fad5-4f37-bb87-e6cb36b7078b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("53c277c3-7ddb-4281-9937-97dcfe3753fa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("53d40547-8a09-4b25-988c-2e6d8d8d98ee"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("541c508a-00bf-4a9d-bd47-17fda98b349d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("547422fb-364e-4870-9977-c7782f0712e2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("550e3885-a9d1-4e55-bd25-34228bd6d988"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("550eb7e9-172e-48e4-ae1e-d1b761b42223"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5553e209-1b44-47f5-917d-2c6951ecc044"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("57090802-c51a-4d09-8340-b4453cd0e1f5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5735892a-ec65-4b29-97c5-50939aa9584e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("575da86f-d975-4837-b6f5-6f19c3a5e4b6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5918b484-597f-4a1c-8262-0d0cbbb7986d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("59219312-9e87-4b8c-8dde-325af733d282"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("593647aa-9fea-43ec-a7d6-6476a76ae868"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("599c23b1-4550-41e3-a7e7-3056989927f1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5a33bf14-6bdc-4666-b2e3-ac78e3083e2a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5a7e1d4a-53aa-4f9f-a59b-50e01b7260c7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5aaed954-de4e-4528-8f65-f3f530bc8325"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5b58af00-6817-4214-b151-34830ac563cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5b83cad2-ed64-42cf-87dd-98e27988c31a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5b94e4b9-cc96-433f-abf7-08287137ec54"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5b9f8134-8bf0-4b51-a548-72a36303bbc2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5bb1f56d-7c56-4b01-9da0-2a08a0aaedeb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5c1b6183-eaaf-436c-b863-8a191d9e1f5a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5c4c2d52-6c0d-4aa2-beed-6ce47e3e2bd7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5c735fa8-270e-42c3-b22f-b27418db10cf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5cdc6555-87d7-4fcd-834d-cbbe24c9d08b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5d1e4350-0f39-4428-84c3-6f8f0bbe80d4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5db8ab4b-315b-466e-b9d5-5ba5a19f5f08"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5e10e1e7-9115-4bd7-ad57-e2062f516891"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5e6ae93a-7856-4005-bc77-fc6e4f5ad630"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5e92d73f-e4ea-42c1-9f98-91536c17cdff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5fea1a12-326f-4919-ac9a-02f9fa11ab57"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("60b6ecb0-4ed5-4b8a-b875-07ae33a92b07"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("610ab204-d3c4-4a11-a38b-e31461fdcf27"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("61394669-3f1b-44e5-ae37-50fd2512f4fa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("616dd98e-816d-4e17-b8cd-57b163dbc8a2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6233e901-2600-4b54-ae06-7b987934e99e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6288de60-38be-4291-9ff6-dcf6c0f58cea"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6298a8f9-7c77-4605-a55a-278c61cc8f50"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("632a133b-fcc2-467f-8f9c-1ec63144f8d6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6386de1c-0426-4795-b23d-7ea2754ec782"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("63a222c0-bd45-4af8-b9a7-27f9443a1936"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("64c37072-db97-4e08-8981-c67f0282de5c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("64f735fd-88b6-42ea-9cdd-dc18d3806c34"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6610cf2e-7bfd-4686-b9ac-b105f492d708"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6629a4ca-4e2e-40b8-a66c-964d906c6911"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("662c4b5e-0241-456d-ac7d-9f62fd95c0d1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("665be0fe-5e38-43f6-8b04-02a93bdbeeb4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("66ff3eb4-513b-478b-abd2-2f5126ea66fd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6760b547-a7e7-408a-b3aa-529fe376bfcd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("67d6e882-b60c-40d3-975c-a6d7a2b4e40a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("680d5966-273f-4254-aabe-5d4e00e12a24"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("69308142-f78e-4877-9af8-e7221b01d303"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("69fb4730-4866-4838-9b18-2c0ee9dce80d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("69fc0432-e9dc-400c-8c21-0c26e85df884"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6aa1cd8e-e528-4bcb-ba8e-705b6dcb7da2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b05e8dc-3089-497a-a602-f40c4283d8bb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b1b5c70-a23f-46de-954d-02bdc5bf2ecc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b53ef42-5bd9-4366-ace3-442e307bec60"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b595707-8c47-4bc7-a803-dbc327775c26"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b6b31e2-e5c7-4c85-8405-b8d0b6e158c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b774802-fcb5-49ae-8ecb-ecaf1a278b1c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6c5b6422-126d-4bf0-8856-7b86d74ea1b3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6c76e98e-44ca-4d25-91e7-b07c68577c5e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6c7c180f-6dc1-4c4d-97bd-814080df8bcf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6cb287c2-2fb2-4845-b11f-e78bd5db2ce3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6d3a3e2a-713c-4232-9b70-834a2c0e9705"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6d43098c-632d-4e89-996f-98b1c99e5630"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6da1a0e2-9af5-4a4c-b52d-c0faead67d70"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6dc44585-5b88-45d7-9c64-7c845408b698"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6dc4e4a0-2c10-4c27-a08f-a0ca0aa13df2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6de43652-2db9-4627-a255-9cb1f8efb820"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6e19aeca-d37a-4b00-9354-c6dd90f12de2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6e3ea719-48b1-408a-bc55-0986c1e94cd5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6f81b35f-8339-4012-8029-ca193403e52c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("70039212-c8a8-43fc-82a5-150d95831772"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("70272185-b2b3-4178-96b8-43bea330dcae"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("706e5110-c5e2-4915-9989-c071fcb492ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("70bee932-1c14-42f8-b4df-9a85589ca80e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("70d4f87f-4489-455a-a435-d6df9e09a87e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("71357738-c8e2-4cb7-a41a-365659bb8d58"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("721313e7-935a-4bb8-8c6d-0e014211b2ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("721d7dbf-c947-405c-8dba-e672a091f4c0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("728bd3e3-23f2-41c6-8ac5-4cfa223a5a7e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("733755fd-628f-4130-a694-aaba340531ba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("736437d7-0f6f-41b7-bc69-5ed721da4f85"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7398029b-c6a1-484f-b1f6-1afe568ee1e2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("74134dc6-8e26-4195-9cdc-c22aa0a3558c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("752a8c5a-5f2a-4575-af2f-d825cffc6eb3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("763633e7-3b4b-470a-978e-f9e456e4df7c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7644f1d7-3198-4313-9340-abefd459a4f3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("76844306-4c37-4a6f-aac4-9e518e96306f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("768df4e9-ed5a-4141-901b-e25ac404d559"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7703d54d-ca33-44b9-b519-c618bae5bcc7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7753c1fa-34d8-4d09-a7c7-38024079117c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("78029185-9dfc-4b1b-8695-45ebc2a09cf4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("787e5d63-61e2-48cc-acf0-633e2bf923f2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("78d69798-f956-4222-8d2b-f9f630fb9e36"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7909d3f7-ef5d-4321-b76d-712d9b0a0c68"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("795ce865-3ac4-43b8-88d5-049a34e4359e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("79d783d3-e423-4c6d-b914-d7b7d161a89f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7aa4b078-459b-4392-a0a7-93e533b2283e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7af19499-8bc8-4a91-964d-88618ea8998a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7bbd90ad-98e9-4415-8040-23500f2e01e7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7cb4566b-c584-4167-8736-f52ca7fd837d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7cb7461b-3530-4c01-8978-7f676b8f71ed"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7deedc21-2878-40cc-ab47-f6da0d9002f1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7e530482-0a13-4728-99db-a376304398b8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7f01fbd8-653c-40ba-8ed0-57386a9b4557"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7fe63a95-8ff6-4cff-9a29-a124136516b5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7febef93-09ce-49e9-9643-ecb3076ce9a7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7fec2f4f-6a2e-47ec-8f3c-016c581e4bbd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("80f0fc4d-9fc7-449d-9d68-ee89333f0eff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8122b09b-a174-41d9-9a38-c0a5223366b8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8134af78-3100-4679-bf1d-be82410df429"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("81630fdd-5949-412b-a2e0-d3da8bc8bcda"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("816affba-0118-4668-887f-fb882ed573b2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8177a148-5674-4b8f-8ded-050907f640f3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("81c95d3a-3193-4e9c-a411-adf97c751a43"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("824a046b-9ca3-4db8-993d-e755122854e0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("827b2685-47ec-44df-a90f-980f5e0c1591"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("831ad501-d2fe-4782-ab83-4f1c8e0b15ff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("83bbaedb-5d81-4bc6-9f66-3bd700c99c1f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("844a620f-f3b8-4b6b-8e3c-783ae2aa232a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("855205e7-1cc9-4c5f-a2c2-7d5d84011708"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8559d1a0-4a03-410a-8910-44a089a07df8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("85d686f1-55b2-4d36-8dba-3207b50901a7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("85fc0dac-a53f-4638-880d-40b24bb282f3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("863359dd-3171-4641-97bb-b21f06859072"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("864a8111-d0c1-4b74-b94e-515f0869355e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8675aa70-cfbc-471a-8566-dcc851f201d3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("86c5688f-2fac-4d58-a245-ad8ce14cafbf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("86d07669-4670-48a1-8f30-7d7b26224ad6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("86f66699-29b6-4b94-85cb-d241e832230a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8727ebfd-e2e1-43da-ab3d-fee48cff9acc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("88e972e1-88a0-4eb9-847c-0925e5999a46"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("89038b42-8181-48df-a0cd-2ca3913f2d68"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("892183d6-3a28-4347-afb4-bc89602ca927"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("896aed46-8290-49b0-a6f8-90d53027cd1f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8a08c920-c911-43e5-90dd-27d4d4e757d0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8ac85e6c-6167-496c-b16f-fa94f81cd94a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8af24d6a-eecd-434e-9f1a-60ab6bc05490"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8b4f9f7c-3376-4dd8-95c1-de55b1be4dfd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8ba772ed-e45b-4be8-b91d-0c6c92de59e4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8bccd43b-ed6f-4ed8-ae6e-80ad7e330658"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8c20b4dc-1540-4b14-8c88-0e1d87de22c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8c3295dc-fe73-45bc-9a7b-679d4aaad0cf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8c8afb56-88ea-483a-a7d4-033c22f53497"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8d18d129-07f1-4c4d-adba-a985016be0b0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8d1fdc5b-b63a-4745-baeb-5e266d247e99"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8e16bd66-c49b-406a-930e-4dccfb330ff5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8e326085-c879-4704-95b4-c1fc19874176"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8effc15d-8583-4ac6-9f42-1b63c47f92b0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8f7e5f92-1153-4f93-acba-ca48670c8ca9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("905e7328-b8aa-4b08-9c22-c864101e462b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("90bcb315-f080-41a8-a0ac-6122331bb4cf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("90d92801-c13c-4b1a-8885-83d1a07d6db8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("914ce0a4-d900-4bf9-bace-47a6f73e7bed"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("915d76e1-3bf9-4e37-9a9a-4d144cd771cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("91922b9b-ef7b-4aae-95a1-9d6a9e61969a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("939f82ec-15a9-49c8-8828-dc2f8a2d49e2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("93ddc1e6-072c-45f6-99c0-d7d7df9d39cf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9427fafc-7146-4be1-a71e-4e4658236037"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("94f6eff1-4f3f-4850-82e0-a086198e9ffd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("956ce5ff-1fc8-461e-ab2e-0ac70758bb46"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9592d736-26af-46e5-84fd-e43e89b66566"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9598e4cb-0849-401e-bba0-689234b27644"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("95a0ab45-a9ac-4f9a-93e9-b0ffa1c57b5f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("963bdc26-34ad-43c8-b653-bbaa3466276a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9829cab0-746b-4d10-9124-79ddda0a843e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("98daae03-5aaa-4284-9717-7d52da4fe063"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("99309d3e-58d6-4200-b212-c8499467b4ce"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("99619dc5-9c88-45e9-a97d-653c41cda8a1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("99989609-7bd8-4f91-bd55-ad31fbf55ee4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("99dd338d-ef7d-43fd-a4e0-a9103406f0ad"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9aae4921-bda4-4081-b67b-2e0c5ab8bc54"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9c336515-b238-4a1a-947f-dabe47f4b502"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9c4c11f2-0548-4555-beac-ecfd36f9bd74"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9cf795ce-8bdf-494b-b8c6-ef1bfb89c08b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9d7cc90a-7380-4dbf-8641-3201dfcbc75d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9da1ad2b-88db-4cbb-8132-eddfab07d5ba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9dbcac54-db55-4d24-88b2-74a0d75a68c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9dfb4b0b-daa6-4a90-9a82-60734d3d2f04"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9e19c411-f728-4a43-a057-39d4155c71cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9e4adf71-ed15-453a-b50e-de03d2077e04"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9e7b2a4d-cfe8-4524-8a1e-c196ea897e9f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9f12c405-35ac-4d90-9b7b-023be355867e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9fb9abce-e1ac-4c11-94b2-a32d63f6fb40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a0c1dcb6-7812-48e6-8c01-f7edad7a2caf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a1341b43-9c62-4e71-87cc-61a0d4d1b105"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a1cf60be-8149-445d-a7a6-e7c7e7051944"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a238b70f-1198-4b2f-8c03-41f3503e5389"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a26e57c9-1cb8-4fca-ba80-9e02abc81df8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a3328262-207d-4e65-96d8-202368ca0cb8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a37a9aa3-45e9-4d90-9df6-109f3a28a5af"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a392113c-d040-4b36-b47d-9099275bb308"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a5830277-af1d-4c64-be72-00591f36216c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a5902c55-6ff4-4bbe-88a1-ebba45b03cec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a64918a6-e6f5-495e-ad2d-a8e3655c9424"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a653eb04-de2e-47f7-8e2c-09277cfe95ae"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a68cf527-a458-4d84-8171-7756813ca72c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a6ee8177-107b-47dd-bcfd-30960ccc6e9c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a73a9cb4-5bc2-4d42-b7cd-191d5e1ee307"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a77aad00-caa0-44a2-95cb-8afd9c4ff00c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a7b1eda9-bed4-4456-8e54-529828cdcbf9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a7ffcc9e-fecd-431c-8044-e004682d023f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a8604e8f-9330-4431-8cf6-0a68fc793c82"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a869dd39-dcf7-46f2-b9bf-b210816109ac"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a919f57f-8378-42d8-82f8-b87eaf008641"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9299f0c-9eb8-4369-a260-4be929e72736"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9320108-ad58-41b8-b7b5-f52163a23927"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a98b4a84-e51f-4d03-86d9-3b8bdac10e69"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9b8e24c-012a-48dc-a823-d48c1637cb42"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9ca43e9-ef92-4f1c-ac02-a6c8ccad7b9f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9e93be0-cb0e-4418-ba3c-94e7869f6199"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aa6af4e6-a44f-46c4-abf6-449f8a68bab1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aa9179c1-17ef-4c61-a48a-74193fa7bfdf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aa97c894-ed26-4fdd-945f-db9667979268"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aac1846d-a0ea-46f3-984d-b3938b0cb82d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aac49cf2-5d3f-4c69-9847-027fecaeef30"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aad49293-242a-43ad-a8b1-e91d7792c4b2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ab0d9117-83f3-412d-bce5-b3e698246c0b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ab13c115-6924-4d88-822c-0704b8df4767"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ab53a592-0f5a-43e2-9133-bf3169b0f274"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ab9d5a42-2b8d-491b-9fd1-8120df23c8e6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("abb23dad-0880-41ab-8d2d-dd33e11f148f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("abd34ee6-a578-4639-b73d-fa4e08f40345"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ac507f42-1593-49ea-865f-10b2523617c7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ac6c4362-1fb1-4b7a-9406-016bed804804"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ac970eb0-f5cf-4db0-90f0-e281f5d4775c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("acd63934-e40d-4650-a094-01cea45432be"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ace7d4b0-33e5-46db-a41d-2fa7a321f67a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ad357e52-0978-4583-91e6-bc03a222f655"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ad3a51da-2e25-4818-b96f-6a6d8a20d803"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ad3b53f8-8c1b-439f-a0df-9f24827026d5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("adbd3144-1774-45e8-8eb7-60f01a712426"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ade3a084-8680-47b5-9d2e-288cb6c5f9d5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ae1b91d0-e746-4f65-9f64-2d2e23603a82"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ae93f2a5-612e-4514-b5fd-9c8aecdd73c7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aeb9ed1c-6c01-4829-94e4-e530dbf79821"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("af82bc24-a355-4247-9532-b305eb57e16f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b02be240-1364-4c97-8bb6-675d7d842332"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b02ce5c0-64e9-4d24-90b9-269a28a1e9f9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b04b739d-7ffa-41ee-9eb9-95cb1b4ef508"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b09f2243-60f0-469a-8f3b-0ea6abc83267"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b1cda5a0-115f-4976-a0a6-9d427ff6dceb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b2204ea2-eb50-439f-a64d-98062ea1d21f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b26bfc88-eb8a-45b9-9dd0-0e41949a2648"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b327e35c-5dad-4b79-9cef-60fbd504eb37"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b3492c68-8373-4769-9b29-22f66635a478"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b3d88ca6-ea13-4540-a623-c02e43800a3b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b45359df-c020-4314-adb1-d1921db642da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b475386c-30cc-453a-b3b7-1d17ace13595"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b577a043-b6b8-4db8-80e7-8abbb565c8c5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b6650b13-582b-4d54-adac-991ac140e039"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b6bbe4f8-aa59-414a-8292-2d3919590a20"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b6c6d5c8-e2d5-4469-8dd8-fa972ef7eaea"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b7e238e8-29ec-4522-8252-b2cae7d4f58e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b8567c1e-8610-4c2b-a240-65e8a74919fa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b8997708-53d0-4932-8fbf-265083e11517"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b89b68fd-0d40-4941-9ee1-e4f7a56351a0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b8b8c069-0993-4a45-a226-a6c8c18185ab"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b8d05bf9-2ef2-416d-ba70-b5dba74fe777"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b9163121-2747-4d2b-bcf5-ab5ff7396e56"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b9975ea1-5b45-4e27-abb8-4c3f7878b1f7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bacb459b-0f24-4233-bb35-cd224a51678e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bafddcbf-4108-431e-9f57-568be08fd538"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bb23b276-2c1c-4cde-bc9c-9d90d5a04890"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bb5560fc-7995-40a2-b92f-3d828c67dcfa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bb62b28f-9947-42b1-92e4-743a1e0c4a76"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bb6fd2f0-458a-4ea5-aa58-e1c1a2fbd56d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bc20d819-1782-4588-885d-129f21a27cf9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bc9f369e-5fd4-466c-8d97-ddb1ecd2aed2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bccaacb3-a9a5-44aa-b05b-3f29c3c6e38a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bcdfa310-d887-49bf-a562-1e439759044a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bd317edd-214a-4e11-a9dc-3cc71a2907c3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("be05603a-83e4-48d4-90d9-e074b7d34dcd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("be7ce40e-5fff-42df-8386-b42694ca86da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bec8a6a5-c3de-4322-856a-870ceb992fe4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bf48cefd-0d00-4186-a366-343c25f43615"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bf7bb8e8-e81f-4655-9e84-28738feae936"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bffdf7f2-6200-42a2-a4bc-a8111e27e043"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0244c0e-6ae6-40cb-a967-4039b2a0ce7c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0594fb5-77ff-4287-9b8d-7ff326afe9ff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c093b557-4954-4f05-8f5c-6c6d7916c62d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0ec139b-13b4-4f86-bee3-06665ad81a40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0f33a36-cac4-4e47-a3f5-d1863c2f0f99"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0f51e35-d0e8-4318-afaf-c5fcbc29f4c1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c13fc7d0-beb1-42a3-b831-4816d7649059"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c1588dcc-e314-4097-a54c-c0ffbe79209f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c1d6f464-f38a-4e38-9f74-4c5d22a42c88"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c1f059dd-5063-468a-9dfa-0360fe0b030d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c1f06401-9488-4a27-b932-59cce52c5819"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c203d5fb-96d7-4643-b2ef-b13b1d88c75b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c233674f-259a-4304-b81f-dce1f415d85b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c263ea53-ca4d-41f5-b3f5-6178fec302aa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c2aa9164-1073-4271-82ef-44344fbe456e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c33c3667-b8c5-484a-8ea0-b92933b5a9f0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c389c9e2-a5d8-4104-a4cf-510ade44f143"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c41d42b1-5b0d-47c9-ba53-d58d3d109b64"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c42ad3df-cfe3-4dca-9dcf-dbbaac569a2f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c42ff4c7-f4c6-4568-8b5c-0b556bd55926"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c4381eb3-d21f-4bd1-bc1c-66c03b7d8bcf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c62aa674-db07-4251-a50b-1676c11a9a25"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c6772c3c-a6bb-4728-9250-a408ab3856bd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c6a12d34-c78f-44a2-a7ff-4b8d88f316cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c6e9f744-4dbf-4e8e-a219-cab051ec610c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c7364d1e-6139-4575-84cb-b420d21275c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c7383149-1f77-430d-8bef-c5667be3846b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c80a4f21-528c-4771-98d7-10cd591699a4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c8a1cf0a-9441-47aa-8c64-64e8962a9bd4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c8af067c-ba6a-4a76-86d8-1ce8e532ef8b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c8b9a2b6-b783-417f-8479-3a0d732fb901"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c8ff06a7-eac9-4db7-ab22-46954d4481cb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c93a87fb-a3d3-4d4f-a55d-8fabcfb9ab64"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c9409937-b794-4b69-b36b-38467daab09a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c9a6c3bf-02d4-4945-83e8-b7c6cf9701fa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c9df61c4-2a0b-47bd-8b51-fef7f430e528"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ca0e4a68-bd50-494c-bd45-abb33c5e1b0a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ca3f535b-4a32-4dd7-a56b-2ac20dea4472"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cb93548e-c1ce-43f6-b3a1-6903f8835b33"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cbf3cd49-91bd-49cc-8926-ccc6c0e7eca4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cbfdddd1-9e32-4de2-adca-7b32241c265d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cc57198c-b40f-4c11-ad50-fceae4669a3e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cca92e6d-e2c3-4c5f-be56-5b8682b353eb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ccccb57f-a2f9-4183-ae88-5710d3afaefd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ccd3e8f1-39e9-4e09-aa41-625afda84460"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ccf0645d-ddad-4c9e-b4f1-dc1f1edb2aa4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cde0f9b6-6b13-4de9-adfe-cad1fe085e30"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ce086a21-29c2-444c-b53d-f3b70b086b2f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cf6ac249-f20a-400b-8543-31f2d2fe23f0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cf8a3ea2-d5d2-4bf2-ba6b-cf1309d18bb1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cfad4ee5-580f-4df2-918b-bc89c615ad0b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d0ec2790-a870-405e-bb61-2dcc3cf47467"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d18033cd-9cf6-4800-9176-57758bb444dc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d198c901-fe4e-4c3f-9323-d6a771f51960"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d1ba62a4-767b-49ba-9ce8-ab17537b2fe1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d1c9bb3c-2929-46a8-a338-adfddf0ef524"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d2155fa6-b03d-468c-884e-ccf6fefc40bd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d22c341b-80c2-436d-98e1-8a2575bc975a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d28e7ed1-3317-41c5-bec6-725369ed1171"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d2c8f60e-fda4-4744-9017-9c727fdcfe1f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d2d025a2-e691-4986-b9c4-923e7f1a47c3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d2f5f610-c55d-427e-9a78-12731c5cce5d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d31767ef-2cf8-4046-9881-d5651d81ade8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d3e21e8a-99ce-4033-8db6-9d0f0648beb3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d3f822a0-e201-4a61-8913-589c74818ae0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d488c5cc-4de9-4631-8ce1-0db0e700b546"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d4df3617-8209-4bcd-948e-fa723beb6666"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d4f5f719-8c52-4f8d-945d-1c31404cc628"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d6dc44d1-63ac-4871-b175-60ac4040069a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d75442cf-87f8-4a56-8ee0-8ed7f94fe738"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d7a8df36-2978-45b8-99d1-76d84cf34c01"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d863cbc3-5e5e-4095-855c-026f0850dd58"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d867e7e9-feb9-4d36-8757-4afd865e697b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d89eb759-58c4-43f4-9fe4-e6a21af23f5c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d8ef9f21-479e-4504-8bf7-aef2dbe6184d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d9289367-c8aa-4b6a-b1ad-857fec94c6bb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d9acdbec-61ff-4308-978a-2f4d1c2c4059"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("da3b5de9-bb1d-4545-a172-fa29301d552e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("da453ad0-5f1d-417c-baa3-74ae297f0b7a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("da893bbd-965a-49b7-a661-707a1ba899d1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("db1684c1-7ffc-4e8a-b8cf-8240a0d03519"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("db4a69b2-65ba-4dd8-8b3e-eadf2cc241c6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dbb2bb9f-0f80-4df4-9d5c-98af2ee41826"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dc344605-c507-4054-b4e3-293cf0602bc4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dc407f1e-e25f-4995-9feb-5bacc8658149"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dd41a7d6-9b11-4ec4-9518-388266750cfa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dda39817-d01d-467f-a6a3-7487011a45d1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ddb249c5-360b-4c4f-a7f6-1f6822d236c8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("de4cc1db-51cb-4b62-bee2-9750cbe4f5c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("df242a51-7ed5-4205-be60-47e0e1f46fad"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dfdf753b-75bd-46f0-8cde-15545be9bfba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e020e651-e422-46d3-ae28-34887c5a4a8e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e0747660-6d75-476a-be0f-73865bf47363"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e0d0cc73-d3ef-41ff-a158-4692b62ed3f9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e114aeec-c8d9-4d20-8fe1-8822058cb38b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e1217d07-91f8-4019-b3a2-0c0d69316ab8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e251f943-ce2f-4003-b208-e2797aa72202"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e28babaa-7801-49a2-9c28-58701549ce5d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e30f2e83-b80b-4b96-8f39-fa60317afcc7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e32b0a28-8cd5-4053-bc86-fff9c6469106"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e3409c98-72d7-425b-9e2d-da54f75b3be8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e476bcad-b898-4f68-9c26-4f1a1159dff6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e4f29379-6fd3-4501-afc5-bc5a41cb6e93"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e506460f-4577-4405-8cc3-cc36a4bb516d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e574d0af-5c63-4306-b1d3-43b7359de06d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e5b8e9f3-f0cc-4ad7-8707-577ee1b25b3e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e5e02890-87bd-4fab-b590-ffa557c3532e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e607a4b6-85cc-4f12-a53d-116cb6eef4f5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e651fe4a-d759-49c5-8e00-55137d0f2975"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e6b42536-6bf8-42e3-8ef5-7d1a283a8608"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e6b68bc2-6814-4bbf-b37e-44a0b7807c2d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e6d68ab7-5c27-4f25-896f-11dbf04056cd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e70e39ec-e476-4991-a39d-7d0e009556ef"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e7440532-8033-44d6-99b4-037a05da0c54"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e7c7cbaa-9a85-4033-be0f-b5bebcce0760"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e7f52bd2-f0cb-4194-aa85-4ad76a3a0671"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e8daa3e2-77d1-4cfa-9ac9-501e7b2b4b0a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e97116a4-7d30-4671-8ba1-cdce0a153d1d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e9e7f20c-9f74-41fd-b054-cad59fca2cd4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ea3e14ca-2872-47e7-a10c-8b2e0b46bdba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ea6870dc-507e-4ec4-a38c-cd8a5e8b7025"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eadedeb6-c31e-483f-b6c4-ca0153359ad7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eaedd67b-723b-4800-a1ae-56341b0d9e22"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eb24b5a3-5102-429b-93a9-15656fee850f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eb3d4195-8c73-46b6-87e9-ef0de83edddf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eb90bd3f-5405-412d-81e0-7a58be52dcef"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eba772d4-509e-4fe7-ba51-d9a29b190432"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ec4a598d-773d-44c1-935e-2053b54e45a3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ec8188ee-f4e4-4f5e-91ae-472e765060cd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ed260406-bdd6-42ef-bf2a-1246eea392f9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("edfa125a-1e46-4c7e-9f3a-568ae013a4df"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("edfdf747-be92-462f-87ed-53d228a33172"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ee52ce62-212c-4735-b438-26fbdc37e3e2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eeaba884-d4c5-4a83-88fb-adcd79adbc50"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eebd633a-3af0-4b79-83d5-b6490765e06c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f0197bcf-6846-4c0a-9659-0c2626a9bcf0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f099ce74-1a3d-4d47-9810-75c2b1b178b6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f0f78cc4-1ab4-4548-abed-63c65a267a8a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f112a50a-d94a-49d3-a140-0a0402baf0d3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f18e81da-1fec-4308-a881-6defa7c6d18b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f33c3cc9-dc4b-4b77-baa9-5a5f10704398"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f348f2f6-37c2-41c2-8d53-fd06a18acce0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f3c6ee73-5561-4068-96ec-364016e7d9ef"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f3dc8f07-c2bb-4b92-b0b0-4e01a395a2c6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f44e7220-892e-40b5-8ef4-3da129c2a6ae"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f49855d8-371f-4bdf-8ade-ed6b475e6b27"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f4c55f77-ab80-4e00-bed3-aa6631aba074"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f4f9f7fb-eeff-46dc-9727-04d8aa56240a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f53bb77f-e55a-468f-b7be-b66baf7e3e5b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f5bc4a51-004f-4e5e-99b9-e6ae888d57de"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f6dc9514-bdaf-4817-b3bf-34cd4b5c3e18"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f768173a-7a22-40f7-90a3-4676da7e5010"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f77317d9-654f-4f51-925e-004c592049da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f7a639a4-b824-445c-b158-108ebd70cc9a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f833a494-961b-42d3-9843-e4e61607b5be"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f85bd17b-06c7-49bd-8bfc-ee2bf3ffea99"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f8806fa4-cc2c-46e8-9b87-6231da0e3ddd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f973fb71-4a44-4603-8b13-25002dd6dbd8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fa886080-4271-4684-9999-1b6862a20ac1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 835, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fac30fe9-a39c-445a-84de-637a199f1dfa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("facc5c16-f700-4248-9893-a395bffaf2e4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 831, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("faefa284-84cf-4c1e-aa73-dccdc3de729d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fbb1c6c1-9fa9-4315-8e31-3499bf00bfef"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fc1072e4-61d4-4e89-bc70-c7e8860fd208"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fe72ee98-88e9-4d19-aba1-f97f61b7d4de"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 834, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fed4c295-7a01-463c-998e-70ebad8cd2cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 832, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ff02f181-491c-4925-ad13-07edd2ddb3f1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 833, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("09a03b1f-9ece-4086-94d8-462f98985851"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("0bc5bdb3-7e62-4c28-b4d3-fd4d3e7580c8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("0c5ecb8f-5c72-4e55-82c5-cff6a068f5a4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("0f4ceb73-146d-474e-8232-3cabbccc27e7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("10415159-e774-4431-8de1-5ce83324718f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("171de910-9dbe-4b30-a4d7-a79e231fc411"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("177835d3-9d2a-42ef-88fd-a572ba3df9ca"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("1836bb37-423e-444b-bf2e-df21fed87fb1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("1a191392-64f3-408e-87f0-b91e10545b57"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("1a23b4ab-db97-4f74-bce9-151db100b0b0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("1e045f5d-abab-4826-85ea-b9c3fcafc271"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2063f11b-3b00-41a6-baea-2de71e34e5da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("262436f8-2a32-434b-9d19-90d1922daadc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("283901d1-24a4-4e8e-94f6-3fa3dfb4720a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("28cdf699-e727-447b-b3ee-9d10f8b2a5b2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("28e2b1b8-e353-4174-99a5-816229c68bd1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2b224064-51d8-451c-806a-836f4d7e707a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2e1a8e9d-983f-445b-8f31-270510396d90"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2f14ff08-2c57-4da3-9c69-2978efd4ac6e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2f810727-4e7b-40ac-8356-ad1477d49150"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("30081c46-bbe9-4ac7-894c-4852476d66e5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("3883de67-ab59-458a-9de1-1e1026e27bf0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("3a151fd0-81a0-4b01-a439-d2aa553b0b38"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("3a2495f2-4581-43c1-8061-426525b1815a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("40c51e0c-d21c-492a-bbab-e9af3acc0187"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("450a71cf-f2db-4932-96d9-33afcb7e1272"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("48052b97-14e6-43a6-b096-7e7b4e95ee66"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("4f626d5c-3e9d-4fe4-839a-df9eb0262ba0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("512a905c-fbd5-4e1f-ad61-caba44d8b0f9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("529fc755-8b44-44be-a56f-0d751b82e76a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("5963233a-8e39-459e-931c-e27c057a49b6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("5980613c-07da-44b7-bda4-5de17f9c20e5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("5f6f4fcf-e1cb-472e-8fd3-f331875e5153"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("637cbed8-f8a3-41a4-a649-cfed2613c6cb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("63e486cf-7366-4c56-8d33-1f5f1874434b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("6ce9c61c-ab43-4084-bd62-9ad5e2ab6cf9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("714b47c3-c63b-426f-accc-bcb7ebdde0e3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("7314670d-020b-4c64-9870-84d5e2eb0ba4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("744e0bc7-0946-41ea-bc82-d0cea5cbf4c1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("75a1d3e7-c6e7-4b50-85e9-c74ca31b0b5f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("7bd20795-fa24-4a48-ac2a-5c5c8510ea97"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("7eef13f6-e9be-4ca4-8f03-30c4aa75e493"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("808af9be-2074-40a7-96b1-17973bd59449"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("821630fc-d361-458f-b69c-2115a1c10b24"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("87724dc3-a0e4-4fe3-af64-0c174951d58e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("89658af6-0df5-42bf-b550-5923fadc6f33"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("8c8c8518-d59b-4512-b75c-36a67f95c260"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("8eb3c12d-029c-48f7-8995-d04f2d76f815"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("90398d4a-b576-431d-ad9a-3a632a333daa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("96423534-6b1a-4af8-93d7-6f99af296ecd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("966076cc-19e7-4922-921d-aad15d5164b1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("9752610e-8cf8-4ef9-b820-666df89a720a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("9e207d14-f5a8-43b0-b7b0-1d4c484e5444"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("a237b616-e51b-4c6c-8fe2-ef485b0a3879"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("a88ea916-5e6c-4d83-83a9-1d4fdfef25ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("a8aca94c-fe23-43e0-93a7-39a6614b5d87"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("aa74ebd7-e4b1-4ea4-83e2-989d94b90d6a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("aabc9e69-6dae-4f35-9250-8427eaedf15c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("aae1f1d4-f79f-4c3a-83d5-debffd711981"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("acb1b45d-4161-4c4a-a518-c508ed5a03b5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("afc18147-790a-4af0-bffa-a54156c6ba7c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("afc35e3e-2400-4e4d-82d1-c11e3b3274d2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("b22c66a1-fedc-4822-83c7-5918ef35d35d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("b35aa52d-9188-4489-8189-73f4e6b9841e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("b61e88e8-9c3e-4ffa-8265-3c1053df076e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("ba4ac402-5733-4608-acd0-bc1edfd1a157"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("bac6f0b5-34e1-4425-a1d6-05624aa72fdd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("be09d030-9c00-4a2d-83cf-222a469b317a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c23322c5-ad2a-4050-9e64-e377341617a9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c309f510-67ec-4d13-912d-f703231458cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c486d5cb-772b-41b8-90f4-fc382cc8414b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c656debb-f595-41af-8234-48f3c4c19a51"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c821c96d-eebc-4f9c-8bd8-2aa4a304fb23"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("d19708ca-ac42-4ad4-8d62-e85722f946f6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("d30e6e98-5a25-40af-a625-be880ef69a9b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("d54f6551-d1f2-4856-a873-86a6e17eebb4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("d7818e64-186b-435f-a871-cdb9f75d4459"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("dcc5eb65-dee4-4bd5-a61b-80d3dfa54c41"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("de3724fd-80a8-46f9-8b5b-db378a84048c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("de958aa1-aa8c-482b-8d76-11c9b8c68c47"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("def28f4a-9a97-4659-85f4-7a0f47ec3309"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e2b58ea1-969f-4f72-a2a6-429c7fdd8f37"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e47bbf30-f087-49dc-a85d-f097d829a39a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e54e5839-5fc8-4494-9360-8989442a2242"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e5c5d288-6a87-42ec-81c1-d58f1a6fcf1b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e9b9cd69-3073-4002-a0f6-37c2153c53ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e9f60b79-5fde-4026-b6a2-fb27112135e7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("ed0e2086-7425-4d2d-b372-d9b219d5638b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("f1c53a5e-5205-4f4b-8463-c9c074919477"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("f5d543c2-b584-40e4-afa0-19435627e3ff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("f68a87eb-4812-4075-a29c-82831687c30f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("f965ecf6-2057-479d-a571-3f4e30c1e493"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fadeb941-fe23-40f4-b1cd-5c949dc8372f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fb88f5b1-2248-45ca-bd47-1a2213b82fd3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fb9b6f64-a7a6-4744-a12f-5bdf31e6f0af"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fd74ae1f-78c3-4efa-8449-6ecc1fb482ab"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fea68b1b-7080-428d-9180-3a2fabf95d71"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("ffa035bd-4c18-4a12-9bc7-5e66fc29e149"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 20, 30, 29, 781, DateTimeKind.Local).AddTicks(7330));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Slipways",
                keyColumn: "Id",
                keyValue: new Guid("11acb81e-0b41-46aa-a079-18c13cde3f3d"));

            migrationBuilder.DeleteData(
                table: "Slipways",
                keyColumn: "Id",
                keyValue: new Guid("18db0434-5d5e-48e4-8c4c-c7b25b3ed45f"));

            migrationBuilder.DeleteData(
                table: "Slipways",
                keyColumn: "Id",
                keyValue: new Guid("3ec52114-07df-4e6f-83e7-8cb0c6a5e7d7"));

            migrationBuilder.DeleteData(
                table: "Slipways",
                keyColumn: "Id",
                keyValue: new Guid("4ea84c51-a84c-4aec-bd52-7c9fba0c0e92"));

            migrationBuilder.DeleteData(
                table: "Slipways",
                keyColumn: "Id",
                keyValue: new Guid("600eebce-5dd4-4de1-9068-401744a74c01"));

            migrationBuilder.DeleteData(
                table: "Slipways",
                keyColumn: "Id",
                keyValue: new Guid("9f232734-8907-4a21-9b76-de97feb54a3d"));

            migrationBuilder.DeleteData(
                table: "Slipways",
                keyColumn: "Id",
                keyValue: new Guid("bfd617fd-29c5-4614-b976-65320c0f5ecc"));

            migrationBuilder.DeleteData(
                table: "Slipways",
                keyColumn: "Id",
                keyValue: new Guid("c6e16aaa-733b-4e1e-ab0e-19bb82669e0d"));

            migrationBuilder.DeleteData(
                table: "Slipways",
                keyColumn: "Id",
                keyValue: new Guid("f0caa49c-2d84-437a-a1f2-53f56a4e48fd"));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: new Guid("06448fd8-dcc1-4579-947a-8a7b18bc1aab"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: new Guid("8976ceb5-19d6-4f5c-a34d-a43801667b40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: new Guid("f5836f04-e23b-475a-a079-1e4f3c9c4d87"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("102a6d4b-bd31-4428-bc16-e6991a1a9a1d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 387, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("45a1882c-4822-4cd1-9621-cebda51bfa05"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 387, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("75ee4dd3-5933-4904-9020-5836ec757f02"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 387, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("8baa7bf4-cb1d-4d5e-b3c8-ef190dac1c3c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 387, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: new Guid("d07683a9-2ffa-4763-a047-31214e8eb9c9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 387, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("003200ab-d138-49d9-aa52-217817941f85"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("005dfdae-efcc-410a-bf1c-24096e0c2866"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("00c33ed9-6bea-45b4-8728-7edc7e43e2f3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("00e386ac-e35c-4a6e-80dd-f8cd8a9e7a62"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0309cd61-90c9-470e-99d4-2ee4fb2c5f84"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("04572010-1db2-4338-8562-b3dca5e715c5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("04790e03-4353-4e80-beef-b3ed439484bc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("04acd7e5-3cbc-4cdd-b4a9-f452e868f4d6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("04cbc946-8ee9-4521-ac52-557642cad52c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("05ca0e33-5c71-4368-b824-2243fcff656c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06219dd9-a2c4-463c-9619-623b3c026cbc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06b978dd-8c4d-48ac-a0c8-2c16681ed281"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06c498e3-786a-48be-83be-6a6293ea3b8c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06d86c6b-5ed0-475f-805a-a3ceb59af083"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("06e6b715-eb03-46ce-adf4-6cafca6368eb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("070b1eb4-3872-4e07-b2e5-e25fd9251b93"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("07374faf-2039-4430-ae6d-adc0e0784c4b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("07830b68-c5b8-42dd-bf48-7176802130d0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("087b6386-0957-4b47-af7d-ecd62f6d63ce"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("09227288-8c72-4b12-88fe-8765d1b2b400"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("09370c05-1041-4395-a5d4-b8db6e59c4c8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("094b96e5-caeb-46d3-a8ee-d44182add069"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("09e15cf6-f155-4b76-b92f-6c260839121c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0a6fe221-9fc9-46e0-802f-9c367a32ed72"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0d0082cf-0b4b-4c8b-8e97-5d37b511916b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0d8233b8-36c9-4a24-ad77-a4e7c617932f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0e065a22-9a0b-4f1d-b813-22fe6321bb1a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0e0dbcc9-0a7d-494a-bc92-52e56a7fffe2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0e192297-1224-4465-b1c7-a476cc17f74d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0f7f58a8-411f-43d9-b42a-e897e63c4faa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0fab94c7-d51c-4b5a-a2ab-694c13efb024"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("0fd56e0a-e32e-4b56-9cda-e0ce93d715c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("104fdc24-1dc6-4cb7-b44f-10bd02e13f40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1125a391-6586-4951-865f-3a2c72f2c81a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("116572da-c036-4486-ac18-a92932424e30"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12499527-9476-45ed-80a2-b2b729742414"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12847496-b0e9-4cb3-905c-b1b1c3c087db"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12a3037f-cbf3-49d3-8da5-77fb38730bba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12deef85-1779-4b4f-9ba6-8467dc9d9866"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("12f63015-c66a-4e89-a69b-ddd069872d40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("133f0f6c-2ca1-4798-9360-5b5f417dd839"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("136febf6-1371-4118-a9b8-4275444bda5d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("13e91b77-90f3-41a5-a320-641748e9c311"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("14699a51-aaa5-4ae4-98a6-d35aa9a80ec3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("15859426-834c-429e-9c41-2e097b717b1d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16258271-ec03-4542-873c-1642c8b654c9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16508b11-4349-48f7-be51-1227b7888585"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16578824-88de-4700-ab09-f61dbb1182bd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16a780aa-475d-41dc-a8ec-20488415b6d7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16b9b4e7-be14-41fd-941e-6755c97276cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("16d180c2-63aa-486b-8966-81a6041360bc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("17ea8bab-4e26-4c4a-8071-7e7e4f464e29"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("18216ff8-18aa-4a71-bd32-e7479ccc439d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("184200bc-cdb6-4116-a7cf-ac986c2d4fb8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("18e6fa6e-2564-4057-8503-05213e49e57a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("19cc3b9a-546b-43dd-96a3-b0bf903672d2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1b2e2996-c2ef-4d9c-9052-ced8cb7bc226"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1b51e55e-088a-44c3-a633-b1bee44422d7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1b8ac909-8377-4887-ab70-748de2dd9775"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1c80e441-a1d7-400c-b569-e038c9876a4f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1cc71bb2-99e5-4479-8ae9-8375568ed22c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1ce53a59-33b9-40dc-9b17-3cd2a2414607"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1d26e504-7f9e-480a-b52c-5932be6549ab"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1e51195c-f9d7-4cff-9db1-d92bb855005c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1ebd0f94-cc06-445c-8e73-43fe2b8c72dc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1ed983c3-114c-4fcc-a1db-61d336cf045f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1edc5fa4-88af-47f5-95a4-0e77a06fe8b1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1f1bbed7-c1fa-45b4-90d3-df94b50ad631"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1fa822e6-fb0c-4331-83f1-749972046dca"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("1faa9b2c-c269-4662-af70-ef11da27cc1c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("200363fc-cdc5-4c22-a271-a25d1ba880ed"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("213a585d-d665-4be7-96a4-78a992b9614d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2203fce7-9d1e-4586-84ab-0797468863a1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("220ff4c6-83da-4a1b-9c13-dfee5a2a8798"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("227b83f7-1302-4d7e-8d70-899036ff4ce2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("227e53ca-4dd9-482b-be62-52fdc62a4b4e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("22b7dcb3-8c42-4f71-9191-49143ba3a828"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("22fd01e0-090b-476b-80aa-f4586e259785"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23045f8b-e7e8-4534-8162-b7dba81764db"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23517de9-9b81-4a34-ab82-adff6443c235"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23636a08-775b-4101-a1af-1b57fb466d81"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23721dfd-9b89-4b69-af80-063229917f27"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("23af9b02-5c82-4f6e-acb8-f92a06e5e4da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("24440872-5bd2-4fb3-8554-907b49816c49"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("244cae8b-ce75-4c2d-a66e-cb804f8335a2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("24c6a014-864b-4d53-bd05-0b49106f5412"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("24ce3282-39dd-4f2f-ba80-9676e59de7c7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("25530a3e-d0a8-456f-b7ea-6a3886843279"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("25582d3f-dc5f-4c70-bd08-e84fd13201ca"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("259dcb4a-2366-45a6-a448-b06a8941ae16"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("25ca1bef-4f8e-4523-89f5-7d8593e46370"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("26259e8f-7d2d-47e0-8851-0257542b63b3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("26656fda-cacf-4e92-9935-3ae6e717fe5b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("27dfd137-3b88-42e8-9baf-6bee76e0717c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("27eed51b-c0a4-417e-926b-bb4194bfb341"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2813f196-3404-4ac2-92be-e288fe1607af"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2852b9ab-d30e-4d04-ae06-3e946f48a0b1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("28ec91e8-90c0-44d1-8fd2-b0b64c00c43b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2ae6cc12-5491-4f59-94c5-ccdbcb7474c8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2c68509c-bf1e-4866-9ec4-b26b231e5e04"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2c95f83d-4669-4553-a18d-3f493176d34d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2cb8ae5b-c5c9-4fa8-bac0-bb724f2754f4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2d1fa45a-8928-4ad0-b564-e74f7189681c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2d93f2be-6d57-4716-a775-92fb5a63f88f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2d9f473e-f2b6-4f50-bb4d-96362230a976"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2e1d458b-f78f-41dc-bebd-e0512578610a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2eacef2f-7a8f-413a-a2c7-f1da4cf22742"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2ee12b9a-f7fd-4856-82b9-6bdd850c2bba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2f025389-fac8-4557-94d3-7d0428878c86"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2f1080ba-97a2-40b3-af4e-3ac3d53d27de"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2f56e265-cd67-4ea1-8529-549b6ccf273a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("2ff6379d-d168-4022-8da0-16846d45ef9b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("30739ff3-9d71-4e38-991c-0f7a2f54ed2d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3079c709-9d83-4c59-bf91-6bed2d5ea372"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("308c39b6-475f-42c3-857f-7cf257426fa1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("308f5979-4ab8-48ab-b618-081aa285559e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("30bff0df-8333-49ec-8fd7-a2d4c0db1cb1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("314945d6-b499-40cf-bb21-d76cf4547e3a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("314ef522-a060-4033-ba14-8169dd26bb8d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3199ce09-cd9b-4be2-82bc-f03bb81438e5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3244d787-f884-40ae-9752-ad3507309edc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("32807065-b887-49f0-935a-80033e5f3cb0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("32b997c2-d97c-452a-a5c1-ee4592a15b4c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33092c28-201a-4210-89c9-ce68cad61ed1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33193e2b-1203-4681-a23d-f87b9fab4b60"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33bdec83-6184-4ca5-a075-f44185aef302"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33ceb441-23bc-4ca6-9fcd-ac35d41ef117"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("33e0bce0-13df-4ffc-be9d-f1a79e795e1c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3404a6e5-8dfe-42b1-90f6-c0c3741b6ac8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("340707f4-5d35-4898-8b34-95ea3f4206b3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("355b02d2-c578-46d9-a56b-8046d470cb95"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("36243256-7786-4e69-922f-50785d8904bf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("36e85829-2fb3-41a0-8a1b-aa9e76431b47"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("36f80081-9353-4ab1-8e61-07a5509f1cea"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("38414157-862e-428a-ae2c-77ff79871227"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("38497786-6c29-47f4-93de-d96001629496"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("391bbba5-83d4-4791-b07e-65ab29b423f6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3944c1fd-39f5-47b1-bb6e-323db05d70e8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3954300d-f112-4fe6-8d0a-b06496372e36"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3988cd01-1c7c-4bd3-a8ce-d324f73f346d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3a24863b-fdec-455c-82da-ea8c7ae6f97a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3a8ed45f-28e7-4263-8437-d926c6a194f4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ad4013f-644b-47f5-a641-44b332bfecb2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3adf88fd-fd7a-41d0-84f5-1143c98a6564"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3af7d65c-c732-49e9-be05-fe3b5f88657c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3bec53ca-444e-4014-a7b0-07b3591e954b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3bfcf759-27b3-4042-b59a-f6c8ed9e533e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3c7cfb10-c866-404b-b11c-0d79986f865a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3cd46cc7-b94d-424f-a860-c389dd9992a4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3d276f8d-a38c-407b-9727-b2a77b06284b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3d43a8d7-e599-4fc4-bf62-65eb0794685e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3de69bf8-dcbb-4afb-a15b-a8683a6a689c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3de8ea26-ab29-4e46-adad-06198ba2e0b7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3dec3921-6f01-4801-b648-a7f3ee33acd3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3eba7da6-fbd6-431c-91d3-522ec49275f0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ed90357-4b01-4119-b1c5-bd2c62871e7b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ef81fc0-33dc-4f67-8bb8-3f66975292d5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3f0b6b74-80a9-4576-a3cb-ea967dfc349f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3f3b4445-9a6a-44c3-8575-d86ce30e2de0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3f8ceb6d-e95d-46e6-b523-3d15fe706049"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ff99b92-4396-4fa7-af73-02b9c015dcad"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("3ffddb2c-4c17-47d1-a7de-e1663d4031b7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("414dd4ee-b38b-489f-a1fe-19b1d62f3202"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("427318d0-ee8d-4d9b-89f1-e8a8685b5d8c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("42805eb1-aca9-4f32-a373-24a9cf839aed"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("42b865fb-5dd8-4204-a7aa-260704d69e21"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("42ecae60-eeb3-4b41-9721-46b3f12d04b8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("438b565e-f293-43c8-8771-377e555ed5ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("43ca90f5-3b4c-4b35-86ac-cab0fe1c2ce5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4457a320-1f99-4352-8a43-ff24109d99ea"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("44bb934c-4250-4e1b-ad70-0fbd8bb3eadd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("44f7e955-c97d-45c8-9ed7-19406806fb4c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4520c1a8-174c-4b95-9ca3-fe1e3f9d874a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("45634232-36ac-416c-806d-5f64201dae2c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("45721a68-566c-4e2a-a6c7-a7595982a779"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4626f6bc-494b-4a51-8c10-b47a32e87790"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4627475d-ccda-4d53-8f13-28527c49eaf5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("46644438-83d6-4da8-a2a1-1deb2cb67561"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("46a3350b-f3e6-4f5d-a297-2652c43bfac8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("46d8ed02-73fd-4958-8e2e-006c047d0576"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("46e61953-4bdd-4045-a14e-a83948514c8a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("470acd2a-f3e7-4fd2-96b0-e90344ee51bf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("47174d8f-1b8e-4599-8a59-b580dd55bc87"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 382, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("478f21e9-906b-4c6f-a009-b5eabb052746"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("47d3e815-c556-4e1b-93de-9fe07329fb00"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("48780245-36f2-453e-b430-5fa838851d6d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("48f2661f-f9cb-4093-9d57-da2418ed656e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("492f85b8-e5c6-439e-8e14-08ca78f10dce"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("497c29ee-32b2-4535-ac5f-3881a106c793"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a0061f0-7355-4a95-9c70-f05c8920d790"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a2501bf-cb57-46bb-87d3-d6808286b31b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a4daad2-0e96-4070-914e-a1c4f6b7a3e5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a69e82e-97a3-4573-8aeb-b695c1eaa0b1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4a904d59-d48f-4878-af7b-cbd955f342e0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4ae7098c-116d-42c4-8044-1db0af0f57ee"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4b348b56-b08c-4522-9042-49c1edb45d0d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4b386a6a-996e-4a4a-a440-15d6b40226d4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4c00a166-7d6d-48d7-b4dc-673b96b4041e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4c7d796a-39f2-4f26-97a9-3aad01713e29"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4c8282c1-c9c5-40c2-b379-95495ce0deee"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4d00c13e-e689-4dfc-85e6-a3fc8596ac8b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4dbce62d-a015-4011-afcd-423bb8d4b7a1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4dd743e9-3040-4f11-8c7c-d5c5789d80b4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4de8a51c-4c6a-4334-92dd-0b1cbb8e0573"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4e4fac1a-6fb4-4ce2-a041-bdc4a668d95d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4e6a3d17-1855-4458-b3fc-e71921a4da7b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4e7a6cfa-7548-4f7f-a97a-eb0694881003"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4ed5f6da-b7a0-4431-ab1f-1a26e69a21bc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4ee515f9-8cfb-4835-8460-8dde0b978fbe"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4eec6b25-6b02-4448-b5db-10843c8d6175"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("4ef9dd9c-b32b-43fc-bc5e-3849d4ab7ecc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("501aa608-ea81-4690-a491-6602114c14af"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("503ad891-c9de-428c-b682-434510ed9de8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("506e6b03-1209-4650-8b3b-3cd2d4724b5f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("50a449ba-af4c-42c7-b2c4-9a3eda37e1e3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5140295e-b93e-4081-a920-642d89c7ca8b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("516c4814-d70b-47bf-99bf-a76844b94e5e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("516fbf8c-dc08-4808-b39b-1fa65a462180"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("522286e2-b2b3-4d0d-9a11-01b3ea418c76"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5287a3e1-c540-4ab1-b52e-880d124cbc43"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("53088d32-226a-49b7-962d-a5879c3aba29"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5310aed3-784c-4290-bfff-806c75b831d9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("531da758-b2f5-471d-9d9f-a78576081079"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("532d8718-6ec7-4f12-bb2f-bde2dec50182"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5389b878-fad5-4f37-bb87-e6cb36b7078b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("53c277c3-7ddb-4281-9937-97dcfe3753fa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("53d40547-8a09-4b25-988c-2e6d8d8d98ee"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("541c508a-00bf-4a9d-bd47-17fda98b349d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("547422fb-364e-4870-9977-c7782f0712e2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("550e3885-a9d1-4e55-bd25-34228bd6d988"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("550eb7e9-172e-48e4-ae1e-d1b761b42223"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5553e209-1b44-47f5-917d-2c6951ecc044"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("57090802-c51a-4d09-8340-b4453cd0e1f5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5735892a-ec65-4b29-97c5-50939aa9584e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("575da86f-d975-4837-b6f5-6f19c3a5e4b6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5918b484-597f-4a1c-8262-0d0cbbb7986d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("59219312-9e87-4b8c-8dde-325af733d282"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("593647aa-9fea-43ec-a7d6-6476a76ae868"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("599c23b1-4550-41e3-a7e7-3056989927f1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5a33bf14-6bdc-4666-b2e3-ac78e3083e2a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5a7e1d4a-53aa-4f9f-a59b-50e01b7260c7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5aaed954-de4e-4528-8f65-f3f530bc8325"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5b58af00-6817-4214-b151-34830ac563cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5b83cad2-ed64-42cf-87dd-98e27988c31a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5b94e4b9-cc96-433f-abf7-08287137ec54"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5b9f8134-8bf0-4b51-a548-72a36303bbc2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5bb1f56d-7c56-4b01-9da0-2a08a0aaedeb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5c1b6183-eaaf-436c-b863-8a191d9e1f5a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5c4c2d52-6c0d-4aa2-beed-6ce47e3e2bd7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5c735fa8-270e-42c3-b22f-b27418db10cf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5cdc6555-87d7-4fcd-834d-cbbe24c9d08b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5d1e4350-0f39-4428-84c3-6f8f0bbe80d4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5db8ab4b-315b-466e-b9d5-5ba5a19f5f08"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5e10e1e7-9115-4bd7-ad57-e2062f516891"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5e6ae93a-7856-4005-bc77-fc6e4f5ad630"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5e92d73f-e4ea-42c1-9f98-91536c17cdff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("5fea1a12-326f-4919-ac9a-02f9fa11ab57"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("60b6ecb0-4ed5-4b8a-b875-07ae33a92b07"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("610ab204-d3c4-4a11-a38b-e31461fdcf27"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("61394669-3f1b-44e5-ae37-50fd2512f4fa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("616dd98e-816d-4e17-b8cd-57b163dbc8a2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6233e901-2600-4b54-ae06-7b987934e99e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6288de60-38be-4291-9ff6-dcf6c0f58cea"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6298a8f9-7c77-4605-a55a-278c61cc8f50"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("632a133b-fcc2-467f-8f9c-1ec63144f8d6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6386de1c-0426-4795-b23d-7ea2754ec782"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("63a222c0-bd45-4af8-b9a7-27f9443a1936"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("64c37072-db97-4e08-8981-c67f0282de5c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("64f735fd-88b6-42ea-9cdd-dc18d3806c34"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6610cf2e-7bfd-4686-b9ac-b105f492d708"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6629a4ca-4e2e-40b8-a66c-964d906c6911"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("662c4b5e-0241-456d-ac7d-9f62fd95c0d1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("665be0fe-5e38-43f6-8b04-02a93bdbeeb4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("66ff3eb4-513b-478b-abd2-2f5126ea66fd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6760b547-a7e7-408a-b3aa-529fe376bfcd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("67d6e882-b60c-40d3-975c-a6d7a2b4e40a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("680d5966-273f-4254-aabe-5d4e00e12a24"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("69308142-f78e-4877-9af8-e7221b01d303"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("69fb4730-4866-4838-9b18-2c0ee9dce80d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("69fc0432-e9dc-400c-8c21-0c26e85df884"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6aa1cd8e-e528-4bcb-ba8e-705b6dcb7da2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b05e8dc-3089-497a-a602-f40c4283d8bb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b1b5c70-a23f-46de-954d-02bdc5bf2ecc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b53ef42-5bd9-4366-ace3-442e307bec60"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b595707-8c47-4bc7-a803-dbc327775c26"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b6b31e2-e5c7-4c85-8405-b8d0b6e158c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6b774802-fcb5-49ae-8ecb-ecaf1a278b1c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6c5b6422-126d-4bf0-8856-7b86d74ea1b3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6c76e98e-44ca-4d25-91e7-b07c68577c5e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6c7c180f-6dc1-4c4d-97bd-814080df8bcf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6cb287c2-2fb2-4845-b11f-e78bd5db2ce3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6d3a3e2a-713c-4232-9b70-834a2c0e9705"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6d43098c-632d-4e89-996f-98b1c99e5630"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6da1a0e2-9af5-4a4c-b52d-c0faead67d70"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6dc44585-5b88-45d7-9c64-7c845408b698"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6dc4e4a0-2c10-4c27-a08f-a0ca0aa13df2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6de43652-2db9-4627-a255-9cb1f8efb820"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6e19aeca-d37a-4b00-9354-c6dd90f12de2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6e3ea719-48b1-408a-bc55-0986c1e94cd5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("6f81b35f-8339-4012-8029-ca193403e52c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("70039212-c8a8-43fc-82a5-150d95831772"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("70272185-b2b3-4178-96b8-43bea330dcae"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("706e5110-c5e2-4915-9989-c071fcb492ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("70bee932-1c14-42f8-b4df-9a85589ca80e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("70d4f87f-4489-455a-a435-d6df9e09a87e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("71357738-c8e2-4cb7-a41a-365659bb8d58"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("721313e7-935a-4bb8-8c6d-0e014211b2ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("721d7dbf-c947-405c-8dba-e672a091f4c0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("728bd3e3-23f2-41c6-8ac5-4cfa223a5a7e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("733755fd-628f-4130-a694-aaba340531ba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("736437d7-0f6f-41b7-bc69-5ed721da4f85"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7398029b-c6a1-484f-b1f6-1afe568ee1e2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("74134dc6-8e26-4195-9cdc-c22aa0a3558c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("752a8c5a-5f2a-4575-af2f-d825cffc6eb3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("763633e7-3b4b-470a-978e-f9e456e4df7c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7644f1d7-3198-4313-9340-abefd459a4f3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("76844306-4c37-4a6f-aac4-9e518e96306f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("768df4e9-ed5a-4141-901b-e25ac404d559"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7703d54d-ca33-44b9-b519-c618bae5bcc7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7753c1fa-34d8-4d09-a7c7-38024079117c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("78029185-9dfc-4b1b-8695-45ebc2a09cf4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("787e5d63-61e2-48cc-acf0-633e2bf923f2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("78d69798-f956-4222-8d2b-f9f630fb9e36"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7909d3f7-ef5d-4321-b76d-712d9b0a0c68"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("795ce865-3ac4-43b8-88d5-049a34e4359e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("79d783d3-e423-4c6d-b914-d7b7d161a89f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7aa4b078-459b-4392-a0a7-93e533b2283e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7af19499-8bc8-4a91-964d-88618ea8998a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7bbd90ad-98e9-4415-8040-23500f2e01e7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7cb4566b-c584-4167-8736-f52ca7fd837d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7cb7461b-3530-4c01-8978-7f676b8f71ed"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7deedc21-2878-40cc-ab47-f6da0d9002f1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7e530482-0a13-4728-99db-a376304398b8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7f01fbd8-653c-40ba-8ed0-57386a9b4557"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7fe63a95-8ff6-4cff-9a29-a124136516b5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7febef93-09ce-49e9-9643-ecb3076ce9a7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("7fec2f4f-6a2e-47ec-8f3c-016c581e4bbd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("80f0fc4d-9fc7-449d-9d68-ee89333f0eff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8122b09b-a174-41d9-9a38-c0a5223366b8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8134af78-3100-4679-bf1d-be82410df429"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("81630fdd-5949-412b-a2e0-d3da8bc8bcda"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("816affba-0118-4668-887f-fb882ed573b2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8177a148-5674-4b8f-8ded-050907f640f3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("81c95d3a-3193-4e9c-a411-adf97c751a43"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("824a046b-9ca3-4db8-993d-e755122854e0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("827b2685-47ec-44df-a90f-980f5e0c1591"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("831ad501-d2fe-4782-ab83-4f1c8e0b15ff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("83bbaedb-5d81-4bc6-9f66-3bd700c99c1f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("844a620f-f3b8-4b6b-8e3c-783ae2aa232a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("855205e7-1cc9-4c5f-a2c2-7d5d84011708"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8559d1a0-4a03-410a-8910-44a089a07df8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("85d686f1-55b2-4d36-8dba-3207b50901a7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("85fc0dac-a53f-4638-880d-40b24bb282f3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("863359dd-3171-4641-97bb-b21f06859072"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("864a8111-d0c1-4b74-b94e-515f0869355e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8675aa70-cfbc-471a-8566-dcc851f201d3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("86c5688f-2fac-4d58-a245-ad8ce14cafbf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("86d07669-4670-48a1-8f30-7d7b26224ad6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("86f66699-29b6-4b94-85cb-d241e832230a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8727ebfd-e2e1-43da-ab3d-fee48cff9acc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("88e972e1-88a0-4eb9-847c-0925e5999a46"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("89038b42-8181-48df-a0cd-2ca3913f2d68"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("892183d6-3a28-4347-afb4-bc89602ca927"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("896aed46-8290-49b0-a6f8-90d53027cd1f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8a08c920-c911-43e5-90dd-27d4d4e757d0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8ac85e6c-6167-496c-b16f-fa94f81cd94a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8af24d6a-eecd-434e-9f1a-60ab6bc05490"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8b4f9f7c-3376-4dd8-95c1-de55b1be4dfd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8ba772ed-e45b-4be8-b91d-0c6c92de59e4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8bccd43b-ed6f-4ed8-ae6e-80ad7e330658"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8c20b4dc-1540-4b14-8c88-0e1d87de22c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8c3295dc-fe73-45bc-9a7b-679d4aaad0cf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8c8afb56-88ea-483a-a7d4-033c22f53497"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8d18d129-07f1-4c4d-adba-a985016be0b0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8d1fdc5b-b63a-4745-baeb-5e266d247e99"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8e16bd66-c49b-406a-930e-4dccfb330ff5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8e326085-c879-4704-95b4-c1fc19874176"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8effc15d-8583-4ac6-9f42-1b63c47f92b0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("8f7e5f92-1153-4f93-acba-ca48670c8ca9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("905e7328-b8aa-4b08-9c22-c864101e462b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("90bcb315-f080-41a8-a0ac-6122331bb4cf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("90d92801-c13c-4b1a-8885-83d1a07d6db8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("914ce0a4-d900-4bf9-bace-47a6f73e7bed"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("915d76e1-3bf9-4e37-9a9a-4d144cd771cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("91922b9b-ef7b-4aae-95a1-9d6a9e61969a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("939f82ec-15a9-49c8-8828-dc2f8a2d49e2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("93ddc1e6-072c-45f6-99c0-d7d7df9d39cf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9427fafc-7146-4be1-a71e-4e4658236037"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("94f6eff1-4f3f-4850-82e0-a086198e9ffd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("956ce5ff-1fc8-461e-ab2e-0ac70758bb46"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9592d736-26af-46e5-84fd-e43e89b66566"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9598e4cb-0849-401e-bba0-689234b27644"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("95a0ab45-a9ac-4f9a-93e9-b0ffa1c57b5f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("963bdc26-34ad-43c8-b653-bbaa3466276a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9829cab0-746b-4d10-9124-79ddda0a843e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("98daae03-5aaa-4284-9717-7d52da4fe063"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("99309d3e-58d6-4200-b212-c8499467b4ce"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("99619dc5-9c88-45e9-a97d-653c41cda8a1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("99989609-7bd8-4f91-bd55-ad31fbf55ee4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("99dd338d-ef7d-43fd-a4e0-a9103406f0ad"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9aae4921-bda4-4081-b67b-2e0c5ab8bc54"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9c336515-b238-4a1a-947f-dabe47f4b502"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9c4c11f2-0548-4555-beac-ecfd36f9bd74"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9cf795ce-8bdf-494b-b8c6-ef1bfb89c08b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9d7cc90a-7380-4dbf-8641-3201dfcbc75d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9da1ad2b-88db-4cbb-8132-eddfab07d5ba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9dbcac54-db55-4d24-88b2-74a0d75a68c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9dfb4b0b-daa6-4a90-9a82-60734d3d2f04"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9e19c411-f728-4a43-a057-39d4155c71cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9e4adf71-ed15-453a-b50e-de03d2077e04"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9e7b2a4d-cfe8-4524-8a1e-c196ea897e9f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9f12c405-35ac-4d90-9b7b-023be355867e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("9fb9abce-e1ac-4c11-94b2-a32d63f6fb40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a0c1dcb6-7812-48e6-8c01-f7edad7a2caf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a1341b43-9c62-4e71-87cc-61a0d4d1b105"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a1cf60be-8149-445d-a7a6-e7c7e7051944"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a238b70f-1198-4b2f-8c03-41f3503e5389"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a26e57c9-1cb8-4fca-ba80-9e02abc81df8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a3328262-207d-4e65-96d8-202368ca0cb8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a37a9aa3-45e9-4d90-9df6-109f3a28a5af"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a392113c-d040-4b36-b47d-9099275bb308"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a5830277-af1d-4c64-be72-00591f36216c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a5902c55-6ff4-4bbe-88a1-ebba45b03cec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a64918a6-e6f5-495e-ad2d-a8e3655c9424"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a653eb04-de2e-47f7-8e2c-09277cfe95ae"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a68cf527-a458-4d84-8171-7756813ca72c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a6ee8177-107b-47dd-bcfd-30960ccc6e9c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a73a9cb4-5bc2-4d42-b7cd-191d5e1ee307"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a77aad00-caa0-44a2-95cb-8afd9c4ff00c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a7b1eda9-bed4-4456-8e54-529828cdcbf9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a7ffcc9e-fecd-431c-8044-e004682d023f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a8604e8f-9330-4431-8cf6-0a68fc793c82"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a869dd39-dcf7-46f2-b9bf-b210816109ac"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a919f57f-8378-42d8-82f8-b87eaf008641"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9299f0c-9eb8-4369-a260-4be929e72736"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9320108-ad58-41b8-b7b5-f52163a23927"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a98b4a84-e51f-4d03-86d9-3b8bdac10e69"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9b8e24c-012a-48dc-a823-d48c1637cb42"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9ca43e9-ef92-4f1c-ac02-a6c8ccad7b9f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("a9e93be0-cb0e-4418-ba3c-94e7869f6199"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aa6af4e6-a44f-46c4-abf6-449f8a68bab1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aa9179c1-17ef-4c61-a48a-74193fa7bfdf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aa97c894-ed26-4fdd-945f-db9667979268"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aac1846d-a0ea-46f3-984d-b3938b0cb82d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aac49cf2-5d3f-4c69-9847-027fecaeef30"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aad49293-242a-43ad-a8b1-e91d7792c4b2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ab0d9117-83f3-412d-bce5-b3e698246c0b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ab13c115-6924-4d88-822c-0704b8df4767"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ab53a592-0f5a-43e2-9133-bf3169b0f274"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ab9d5a42-2b8d-491b-9fd1-8120df23c8e6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("abb23dad-0880-41ab-8d2d-dd33e11f148f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("abd34ee6-a578-4639-b73d-fa4e08f40345"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ac507f42-1593-49ea-865f-10b2523617c7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ac6c4362-1fb1-4b7a-9406-016bed804804"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ac970eb0-f5cf-4db0-90f0-e281f5d4775c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("acd63934-e40d-4650-a094-01cea45432be"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ace7d4b0-33e5-46db-a41d-2fa7a321f67a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ad357e52-0978-4583-91e6-bc03a222f655"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ad3a51da-2e25-4818-b96f-6a6d8a20d803"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ad3b53f8-8c1b-439f-a0df-9f24827026d5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("adbd3144-1774-45e8-8eb7-60f01a712426"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ade3a084-8680-47b5-9d2e-288cb6c5f9d5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ae1b91d0-e746-4f65-9f64-2d2e23603a82"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ae93f2a5-612e-4514-b5fd-9c8aecdd73c7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("aeb9ed1c-6c01-4829-94e4-e530dbf79821"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("af82bc24-a355-4247-9532-b305eb57e16f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b02be240-1364-4c97-8bb6-675d7d842332"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b02ce5c0-64e9-4d24-90b9-269a28a1e9f9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b04b739d-7ffa-41ee-9eb9-95cb1b4ef508"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b09f2243-60f0-469a-8f3b-0ea6abc83267"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b1cda5a0-115f-4976-a0a6-9d427ff6dceb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b2204ea2-eb50-439f-a64d-98062ea1d21f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b26bfc88-eb8a-45b9-9dd0-0e41949a2648"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b327e35c-5dad-4b79-9cef-60fbd504eb37"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b3492c68-8373-4769-9b29-22f66635a478"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b3d88ca6-ea13-4540-a623-c02e43800a3b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b45359df-c020-4314-adb1-d1921db642da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b475386c-30cc-453a-b3b7-1d17ace13595"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b577a043-b6b8-4db8-80e7-8abbb565c8c5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b6650b13-582b-4d54-adac-991ac140e039"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b6bbe4f8-aa59-414a-8292-2d3919590a20"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b6c6d5c8-e2d5-4469-8dd8-fa972ef7eaea"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b7e238e8-29ec-4522-8252-b2cae7d4f58e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b8567c1e-8610-4c2b-a240-65e8a74919fa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b8997708-53d0-4932-8fbf-265083e11517"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b89b68fd-0d40-4941-9ee1-e4f7a56351a0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b8b8c069-0993-4a45-a226-a6c8c18185ab"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b8d05bf9-2ef2-416d-ba70-b5dba74fe777"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b9163121-2747-4d2b-bcf5-ab5ff7396e56"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("b9975ea1-5b45-4e27-abb8-4c3f7878b1f7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bacb459b-0f24-4233-bb35-cd224a51678e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bafddcbf-4108-431e-9f57-568be08fd538"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bb23b276-2c1c-4cde-bc9c-9d90d5a04890"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bb5560fc-7995-40a2-b92f-3d828c67dcfa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bb62b28f-9947-42b1-92e4-743a1e0c4a76"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bb6fd2f0-458a-4ea5-aa58-e1c1a2fbd56d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bc20d819-1782-4588-885d-129f21a27cf9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bc9f369e-5fd4-466c-8d97-ddb1ecd2aed2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bccaacb3-a9a5-44aa-b05b-3f29c3c6e38a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bcdfa310-d887-49bf-a562-1e439759044a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bd317edd-214a-4e11-a9dc-3cc71a2907c3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("be05603a-83e4-48d4-90d9-e074b7d34dcd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("be7ce40e-5fff-42df-8386-b42694ca86da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bec8a6a5-c3de-4322-856a-870ceb992fe4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bf48cefd-0d00-4186-a366-343c25f43615"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bf7bb8e8-e81f-4655-9e84-28738feae936"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("bffdf7f2-6200-42a2-a4bc-a8111e27e043"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0244c0e-6ae6-40cb-a967-4039b2a0ce7c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0594fb5-77ff-4287-9b8d-7ff326afe9ff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c093b557-4954-4f05-8f5c-6c6d7916c62d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0ec139b-13b4-4f86-bee3-06665ad81a40"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0f33a36-cac4-4e47-a3f5-d1863c2f0f99"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c0f51e35-d0e8-4318-afaf-c5fcbc29f4c1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c13fc7d0-beb1-42a3-b831-4816d7649059"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c1588dcc-e314-4097-a54c-c0ffbe79209f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c1d6f464-f38a-4e38-9f74-4c5d22a42c88"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c1f059dd-5063-468a-9dfa-0360fe0b030d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c1f06401-9488-4a27-b932-59cce52c5819"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c203d5fb-96d7-4643-b2ef-b13b1d88c75b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c233674f-259a-4304-b81f-dce1f415d85b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c263ea53-ca4d-41f5-b3f5-6178fec302aa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c2aa9164-1073-4271-82ef-44344fbe456e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c33c3667-b8c5-484a-8ea0-b92933b5a9f0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c389c9e2-a5d8-4104-a4cf-510ade44f143"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c41d42b1-5b0d-47c9-ba53-d58d3d109b64"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c42ad3df-cfe3-4dca-9dcf-dbbaac569a2f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c42ff4c7-f4c6-4568-8b5c-0b556bd55926"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c4381eb3-d21f-4bd1-bc1c-66c03b7d8bcf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c62aa674-db07-4251-a50b-1676c11a9a25"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c6772c3c-a6bb-4728-9250-a408ab3856bd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c6a12d34-c78f-44a2-a7ff-4b8d88f316cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c6e9f744-4dbf-4e8e-a219-cab051ec610c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c7364d1e-6139-4575-84cb-b420d21275c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c7383149-1f77-430d-8bef-c5667be3846b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c80a4f21-528c-4771-98d7-10cd591699a4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c8a1cf0a-9441-47aa-8c64-64e8962a9bd4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c8af067c-ba6a-4a76-86d8-1ce8e532ef8b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c8b9a2b6-b783-417f-8479-3a0d732fb901"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c8ff06a7-eac9-4db7-ab22-46954d4481cb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c93a87fb-a3d3-4d4f-a55d-8fabcfb9ab64"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c9409937-b794-4b69-b36b-38467daab09a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c9a6c3bf-02d4-4945-83e8-b7c6cf9701fa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("c9df61c4-2a0b-47bd-8b51-fef7f430e528"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ca0e4a68-bd50-494c-bd45-abb33c5e1b0a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ca3f535b-4a32-4dd7-a56b-2ac20dea4472"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cb93548e-c1ce-43f6-b3a1-6903f8835b33"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cbf3cd49-91bd-49cc-8926-ccc6c0e7eca4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cbfdddd1-9e32-4de2-adca-7b32241c265d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cc57198c-b40f-4c11-ad50-fceae4669a3e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cca92e6d-e2c3-4c5f-be56-5b8682b353eb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ccccb57f-a2f9-4183-ae88-5710d3afaefd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ccd3e8f1-39e9-4e09-aa41-625afda84460"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ccf0645d-ddad-4c9e-b4f1-dc1f1edb2aa4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cde0f9b6-6b13-4de9-adfe-cad1fe085e30"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ce086a21-29c2-444c-b53d-f3b70b086b2f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cf6ac249-f20a-400b-8543-31f2d2fe23f0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cf8a3ea2-d5d2-4bf2-ba6b-cf1309d18bb1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("cfad4ee5-580f-4df2-918b-bc89c615ad0b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d0ec2790-a870-405e-bb61-2dcc3cf47467"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d18033cd-9cf6-4800-9176-57758bb444dc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d198c901-fe4e-4c3f-9323-d6a771f51960"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d1ba62a4-767b-49ba-9ce8-ab17537b2fe1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d1c9bb3c-2929-46a8-a338-adfddf0ef524"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d2155fa6-b03d-468c-884e-ccf6fefc40bd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d22c341b-80c2-436d-98e1-8a2575bc975a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d28e7ed1-3317-41c5-bec6-725369ed1171"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d2c8f60e-fda4-4744-9017-9c727fdcfe1f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d2d025a2-e691-4986-b9c4-923e7f1a47c3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d2f5f610-c55d-427e-9a78-12731c5cce5d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d31767ef-2cf8-4046-9881-d5651d81ade8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d3e21e8a-99ce-4033-8db6-9d0f0648beb3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d3f822a0-e201-4a61-8913-589c74818ae0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d488c5cc-4de9-4631-8ce1-0db0e700b546"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d4df3617-8209-4bcd-948e-fa723beb6666"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d4f5f719-8c52-4f8d-945d-1c31404cc628"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d6dc44d1-63ac-4871-b175-60ac4040069a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d75442cf-87f8-4a56-8ee0-8ed7f94fe738"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d7a8df36-2978-45b8-99d1-76d84cf34c01"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d863cbc3-5e5e-4095-855c-026f0850dd58"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d867e7e9-feb9-4d36-8757-4afd865e697b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d89eb759-58c4-43f4-9fe4-e6a21af23f5c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d8ef9f21-479e-4504-8bf7-aef2dbe6184d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d9289367-c8aa-4b6a-b1ad-857fec94c6bb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("d9acdbec-61ff-4308-978a-2f4d1c2c4059"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("da3b5de9-bb1d-4545-a172-fa29301d552e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("da453ad0-5f1d-417c-baa3-74ae297f0b7a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("da893bbd-965a-49b7-a661-707a1ba899d1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("db1684c1-7ffc-4e8a-b8cf-8240a0d03519"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("db4a69b2-65ba-4dd8-8b3e-eadf2cc241c6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dbb2bb9f-0f80-4df4-9d5c-98af2ee41826"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dc344605-c507-4054-b4e3-293cf0602bc4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dc407f1e-e25f-4995-9feb-5bacc8658149"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dd41a7d6-9b11-4ec4-9518-388266750cfa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dda39817-d01d-467f-a6a3-7487011a45d1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ddb249c5-360b-4c4f-a7f6-1f6822d236c8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("de4cc1db-51cb-4b62-bee2-9750cbe4f5c4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("df242a51-7ed5-4205-be60-47e0e1f46fad"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("dfdf753b-75bd-46f0-8cde-15545be9bfba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e020e651-e422-46d3-ae28-34887c5a4a8e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e0747660-6d75-476a-be0f-73865bf47363"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e0d0cc73-d3ef-41ff-a158-4692b62ed3f9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e114aeec-c8d9-4d20-8fe1-8822058cb38b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e1217d07-91f8-4019-b3a2-0c0d69316ab8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e251f943-ce2f-4003-b208-e2797aa72202"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e28babaa-7801-49a2-9c28-58701549ce5d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e30f2e83-b80b-4b96-8f39-fa60317afcc7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e32b0a28-8cd5-4053-bc86-fff9c6469106"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e3409c98-72d7-425b-9e2d-da54f75b3be8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e476bcad-b898-4f68-9c26-4f1a1159dff6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e4f29379-6fd3-4501-afc5-bc5a41cb6e93"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e506460f-4577-4405-8cc3-cc36a4bb516d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e574d0af-5c63-4306-b1d3-43b7359de06d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e5b8e9f3-f0cc-4ad7-8707-577ee1b25b3e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e5e02890-87bd-4fab-b590-ffa557c3532e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e607a4b6-85cc-4f12-a53d-116cb6eef4f5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e651fe4a-d759-49c5-8e00-55137d0f2975"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e6b42536-6bf8-42e3-8ef5-7d1a283a8608"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e6b68bc2-6814-4bbf-b37e-44a0b7807c2d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e6d68ab7-5c27-4f25-896f-11dbf04056cd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e70e39ec-e476-4991-a39d-7d0e009556ef"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e7440532-8033-44d6-99b4-037a05da0c54"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e7c7cbaa-9a85-4033-be0f-b5bebcce0760"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e7f52bd2-f0cb-4194-aa85-4ad76a3a0671"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e8daa3e2-77d1-4cfa-9ac9-501e7b2b4b0a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e97116a4-7d30-4671-8ba1-cdce0a153d1d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("e9e7f20c-9f74-41fd-b054-cad59fca2cd4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ea3e14ca-2872-47e7-a10c-8b2e0b46bdba"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ea6870dc-507e-4ec4-a38c-cd8a5e8b7025"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eadedeb6-c31e-483f-b6c4-ca0153359ad7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eaedd67b-723b-4800-a1ae-56341b0d9e22"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eb24b5a3-5102-429b-93a9-15656fee850f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eb3d4195-8c73-46b6-87e9-ef0de83edddf"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eb90bd3f-5405-412d-81e0-7a58be52dcef"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eba772d4-509e-4fe7-ba51-d9a29b190432"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ec4a598d-773d-44c1-935e-2053b54e45a3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ec8188ee-f4e4-4f5e-91ae-472e765060cd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ed260406-bdd6-42ef-bf2a-1246eea392f9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("edfa125a-1e46-4c7e-9f3a-568ae013a4df"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("edfdf747-be92-462f-87ed-53d228a33172"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ee52ce62-212c-4735-b438-26fbdc37e3e2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eeaba884-d4c5-4a83-88fb-adcd79adbc50"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("eebd633a-3af0-4b79-83d5-b6490765e06c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f0197bcf-6846-4c0a-9659-0c2626a9bcf0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f099ce74-1a3d-4d47-9810-75c2b1b178b6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f0f78cc4-1ab4-4548-abed-63c65a267a8a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f112a50a-d94a-49d3-a140-0a0402baf0d3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f18e81da-1fec-4308-a881-6defa7c6d18b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f33c3cc9-dc4b-4b77-baa9-5a5f10704398"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f348f2f6-37c2-41c2-8d53-fd06a18acce0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f3c6ee73-5561-4068-96ec-364016e7d9ef"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f3dc8f07-c2bb-4b92-b0b0-4e01a395a2c6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f44e7220-892e-40b5-8ef4-3da129c2a6ae"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f49855d8-371f-4bdf-8ade-ed6b475e6b27"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f4c55f77-ab80-4e00-bed3-aa6631aba074"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f4f9f7fb-eeff-46dc-9727-04d8aa56240a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f53bb77f-e55a-468f-b7be-b66baf7e3e5b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f5bc4a51-004f-4e5e-99b9-e6ae888d57de"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f6dc9514-bdaf-4817-b3bf-34cd4b5c3e18"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f768173a-7a22-40f7-90a3-4676da7e5010"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f77317d9-654f-4f51-925e-004c592049da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f7a639a4-b824-445c-b158-108ebd70cc9a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f833a494-961b-42d3-9843-e4e61607b5be"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f85bd17b-06c7-49bd-8bfc-ee2bf3ffea99"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f8806fa4-cc2c-46e8-9b87-6231da0e3ddd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("f973fb71-4a44-4603-8b13-25002dd6dbd8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fa886080-4271-4684-9999-1b6862a20ac1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 386, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fac30fe9-a39c-445a-84de-637a199f1dfa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("facc5c16-f700-4248-9893-a395bffaf2e4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 383, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("faefa284-84cf-4c1e-aa73-dccdc3de729d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fbb1c6c1-9fa9-4315-8e31-3499bf00bfef"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fc1072e4-61d4-4e89-bc70-c7e8860fd208"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fe72ee98-88e9-4d19-aba1-f97f61b7d4de"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 385, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("fed4c295-7a01-463c-998e-70ebad8cd2cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: new Guid("ff02f181-491c-4925-ad13-07edd2ddb3f1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 384, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("09a03b1f-9ece-4086-94d8-462f98985851"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("0bc5bdb3-7e62-4c28-b4d3-fd4d3e7580c8"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("0c5ecb8f-5c72-4e55-82c5-cff6a068f5a4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("0f4ceb73-146d-474e-8232-3cabbccc27e7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("10415159-e774-4431-8de1-5ce83324718f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("171de910-9dbe-4b30-a4d7-a79e231fc411"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("177835d3-9d2a-42ef-88fd-a572ba3df9ca"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("1836bb37-423e-444b-bf2e-df21fed87fb1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("1a191392-64f3-408e-87f0-b91e10545b57"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("1a23b4ab-db97-4f74-bce9-151db100b0b0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("1e045f5d-abab-4826-85ea-b9c3fcafc271"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2063f11b-3b00-41a6-baea-2de71e34e5da"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("262436f8-2a32-434b-9d19-90d1922daadc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("283901d1-24a4-4e8e-94f6-3fa3dfb4720a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("28cdf699-e727-447b-b3ee-9d10f8b2a5b2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("28e2b1b8-e353-4174-99a5-816229c68bd1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2b224064-51d8-451c-806a-836f4d7e707a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2e1a8e9d-983f-445b-8f31-270510396d90"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2f14ff08-2c57-4da3-9c69-2978efd4ac6e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("2f810727-4e7b-40ac-8356-ad1477d49150"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("30081c46-bbe9-4ac7-894c-4852476d66e5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("3883de67-ab59-458a-9de1-1e1026e27bf0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("3a151fd0-81a0-4b01-a439-d2aa553b0b38"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("3a2495f2-4581-43c1-8061-426525b1815a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("40c51e0c-d21c-492a-bbab-e9af3acc0187"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("450a71cf-f2db-4932-96d9-33afcb7e1272"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("48052b97-14e6-43a6-b096-7e7b4e95ee66"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("4f626d5c-3e9d-4fe4-839a-df9eb0262ba0"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("512a905c-fbd5-4e1f-ad61-caba44d8b0f9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("529fc755-8b44-44be-a56f-0d751b82e76a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("5963233a-8e39-459e-931c-e27c057a49b6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("5980613c-07da-44b7-bda4-5de17f9c20e5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("5f6f4fcf-e1cb-472e-8fd3-f331875e5153"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("637cbed8-f8a3-41a4-a649-cfed2613c6cb"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("63e486cf-7366-4c56-8d33-1f5f1874434b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("6ce9c61c-ab43-4084-bd62-9ad5e2ab6cf9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("714b47c3-c63b-426f-accc-bcb7ebdde0e3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("7314670d-020b-4c64-9870-84d5e2eb0ba4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("744e0bc7-0946-41ea-bc82-d0cea5cbf4c1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("75a1d3e7-c6e7-4b50-85e9-c74ca31b0b5f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("7bd20795-fa24-4a48-ac2a-5c5c8510ea97"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("7eef13f6-e9be-4ca4-8f03-30c4aa75e493"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("808af9be-2074-40a7-96b1-17973bd59449"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("821630fc-d361-458f-b69c-2115a1c10b24"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("87724dc3-a0e4-4fe3-af64-0c174951d58e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("89658af6-0df5-42bf-b550-5923fadc6f33"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("8c8c8518-d59b-4512-b75c-36a67f95c260"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("8eb3c12d-029c-48f7-8995-d04f2d76f815"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("90398d4a-b576-431d-ad9a-3a632a333daa"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("96423534-6b1a-4af8-93d7-6f99af296ecd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("966076cc-19e7-4922-921d-aad15d5164b1"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("9752610e-8cf8-4ef9-b820-666df89a720a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("9e207d14-f5a8-43b0-b7b0-1d4c484e5444"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("a237b616-e51b-4c6c-8fe2-ef485b0a3879"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("a88ea916-5e6c-4d83-83a9-1d4fdfef25ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("a8aca94c-fe23-43e0-93a7-39a6614b5d87"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("aa74ebd7-e4b1-4ea4-83e2-989d94b90d6a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("aabc9e69-6dae-4f35-9250-8427eaedf15c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("aae1f1d4-f79f-4c3a-83d5-debffd711981"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("acb1b45d-4161-4c4a-a518-c508ed5a03b5"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("afc18147-790a-4af0-bffa-a54156c6ba7c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("afc35e3e-2400-4e4d-82d1-c11e3b3274d2"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("b22c66a1-fedc-4822-83c7-5918ef35d35d"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("b35aa52d-9188-4489-8189-73f4e6b9841e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("b61e88e8-9c3e-4ffa-8265-3c1053df076e"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("ba4ac402-5733-4608-acd0-bc1edfd1a157"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("bac6f0b5-34e1-4425-a1d6-05624aa72fdd"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 347, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("be09d030-9c00-4a2d-83cf-222a469b317a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c23322c5-ad2a-4050-9e64-e377341617a9"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c309f510-67ec-4d13-912d-f703231458cc"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c486d5cb-772b-41b8-90f4-fc382cc8414b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c656debb-f595-41af-8234-48f3c4c19a51"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("c821c96d-eebc-4f9c-8bd8-2aa4a304fb23"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("d19708ca-ac42-4ad4-8d62-e85722f946f6"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("d30e6e98-5a25-40af-a625-be880ef69a9b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("d54f6551-d1f2-4856-a873-86a6e17eebb4"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("d7818e64-186b-435f-a871-cdb9f75d4459"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("dcc5eb65-dee4-4bd5-a61b-80d3dfa54c41"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("de3724fd-80a8-46f9-8b5b-db378a84048c"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("de958aa1-aa8c-482b-8d76-11c9b8c68c47"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("def28f4a-9a97-4659-85f4-7a0f47ec3309"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e2b58ea1-969f-4f72-a2a6-429c7fdd8f37"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e47bbf30-f087-49dc-a85d-f097d829a39a"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e54e5839-5fc8-4494-9360-8989442a2242"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e5c5d288-6a87-42ec-81c1-d58f1a6fcf1b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e9b9cd69-3073-4002-a0f6-37c2153c53ec"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("e9f60b79-5fde-4026-b6a2-fb27112135e7"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("ed0e2086-7425-4d2d-b372-d9b219d5638b"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("f1c53a5e-5205-4f4b-8463-c9c074919477"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("f5d543c2-b584-40e4-afa0-19435627e3ff"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("f68a87eb-4812-4075-a29c-82831687c30f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("f965ecf6-2057-479d-a571-3f4e30c1e493"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fadeb941-fe23-40f4-b1cd-5c949dc8372f"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fb88f5b1-2248-45ca-bd47-1a2213b82fd3"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fb9b6f64-a7a6-4744-a12f-5bdf31e6f0af"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fd74ae1f-78c3-4efa-8449-6ecc1fb482ab"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("fea68b1b-7080-428d-9180-3a2fabf95d71"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Waters",
                keyColumn: "Id",
                keyValue: new Guid("ffa035bd-4c18-4a12-9bc7-5e66fc29e149"),
                column: "Created",
                value: new DateTime(2019, 12, 5, 19, 18, 58, 348, DateTimeKind.Local).AddTicks(1490));
        }
    }
}
