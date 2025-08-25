using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecommerce_app.Migrations
{
    /// <inheritdoc />
    public partial class AddDataDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f0ca05a-6a65-40a7-9c70-72831b2450ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f89d4ab-783a-4e35-8649-0d39aa80c2c6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "726bdd03-85fe-417b-8c4c-309ba4a61f77", null, "Admin", "ADMIN" },
                    { "7b6b83c6-b4d5-4fae-a654-f4526da85e7a", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "product_brand", "product_detail", "product_isActive", "product_isHome", "product_name", "product_price", "product_sizes", "product_tag", "product_tagColor" },
                values: new object[,]
                {
                    { 41, 3, "Zara", "Halter yakalı, bağcıklı ve V yakalı uzun elbise. İç astarı vardır. Sırtı açık, bağcıklı ve dikiş kısmında gizli fermuarlı kapamalıdır.", true, true, "Desenli Halter Uzun Elbise", 2290.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Yeni", "3E6DD6" },
                    { 42, 3, "Pull&Bear", "Dikiş kısmında gizli fermuarlı kapamalıdır.", true, true, "Dokulu Çiçekli Kısa Elbise", 1490.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Sezon İndirimi", "b74646" },
                    { 43, 3, "Pull&Bear", "Dikiş kısmında gizli fermuarlı kapamalıdır.", true, true, "Uzun Kollu Kısa Elbise", 920.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Son Ürünler", "f7ecd5" },
                    { 44, 13, "Zara", "City el çantası. Metal detaylı. Metal fermuarlı iç cep. Çıkarılabilir çapraz askılı. Çift kulplu metal fermuar kapamalı.", true, true, "City Çanta", 1490.0, "[\"M\"]", "Yeni", "3E6DD6" },
                    { 45, 13, "Zara", "Süet, topuklu sandalet ayakkabı. Ön tarafında fiyonk detayı. Ayarlanabilir elastik bantlı arka şerit. Yüksek topuklu.", true, true, "Süet Fiyonklu Topuklu Sandalet", 2890.0, "[\"35\",\"36\",\"37\",\"38\",\"39\",\"40\"]", "Yeni", "3E6DD6" }
                });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "Id", "ProductId", "color_hex", "color_name" },
                values: new object[] { 17, 41, "024697", "Lacivert" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ProductId", "image_url" },
                values: new object[,]
                {
                    { 74, 41, "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_on.heic?updatedAt=1755463778774" },
                    { 75, 41, "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_arka.heic?updatedAt=1755463778920" },
                    { 76, 41, "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_canli_on.heic?updatedAt=1755463778913" },
                    { 77, 41, "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_canli_arka.heic?updatedAt=1755463779108" },
                    { 78, 41, "https://ik.imagekit.io/osdata/clothes/Women/elbise3_zara_canli_yan.heic?updatedAt=1755463779329" },
                    { 79, 42, "https://ik.imagekit.io/osdata/clothes/Women/elbise5_pull&bear.heic?updatedAt=1755463779457" },
                    { 80, 43, "https://ik.imagekit.io/osdata/clothes/Women/elbise4_pull&bear.heic?updatedAt=1755463779406" },
                    { 81, 44, "https://ik.imagekit.io/osdata/clothes/Women/canta2_zara.heic?updatedAt=1755463790358" },
                    { 82, 45, "https://ik.imagekit.io/osdata/clothes/Women/ayakkab%C4%B11_zara_yan.heic?updatedAt=1755463790454" },
                    { 83, 45, "https://ik.imagekit.io/osdata/clothes/Women/ayakkab%C4%B11_zara_ust.heic?updatedAt=1755463790372" },
                    { 84, 45, "https://ik.imagekit.io/osdata/clothes/Women/ayakkab%C4%B11_zara_arka.heic?updatedAt=1755463790215" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "726bdd03-85fe-417b-8c4c-309ba4a61f77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b6b83c6-b4d5-4fae-a654-f4526da85e7a");

            migrationBuilder.DeleteData(
                table: "ProductColors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f0ca05a-6a65-40a7-9c70-72831b2450ac", null, "Admin", "ADMIN" },
                    { "4f89d4ab-783a-4e35-8649-0d39aa80c2c6", null, "User", "USER" }
                });
        }
    }
}
