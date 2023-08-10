using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimplStudy.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdressesPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdressesPoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateOrder = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateReceipt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TotalPrice = table.Column<int>(type: "integer", nullable: false),
                    TotalCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AddressesPointId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buyers_AdressesPoints_AddressesPointId",
                        column: x => x.AddressesPointId,
                        principalTable: "AdressesPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    HoursProduction = table.Column<int>(type: "integer", nullable: false),
                    AddressesPointId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_AdressesPoints_AddressesPointId",
                        column: x => x.AddressesPointId,
                        principalTable: "AdressesPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    AddressesPointId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_AdressesPoints_AddressesPointId",
                        column: x => x.AddressesPointId,
                        principalTable: "AdressesPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stores_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    DeliveryId = table.Column<int>(type: "integer", nullable: false),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    BuyerId = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => new { x.ProductId, x.BuyerId, x.SellerId, x.DeliveryId });
                    table.ForeignKey(
                        name: "FK_Items_Buyers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Buyers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Deliveries_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdressesPoints",
                columns: new[] { "Id", "Address" },
                values: new object[,]
                {
                    { 1, "Ленина, 32" },
                    { 2, "Уссурийская, 47" },
                    { 3, "Братская, 55" },
                    { 4, "Петровсеая, 32" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Часы наручные" },
                    { 2, "Фотокамеры" },
                    { 3, "Процессоры" }
                });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "DateOrder", "DateReceipt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 8, 13, 11, 31, 212, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 8, 10, 13, 11, 31, 212, DateTimeKind.Utc).AddTicks(2284) },
                    { 2, new DateTime(2023, 8, 7, 13, 11, 31, 212, DateTimeKind.Utc).AddTicks(2285), new DateTime(2023, 8, 10, 13, 11, 31, 212, DateTimeKind.Utc).AddTicks(2285) },
                    { 3, new DateTime(2023, 8, 6, 13, 11, 31, 212, DateTimeKind.Utc).AddTicks(2286), new DateTime(2023, 8, 11, 13, 11, 31, 212, DateTimeKind.Utc).AddTicks(2287) },
                    { 4, new DateTime(2023, 8, 5, 13, 11, 31, 212, DateTimeKind.Utc).AddTicks(2287), new DateTime(2023, 8, 12, 13, 11, 31, 212, DateTimeKind.Utc).AddTicks(2288) }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "TotalCount", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 0, 0 },
                    { 2, 0, 0 },
                    { 3, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Белов Ч.Ч." },
                    { 2, "Чернов К.Т." },
                    { 3, "Краснов Х.Т." },
                    { 4, "Корнев М.М." }
                });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "Id", "AddressesPointId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Орлов К.Ч." },
                    { 2, 1, "Шмелев С.С." },
                    { 3, 2, "Синичкин К.П." },
                    { 4, 3, "Ястребов А.А." },
                    { 5, 4, "Курков П.П." }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "AddressesPointId", "HoursProduction", "Name" },
                values: new object[,]
                {
                    { 1, 1, 120, "Петров А.А." },
                    { 2, 2, 220, "Сидоров А.Б." },
                    { 3, 3, 50, "Репин Б.В." },
                    { 4, 4, 90, "Жабин У.А." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name", "Price", "Weight" },
                values: new object[,]
                {
                    { 1, 1, "COROS Apex 46mm", 2300, 30f },
                    { 2, 1, "Garmin Fenix 7", 4400, 40f },
                    { 3, 2, "Garmin Forerunner 945", 5300, 41f },
                    { 4, 2, "COROS Pace 2", 1820, 33f }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "AddressesPointId", "Name", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, "Shop1", 1 },
                    { 2, 2, "Shop2", 2 },
                    { 3, 3, "Shop3", 3 },
                    { 4, 4, "Shop4", 4 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "BuyerId", "DeliveryId", "ProductId", "SellerId", "Count", "OrderId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 2, 1 },
                    { 1, 2, 2, 1, 2, 1 },
                    { 3, 2, 2, 2, 1, 3 },
                    { 2, 1, 3, 1, 3, 2 },
                    { 3, 2, 3, 2, 1, 3 },
                    { 3, 3, 3, 3, 1, 3 },
                    { 2, 1, 4, 2, 4, 2 },
                    { 3, 4, 4, 4, 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buyers_AddressesPointId",
                table: "Buyers",
                column: "AddressesPointId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BuyerId",
                table: "Items",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_DeliveryId",
                table: "Items",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_OrderId",
                table: "Items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_SellerId",
                table: "Items",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_AddressesPointId",
                table: "Managers",
                column: "AddressesPointId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_AddressesPointId",
                table: "Stores",
                column: "AddressesPointId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_SellerId",
                table: "Stores",
                column: "SellerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "AdressesPoints");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
