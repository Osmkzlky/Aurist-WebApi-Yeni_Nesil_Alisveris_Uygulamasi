using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecommerce_app.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_kind = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_campaign = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_campaignColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_image = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    category_isHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AddressName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AddressSurname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    OrderPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderEmail = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderTotalPrice = table.Column<double>(type: "double", nullable: false),
                    OrderPromoRating = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderPromoPrice = table.Column<double>(type: "double", nullable: true),
                    OrderPaymentCardNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderPaymentCardCompany = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderShippingPrice = table.Column<double>(type: "double", nullable: false),
                    OrderShippingCompany = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Promos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PromoImage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PromoTitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PromoDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PromoExpirationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PromoProcess = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ReviewDetail = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReviewRating = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    slider_title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slider_detail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slider_image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    slider_index = table.Column<int>(type: "int", nullable: false),
                    slider_isActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    product_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    product_price = table.Column<double>(type: "double", nullable: false),
                    product_detail = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    product_isActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    product_tag = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    product_tagColor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    product_sizes = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    product_isHome = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    product_brand = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AddressTitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AddressCity = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AddressDistricts = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AddressPostalCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AddressDetail = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    color_name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color_hex = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductColors_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    image_url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductColorId = table.Column<int>(type: "int", nullable: true),
                    ProductSizeId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductPriceSnapshot = table.Column<double>(type: "double", nullable: false),
                    ProductColorNameSnapshot = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductColorHexSnapshot = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductNameSnapshot = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductBrandSnapshot = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductImageSnapshot = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductSizeSnapshot = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ProductColors_ProductColorId",
                        column: x => x.ProductColorId,
                        principalTable: "ProductColors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f0ca05a-6a65-40a7-9c70-72831b2450ac", null, "Admin", "ADMIN" },
                    { "4f89d4ab-783a-4e35-8649-0d39aa80c2c6", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "category_campaign", "category_campaignColor", "category_image", "category_isHome", "category_kind", "category_name", "category_url" },
                values: new object[,]
                {
                    { 1, "Mega İndirim Günleri!", "FFD700", "https://ik.imagekit.io/osdata/clothes/womenList.heic?updatedAt=1755084524577", true, "Women", "Tümünü Gör", "view-all" },
                    { 2, null, null, "https://ik.imagekit.io/osdata/clothes/Women/bluz1_on_jack&jones.heic?updatedAt=1753264404211", true, "Women", "Tişört/Bluz", "tshirt-blouses" },
                    { 3, null, null, "https://ik.imagekit.io/osdata/clothes/Women/elbise1_on_jack&jones.heic?updatedAt=1753264410116", true, "Women", "Elbiseler", "dresses" },
                    { 4, null, null, "https://ik.imagekit.io/osdata/clothes/Women/gomlek1_on_jack&jones.heic?updatedAt=1753264400669", true, "Women", "Gömlekler", "shirts" },
                    { 5, null, null, "https://ik.imagekit.io/osdata/clothes/Women/etek1_on_jack&jones.heic?updatedAt=1753267522055", true, "Women", "Etekler", "skirts" },
                    { 6, null, null, "https://ik.imagekit.io/osdata/clothes/Women/pantolon1_on_jack&jones.heic?updatedAt=1753264378490", true, "Women", "Pantolon", "trousers" },
                    { 7, null, null, "https://ik.imagekit.io/osdata/clothes/Women/sort1_on_jack&jones.heic?updatedAt=1753264384700", true, "Women", "Şortlar", "shorts" },
                    { 8, null, null, "https://ik.imagekit.io/osdata/clothes/Women/jean1_on_jack&jones.heic?updatedAt=1753264387431", true, "Women", "Jeans", "jeans" },
                    { 9, null, null, "https://ik.imagekit.io/osdata/clothes/Women/sweatshirt1_on_jack&jones.heic?updatedAt=1753264382676", true, "Women", "Sweatshirts", "sweatshirts" },
                    { 10, null, null, "https://ik.imagekit.io/osdata/clothes/Women/mont1_on_jack&jones.heic?updatedAt=1753264383272", true, "Women", "Ceketler/Montlar", "jackets-coats" },
                    { 11, null, null, "https://ik.imagekit.io/osdata/clothes/Women/kazak1_on_jack&jones.heic?updatedAt=1753264382849", true, "Women", "Kazak/Hırka", "knitwears" },
                    { 12, null, null, "https://ik.imagekit.io/osdata/clothes/Women/tailoring1_on_jack&jones.heic?updatedAt=1753264383334", true, "Women", "Tailoring", "tailoring" },
                    { 13, null, null, "https://ik.imagekit.io/osdata/clothes/Women/canta1_jack&jones.heic?updatedAt=1753264409942", true, "Women", "Aksesuarlar", "accessories" },
                    { 14, "Hafta Sonuna Özel Kaçırılmaz Fiyatlar!", "b74646", "https://ik.imagekit.io/osdata/clothes/MenList.heic?updatedAt=1755084524691", true, "Men", "Tümünü Gör", "view-all" },
                    { 15, "Sezon Hazır Mısın? Yemyeşil İndirimler", "3ab21d", "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray1_on.heic?updatedAt=1753264188000", true, "Men", "Spor", "sports" },
                    { 16, null, null, "https://ik.imagekit.io/osdata/clothes/Men/tshirt5_on_zara.heic?updatedAt=1753264086292", true, "Men", "Tişört", "t-shirts" },
                    { 17, null, null, "https://ik.imagekit.io/osdata/clothes/Men/pantolon1_on_zara.heic?updatedAt=1753264046736", true, "Men", "Pantolon", "trousers" },
                    { 18, null, null, "https://ik.imagekit.io/osdata/clothes/Men/sort1_on_zara.heic?updatedAt=1753264048405", true, "Men", "Şortlar", "shorts" },
                    { 19, null, null, "https://ik.imagekit.io/osdata/clothes/Men/gomlek1_on_zara.heic?updatedAt=1753264040447", true, "Men", "Gömlekler", "shirts" },
                    { 20, null, null, "https://ik.imagekit.io/osdata/clothes/Men/jean2_on_zara.heic?updatedAt=1753264043367", true, "Men", "Jeans", "jeans" },
                    { 21, null, null, "https://ik.imagekit.io/osdata/clothes/Men/mont1_jack&jones.heic?updatedAt=1753264045216", true, "Men", "Ceketler/Montlar", "jackets-coats" },
                    { 22, null, null, "https://ik.imagekit.io/osdata/clothes/Men/swetshirt1_jack&jones.heic?updatedAt=1753264082051", true, "Men", "Sweatshirtler", "sweatshirts" },
                    { 23, null, null, "https://ik.imagekit.io/osdata/clothes/Men/takimelbise1_jack&jones.heic?updatedAt=1753267118640", true, "Men", "Takım Elbiseler", "tailoring" },
                    { 24, null, null, "https://ik.imagekit.io/osdata/clothes/Men/ayakkab%C4%B11_jack&jones.heic?updatedAt=1753264039411", true, "Men", "Ayakkabılar", "shoes" },
                    { 25, null, null, "https://ik.imagekit.io/osdata/clothes/Men/corap1_jack&jones.heic?updatedAt=1753264041706", true, "Men", "Aksesuarlar", "accessories" },
                    { 26, null, null, "https://ik.imagekit.io/osdata/clothes/kidList.heic?updatedAt=1755084709328", true, "Kids", "Tümünü Gör", "view-all" },
                    { 27, null, null, "https://ik.imagekit.io/osdata/clothes/Kids/jean1_on_jack&jones.heic?updatedAt=1753264472717", true, "Kids", "Jeans", "jeans" },
                    { 28, null, null, "https://ik.imagekit.io/osdata/clothes/Kids/tisort_jack&jones.heic?updatedAt=1753264472788", true, "Kids", "Tişörtler", "t-shirts" },
                    { 29, null, null, "https://ik.imagekit.io/osdata/clothes/Kids/esofman1_arka_jack&jones.heic?updatedAt=1753264472795", true, "Kids", "Eşofmanlar", "tracksuits" },
                    { 30, null, null, "https://ik.imagekit.io/osdata/clothes/Kids/sort1_on_jack&jones.heic?updatedAt=1753264475488", true, "Kids", "Şortlar", "shorts" },
                    { 31, null, null, "https://ik.imagekit.io/osdata/clothes/Kids/gomlek1_on_jack&jones.heic?updatedAt=1753264472764", true, "Kids", "Gömlekler", "shirts" },
                    { 32, null, null, "https://ik.imagekit.io/osdata/clothes/Kids/corap1_jack&jones.heic?updatedAt=1753264475251", true, "Kids", "Aksesuarlar", "accessories" }
                });

            migrationBuilder.InsertData(
                table: "Promos",
                columns: new[] { "Id", "PromoDescription", "PromoExpirationDate", "PromoImage", "PromoProcess", "PromoTitle" },
                values: new object[,]
                {
                    { 1, "agustos10", new DateTime(2025, 8, 20, 16, 4, 8, 950, DateTimeKind.Unspecified).AddTicks(1010), "https://ik.imagekit.io/osdata/Promo1.png?updatedAt=1755362698992", "% 10", "%10 İndirim" },
                    { 2, "efsaneindirim15", new DateTime(2025, 8, 30, 16, 4, 8, 950, DateTimeKind.Unspecified).AddTicks(1010), "https://ik.imagekit.io/osdata/Promo3.png?updatedAt=1755362698992", "% 15", "Efsane Yaz İndirimi" },
                    { 3, "sezonindirim22", new DateTime(2025, 8, 22, 16, 4, 8, 950, DateTimeKind.Unspecified).AddTicks(1010), "https://ik.imagekit.io/osdata/Promo4.png?updatedAt=1755362698992", "% 22", "Sezon İndirimi" },
                    { 4, "agustos15", new DateTime(2025, 8, 27, 16, 4, 8, 950, DateTimeKind.Unspecified).AddTicks(1010), "https://ik.imagekit.io/osdata/Promo2.png?updatedAt=1755362698992", "% 15", "%15 İndirim" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "slider_detail", "slider_image", "slider_index", "slider_isActive", "slider_title" },
                values: new object[,]
                {
                    { 1, "Slider 1 Açıklama", "https://ik.imagekit.io/osdata/clothes/slider_1.png?updatedAt=1753124783871", 0, true, "Başlık" },
                    { 2, "Slider 2 Açıklama", "https://ik.imagekit.io/osdata/clothes/slider_2.png?updatedAt=1753124784575", 1, true, "Başlık" },
                    { 3, "Slider 3 Açıklama", "https://ik.imagekit.io/osdata/clothes/slider_3.png?updatedAt=1753124785298", 2, true, "Başlık" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "product_brand", "product_detail", "product_isActive", "product_isHome", "product_name", "product_price", "product_sizes", "product_tag", "product_tagColor" },
                values: new object[,]
                {
                    { 1, 4, "Jack&Jones", "Günlük kullanım için mükemmel, her döneme uygun, kaliteli bir gömlek ile günlük gardırobunuzu yükseltin.Poplin, benzersiz bir görünüm için güçlü bir kumaştır ve ışıldayan bir parlaklığa sahiptir.", true, true, "Kadın Keten Gömlek", 1790.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "İndirim", "00bf63" },
                    { 2, 2, "Jack&Jones", "Taze, eğlenceli ve renkli bir görünüm sağlayan hafif plaj stiliyle yaza hazır olun. Açık uçlu kumaş; kuruluk hissi ve daha rustik bir görünüm verir.", true, true, "Kadın Desenli Askılı Keten Bluz", 1390.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Son Ürün", "FF0000" },
                    { 3, 9, "Jack&Jones", "Günlük kullanım için kaliteli sweat. İç kısmı yumuşak dokunuşlu hafif fırçalanmış kuma", true, true, "Kadın Kapüşonlu Minimal Logo Baskılı Sweatshirt", 1190.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Turuncu İndirim", "FFA500" },
                    { 4, 4, "Jack&Jones", "Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.", true, true, "Kadın Kısa Kollu Kroşe Gömlek", 1390.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Yeni Sezon", "0000FF" },
                    { 5, 3, "Jack&Jones", "Taze, eğlenceli ve renkli bir görünüm sağlayan hafif plaj stiliyle yaza hazır olun. Pamuk, yumuşak ve nefes alabilen özellikleriyle bilinen doğal bir iplik türüdür.", true, true, "Kadın Düz İşlemeli Elbise", 1590.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Harika Fiyat", "FFC107" },
                    { 6, 3, "Jack&Jones", "Her duruma uygun şık bir görünüm yaratmayı kolaylaştıran hafif, havadar bir yazlık takım ile gardırobunuzu güzelleştirin. Denim kumaşı; birlikte dokunan boyalı çözgü ipliği ve atkı dokuma ipi ile öne çıkan, dayanıklı bir çapraz dokuma kumaştır.", true, true, "Kadın Askılı Denim Elbise", 1990.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Efsane Ürün", "E1AD01" },
                    { 7, 7, "Jack&Jones", "Eşofman şortları, süper rahat olmalarını sağlayan büzme ipli ve elastik bel bandına sahiptir. Çeşitli kumaş ve bağlantı parçalarından oluşurlar. Dokuma kumaş; örgü kumaşlar gibi esnemeyen güçlü ve dayanıklı bir malzemedir.", true, true, "Kadın Keten Şort", 1090.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Yeni Sezon", "0000FF" },
                    { 8, 12, "Jack&Jones", "Kıyafet yönetmeliği şık bir kıyafet gerektirdiğinde, resmi kıyafetlerle bir üst seviyeye çıkın. Dimi; klasik bir görünüm yaratan V veya W deseniyle ünlü, dayanıklı, dokuma bir kumaştır.", true, true, "Kadın Keten Kruvaze", 2790.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Efsane Fiyat", "8B0000" },
                    { 9, 13, "Jack&Jones", "İş, okul, seyahat ve açık hava etkinlikleri de dahil olmak üzere günlük kullanım için kaliteli bir çanta. Poliüretan deriye alternatif, dayanıklı, ve sentetik bir materyaldir.", true, true, "Kadın Ayarlanabilir Askılı Canta", 1790.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Yeni Ürün", "808000" },
                    { 10, 10, "Jack&Jones", "Deri görünümlü motorcu ceketi", true, true, "Kadın Fermuar Detaylı Deri Ceket", 2190.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "En Çok Satılan", "FFC107" },
                    { 11, 6, "Jack&Jones", "Günlük kıyafetler rahattır ve günlük kullanım için uygundur. Dokuma kumaş; örgü kumaşlar gibi esnemeyen güçlü ve dayanıklı bir malzemedir.", true, true, "Kadın Pileli Keten Pantolon", 1790.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Flaş Fiyat", "FFD700" },
                    { 12, 11, "Jack&Jones", "Bu sade örgü, gardırobunuzdaki her şeyle uyumludur. Düz örgü, konforu ve esnekliği ön plana çıkaran bir örgülü kumaştır..", true, true, "Kadın Cizgili Kazak", 990.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Avantajlı Ürün", "800080" },
                    { 13, 5, "Jack&Jones", "Ribana örgü, dikey çizgilere sahiptir ve rahat bir his için çok esnektir.", true, true, "Kadın Örgülü Etek", 870.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Yeni", "3E6DD6" },
                    { 14, 2, "Jack&Jones", "Bu haftasonu kot pantolonla giyebileceğiniz gibi, ofiste gömlek ve pantolonun üzerine de giyebileceğiniz rahat bir örgü türüdür. Yapısal örgü, özel bir görünüm için hafif bir doku ile üretilmiştir.", true, true, "Kadın Örgülü Bluz", 950.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Yeni", "3E6DD6" },
                    { 15, 2, "Jack&Jones", "Bu sade örgü, gardırobunuzdaki her şeyle uyumludur. Düz örgü, konforu ve esnekliği ön plana çıkaran bir örgülü kumaştır..", true, true, "Kadın Kırmızı Bluz", 990.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]", "Yeni", "3E6DD6" },
                    { 16, 15, "Puma", "Galatasaray 25/26 alternatif forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.", true, true, "GALATASARAY 25/26 Alternatif Forması", 4499.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni Sezon", "00bf63" },
                    { 17, 15, "Puma", "Galatasaray 25/26 İç Saha forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.", true, true, "GALATASARAY 25/26 Erkek İç Saha Forması", 4499.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni Sezon", "00bf63" },
                    { 18, 15, "Puma", "Galatasaray 25/26 İç Saha forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.", true, true, "GALATASARAY 25/26 Erkek Deplasman Forması", 4499.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni Sezon", "00bf63" },
                    { 19, 15, "Adidas", "Sağlam temeller üzerine kuruldu. Bu Real Madrid Authentic iç saha forması, yenilenen Bernabéu stadyumunun uzun ve köklü geçmişini yansıtan zarif şekiller, dokular ve renklerle tasarlandı. 25/26 sezonunda efsanevi stadyumda giyilmek üzere tasarlanan forma, hızlı futbol için performans odaklı bir yapıya ve eşsiz ilham için ısı transferli kulüp armasına sahiptir.", true, true, "REAL MADRİD 25/26 Authentic İç Saha Forması", 7999.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni Sezon", "00bf63" },
                    { 20, 15, "Adidas", "Sağlam temeller üzerine kuruldu. Bu Real Madrid Authentic iç saha forması, yenilenen Bernabéu stadyumunun uzun ve köklü geçmişini yansıtan zarif şekiller, dokular ve renklerle tasarlandı. 25/26 sezonunda efsanevi stadyumda giyilmek üzere tasarlanan forma, hızlı futbol için performans odaklı bir yapıya ve eşsiz ilham için ısı transferli kulüp armasına sahiptir.", true, true, "REAL MADRİD 25/26 Deplasman Forması", 5399.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni Sezon", "00bf63" },
                    { 21, 15, "Adidas", "Bu forma, efsanevi stadyuma selam duruyor. Takım ruhunu yeniden canlandırıyor. Bu adidas FC Bayern formasında kulübün ikonik renklerinde büyük bir M harfi yer alıyor. Münih'in kısaltması olan bu harf, ışıltılı tasarımla öne çıkıyor. Taraftarların takımlarına duyduğu sevgiyi gösteren bu konforlu tişört, nemi uzaklaştıran AEROREADY teknolojisine ve nakış kulüp armasına sahiptir.", true, true, "FC BAYERN 25/26 İç Saha Forması", 5399.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni Sezon", "00bf63" },
                    { 22, 15, "Puma", "Galatasaray 25/26 İç Saha forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.", true, true, "GALATASARAY 25/26 Erkek Kaleci Forması", 4499.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni Sezon", "00bf63" },
                    { 23, 15, "Puma", "Galatasaray 25/26 İç Saha forması, Galatasaray’ın 120 yıllık kültürünün sembollerinden biri olan klasik parçalı tasarımıyla kulübün DNA‘sına saygı duruşunda bulunuyor. Formanın ense kısmında yer alan “İlklerin ve Enlerin Takımı” yazısı, kulübün köklü tarihine gönderme yapıyor. Hem performans hem de gurur için tasarlanan bu forma, sahada ve saha dışında rahat etmeni sağlayacak son teknoloji kumaş teknolojisine sahip. Formanı giy, tarihi kucakla ve önümüzdeki sezon da takımının yanında ol.", true, true, "GALATASARAY 25/26 Erkek Kaleci Forması", 4499.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni Sezon", "00bf63" },
                    { 24, 15, "Nike", "Hız takıntın mı var? Oyunun en büyük yıldızları da senin gibi. Bu yüzden bu Elite kramponu geliştirilmiş 3/4 boy Air Zoom birimiyle donattık. Bu stil, sana ve sporun en hızlı oyuncularına defansı aşmak için ihtiyaç duyulan itiş gücünü sunar. Hem kendinden hem ayakkabından mükemmel bir performans beklediğini biliyoruz. Bu nedenle, şimdiye kadarki en hızlı tepki veren Mercurial'ı tasarladık.", true, true, "Nike Mercurial Vapor 16 Elite", 13999.0, "[\"EU 36\",\"EU 37\",\"EU 38\",\"EU 39\",\"EU 40\",\"EU 41\",\"EU 42\",\"EU 43\",\"EU 44\",\"EU 45\"]", "Yeni", "3E6DD6" },
                    { 25, 15, "Nike", "İsabete çok mu önem veriyorsun? Biz de öyle. Bu yüzden Phantom 6 Elite'i, isabet yeteneğine güç katan çığır açıcı Gripknit ile tasarladık. Yapışkan doku, ayağını topa yaklaştırır ve her fırsatı değerlendirebilmen için sana kontrol kazandırır. Bu kramponla şut kaçırmak diye bir şey yok. Ayrıca Cyclone 360 tutuş plakasıyla bir araya gelerek hızlı dönüşler yapmanı sağlar ve golleri sıralaman için sana rakip tanımayan avantaj sunar.", true, true, "Nike Phantom 6 Low Elite", 13999.0, "[\"EU 36\",\"EU 37\",\"EU 38\",\"EU 39\",\"EU 40\",\"EU 41\",\"EU 42\",\"EU 43\",\"EU 44\",\"EU 45\"]", "Yeni", "3E6DD6" },
                    { 26, 15, "Nike", "Hızına seviye atlatmak mı istiyorsun? Bu Academy kramponu geliştirilmiş bir Air Zoom topuk birimiyle ürettik. Bu birim, defansı aşmak için ihtiyaç duyduğun itiş gücünü sunar. Ortaya çıkan stil, maç boyu tempoyu belirleyebilmen için en hızlı tepki veren Mercurial modelidir.", true, true, "Nike Mercurial Superfly 10 Academy LV8", 5299.0, "[\"EU 36\",\"EU 37\",\"EU 38\",\"EU 39\",\"EU 40\",\"EU 41\",\"EU 42\",\"EU 43\",\"EU 44\",\"EU 45\"]", "Yeni", "3E6DD6" },
                    { 27, 16, "Jack&Jones", "Bu klasik tişört; kot pantolon, şort ve pantolonlarla iyi uyum sağlayarak gardırobun vazgeçilmezi olacak. Penye jarse esnektir ve yumuşak bir hisse sahiptir. Günlük kullanım için mükemmeldir.", true, true, "Erkek Kol ve Yaka Detaylı Tişört", 890.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 28, 16, "Jack&Jones", "Bu klasik tişört; kot pantolon, şort ve pantolonlarla iyi uyum sağlayarak gardırobun vazgeçilmezi olacak. Penye jarse esnektir ve yumuşak bir hisse sahiptir. Günlük kullanım için mükemmeldir.", true, true, "Erkek Kol ve Yaka Detaylı Tişört", 890.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 29, 19, "Zara", "Keten ve pamuk karışımlı relaxed fit gömlek. Yakası düğmeli. Düğmeli manşetli uzun kollu. Göğsü yama cepli ve önü düğmeli.", true, true, "Pamuklu Keten Gömlek", 1690.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 30, 17, "Zara", "%14 keten ve pamuk karışımlı kumaştan üretilmiş relaxed fit pantolon. Ayarlanabilir bağcıklı lastikli bel. Ön cepli ve biyeli arka cepli.", true, true, "Relaxed Fit Pamuklu - Keten Pantolon", 1690.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 31, 17, "Zara", "%14 keten ve pamuk karışımlı kumaştan üretilmiş relaxed fit pantolon. Ayarlanabilir bağcıklı lastikli bel. Ön cepli ve biyeli arka cepli.", true, true, "Relaxed Fit Pamuklu - Keten Pantolon", 1690.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 32, 18, "Zara", "Keten kumaştan regular fit bermuda. Beli ayarlanabilir büzgü ipli elastik ve önde pileli. Ön cepli ve arkada yama cep detaylı.", true, true, "%100 Keten Bermuda Şort", 1690.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 33, 25, "Zara", "İkili eau de toilette seti. Koku piramidinde fındık, biber ve kehribar (I) + limon, yeşil notalar ve misk (II) notaları yer alıyor.", true, true, "Seoul + Lisboa Edt 2 X 90 ML (3.4 FL. OZ)", 990.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 34, 16, "Zara", "Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.", true, true, "Dik Dokulu Polo Tişört", 1320.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 35, 16, "Zara", "Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.", true, true, "Dik Dokulu Polo Tişört", 1320.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 36, 16, "Zara", "Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.", true, true, "Dik Dokulu Polo Tişört", 1320.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 37, 16, "Zara", "Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.", true, true, "Basic Kontrast Kumaşlı Tişört", 920.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 38, 16, "Zara", "Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.", true, true, "Basic Kontrast Kumaşlı Tişört", 920.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 39, 16, "Zara", "Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.", true, true, "Basic Kontrast Kumaşlı Tişört", 920.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" },
                    { 40, 16, "Zara", "Regular fit polo t-shirt. Önü açık yakalı, kısa kollu ve fitilli kenarlı.", true, true, "Basic Kontrast Kumaşlı Tişört", 920.0, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]", "Yeni", "3E6DD6" }
                });

            migrationBuilder.InsertData(
                table: "ProductColors",
                columns: new[] { "Id", "ProductId", "color_hex", "color_name" },
                values: new object[,]
                {
                    { 1, 1, "ff66c4", "Pembe" },
                    { 2, 1, "000000", "Siyah" },
                    { 3, 1, "FFFFFF", "Beyaz" },
                    { 4, 2, "F7B9D9", "Pembe" },
                    { 5, 2, "9B30FF", "Mor" },
                    { 6, 3, "FF0000", "Kırmızı" },
                    { 7, 4, "00FF00", "Yeşil" },
                    { 8, 5, "0000FF", "Mavi" },
                    { 9, 6, "FFFF00", "Sarı" },
                    { 10, 7, "FFA500", "Turuncu" },
                    { 11, 24, "ff66c4", "Pembe" },
                    { 12, 24, "000000", "Siyah" },
                    { 13, 24, "808080", "Gri" },
                    { 14, 24, "FFFFFF", "Beyaz" },
                    { 15, 25, "808080", "Mor" },
                    { 16, 25, "FF0000", "Kırmızı" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ProductId", "image_url" },
                values: new object[,]
                {
                    { 1, 1, "https://ik.imagekit.io/osdata/clothes/Women/gomlek1_on_jack&jones.heic?updatedAt=1753264400669" },
                    { 2, 1, "https://ik.imagekit.io/osdata/clothes/Women/gomlek1_arka_jack&jones.heic?updatedAt=1753264399797" },
                    { 3, 2, "https://ik.imagekit.io/osdata/clothes/Women/bluz1_on_jack&jones.heic?updatedAt=1753264404211" },
                    { 4, 2, "https://ik.imagekit.io/osdata/clothes/Women/bluz1_arka_jack&jones.heic?updatedAt=1753264398224" },
                    { 5, 3, "https://ik.imagekit.io/osdata/clothes/Women/sweatshirt1_on_jack&jones.heic?updatedAt=1753264382676" },
                    { 6, 3, "https://ik.imagekit.io/osdata/clothes/Women/sweatshirt_arka_jack&jones.heic?updatedAt=1753264382292" },
                    { 7, 4, "https://ik.imagekit.io/osdata/clothes/Women/gomlek2_on_jack&jones.heic?updatedAt=1753264410066" },
                    { 8, 4, "https://ik.imagekit.io/osdata/clothes/Women/gomlek2_arka_jack&jones.heic?updatedAt=1753264410148" },
                    { 9, 5, "https://ik.imagekit.io/osdata/clothes/Women/elbise1_on_jack&jones.heic?updatedAt=1753264410116" },
                    { 10, 5, "https://ik.imagekit.io/osdata/clothes/Women/elbise1_arka_jack&jones.heic?updatedAt=1753264409983" },
                    { 11, 6, "https://ik.imagekit.io/osdata/clothes/Women/elbise2_jack&jones.heic?updatedAt=1753264409957" },
                    { 12, 7, "https://ik.imagekit.io/osdata/clothes/Women/sort1_on_jack&jones.heic?updatedAt=1753264384700" },
                    { 13, 7, "https://ik.imagekit.io/osdata/clothes/Women/sort1_arka_jack&jones.heic?updatedAt=1753264384643" },
                    { 14, 8, "https://ik.imagekit.io/osdata/clothes/Women/tailoring1_on_jack&jones.heic?updatedAt=1753264383334" },
                    { 15, 8, "https://ik.imagekit.io/osdata/clothes/Women/tailoring1_arka_jack&jones.heic?updatedAt=1753264383008" },
                    { 16, 9, "https://ik.imagekit.io/osdata/clothes/Women/canta1_jack&jones.heic?updatedAt=1753264409942" },
                    { 17, 10, "https://ik.imagekit.io/osdata/clothes/Women/mont1_on_jack&jones.heic?updatedAt=1753264383272" },
                    { 18, 10, "https://ik.imagekit.io/osdata/clothes/Women/mont1_arka_jack&jones.heic?updatedAt=1753264383212" },
                    { 19, 11, "https://ik.imagekit.io/osdata/clothes/Women/pantolon1_on_jack&jones.heic?updatedAt=1753264378490" },
                    { 20, 11, "https://ik.imagekit.io/osdata/clothes/Women/pantolon1_arka_jack&jones.heic?updatedAt=1753264377464" },
                    { 21, 12, "https://ik.imagekit.io/osdata/clothes/Women/kazak1_on_jack&jones.heic?updatedAt=1753264382849" },
                    { 22, 12, "https://ik.imagekit.io/osdata/clothes/Women/kazak1_arka_jack&jones.heic?updatedAt=1753264382530" },
                    { 23, 13, "https://ik.imagekit.io/osdata/clothes/Women/etek1_on_jack&jones.heic?updatedAt=1753267522055" },
                    { 24, 13, "https://ik.imagekit.io/osdata/clothes/Women/etek1_arka_jack&jones.heic?updatedAt=1753267522039" },
                    { 25, 14, "https://ik.imagekit.io/osdata/clothes/Women/bluz2_on_jack&jones.heic?updatedAt=1753264405034" },
                    { 26, 14, "https://ik.imagekit.io/osdata/clothes/Women/bluz2_arka_jack&jones.heic?updatedAt=1753264408207" },
                    { 27, 15, "https://ik.imagekit.io/osdata/clothes/Women/bluz3_on_jack&jones.heic?updatedAt=1753267007813" },
                    { 28, 15, "https://ik.imagekit.io/osdata/clothes/Women/bluz3_arka_jack&jones.heic?updatedAt=1753267007524" },
                    { 29, 16, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray5_on.heic?updatedAt=1755083587943" },
                    { 30, 16, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray5_arka.heic?updatedAt=1755083587546" },
                    { 31, 17, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray1_on.heic?updatedAt=1753264188000" },
                    { 32, 17, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray1_arka.heic?updatedAt=1753264187949" },
                    { 33, 18, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray2_on.heic?updatedAt=1753264187235" },
                    { 34, 18, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray2_arka.heic?updatedAt=1753264187779" },
                    { 35, 19, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_real1_on.heic?updatedAt=1753264191330" },
                    { 36, 19, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_real1_arka.heic?updatedAt=1753264192719" },
                    { 37, 20, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_real2_on.heic?updatedAt=1753264194483" },
                    { 38, 20, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_real2_arka.heic?updatedAt=1753264192017" },
                    { 39, 21, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_bayern1_on.heic?updatedAt=1753264189901" },
                    { 40, 21, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_bayern1_arka.heic?updatedAt=1753264189825" },
                    { 41, 22, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray4_on.heic?updatedAt=1753264190759" },
                    { 42, 22, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galataray4_arka.heic?updatedAt=1753264188871" },
                    { 43, 23, "https://ik.imagekit.io/osdata/clothes/Men/football/forma_galatasaray3.heic?updatedAt=1753264189497" },
                    { 44, 24, "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike1_yan.heic?updatedAt=1753264198469" },
                    { 45, 24, "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike1_ust.heic?updatedAt=1753264200245" },
                    { 46, 25, "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike4_yan.heic?updatedAt=1753264200023" },
                    { 47, 25, "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike4_ust.heic?updatedAt=1753264200325" },
                    { 48, 26, "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike3_yan.heic?updatedAt=1753264198609" },
                    { 49, 26, "https://ik.imagekit.io/osdata/clothes/Men/football/krampon_nike3_ust.heic?updatedAt=1753264198765" },
                    { 50, 27, "https://ik.imagekit.io/osdata/clothes/Men/tshirt9_jack&jones.heic?updatedAt=1753264088651" },
                    { 51, 28, "https://ik.imagekit.io/osdata/clothes/Men/tshirt8_jack&jones.heic?updatedAt=1753264088412" },
                    { 52, 29, "https://ik.imagekit.io/osdata/clothes/Men/gomlek1_on_zara.heic?updatedAt=1753264040447" },
                    { 53, 29, "https://ik.imagekit.io/osdata/clothes/Men/gomlek1_arka_zara.heic?updatedAt=1753264041192" },
                    { 54, 30, "https://ik.imagekit.io/osdata/clothes/Men/pantolon1_on_zara.heic?updatedAt=1753264046736" },
                    { 55, 30, "https://ik.imagekit.io/osdata/clothes/Men/pantolon1_arka_zara.heic?updatedAt=1753264046340" },
                    { 56, 31, "https://ik.imagekit.io/osdata/clothes/Men/pantolon2_on_zara.heic?updatedAt=1753264046949" },
                    { 57, 32, "https://ik.imagekit.io/osdata/clothes/Men/sort1_on_zara.heic?updatedAt=1753264048405" },
                    { 58, 32, "https://ik.imagekit.io/osdata/clothes/Men/sort1_arka_zara.heic?updatedAt=1753264048239" },
                    { 59, 33, "https://ik.imagekit.io/osdata/clothes/Men/parfum1_zara.heic?updatedAt=1753264047132" },
                    { 60, 34, "https://ik.imagekit.io/osdata/clothes/Men/tshirt1_on_zara.heic?updatedAt=1753264083633" },
                    { 61, 34, "https://ik.imagekit.io/osdata/clothes/Men/tshirt1_arka_zara.heic?updatedAt=1753264083089" },
                    { 62, 35, "https://ik.imagekit.io/osdata/clothes/Men/tshirt2_on_zara.heic?updatedAt=1753264083894" },
                    { 63, 35, "https://ik.imagekit.io/osdata/clothes/Men/tshirt2_arka_zara.heic?updatedAt=1753264083912" },
                    { 64, 36, "https://ik.imagekit.io/osdata/clothes/Men/tshirt3_on_zara.heic?updatedAt=1753264083857" },
                    { 65, 36, "https://ik.imagekit.io/osdata/clothes/Men/tshirt3_arka_zara.heic?updatedAt=1753264083729" },
                    { 66, 37, "https://ik.imagekit.io/osdata/clothes/Men/tshirt4_on_zara.heic?updatedAt=1753264083117" },
                    { 67, 37, "https://ik.imagekit.io/osdata/clothes/Men/tshirt4_arka_zara.heic?updatedAt=1753264083080" },
                    { 68, 38, "https://ik.imagekit.io/osdata/clothes/Men/tshirt5_on_zara.heic?updatedAt=1753264086292" },
                    { 69, 38, "https://ik.imagekit.io/osdata/clothes/Men/tshirt5_arka_zara.heic?updatedAt=1753264083987" },
                    { 70, 39, "https://ik.imagekit.io/osdata/clothes/Men/tshirt6_on_zara.heic?updatedAt=1753264087944" },
                    { 71, 39, "https://ik.imagekit.io/osdata/clothes/Men/tshirt6_arka_zara.heic?updatedAt=1753264087191" },
                    { 72, 40, "https://ik.imagekit.io/osdata/clothes/Men/tshirt7_on_zara.heic?updatedAt=1753264087945" },
                    { 73, 40, "https://ik.imagekit.io/osdata/clothes/Men/tshirt7_arka_zara.heic?updatedAt=1753264087723" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_OrderId",
                table: "Addresses",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_OrderId",
                table: "CartItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductColorId",
                table: "CartItems",
                column: "ProductColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ProductId",
                table: "ProductColors",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Promos");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
