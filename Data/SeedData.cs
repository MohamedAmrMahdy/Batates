using Batates.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;

namespace Batates.Data
{
    public static class SeedData
    {
        //static Category C1 = new Category() { ID = 1, Name = "Italian", Description = "Indulge in the rich flavors and culinary heritage of Italy with our authentic Italian cuisine, where every dish is crafted with passion and tradition to transport you to the sun-kissed hills of Tuscany and the bustling streets of Naples.", ImageURL = "https://dummyjson.com/image/512x512/?text=Italian" };
        //static Category C2 = new Category() { ID = 2, Name = "Mexican", Description = "Experience the vibrant and spicy flavors of Mexico with our tantalizing Mexican cuisine, from sizzling fajitas to mouthwatering tacos, guaranteed to ignite your taste buds with every bite.", ImageURL = "https://dummyjson.com/image/512x512/?text=Mexican" };
        //static Category C3 = new Category() { ID = 3, Name = "Japanese", Description = "Embark on a culinary journey to Japan with our exquisite Japanese cuisine, where tradition meets innovation in every carefully crafted sushi roll, flavorful ramen bowl, and delicate tempura dish.", ImageURL = "https://dummyjson.com/image/512x512/?text=Japanese" };
        //static Category C4 = new Category() { ID = 4, Name = "Indian", Description = "Delight your senses with the aromatic spices and diverse flavors of India through our authentic Indian cuisine, featuring savory curries, aromatic biryanis, and decadent desserts that will transport you to the bustling streets of Mumbai and the serene backwaters of Kerala.", ImageURL = "https://dummyjson.com/image/512x512/?text=Indian" };

        public static List<Category> CategoryList()
        {
            List<Category> tempList = new List<Category>()
            {
                new Category() { ID = 1, Name = "Italian", Description = "Indulge in the rich flavors and culinary heritage of Italy with our authentic Italian cuisine, where every dish is crafted with passion and tradition to transport you to the sun-kissed hills of Tuscany and the bustling streets of Naples.", ImageURL = "https://dummyjson.com/image/512x512/?text=Italian" },
                new Category() { ID = 2, Name = "Mexican", Description = "Experience the vibrant and spicy flavors of Mexico with our tantalizing Mexican cuisine, from sizzling fajitas to mouthwatering tacos, guaranteed to ignite your taste buds with every bite.", ImageURL = "https://dummyjson.com/image/512x512/?text=Mexican" },
                new Category() { ID = 3, Name = "Japanese", Description = "Embark on a culinary journey to Japan with our exquisite Japanese cuisine, where tradition meets innovation in every carefully crafted sushi roll, flavorful ramen bowl, and delicate tempura dish.", ImageURL = "https://dummyjson.com/image/512x512/?text=Japanese" },
                new Category() { ID = 4, Name = "Indian", Description = "Delight your senses with the aromatic spices and diverse flavors of India through our authentic Indian cuisine, featuring savory curries, aromatic biryanis, and decadent desserts that will transport you to the bustling streets of Mumbai and the serene backwaters of Kerala.", ImageURL = "https://dummyjson.com/image/512x512/?text=Indian" },
            };

            return tempList;
        }
        public static List<Restaurant> RestaurantList()
        {
            List<Restaurant> tempList = new List<Restaurant>() 
            {
                // Italian
                new Restaurant() { ID = 1, Name = "RomaPizza", Description = "Our mission is to uphold the highest level of quality in all we do, from the quality and origin of our food to our care for the health of our customers and the environment.", State = State.Opened, ContactNo = "0114379314", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 2, Name = "Taste of Italy", Description = "Experience the authentic flavors of Italy with our handcrafted pizzas, pasta, and mouthwatering desserts, served with a touch of Italian hospitality.", State = State.Opened, ContactNo = "0215896347", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 3, Name = "El Taco Loco", Description = "Get ready for a fiesta of flavors with our bold and delicious Mexican cuisine, featuring tacos, burritos, and sizzling fajitas that will transport you south of the border.", State = State.Opened, ContactNo = "0317269854", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 4, Name = "Sushi Zen", Description = "Discover the art of sushi at Sushi Zen, where our skilled chefs combine fresh ingredients with precision and technique to create sushi rolls that are as beautiful as they are delicious.", State = State.Opened, ContactNo = "0413785621", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 5, Name = "Spice Route", Description = "Embark on a culinary journey through the flavors of India at Spice Route, where our aromatic spices and authentic recipes will tantalize your taste buds and transport you to the streets of Mumbai.", State = State.Opened, ContactNo = "0518932746", locationLat = 0, locationLong = 0 },

                new Restaurant() {ID = 6, Name = "Taco Tango", Description = "Dance your taste buds to the rhythm of Mexico with Taco Tango, where our bold flavors and festive atmosphere will spice up your dining experience.", State = State.Opened, ContactNo = "1112345678", locationLat = 0, locationLong = 0},
                new Restaurant() { ID = 7, Name = "Burrito Bar", Description = "Wrap yourself in flavor with Burrito Bar, where our customizable burritos and fresh ingredients will satisfy your cravings for authentic Mexican cuisine.", State = State.Opened, ContactNo = "1212345678" , locationLat = 0, locationLong = 0},
                new Restaurant() { ID = 8, Name = "Fiesta Grill", Description = "Join the fiesta at Fiesta Grill, where our sizzling fajitas, flavorful tacos, and refreshing margaritas will transport you straight to the heart of Mexico.", State = State.Opened, ContactNo = "1312345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 9, Name = "Cantina Caliente", Description = "Heat up your night at Cantina Caliente, where our spicy dishes and lively atmosphere will make every meal feel like a celebration.", State = State.Opened, ContactNo = "1412345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 10, Name = "Salsa Street", Description = "Take a trip down Salsa Street for a taste of authentic Mexican street food, where our vibrant flavors and casual setting will keep you coming back for more.", State = State.Opened, ContactNo = "1512345678", locationLat = 0, locationLong = 0 },

                new Restaurant() { ID = 11, Name = "Sushi Supreme", Description = "Experience sushi perfection at Sushi Supreme, where our expert chefs use only the freshest ingredients to create sushi rolls that are as beautiful as they are delicious.", State = State.Opened, ContactNo = "1612345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 12, Name = "Sakura Sushi Bar", Description = "Find your zen at Sakura Sushi Bar, where our serene ambiance and exquisite sushi creations will transport you to the tranquil gardens of Japan.", State = State.Opened, ContactNo = "1712345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 13, Name = "Ninja Noodles", Description = "Unleash your inner ninja at Ninja Noodles, where our bold flavors and innovative noodle dishes will satisfy your cravings for authentic Japanese cuisine.", State = State.Opened, ContactNo = "1812345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 14, Name = "Tokyo Teppanyaki", Description = "Experience the excitement of teppanyaki dining at Tokyo Teppanyaki, where our skilled chefs entertain and delight you with their culinary prowess.", State = State.Opened, ContactNo = "1912345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 15, Name = "Wasabi Wonderland", Description = "Journey into the world of wasabi at Wasabi Wonderland, where our bold flavors and creative sushi rolls will awaken your senses and transport you to a land of culinary adventure.", State = State.Opened, ContactNo = "2012345678", locationLat = 0, locationLong = 0 },

                new Restaurant() { ID = 16, Name = "Curry Corner", Description = "Spice up your life at Curry Corner, where our aromatic curries and flavorful Indian dishes will take your taste buds on a journey to the vibrant streets of India.", State = State.Opened, ContactNo = "2112345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 17, Name = "Tandoori Terrace", Description = "Experience the flavors of the tandoor at Tandoori Terrace, where our smoky grilled meats and tender breads will transport you to the bustling markets of Delhi.", State = State.Opened, ContactNo = "2212345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 18, Name = "Biryani Bazaar", Description = "Savor the rich flavors of India with Biryani Bazaar, where our fragrant rice dishes and succulent meats are cooked to perfection and served with love.", State = State.Opened, ContactNo = "2312345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 19, Name = "Masala Magic", Description = "Experience the magic of Indian spices at Masala Magic, where our flavorful curries, aromatic biryanis, and decadent desserts will transport you to the colorful streets of Mumbai.", State = State.Opened, ContactNo = "2412345678", locationLat = 0, locationLong = 0 },
                new Restaurant() { ID = 20, Name = "Naan Nirvana", Description = "Find your nirvana at Naan Nirvana, where our soft and fluffy naan breads and savory accompaniments will elevate your dining experience to new heights.", State = State.Opened, ContactNo = "2512345678", locationLat = 0, locationLong = 0 },
            };

            return tempList;
        }
        public static List<Product> ProductsList()
        {
            List<Product> tempList = new List<Product>()
            {
                new Product() { ID = 1, Name = "One Pizza Slice", Description = "Best Pizza slice in the world", Price = 9.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Pizza+Slice", RestaurantID = 1 },
                new Product() { ID = 2, Name = "One Pizza", Description = "Best Entire Pizza in the world", Price = 9.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Entire+Pizza", RestaurantID = 1 },
                new Product() { ID = 3, Name = "Vegetarian Pizza", Description = "A delicious vegetarian pizza", Price = 11.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Vegetarian+Pizza", RestaurantID = 1 },
                new Product() { ID = 4, Name = "Pepperoni Pizza", Description = "Classic pepperoni pizza", Price = 12.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Pepperoni+Pizza", RestaurantID = 1 },
                new Product() { ID = 5, Name = "Margherita Pizza", Description = "Traditional margherita pizza", Price = 10.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Margherita+Pizza", RestaurantID = 1 },

                new Product() { ID = 6, Name = "Spaghetti Carbonara", Description = "Classic Italian pasta dish with creamy carbonara sauce, pancetta, and Parmesan cheese", Price = 14.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Spaghetti+Carbonara", RestaurantID = 2 },
                new Product() { ID = 7, Name = "Ravioli al Pomodoro", Description = "Homemade ravioli filled with ricotta cheese, served with a flavorful tomato sauce", Price = 16.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Ravioli+al+Pomodoro", RestaurantID = 2 },
                new Product() { ID = 8, Name = "Tiramisu", Description = "Classic Italian dessert made with layers of coffee-soaked ladyfingers and mascarpone cheese, dusted with cocoa powder", Price = 8.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Tiramisu", RestaurantID = 2 },
                new Product() { ID = 9, Name = "Caprese Salad", Description = "Fresh salad made with ripe tomatoes, mozzarella cheese, basil, and balsamic glaze", Price = 9.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Caprese+Salad", RestaurantID = 2 },
                new Product() { ID = 10, Name = "Fettuccine Alfredo", Description = "Creamy fettuccine pasta tossed in a rich Alfredo sauce made with butter, cream, and Parmesan cheese", Price = 13.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Fettuccine+Alfredo", RestaurantID = 2 },

                new Product() { ID = 11, Name = "Taco Supreme", Description = "A supreme taco filled with seasoned beef, lettuce, cheese, tomatoes, and sour cream, served in a crispy corn shell", Price = 3.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Taco+Supreme", RestaurantID = 6 },
                new Product() { ID = 12, Name = "Chicken Burrito", Description = "A hearty burrito filled with tender grilled chicken, rice, beans, cheese, and salsa, wrapped in a warm flour tortilla", Price = 8.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Chicken+Burrito", RestaurantID = 6 },
                new Product() { ID = 13, Name = "Chili Con Carne", Description = "A comforting bowl of chili made with ground beef, beans, tomatoes, and spices, topped with cheese and onions", Price = 6.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Chili+Con+Carne", RestaurantID = 6 },
                new Product() { ID = 14, Name = "Quesadilla", Description = "A cheesy quesadilla filled with melted cheese and your choice of chicken, beef, or vegetables, served with salsa and sour cream", Price = 7.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Quesadilla", RestaurantID = 6 },
                new Product() { ID = 15, Name = "Nachos Supreme", Description = "A supreme platter of nachos topped with seasoned beef, melted cheese, jalapenos, tomatoes, and sour cream, perfect for sharing", Price = 10.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Nachos+Supreme", RestaurantID = 6 },

                new Product() { ID = 16, Name = "Sushi Platter", Description = "An exquisite platter of assorted sushi, featuring a variety of nigiri and maki rolls made with fresh fish and seasoned rice", Price = 24.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Sushi+Platter", RestaurantID = 11 },
                new Product() { ID = 17, Name = "Tempura Shrimp Roll", Description = "A crispy tempura shrimp roll wrapped in seaweed and rice, served with soy sauce and wasabi for dipping", Price = 12.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Tempura+Shrimp+Roll", RestaurantID = 11 },
                new Product() { ID = 18, Name = "Sashimi Sampler", Description = "A delectable sampler of fresh sashimi slices, including tuna, salmon, and yellowtail, served with pickled ginger and wasabi", Price = 18.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Sashimi+Sampler", RestaurantID = 11 },
                new Product() { ID = 19, Name = "Udon Noodle Soup", Description = "A comforting bowl of udon noodles in a savory broth, topped with sliced green onions, tempura flakes, and a seasoned boiled egg", Price = 10.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Udon+Noodle+Soup", RestaurantID = 11 },
                new Product() { ID = 20, Name = "Teriyaki Chicken Bento Box", Description = "A traditional Japanese bento box featuring teriyaki chicken, steamed rice, vegetable tempura, and a side of miso soup", Price = 16.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Teriyaki+Chicken+Bento+Box", RestaurantID = 11 },

                new Product() { ID = 21, Name = "Chicken Tikka Masala", Description = "Tender pieces of grilled chicken cooked in a creamy tomato-based sauce with aromatic Indian spices, served with basmati rice", Price = 14.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Chicken+Tikka+Masala", RestaurantID = 16 },
                new Product() { ID = 22, Name = "Vegetable Biryani", Description = "Fragrant basmati rice cooked with mixed vegetables, herbs, and spices, served with raita and papadum", Price = 12.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Vegetable+Biryani", RestaurantID = 16 },
                new Product() { ID = 23, Name = "Paneer Butter Masala", Description = "Soft cubes of paneer cheese cooked in a rich and creamy tomato-based sauce, flavored with butter and aromatic spices, served with naan bread", Price = 13.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Paneer+Butter+Masala", RestaurantID = 16 },
                new Product() { ID = 24, Name = "Dal Tadka", Description = "Yellow lentils cooked with onions, tomatoes, garlic, and cumin seeds, tempered with ghee and garnished with fresh cilantro, served with rice or naan", Price = 9.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Dal+Tadka", RestaurantID = 16 },
                new Product() { ID = 25, Name = "Gulab Jamun", Description = "Soft and spongy milk dumplings soaked in a sweet rose-flavored syrup, served warm and garnished with chopped pistachios", Price = 6.99, ImageURL = "https://dummyjson.com/image/512x512/?text=Gulab+Jamun", RestaurantID = 16 },

            };

            return tempList;
        }

        public static List<ApplicationUser> UsersList()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            List<ApplicationUser> tempList = new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    UserName = "admin@batates.com",
                    NormalizedUserName = "admin@batates".ToUpper(),
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    Email = "admin@batates.com",
                    NormalizedEmail = "admin@batates.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123@Abc")
                },
                new ApplicationUser()
                {
                    UserName = "customer@batates.com",
                    NormalizedUserName = "customer@batates".ToUpper(),
                    Id = "2097f2ca-02a2-4b4f-97a0-1a7679151295",
                    Email = "customer@batates.com",
                    NormalizedEmail = "customer@batates.com".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123@Abc")
                }
            };

            return tempList;
        }

        public static List<IdentityRole> RoleList()
        {
            List<IdentityRole> tempList = new List<IdentityRole>()
            {
                new IdentityRole() { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = SD.Role_Admin, NormalizedName = SD.Role_Admin.ToUpper() },
                new IdentityRole() { Id = "d3c902cf-6b3e-4f66-9b82-c6a18a4ffa13", Name = SD.Role_Customer, NormalizedName = SD.Role_Customer.ToUpper() }
            };

            return tempList;
        }

        public static List<IdentityUserRole<string>> UserRoleList()
        {
            List<IdentityUserRole<string>> tempList = new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>()
                { RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210", UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                new IdentityUserRole<string>()
                { RoleId = "d3c902cf-6b3e-4f66-9b82-c6a18a4ffa13", UserId = "2097f2ca-02a2-4b4f-97a0-1a7679151295" }
            };

            return tempList;
        }

        //public static List<Order> OrderList()
        //{
        //    List<Order> tempList = new List<Order>()
        //    {

        //    };
        //}
    }

    //public class Seeding2
    //{
    //    Category C1 { get; set; } = new Category() { ID = 1, Name = "Italian", Description = "Indulge in the rich flavors and culinary heritage of Italy with our authentic Italian cuisine, where every dish is crafted with passion and tradition to transport you to the sun-kissed hills of Tuscany and the bustling streets of Naples.", ImageURL = "https://dummyjson.com/image/512x512/?text=Italian" };
    //    Category C2 { get; set; } = new Category() { ID = 2, Name = "Mexican", Description = "Experience the vibrant and spicy flavors of Mexico with our tantalizing Mexican cuisine, from sizzling fajitas to mouthwatering tacos, guaranteed to ignite your taste buds with every bite.", ImageURL = "https://dummyjson.com/image/512x512/?text=Mexican" };
    //    Category C3 { get; set; } = new Category() { ID = 3, Name = "Japanese", Description = "Embark on a culinary journey to Japan with our exquisite Japanese cuisine, where tradition meets innovation in every carefully crafted sushi roll, flavorful ramen bowl, and delicate tempura dish.", ImageURL = "https://dummyjson.com/image/512x512/?text=Japanese" };
    //    Category C4 { get; set; } = new Category() { ID = 4, Name = "Indian", Description = "Delight your senses with the aromatic spices and diverse flavors of India through our authentic Indian cuisine, featuring savory curries, aromatic biryanis, and decadent desserts that will transport you to the bustling streets of Mumbai and the serene backwaters of Kerala.", ImageURL = "https://dummyjson.com/image/512x512/?text=Indian" };

    //    public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
    //    Restaurant R1 { get; set; } = new Restaurant() { ID = 1, Name = "RomaPizza", Description = "Our mission is to uphold the highest level of quality in all we do, from the quality and origin of our food to our care for the health of our customers and the environment.", State = State.Opened, ContactNo = "0114379314" };
    //    Restaurant R2 { get; set; } = new Restaurant() { ID = 2, Name = "Taste of Italy", Description = "Experience the authentic flavors of Italy with our handcrafted pizzas, pasta, and mouthwatering desserts, served with a touch of Italian hospitality.", State = State.Opened, ContactNo = "0215896347" };
    //    Restaurant R3 { get; set; } = new Restaurant() { ID = 3, Name = "El Taco Loco", Description = "Get ready for a fiesta of flavors with our bold and delicious Mexican cuisine, featuring tacos, burritos, and sizzling fajitas that will transport you south of the border.", State = State.Opened, ContactNo = "0317269854" };
    //    Restaurant R4 { get; set; } = new Restaurant() { ID = 4, Name = "Sushi Zen", Description = "Discover the art of sushi at Sushi Zen, where our skilled chefs combine fresh ingredients with precision and technique to create sushi rolls that are as beautiful as they are delicious.", State = State.Opened, ContactNo = "0413785621" };
    //    Restaurant R5 { get; set; } = new Restaurant() { ID = 5, Name = "Spice Route", Description = "Embark on a culinary journey through the flavors of India at Spice Route, where our aromatic spices and authentic recipes will tantalize your taste buds and transport you to the streets of Mumbai.", State = State.Opened, ContactNo = "0518932746" };

    //    public Seeding2()
    //    {
    //        R1.Categories.Add(C1);
    //        R1.Categories.Add(C2);
    //        Restaurants.Add(R1);
    //        Restaurants.Add(R2);
    //    }
    //}
}
