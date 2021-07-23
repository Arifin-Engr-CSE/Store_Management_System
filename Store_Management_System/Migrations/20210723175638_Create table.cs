using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store_Management_System.Migrations
{
    public partial class Createtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                schema: "Identity",
                columns: table => new
                {
                    BillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillName = table.Column<string>(nullable: true),
                    GoodsReceivedNoteId = table.Column<int>(nullable: false),
                    VendorDONumber = table.Column<string>(nullable: true),
                    VendorInvoiceNumber = table.Column<string>(nullable: true),
                    BillDate = table.Column<DateTimeOffset>(nullable: false),
                    BillDueDate = table.Column<DateTimeOffset>(nullable: false),
                    BillTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                });

            migrationBuilder.CreateTable(
                name: "BillTypes",
                schema: "Identity",
                columns: table => new
                {
                    BillTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillTypeName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillTypes", x => x.BillTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Branchs",
                schema: "Identity",
                columns: table => new
                {
                    BranchId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchs", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "Identity",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: false),
                    CustomerTypeId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                schema: "Identity",
                columns: table => new
                {
                    CustomerTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.CustomerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "GoodsReceivedNotes",
                schema: "Identity",
                columns: table => new
                {
                    GoodsReceivedNoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoodsReceivedNoteName = table.Column<string>(nullable: true),
                    PurchaseOrderId = table.Column<int>(nullable: false),
                    GRNDate = table.Column<DateTimeOffset>(nullable: false),
                    VendorDONumber = table.Column<string>(nullable: true),
                    VendorInvoiceNumber = table.Column<string>(nullable: true),
                    IsFullReceive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceivedNotes", x => x.GoodsReceivedNoteId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                schema: "Identity",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                schema: "Identity",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderName = table.Column<string>(nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTimeOffset>(nullable: false),
                    DeliveryDate = table.Column<DateTimeOffset>(nullable: false),
                    PurchaseTypeId = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.PurchaseOrderId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseTypes",
                schema: "Identity",
                columns: table => new
                {
                    PurchaseTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseTypeName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseTypes", x => x.PurchaseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                schema: "Identity",
                columns: table => new
                {
                    SalesOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesOrderName = table.Column<string>(nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTimeOffset>(nullable: false),
                    DeliveryDate = table.Column<DateTimeOffset>(nullable: false),
                    CustomerRefNumber = table.Column<string>(nullable: true),
                    SalesTypeId = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Tax = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.SalesOrderId);
                });

            migrationBuilder.CreateTable(
                name: "SalesTypes",
                schema: "Identity",
                columns: table => new
                {
                    SalesTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesTypeName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTypes", x => x.SalesTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                schema: "Identity",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(nullable: false),
                    VendorTypeId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "VendorTypes",
                schema: "Identity",
                columns: table => new
                {
                    VendorTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorTypeName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorTypes", x => x.VendorTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Identity",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductQTY = table.Column<string>(nullable: true),
                    BuyingPrice = table.Column<decimal>(nullable: false),
                    SellingPrice = table.Column<decimal>(nullable: false),
                    BranchId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "Identity",
                        principalTable: "ProductTypes",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderLines",
                schema: "Identity",
                columns: table => new
                {
                    PurchaseOrderLineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    DiscountPercentage = table.Column<double>(nullable: false),
                    DiscountAmount = table.Column<double>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false),
                    TaxPercentage = table.Column<double>(nullable: false),
                    TaxAmount = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderLines", x => x.PurchaseOrderLineId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderLines_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalSchema: "Identity",
                        principalTable: "PurchaseOrders",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderLines",
                schema: "Identity",
                columns: table => new
                {
                    SalesOrderLineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesOrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    DiscountPercentage = table.Column<double>(nullable: false),
                    DiscountAmount = table.Column<double>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false),
                    TaxPercentage = table.Column<double>(nullable: false),
                    TaxAmount = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderLines", x => x.SalesOrderLineId);
                    table.ForeignKey(
                        name: "FK_SalesOrderLines_SalesOrders_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalSchema: "Identity",
                        principalTable: "SalesOrders",
                        principalColumn: "SalesOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPhotos",
                schema: "Identity",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPhotos", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductPhotos_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Identity",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "Identity",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderLines_PurchaseOrderId",
                schema: "Identity",
                table: "PurchaseOrderLines",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderLines_SalesOrderId",
                schema: "Identity",
                table: "SalesOrderLines",
                column: "SalesOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "BillTypes",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Branchs",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "CustomerTypes",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "GoodsReceivedNotes",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "ProductPhotos",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "PurchaseOrderLines",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "PurchaseTypes",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "SalesOrderLines",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "SalesTypes",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Vendors",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "VendorTypes",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "PurchaseOrders",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "SalesOrders",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "ProductTypes",
                schema: "Identity");
        }
    }
}
