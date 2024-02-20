using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Batates.Data.Migrations
{
    /// <inheritdoc />
    public partial class DBSeedingImprovements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2873a2c8-7485-4473-9dfe-5e51ac0cd123", "AQAAAAIAAYagAAAAENWiBqTuCpcOgKyGMPI4aiW3zzL8pPhonIAc8dXLZglNHhwRghSo0Akjxdo4lqIbyA==", "f10fc074-d88a-4e3f-93e4-59eb5e71f75c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad6a50f6-6a25-4333-9a5f-4d711baf13ea", "AQAAAAIAAYagAAAAEFxsX8a1SXs0lOYgazzSdgFImTad1nRLmwzhcnm/4wG3v+9JhC8tPFteoN2gp+IfeQ==", "366f00af-f16f-4f4b-ba90-7489ab9606a4" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL" },
                values: new object[] { "Indulge in the rich flavors and culinary heritage of Italy with our authentic Italian cuisine, where every dish is crafted with passion and tradition to transport you to the sun-kissed hills of Tuscany and the bustling streets of Naples.", "https://dummyjson.com/image/512x512/?text=Italian" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "Description", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 2, "Experience the vibrant and spicy flavors of Mexico with our tantalizing Mexican cuisine, from sizzling fajitas to mouthwatering tacos, guaranteed to ignite your taste buds with every bite.", "https://dummyjson.com/image/512x512/?text=Mexican", "Mexican" },
                    { 3, "Embark on a culinary journey to Japan with our exquisite Japanese cuisine, where tradition meets innovation in every carefully crafted sushi roll, flavorful ramen bowl, and delicate tempura dish.", "https://dummyjson.com/image/512x512/?text=Japanese", "Japanese" },
                    { 4, "Delight your senses with the aromatic spices and diverse flavors of India through our authentic Indian cuisine, featuring savory curries, aromatic biryanis, and decadent desserts that will transport you to the bustling streets of Mumbai and the serene backwaters of Kerala.", "https://dummyjson.com/image/512x512/?text=Indian", "Indian" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageURL",
                value: "https://dummyjson.com/image/512x512/?text=Pizza+Slice");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ExtraDetails", "ImageURL", "Name", "Price", "RestaurantID" },
                values: new object[,]
                {
                    { 2, "Best Entire Pizza in the world", null, "https://dummyjson.com/image/512x512/?text=Entire+Pizza", "One Pizza", 9.9900000000000002, 1 },
                    { 3, "A delicious vegetarian pizza", null, "https://dummyjson.com/image/512x512/?text=Vegetarian+Pizza", "Vegetarian Pizza", 11.99, 1 },
                    { 4, "Classic pepperoni pizza", null, "https://dummyjson.com/image/512x512/?text=Pepperoni+Pizza", "Pepperoni Pizza", 12.99, 1 },
                    { 5, "Traditional margherita pizza", null, "https://dummyjson.com/image/512x512/?text=Margherita+Pizza", "Margherita Pizza", 10.99, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Our mission is to uphold the highest level of quality in all we do, from the quality and origin of our food to our care for the health of our customers and the environment.");

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "ID", "ContactNo", "Description", "ImageURL", "Name", "State" },
                values: new object[,]
                {
                    { 2, "0215896347", "Experience the authentic flavors of Italy with our handcrafted pizzas, pasta, and mouthwatering desserts, served with a touch of Italian hospitality.", null, "Taste of Italy", 3 },
                    { 3, "0317269854", "Get ready for a fiesta of flavors with our bold and delicious Mexican cuisine, featuring tacos, burritos, and sizzling fajitas that will transport you south of the border.", null, "El Taco Loco", 3 },
                    { 4, "0413785621", "Discover the art of sushi at Sushi Zen, where our skilled chefs combine fresh ingredients with precision and technique to create sushi rolls that are as beautiful as they are delicious.", null, "Sushi Zen", 3 },
                    { 5, "0518932746", "Embark on a culinary journey through the flavors of India at Spice Route, where our aromatic spices and authentic recipes will tantalize your taste buds and transport you to the streets of Mumbai.", null, "Spice Route", 3 },
                    { 6, "1112345678", "Dance your taste buds to the rhythm of Mexico with Taco Tango, where our bold flavors and festive atmosphere will spice up your dining experience.", null, "Taco Tango", 3 },
                    { 7, "1212345678", "Wrap yourself in flavor with Burrito Bar, where our customizable burritos and fresh ingredients will satisfy your cravings for authentic Mexican cuisine.", null, "Burrito Bar", 3 },
                    { 8, "1312345678", "Join the fiesta at Fiesta Grill, where our sizzling fajitas, flavorful tacos, and refreshing margaritas will transport you straight to the heart of Mexico.", null, "Fiesta Grill", 3 },
                    { 9, "1412345678", "Heat up your night at Cantina Caliente, where our spicy dishes and lively atmosphere will make every meal feel like a celebration.", null, "Cantina Caliente", 3 },
                    { 10, "1512345678", "Take a trip down Salsa Street for a taste of authentic Mexican street food, where our vibrant flavors and casual setting will keep you coming back for more.", null, "Salsa Street", 3 },
                    { 11, "1612345678", "Experience sushi perfection at Sushi Supreme, where our expert chefs use only the freshest ingredients to create sushi rolls that are as beautiful as they are delicious.", null, "Sushi Supreme", 3 },
                    { 12, "1712345678", "Find your zen at Sakura Sushi Bar, where our serene ambiance and exquisite sushi creations will transport you to the tranquil gardens of Japan.", null, "Sakura Sushi Bar", 3 },
                    { 13, "1812345678", "Unleash your inner ninja at Ninja Noodles, where our bold flavors and innovative noodle dishes will satisfy your cravings for authentic Japanese cuisine.", null, "Ninja Noodles", 3 },
                    { 14, "1912345678", "Experience the excitement of teppanyaki dining at Tokyo Teppanyaki, where our skilled chefs entertain and delight you with their culinary prowess.", null, "Tokyo Teppanyaki", 3 },
                    { 15, "2012345678", "Journey into the world of wasabi at Wasabi Wonderland, where our bold flavors and creative sushi rolls will awaken your senses and transport you to a land of culinary adventure.", null, "Wasabi Wonderland", 3 },
                    { 16, "2112345678", "Spice up your life at Curry Corner, where our aromatic curries and flavorful Indian dishes will take your taste buds on a journey to the vibrant streets of India.", null, "Curry Corner", 3 },
                    { 17, "2212345678", "Experience the flavors of the tandoor at Tandoori Terrace, where our smoky grilled meats and tender breads will transport you to the bustling markets of Delhi.", null, "Tandoori Terrace", 3 },
                    { 18, "2312345678", "Savor the rich flavors of India with Biryani Bazaar, where our fragrant rice dishes and succulent meats are cooked to perfection and served with love.", null, "Biryani Bazaar", 3 },
                    { 19, "2412345678", "Experience the magic of Indian spices at Masala Magic, where our flavorful curries, aromatic biryanis, and decadent desserts will transport you to the colorful streets of Mumbai.", null, "Masala Magic", 3 },
                    { 20, "2512345678", "Find your nirvana at Naan Nirvana, where our soft and fluffy naan breads and savory accompaniments will elevate your dining experience to new heights.", null, "Naan Nirvana", 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ExtraDetails", "ImageURL", "Name", "Price", "RestaurantID" },
                values: new object[,]
                {
                    { 6, "Classic Italian pasta dish with creamy carbonara sauce, pancetta, and Parmesan cheese", null, "https://dummyjson.com/image/512x512/?text=Spaghetti+Carbonara", "Spaghetti Carbonara", 14.99, 2 },
                    { 7, "Homemade ravioli filled with ricotta cheese, served with a flavorful tomato sauce", null, "https://dummyjson.com/image/512x512/?text=Ravioli+al+Pomodoro", "Ravioli al Pomodoro", 16.989999999999998, 2 },
                    { 8, "Classic Italian dessert made with layers of coffee-soaked ladyfingers and mascarpone cheese, dusted with cocoa powder", null, "https://dummyjson.com/image/512x512/?text=Tiramisu", "Tiramisu", 8.9900000000000002, 2 },
                    { 9, "Fresh salad made with ripe tomatoes, mozzarella cheese, basil, and balsamic glaze", null, "https://dummyjson.com/image/512x512/?text=Caprese+Salad", "Caprese Salad", 9.9900000000000002, 2 },
                    { 10, "Creamy fettuccine pasta tossed in a rich Alfredo sauce made with butter, cream, and Parmesan cheese", null, "https://dummyjson.com/image/512x512/?text=Fettuccine+Alfredo", "Fettuccine Alfredo", 13.99, 2 },
                    { 11, "A supreme taco filled with seasoned beef, lettuce, cheese, tomatoes, and sour cream, served in a crispy corn shell", null, "https://dummyjson.com/image/512x512/?text=Taco+Supreme", "Taco Supreme", 3.9900000000000002, 6 },
                    { 12, "A hearty burrito filled with tender grilled chicken, rice, beans, cheese, and salsa, wrapped in a warm flour tortilla", null, "https://dummyjson.com/image/512x512/?text=Chicken+Burrito", "Chicken Burrito", 8.9900000000000002, 6 },
                    { 13, "A comforting bowl of chili made with ground beef, beans, tomatoes, and spices, topped with cheese and onions", null, "https://dummyjson.com/image/512x512/?text=Chili+Con+Carne", "Chili Con Carne", 6.9900000000000002, 6 },
                    { 14, "A cheesy quesadilla filled with melted cheese and your choice of chicken, beef, or vegetables, served with salsa and sour cream", null, "https://dummyjson.com/image/512x512/?text=Quesadilla", "Quesadilla", 7.9900000000000002, 6 },
                    { 15, "A supreme platter of nachos topped with seasoned beef, melted cheese, jalapenos, tomatoes, and sour cream, perfect for sharing", null, "https://dummyjson.com/image/512x512/?text=Nachos+Supreme", "Nachos Supreme", 10.99, 6 },
                    { 16, "An exquisite platter of assorted sushi, featuring a variety of nigiri and maki rolls made with fresh fish and seasoned rice", null, "https://dummyjson.com/image/512x512/?text=Sushi+Platter", "Sushi Platter", 24.989999999999998, 11 },
                    { 17, "A crispy tempura shrimp roll wrapped in seaweed and rice, served with soy sauce and wasabi for dipping", null, "https://dummyjson.com/image/512x512/?text=Tempura+Shrimp+Roll", "Tempura Shrimp Roll", 12.99, 11 },
                    { 18, "A delectable sampler of fresh sashimi slices, including tuna, salmon, and yellowtail, served with pickled ginger and wasabi", null, "https://dummyjson.com/image/512x512/?text=Sashimi+Sampler", "Sashimi Sampler", 18.989999999999998, 11 },
                    { 19, "A comforting bowl of udon noodles in a savory broth, topped with sliced green onions, tempura flakes, and a seasoned boiled egg", null, "https://dummyjson.com/image/512x512/?text=Udon+Noodle+Soup", "Udon Noodle Soup", 10.99, 11 },
                    { 20, "A traditional Japanese bento box featuring teriyaki chicken, steamed rice, vegetable tempura, and a side of miso soup", null, "https://dummyjson.com/image/512x512/?text=Teriyaki+Chicken+Bento+Box", "Teriyaki Chicken Bento Box", 16.989999999999998, 11 },
                    { 21, "Tender pieces of grilled chicken cooked in a creamy tomato-based sauce with aromatic Indian spices, served with basmati rice", null, "https://dummyjson.com/image/512x512/?text=Chicken+Tikka+Masala", "Chicken Tikka Masala", 14.99, 16 },
                    { 22, "Fragrant basmati rice cooked with mixed vegetables, herbs, and spices, served with raita and papadum", null, "https://dummyjson.com/image/512x512/?text=Vegetable+Biryani", "Vegetable Biryani", 12.99, 16 },
                    { 23, "Soft cubes of paneer cheese cooked in a rich and creamy tomato-based sauce, flavored with butter and aromatic spices, served with naan bread", null, "https://dummyjson.com/image/512x512/?text=Paneer+Butter+Masala", "Paneer Butter Masala", 13.99, 16 },
                    { 24, "Yellow lentils cooked with onions, tomatoes, garlic, and cumin seeds, tempered with ghee and garnished with fresh cilantro, served with rice or naan", null, "https://dummyjson.com/image/512x512/?text=Dal+Tadka", "Dal Tadka", 9.9900000000000002, 16 },
                    { 25, "Soft and spongy milk dumplings soaked in a sweet rose-flavored syrup, served warm and garnished with chopped pistachios", null, "https://dummyjson.com/image/512x512/?text=Gulab+Jamun", "Gulab Jamun", 6.9900000000000002, 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d4f1a2e-548e-4545-8c8f-f4a9d0224f2f", "AQAAAAIAAYagAAAAEPmkYuDzQLwSECRk45bR41vGeEPYFOdcWN2m2a88Mp3UdQBDbx6V44ailJqb1Fu2Ng==", "6d055753-d7a5-4539-9940-d0772bc62030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "802fc19f-d661-4889-843b-7d04bbe2a270", "AQAAAAIAAYagAAAAEHGo1cmqtmLNEjdEwXWhGNIOegAHUR+uGAL++QZV2GAhcPFweLqy+uxRbKWgf8HMkA==", "f9a32026-2a05-40a7-b65b-29a8b42850e5" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "ImageURL" },
                values: new object[] { "Italian Food Category 123", "https://i.ibb.co/PZ03P9S/pizza.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageURL",
                value: "https://i.ibb.co/PZ03P9S/pizza.png");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Roma Pizza for Italian Food!");
        }
    }
}
