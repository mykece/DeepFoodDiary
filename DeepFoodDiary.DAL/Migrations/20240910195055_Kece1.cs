using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeepFoodDiary.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Kece1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100000, 1"),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AdminName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10000, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "5000, 1"),
                    MealName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "50000, 1"),
                    UserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UserPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Calorie = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carbonhydrate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Measurement = table.Column<float>(type: "real", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PortionType = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    TotalCalorie = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserFoodMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakenCalorie = table.Column<int>(type: "int", nullable: false),
                    MealEateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoodMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserFoodMeals_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoodMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoodMeals_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminName", "CreatedDate", "DeletedDate", "ModifiedDate", "Password", "Status" },
                values: new object[] { 100000, "fooddiary", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(6648), null, null, "123456", 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedDate", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 10000, "Vegetable", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7089), null, null, 1 },
                    { 10001, "Fruits", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7099), null, null, 1 },
                    { 10002, "DairyProducts", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7100), null, null, 1 },
                    { 10003, "MeatProducts", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7102), null, null, 1 },
                    { 10004, "FishandSeafood", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7103), null, null, 1 },
                    { 10005, "Legumes", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7104), null, null, 1 },
                    { 10006, "Grains", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7105), null, null, 1 },
                    { 10007, "SugarsAndSweets", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7106), null, null, 1 },
                    { 10008, "Beverages", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7108), null, null, 1 },
                    { 10009, "Soups ", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7109), null, null, 1 },
                    { 10010, "BakeryProducts", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7110), null, null, 1 },
                    { 10011, "SpicesAndSauces", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7111), null, null, 1 },
                    { 10012, "Snack", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7112), null, null, 1 },
                    { 10013, "AlcoholicBeverages", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7113), null, null, 1 },
                    { 10014, "Salad", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7114), null, null, 1 },
                    { 10015, "Main Food", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7115), null, null, 1 },
                    { 10016, "For Breakfast", new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7116), null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "MealName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 5000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8141), null, "Breakfast", null, 0 },
                    { 5001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8145), null, "Dinner", null, 0 },
                    { 5002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8146), null, "Lunch", null, 0 },
                    { 5003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8147), null, "Snack", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "ModifiedDate", "Password", "SecurityCode", "Status", "UserName", "UserPicture" },
                values: new object[,]
                {
                    { 50000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8407), null, null, "123.MErve**", "070424", 1, "mervesratekcan@gmail.com", null },
                    { 50001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8411), null, null, "123.KErem**", "070794", 1, "alikeremkaya@gmail.com", null },
                    { 50002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8413), null, null, "123.MUsa**", "112233", 1, "musayasirkece@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calorie", "Carbonhydrate", "CategoryId", "CreatedDate", "DeletedDate", "Fat", "FoodName", "Measurement", "ModifiedDate", "Picture", "PortionType", "Protein", "Status" },
                values: new object[,]
                {
                    { 1, 34.0, "6.6", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7292), null, "0.4", "Broccoli ", 100f, null, null, 9, "2.8", 0 },
                    { 2, 25.0, "5  ", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7298), null, "0.3 ", "Cauliflower  ", 100f, null, null, 9, "1.9", 0 },
                    { 3, 41.0, "9.6", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7300), null, "0.2", "Carrot", 100f, null, null, 9, "0.9", 0 },
                    { 4, 23.0, "3.6 ", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7302), null, "0.4", "Spinach  ", 100f, null, null, 9, "2.9", 0 },
                    { 5, 17.0, "3.1 ", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7304), null, "0.3  ", "Zucchini  ", 100f, null, null, 9, "1.2", 0 },
                    { 6, 25.0, "6", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7306), null, "0.2", "Eggplant  ", 100f, null, null, 9, "1", 0 },
                    { 7, 18.0, "3.9", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7307), null, "0.2 ", "Tomato", 100f, null, null, 9, "0.9", 0 },
                    { 8, 40.0, "9.3", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7309), null, "0.1", "Onion", 100f, null, null, 9, "1.1", 0 },
                    { 9, 22.0, "3.3", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7311), null, "0.3", "Mushroom", 100f, null, null, 9, "3.1", 0 },
                    { 10, 25.0, "5.8", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7313), null, "0.1", "Cabbage", 100f, null, null, 9, "1.3", 0 },
                    { 11, 43.0, "8.9 ", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7315), null, "0.3", "Brussels Sprouts ", 100f, null, null, 9, "3.4", 0 },
                    { 12, 31.0, "6", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7316), null, "0.3", "Red Bell Pepper ", 100f, null, null, 9, "1", 0 },
                    { 13, 20.0, "4.6", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7318), null, "0.2", "Green Bell Pepper ", 100f, null, null, 9, "0.9", 0 },
                    { 14, 20.0, "3.9", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7320), null, "0.1", "Asparagus", 100f, null, null, 9, "2.2", 0 },
                    { 15, 61.0, "14.2", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7322), null, "0.3", "Leeks", 100f, null, null, 9, "1.5", 0 },
                    { 16, 16.0, "3", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7324), null, "0.2", "Celery", 100f, null, null, 9, "0.7", 0 },
                    { 17, 86.0, "20.1", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7326), null, "0.1", "Potatoes", 100f, null, null, 9, "1.6", 0 },
                    { 18, 47.0, "10.5", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7328), null, "0.2", "Artichokes", 100f, null, null, 9, "3.3", 0 },
                    { 19, 45.0, "11.7", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7330), null, "0.1", "Butternut Squash", 100f, null, null, 9, "1", 0 },
                    { 20, 81.0, "14.5", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7331), null, "0.4", "Peas", 100f, null, null, 9, "5.4", 0 },
                    { 21, 33.0, "7.5", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7333), null, "0.2", "Okra", 100f, null, null, 9, "1.9", 0 },
                    { 22, 16.0, "3.4", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7335), null, "0.1", "Radishes", 100f, null, null, 9, "0.7", 0 },
                    { 23, 149.0, "33", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7336), null, "0.5", "Garlic", 100f, null, null, 9, "6.4", 0 },
                    { 24, 28.0, "6.4", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7338), null, "0.1", "Turnips", 100f, null, null, 9, "0.9", 0 },
                    { 25, 43.0, "10", 10000, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7340), null, "0.2", "Beetroot ", 100f, null, null, 9, "1.6", 0 },
                    { 26, 52.0, "14g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7342), null, "0.2g", "Apple", 1f, null, null, 4, "0.3g", 0 },
                    { 27, 89.0, "23g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7343), null, "0.3g", "Banana", 1f, null, null, 4, "1.1g", 0 },
                    { 28, 50.0, "12g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7345), null, "0.3g", "Cherries", 100f, null, null, 9, "1g", 0 },
                    { 29, 30.0, "8g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7347), null, "0.2g", "Watermelon", 100f, null, null, 9, "0.6g", 0 },
                    { 30, 60.0, "15g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7349), null, "0.4g", "Mango", 100f, null, null, 9, "0.8g", 0 },
                    { 31, 57.0, "14g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7351), null, "0.3g", "Blueberries", 100f, null, null, 9, "0.7g", 0 },
                    { 32, 160.0, "9g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7352), null, "15g", "Avocado", 100f, null, null, 9, "2g", 0 },
                    { 33, 39.0, "10g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7354), null, "0.3g", "Peach", 1f, null, null, 4, "0.9g", 0 },
                    { 34, 32.0, "8g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7362), null, "0.3g", "Strawberries", 100f, null, null, 9, "0.7g", 0 },
                    { 35, 50.0, "13g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7364), null, "0.1g", "Pineapple", 100f, null, null, 9, "0.5g", 0 },
                    { 36, 34.0, "8.2g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7366), null, "0.2g", "Cantaloupe", 100f, null, null, 9, "0.8g", 0 },
                    { 37, 36.0, "9g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7368), null, "0.1g", "Honeydew Melon", 100f, null, null, 9, "0.5g", 0 },
                    { 38, 61.0, "14.7g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7370), null, "0.5g", "Kiwi", 1f, null, null, 4, "1.1g", 0 },
                    { 39, 60.0, "13g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7372), null, "0.2g", "Dragon Fruit", 100f, null, null, 9, "1.2g", 0 },
                    { 40, 66.0, "16.5g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7373), null, "0.4g", "Lychee", 100f, null, null, 9, "0.8g", 0 },
                    { 41, 43.0, "10g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7375), null, "0.5g", "Blackberries", 100f, null, null, 9, "1.4g", 0 },
                    { 42, 52.0, "12g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7377), null, "0.7g", "Raspberries", 100f, null, null, 9, "1.2g", 0 },
                    { 43, 83.0, "19g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7378), null, "1.2g", "Pomegranate", 100f, null, null, 9, "1.7g", 0 },
                    { 44, 97.0, "23g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7381), null, "0.7g", "Passion Fruit", 1f, null, null, 4, "2.2g", 0 },
                    { 45, 73.0, "18g", 10001, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7382), null, "0.6g", "Mangosteen", 100f, null, null, 9, "0.5g", 0 },
                    { 46, 150.0, "12g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7384), null, "8g", "Whole Milk", 240f, null, null, 2, "8g", 0 },
                    { 47, 154.0, "17g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7386), null, "3.5g", "Plain Yogurt", 245f, null, null, 8, "13g", 0 },
                    { 48, 113.0, "0.4g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7387), null, "9g", "Cheddar Cheese", 28f, null, null, 3, "7g", 0 },
                    { 49, 102.0, "0.01g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7389), null, "11.5g", "Butter", 14f, null, null, 1, "0.1g", 0 },
                    { 50, 207.0, "24g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7391), null, "11g", "Ice Cream", 100f, null, null, 6, "3.5g", 0 },
                    { 51, 85.0, "1g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7393), null, "6g", "Mozzarella Cheese", 30f, null, null, 3, "6g", 0 },
                    { 52, 98.0, "3.4g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7394), null, "4.3g", "Cottage Cheese", 100f, null, null, 9, "11g", 0 },
                    { 53, 264.0, "4g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7396), null, "21g", "Feta Cheese", 100f, null, null, 9, "14g", 0 },
                    { 54, 83.0, "12g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7398), null, "0.2g", "Skim Milk", 240f, null, null, 2, "8g", 0 },
                    { 55, 30.0, "1g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7400), null, "2.5g", "Almond Milk", 240f, null, null, 2, "1g", 0 },
                    { 56, 59.0, "3.6g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7401), null, "0.4g", "Greek Yogurt", 100f, null, null, 9, "10g", 0 },
                    { 57, 55.0, "7g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7403), null, "2g", "Kefir", 240f, null, null, 2, "3g", 0 },
                    { 58, 102.0, "18g", 10002, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7405), null, "1.5g", "Flavored Yogurt (Strawberry)", 150f, null, null, 8, "4g", 0 },
                    { 59, 271.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7407), null, "18g", "Beef Steak", 100f, null, null, 9, "26g", 0 },
                    { 60, 165.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7409), null, "3.6g", "Chicken Breast", 100f, null, null, 9, "31g", 0 },
                    { 61, 231.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7411), null, "13g", "Pork Chop", 100f, null, null, 9, "29g", 0 },
                    { 62, 135.0, "3.8g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7412), null, "1.7g", "Turkey Slices", 100f, null, null, 9, "29g", 0 },
                    { 63, 336.0, "2.4g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7414), null, "26g", "Salami", 50f, null, null, 3, "22g", 0 },
                    { 64, 541.0, "1.4g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7416), null, "42g", "Bacon", 100f, null, null, 9, "37g", 0 },
                    { 65, 291.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7417), null, "21g", "Lamb Leg", 100f, null, null, 9, "25g", 0 },
                    { 66, 337.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7419), null, "25g", "Duck Breast", 100f, null, null, 9, "27g", 0 },
                    { 67, 271.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7421), null, "19g", "Ribeye Steak", 100f, null, null, 9, "24g", 0 },
                    { 68, 250.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7422), null, "15g", "Sirloin Steak", 100f, null, null, 9, "26g", 0 },
                    { 69, 215.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7426), null, "11g", "Ground Beef (85% lean)", 100f, null, null, 9, "26g", 0 },
                    { 70, 209.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7428), null, "11g", "Chicken Thighs", 100f, null, null, 9, "26g", 0 },
                    { 71, 172.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7429), null, "5.7g", "Chicken Drumsticks", 100f, null, null, 9, "28g", 0 },
                    { 72, 203.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7431), null, "8.1g", "Chicken Wings", 100f, null, null, 9, "30g", 0 },
                    { 73, 158.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7440), null, "3.2g", "Venison (Deer Meat)", 100f, null, null, 9, "30g", 0 },
                    { 74, 135.0, "0g", 10003, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7442), null, "0.7g", "Roast Turkey Breast", 100f, null, null, 9, "30g", 0 },
                    { 75, 208.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7443), null, "13g", "Salmon Fillet", 100f, null, null, 9, "20g", 0 },
                    { 76, 184.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7445), null, "8g", "Tuna Steak", 100f, null, null, 9, "25g", 0 },
                    { 77, 99.0, "0.2g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7447), null, "0.3g", "Shrimp", 100f, null, null, 9, "24g", 0 },
                    { 78, 111.0, "5g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7449), null, "0.5g", "Scallops", 100f, null, null, 9, "21g", 0 },
                    { 79, 89.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7450), null, "0.6g", "Lobster", 100f, null, null, 9, "19g", 0 },
                    { 80, 97.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7452), null, "1g", "Crab Meat", 100f, null, null, 9, "21g", 0 },
                    { 81, 82.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7454), null, "0.7g", "Cod Fillet", 100f, null, null, 9, "18g", 0 },
                    { 82, 172.0, "7g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7455), null, "4g", "Mussels", 100f, null, null, 9, "24g", 0 },
                    { 83, 208.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7457), null, "11g", "Sardines", 100f, null, null, 9, "25g", 0 },
                    { 84, 90.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7459), null, "0.7g", "Haddock", 100f, null, null, 9, "20g", 0 },
                    { 85, 140.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7461), null, "3g", "Halibut", 100f, null, null, 9, "27g", 0 },
                    { 86, 68.0, "4g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7462), null, "2g", "Oysters", 100f, null, null, 9, "7g", 0 },
                    { 87, 164.0, "4g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7465), null, "2g", "Octopus", 100f, null, null, 9, "30g", 0 },
                    { 88, 148.0, "5g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7467), null, "2g", "Clams", 100f, null, null, 9, "26g", 0 },
                    { 89, 210.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7468), null, "10g", "Anchovies", 50f, null, null, 9, "29g", 0 },
                    { 90, 86.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7470), null, "1g", "Flounder", 100f, null, null, 9, "18g", 0 },
                    { 91, 97.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7472), null, "2g", "Sea Bass", 100f, null, null, 9, "20g", 0 },
                    { 92, 119.0, "0g", 10004, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7474), null, "5g", "Rainbow Trout", 100f, null, null, 9, "20g", 0 },
                    { 93, 116.0, "20g", 10005, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7475), null, "0.4g", "Lentils", 100f, null, null, 9, "9g", 0 },
                    { 94, 164.0, "27g", 10005, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7477), null, "2.6g", "Chickpeas", 100f, null, null, 9, "9g", 0 },
                    { 95, 132.0, "24g", 10005, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7479), null, "0.5g", "Black Beans", 100f, null, null, 9, "9g", 0 },
                    { 96, 127.0, "22g", 10005, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7480), null, "0.5g", "Kidney Beans", 100f, null, null, 9, "9g", 0 },
                    { 97, 81.0, "14g", 10005, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7482), null, "0.4g", "Green Peas", 100f, null, null, 9, "5g", 0 },
                    { 98, 173.0, "10g", 10005, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7484), null, "9g", "Soybeans", 100f, null, null, 9, "17g", 0 },
                    { 99, 140.0, "26g", 10005, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7485), null, "0.6g", "Navy Beans", 100f, null, null, 9, "8g", 0 },
                    { 100, 143.0, "27g", 10005, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7487), null, "0.6g", "Pinto Beans", 100f, null, null, 9, "9g", 0 },
                    { 101, 112.0, "23.5g", 10006, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7489), null, "0.8g", "Brown Rice", 100f, null, null, 9, "2.6g", 0 },
                    { 102, 130.0, "28.6g", 10006, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7492), null, "0.3g", "White Rice", 100f, null, null, 9, "2.7g", 0 },
                    { 103, 120.0, "21.3g", 10006, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7493), null, "1.9g", "Quinoa", 100f, null, null, 9, "4.4g", 0 },
                    { 104, 389.0, "66.3g", 10006, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7495), null, "6.9g", "Oats", 100f, null, null, 9, "16.9g", 0 },
                    { 105, 354.0, "73.5g", 10006, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7497), null, "2.3g", "Barley", 100f, null, null, 9, "12.5g", 0 },
                    { 106, 86.0, "18.7g", 10006, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7498), null, "1.2g", "Corn", 100f, null, null, 9, "3.2g", 0 },
                    { 107, 343.0, "71.5g", 10006, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7500), null, "3.4g", "Buckwheat", 100f, null, null, 9, "13.3g", 0 },
                    { 108, 378.0, "72.9g", 10006, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7502), null, "4.3g", "Millet", 100f, null, null, 9, "11g", 0 },
                    { 109, 546.0, "61.7g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7505), null, "31g", "Chocolate Bar", 100f, null, null, 9, "4.9g", 0 },
                    { 110, 325.0, "77g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7507), null, "0.2g", "Gummy Bears", 100f, null, null, 9, "6.9g", 0 },
                    { 111, 394.0, "98g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7508), null, "0g", "Hard Candy", 100f, null, null, 9, "0g", 0 },
                    { 112, 305.0, "46.3g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7510), null, "12.1g", "Cupcake", 1f, null, null, 4, "2.7g", 0 },
                    { 113, 452.0, "51g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7518), null, "25g", "Donut", 1f, null, null, 4, "4.9g", 0 },
                    { 114, 376.0, "94g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7520), null, "0g", "Jelly Beans", 100f, null, null, 9, "0g", 0 },
                    { 115, 382.0, "78g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7522), null, "8.3g", "Caramel", 100f, null, null, 9, "4.2g", 0 },
                    { 116, 334.0, "56g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7525), null, "11g", "Baklava", 1f, null, null, 3, "5g", 0 },
                    { 117, 402.0, "48g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7526), null, "20g", "Künefe", 100f, null, null, 7, "9g", 0 },
                    { 118, 89.0, "22g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7528), null, "0g", "Lokum", 1f, null, null, 4, "0.2g", 0 },
                    { 119, 112.0, "18.4g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7530), null, "3.8g", "Şekerpare", 1f, null, null, 4, "1.9g", 0 },
                    { 120, 535.0, "59.4g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7531), null, "29.7g", "Milk Chocolate", 100f, null, null, 9, "7.6g", 0 },
                    { 121, 546.0, "61.7g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7533), null, "31g", "Dark Chocolate", 100f, null, null, 9, "4.9g", 0 },
                    { 122, 539.0, "59g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7535), null, "30g", "White Chocolate", 100f, null, null, 9, "6g", 0 },
                    { 123, 240.0, "24g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7537), null, "15g", "Tiramisu", 1f, null, null, 3, "4g", 0 },
                    { 124, 321.0, "25g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7539), null, "23g", "Cheesecake", 1f, null, null, 3, "6g", 0 },
                    { 125, 70.0, "9g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7540), null, "3.2g", "Macaron", 1f, null, null, 4, "1.2g", 0 },
                    { 126, 233.0, "24g", 10007, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7542), null, "13g", "Cannoli", 1f, null, null, 4, "4g", 0 },
                    { 127, 2.0, "0g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7544), null, "0g", "Coffee, black", 240f, null, null, 2, "0.3g", 0 },
                    { 128, 2.0, "0.3g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7545), null, "0g", "Tea, brewed", 240f, null, null, 2, "0g", 0 },
                    { 129, 150.0, "39g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7547), null, "0g", "Soda", 355f, null, null, 2, "0g", 0 },
                    { 130, 112.0, "26g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7549), null, "0.5g", "Orange Juice", 240f, null, null, 2, "1.7g", 0 },
                    { 131, 146.0, "11g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7551), null, "8g", "Milk, whole", 240f, null, null, 2, "7.9g", 0 },
                    { 132, 20.0, "3g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7552), null, "0.2g", "Espresso", 30f, null, null, 2, "0.2g", 0 },
                    { 133, 74.0, "6g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7554), null, "4g", "Cappuccino", 150f, null, null, 2, "4g", 0 },
                    { 134, 135.0, "12g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7556), null, "7g", "Latte Macchiato", 240f, null, null, 2, "8g", 0 },
                    { 135, 50.0, "12g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7557), null, "0.1g", "Iced Coffee", 240f, null, null, 2, "0.3g", 0 },
                    { 136, 0.0, "0g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7559), null, "0g", "Green Tea", 240f, null, null, 2, "0g", 0 },
                    { 137, 2.0, "0.3g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7561), null, "0g", "Black Tea", 240f, null, null, 2, "0g", 0 },
                    { 138, 2.0, "0.5g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7563), null, "0g", "Herbal Tea", 240f, null, null, 2, "0g", 0 },
                    { 139, 120.0, "22g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7564), null, "2.5g", "Chai Latte", 240f, null, null, 2, "4g", 0 },
                    { 140, 0.0, "0g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7566), null, "0g", "Mineral Water", 330f, null, null, 2, "0g", 0 },
                    { 141, 10.0, "2g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7568), null, "0g", "Flavored Sparkling Water, Lemon", 330f, null, null, 2, "0g", 0 },
                    { 142, 10.0, "2g", 10008, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7570), null, "0g", "Flavored Sparkling Water, Lime", 330f, null, null, 2, "0g", 0 },
                    { 143, 75.0, "8.5g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7571), null, "2.5g", "Chicken Noodle Soup", 240f, null, null, 6, "4.5g", 0 },
                    { 144, 85.0, "18.6g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7573), null, "0.4g", "Tomato Soup", 240f, null, null, 6, "1.5g", 0 },
                    { 145, 160.0, "15g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7575), null, "7g", "Beef Stew", 240f, null, null, 6, "11g", 0 },
                    { 146, 90.0, "17g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7577), null, "1g", "Minestrone", 240f, null, null, 6, "3g", 0 },
                    { 147, 201.0, "21g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7579), null, "8g", "Clam Chowder", 240f, null, null, 6, "16g", 0 },
                    { 148, 180.0, "30g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7580), null, "1g", "Lentil Soup", 240f, null, null, 6, "12g", 0 },
                    { 149, 206.0, "16.5g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7583), null, "12.5g", "Broccoli Cheese Soup", 240f, null, null, 6, "10g", 0 },
                    { 150, 224.0, "17g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7585), null, "14g", "French Onion Soup", 240f, null, null, 6, "8g", 0 },
                    { 151, 180.0, "20g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7587), null, "7g", "Mercimek Soup", 240f, null, null, 6, "9g", 0 },
                    { 152, 165.0, "25g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7594), null, "5g", "Ezogelin Soup", 240f, null, null, 6, "5g", 0 },
                    { 153, 90.0, "3g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7596), null, "4g", "İşkembe Soup", 240f, null, null, 6, "12g", 0 },
                    { 154, 140.0, "18g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7598), null, "6g", "Yayla Soup", 240f, null, null, 6, "6g", 0 },
                    { 155, 150.0, "25g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7600), null, "3g", "Tarhana Soup", 240f, null, null, 6, "5g", 0 },
                    { 156, 75.0, "8g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7601), null, "2g", "Tavuk Suyu Soup", 240f, null, null, 6, "6g", 0 },
                    { 157, 200.0, "0g", 10009, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7603), null, "15g", "Paça Soup", 240f, null, null, 6, "14g", 0 },
                    { 158, 100.0, "20g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7604), null, "2g", "Whole Wheat Bread", 1f, null, null, 3, "4g", 0 },
                    { 159, 175.0, "36g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7607), null, "1g", "Baguette", 58f, null, null, 3, "6g", 0 },
                    { 160, 235.0, "26g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7609), null, "12g", "Croissant", 1f, null, null, 4, "5g", 0 },
                    { 161, 303.0, "41g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7610), null, "13g", "Cinnamon Roll", 1f, null, null, 4, "5g", 0 },
                    { 162, 170.0, "33g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7612), null, "1g", "Sourdough Bread", 2f, null, null, 3, "6g", 0 },
                    { 163, 377.0, "51g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7614), null, "17g", "Muffin", 1f, null, null, 4, "5g", 0 },
                    { 164, 165.0, "33g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7615), null, "0.7g", "Pita Bread", 1f, null, null, 4, "5.5g", 0 },
                    { 165, 83.0, "15.5g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7617), null, "0.8g", "Rye Bread", 1f, null, null, 3, "2.7g", 0 },
                    { 166, 300.0, "52g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7619), null, "8g", "Brioche", 1f, null, null, 4, "6g", 0 },
                    { 167, 142.0, "27g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7620), null, "2.3g", "Focaccia", 1f, null, null, 3, "2.7g", 0 },
                    { 168, 180.0, "27g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7622), null, "7g", "Garlic Bread", 1f, null, null, 3, "5g", 0 },
                    { 169, 120.0, "20g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7624), null, "3.5g", "Crackers", 30f, null, null, 9, "2g", 0 },
                    { 170, 108.0, "22.5g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7626), null, "0.8g", "Pretzels", 1f, null, null, 4, "2.8g", 0 },
                    { 171, 79.0, "14.2g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7627), null, "0.8g", "Melba Toast", 4f, null, null, 3, "2.6g", 0 },
                    { 172, 410.0, "45g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7629), null, "23g", "Croissant, Almond", 1f, null, null, 4, "10g", 0 },
                    { 173, 290.0, "55g", 10010, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7631), null, "3.6g", "Simit", 1f, null, null, 4, "10g", 0 },
                    { 174, 255.0, "64g", 10011, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7633), null, "3.3g", "Black Pepper", 100f, null, null, 9, "10g", 0 },
                    { 175, 312.0, "67.1g", 10011, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7635), null, "3.3g", "Turmeric", 100f, null, null, 9, "9.7g", 0 },
                    { 176, 112.0, "27g", 10011, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7636), null, "0.1g", "Ketchup", 100f, null, null, 9, "1.2g", 0 },
                    { 177, 680.0, "2g", 10011, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7638), null, "75g", "Mayonnaise", 100f, null, null, 9, "1g", 0 },
                    { 178, 247.0, "81g", 10011, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7639), null, "1.2g", "Cinnamon", 100f, null, null, 9, "4g", 0 },
                    { 179, 53.0, "4.9g", 10011, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7641), null, "0.6g", "Soy Sauce", 100f, null, null, 10, "4.9g", 0 },
                    { 180, 30.0, "7g", 10011, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7643), null, "0.2g", "Hot Sauce", 100f, null, null, 10, "1g", 0 },
                    { 181, 325.0, "58g", 10011, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7644), null, "14g", "Curry Powder", 100f, null, null, 9, "14g", 0 },
                    { 182, 547.0, "51.4g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7646), null, "36.4g", "Potato Chips", 100f, null, null, 9, "6.6g", 0 },
                    { 183, 607.0, "20g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7648), null, "54g", "Mixed Nuts", 100f, null, null, 9, "17g", 0 },
                    { 184, 387.0, "78g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7649), null, "4.5g", "Popcorn, Air-popped", 100f, null, null, 9, "13g", 0 },
                    { 185, 462.0, "56g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7651), null, "26g", "Trail Mix", 100f, null, null, 9, "13g", 0 },
                    { 186, 325.0, "76g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7652), null, "0g", "Fruit Snacks", 100f, null, null, 9, "0g", 0 },
                    { 187, 471.0, "64g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7654), null, "21g", "Granola Bar", 1f, null, null, 4, "10g", 0 },
                    { 188, 387.0, "81.3g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7656), null, "3.3g", "Rice Cake", 100f, null, null, 9, "8.4g", 0 },
                    { 189, 472.0, "62.5g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7658), null, "25g", "Vegetable Chips", 100f, null, null, 9, "2.5g", 0 },
                    { 190, 536.0, "50g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7660), null, "34g", "Cheese Puffs", 100f, null, null, 9, "7.6g", 0 },
                    { 191, 410.0, "11g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7661), null, "27g", "Beef Jerky", 100f, null, null, 9, "33g", 0 },
                    { 192, 614.0, "20g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7669), null, "56g", "Almond Butter", 100f, null, null, 9, "21g", 0 },
                    { 193, 515.0, "59g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7671), null, "30g", "Peanut Butter Cups", 1f, null, null, 4, "10g", 0 },
                    { 194, 584.0, "20g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7672), null, "51g", "Sunflower Seeds", 100f, null, null, 9, "20g", 0 },
                    { 195, 177.0, "14g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7674), null, "10g", "Hummus", 100f, null, null, 9, "8g", 0 },
                    { 196, 320.0, "70g", 10012, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7676), null, "7.5g", "Yogurt-Covered Raisins", 100f, null, null, 9, "2.8g", 0 },
                    { 197, 103.0, "6g", 10013, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7677), null, "0g", "Light Beer", 355f, null, null, 2, "1g", 0 },
                    { 198, 125.0, "3.8g", 10013, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7679), null, "0g", "Red Wine", 150f, null, null, 2, "0.1g", 0 },
                    { 199, 231.0, "0g", 10013, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7681), null, "0g", "Vodka", 100f, null, null, 2, "0g", 0 },
                    { 200, 70.0, "0g", 10013, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7682), null, "0g", "Whiskey", 45f, null, null, 2, "0g", 0 },
                    { 201, 263.0, "0g", 10013, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7684), null, "0g", "Gin", 100f, null, null, 2, "0g", 0 },
                    { 202, 87.0, "1.4g", 10013, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7687), null, "0g", "Champagne", 150f, null, null, 2, "0.3g", 0 },
                    { 203, 168.0, "11g", 10013, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7688), null, "0g", "Margarita", 120f, null, null, 2, "0g", 0 },
                    { 204, 231.0, "0g", 10013, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7690), null, "0g", "Rum", 100f, null, null, 2, "0g", 0 },
                    { 205, 180.0, "10g", 10014, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7692), null, "14g", "Caesar Salad", 100f, null, null, 7, "7g", 0 },
                    { 206, 106.0, "4.3g", 10014, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7693), null, "8.4g", "Greek Salad", 100f, null, null, 7, "2.9g", 0 },
                    { 207, 200.0, "5g", 10014, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7695), null, "16g", "Caprese Salad", 100f, null, null, 7, "8g", 0 },
                    { 208, 160.0, "15g", 10014, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7697), null, "10g", "Waldorf Salad", 100f, null, null, 7, "2g", 0 },
                    { 209, 233.0, "9g", 10014, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7698), null, "16g", "Cobb Salad", 100f, null, null, 7, "13g", 0 },
                    { 210, 105.0, "3g", 10014, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7700), null, "7g", "Nicoise Salad", 100f, null, null, 7, "7g", 0 },
                    { 211, 120.0, "20g", 10014, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7702), null, "3.5g", "Quinoa Salad", 100f, null, null, 7, "4g", 0 },
                    { 212, 290.0, "22g", 10014, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7703), null, "12g", "Southwest Chicken Salad", 100f, null, null, 7, "24g", 0 },
                    { 213, 250.0, "5g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7705), null, "15g", "Turkish Kebab", 1f, null, null, 7, "22g", 0 },
                    { 214, 270.0, "34g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7707), null, "10g", "Italian Pizza Margherita", 1f, null, null, 3, "11g", 0 },
                    { 215, 200.0, "42g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7708), null, "1g", "Japanese Sushi Roll", 8f, null, null, 4, "6g", 0 },
                    { 216, 260.0, "10g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7710), null, "14g", "Indian Chicken Curry", 100f, null, null, 7, "25g", 0 },
                    { 217, 156.0, "12g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7712), null, "8g", "Mexican Tacos", 1f, null, null, 4, "9g", 0 },
                    { 218, 90.0, "20g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7714), null, "0.4g", "French Ratatouille", 100f, null, null, 7, "1.2g", 0 },
                    { 219, 295.0, "30g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7715), null, "11g", "American Burger", 1f, null, null, 4, "17g", 0 },
                    { 220, 150.0, "18g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7717), null, "7g", "Greek Moussaka", 100f, null, null, 7, "8g", 0 },
                    { 221, 238.0, "38.3g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7719), null, "7.3g", "Chinese Fried Rice", 100f, null, null, 7, "5.6g", 0 },
                    { 222, 200.0, "10g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7720), null, "14g", "Turkish Menemen", 100f, null, null, 7, "12g", 0 },
                    { 223, 280.0, "31g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7722), null, "7g", "Spanish Paella", 100f, null, null, 7, "22g", 0 },
                    { 224, 310.0, "30g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7723), null, "9g", "Moroccan Tagine", 100f, null, null, 7, "35g", 0 },
                    { 225, 330.0, "18g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7725), null, "18g", "German Schnitzel", 100f, null, null, 7, "25g", 0 },
                    { 226, 150.0, "20g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7727), null, "8g", "Turkish İmam Bayıldı", 1f, null, null, 4, "3g", 0 },
                    { 227, 450.0, "40g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7728), null, "15g", "Vietnamese Pho", 1f, null, null, 6, "30g", 0 },
                    { 228, 280.0, "31g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7730), null, "13g", "Italian Lasagna", 100f, null, null, 7, "17g", 0 },
                    { 229, 560.0, "84g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7732), null, "18g", "Korean Bibimbap", 1f, null, null, 6, "22g", 0 },
                    { 230, 240.0, "10g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7733), null, "10g", "Ethiopian Doro Wat", 1f, null, null, 7, "28g", 0 },
                    { 231, 340.0, "30g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7744), null, "15g", "Brazilian Feijoada", 100f, null, null, 7, "25g", 0 },
                    { 232, 550.0, "40g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7746), null, "30g", "Classic Breakfast Burger", 1f, null, null, 4, "28g", 0 },
                    { 233, 600.0, "40g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7748), null, "35g", "Egg and Bacon Breakfast Burger", 1f, null, null, 4, "35g", 0 },
                    { 234, 500.0, "45g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7749), null, "25g", "Avocado and Turkey Breakfast Burger", 1f, null, null, 4, "30g", 0 },
                    { 235, 400.0, "50g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7751), null, "18g", "Vegetarian Breakfast Burger", 1f, null, null, 4, "18g", 0 },
                    { 236, 650.0, "40g", 10015, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7753), null, "40g", "Spicy Chorizo Breakfast Burger", 1f, null, null, 4, "32g", 0 },
                    { 237, 102.0, "19g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7754), null, "1.7g", "Porridge", 100f, null, null, 9, "2.5g", 0 },
                    { 238, 471.0, "64g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7756), null, "21g", "Granola", 100f, null, null, 9, "10g", 0 },
                    { 239, 155.0, "1.1g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7758), null, "11g", "Boiled Eggs", 2f, null, null, 4, "13g", 0 },
                    { 240, 149.0, "22g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7760), null, "4.5g", "French Toast", 1f, null, null, 3, "5g", 0 },
                    { 241, 149.0, "0.7g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7761), null, "8.3g", "Turkey Sausage", 1f, null, null, 4, "17g", 0 },
                    { 242, 115.0, "6g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7763), null, "10.7g", "Olive", 10f, null, null, 4, "0.8g", 0 },
                    { 243, 304.0, "82.4g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7764), null, "0g", "Honey", 100f, null, null, 9, "0.3g", 0 },
                    { 244, 205.0, "30g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7766), null, "7g", "Whole Wheat Waffles", 1f, null, null, 4, "6g", 0 },
                    { 245, 357.0, "84g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7768), null, "0.4g", "Cornflakes", 100f, null, null, 9, "7.5g", 0 },
                    { 246, 217.0, "24g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7770), null, "9g", "Breakfast Burrito", 1f, null, null, 4, "12g", 0 },
                    { 247, 289.0, "34g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7772), null, "13g", "Gözleme", 1f, null, null, 4, "9g", 0 },
                    { 248, 275.0, "25g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7773), null, "16g", "Börek", 1f, null, null, 3, "8g", 0 },
                    { 249, 250.0, "50g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7775), null, "1.5g", "Bagels", 1f, null, null, 4, "10g", 0 },
                    { 250, 209.0, "26g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7777), null, "7g", "Ricotta Pancakes", 3f, null, null, 4, "11g", 0 },
                    { 251, 289.0, "66g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7778), null, "4g", "Fruit Muesli", 100f, null, null, 9, "6g", 0 },
                    { 252, 143.0, "0.7g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7780), null, "9.5g", "Poached Eggs", 2f, null, null, 4, "12g", 0 },
                    { 253, 97.0, "10g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7781), null, "1g", "Cottage Cheese with Pineapple", 100f, null, null, 9, "11g", 0 },
                    { 254, 134.0, "13g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7783), null, "8g", "Chia Seed Pudding", 100f, null, null, 9, "4g", 0 },
                    { 255, 360.0, "29g", 10016, new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(7785), null, "19g", "English Muffin with Egg and Cheese", 1f, null, null, 4, "19g", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "FullName", "Gender", "Height", "ModifiedDate", "Status", "TotalCalorie", "UserId", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(1993, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8284), null, "Merve Esra Tekcan", true, 170, null, 1, 1543f, 50000, 68 },
                    { 2, new DateTime(1994, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8295), null, "Ali Kerem Kaya", false, 175, null, 1, 2400f, 50001, 76 },
                    { 3, new DateTime(1995, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 22, 50, 54, 704, DateTimeKind.Local).AddTicks(8297), null, "Musa Yasir Keçe", false, 180, null, 1, 2700f, 50002, 74 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodName",
                table: "Foods",
                column: "FoodName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UserId",
                table: "UserDetails",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFoodMeals_FoodID",
                table: "UserFoodMeals",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoodMeals_MealId",
                table: "UserFoodMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoodMeals_UserID",
                table: "UserFoodMeals",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "UserFoodMeals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
