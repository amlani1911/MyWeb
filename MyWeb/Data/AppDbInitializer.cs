using Microsoft.AspNetCore.Identity;
using MyWeb.Data.Static;
using MyWeb.Models;
//using Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.EnableSensitiveDataLogging

namespace MyWeb.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Capacities.Any())
                {
                    context.Capacities.AddRange(new List<Capacity>()
                    {
                        new Capacity()
                        {
                            Cap = "1.5L"
                        },
                        new Capacity()
                        {
                            Cap = "2L"
                        },
                        new Capacity()
                        {
                            Cap = "3L"
                        },
                        new Capacity()
                        {
                            Cap = "4L"
                        },
                        new Capacity()
                        {
                            Cap = "5L"
                        },
                        new Capacity()
                        {
                            Cap = "7.5L"
                        },
                        new Capacity()
                        {
                            Cap = "10L"
                        },
                        new Capacity()
                        {
                            Cap = "12L"
                        },
                        new Capacity()
                        {
                            Cap = "16L"
                        },
                        new Capacity()
                        {
                            Cap = "20L"
                        },
                        new Capacity()
                        {
                            Cap = "2 Burners"
                        },
                        new Capacity()
                        {
                            Cap = "3 Burners"
                        },
                        new Capacity()
                        {
                            Cap = "4 Burners"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                        new Category()
                        {
                            CategoryName = "Pressure Cookers",
                            CategoryImageUrl = "/Images/image1.jpg"
                        },
                        new Category()
                        {
                            CategoryName = "Cooktops",
                            CategoryImageUrl = "~/Images/image2.jpg"
                        },
                        new Category()
                        {
                            CategoryName = "Cookware",
                            CategoryImageUrl = "~/Images/image3.jpg"
                        },
                        new Category()
                        {
                            CategoryName = "Kitchen Appliances",
                            CategoryImageUrl = "~/Images/image4.webp"
                        },
                        new Category()
                        {
                            CategoryName = "Home Solutions",
                            CategoryImageUrl = "~/Images/image5.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Products>()
                    {
                        //new Products()
                        //{
                        //    Sku_Code = 20192,
                        //    ProductName = "Prestige Svachh Popular Spillage Control Stainless Steel Pressure Cooker, (Silver)",
                        //    Price = "Rs. 1520.00",
                        //    ImageUrl = "~/Images/20192.webp",
                        //    Id = 1
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 20355,
                        //    ProductName = "Prestige Deluxe Plus Hard Anodised Handi Pressure Cooker (Black)",
                        //    Price = "Rs. 2170.00",
                        //    ImageUrl = "~/Images/20355.webp",
                        //    Id = 1
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 20167,
                        //    ProductName = "Prestige Svachh Flip-on Mini Hard Anodised Spillage Control Pressure Cooker with Glass Lid, (Black)",
                        //    Price = "Rs. 3610.00",
                        //    ImageUrl = "~/Images/20167.webp",
                        //    Id = 1
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 20160,
                        //    ProductName = "Prestige Svachh Flip-on Hard Anodised Gas and Induction Compatible Pressure Cooker with Glass Lid, (Black)",
                        //    Price = "Rs. 4170.00",
                        //    ImageUrl = "~/Images/20160.webp",
                        //    Id = 1
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 40398,
                        //    ProductName = "Prestige Magic Plus LP Gas Stove GTMP",
                        //    Price = "Rs. 2995.00",
                        //    ImageUrl = "~/Images/40398.webp",
                        //    Id = 42
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 40382,
                        //    ProductName = "Prestige Svachh Neo Toughened Glasstop Gas Stove with Liftable Burners (Black)",
                        //    Price = "Rs. 6180.00",
                        //    ImageUrl = "~/Images/40382.jpg",
                        //    Id = 42
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 40291,
                        //    ProductName = "Prestige Marvel Plus Toughened Glass Top Gas Stove",
                        //    Price = "Rs. 7895.00",
                        //    ImageUrl = "~/Images/40291.webp",
                        //    Id = 42
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 40376,
                        //    ProductName = "Prestige Atlas Duo Toughened Glass Gas Stove",
                        //    Price = "Rs. 5895.00",
                        //    ImageUrl = "~/Images/40376.webp",
                        //    Id = 42
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 41992,
                        //    ProductName = "PRESTIGE INDUCTION COOKTOP – XPRESS",
                        //    Price = "Rs. 2895.00",
                        //    ImageUrl = "~/Images/41992.webp",
                        //    Id = 42
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 41949,
                        //    ProductName = "Prestige PIC 16.0+ 1900W Induction Cooktop with Indian Menu Options (Black)",
                        //    Price = "Rs. 3436.00",
                        //    ImageUrl = "~/Images/41949.jpg",
                        //    Id = 42
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 37578,
                        //    ProductName = "Prestige Durastone Hard Anodised 6 Layer Non-Stick Kadai with Glass Lid (Black)",
                        //    Price = "Rs. 1720.00",
                        //    ImageUrl = "~/Images/37578.jpg",
                        //    Id = 3
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 30348,
                        //    ProductName = "Prestige Omega Select Plus 14 Pits Paniyarakkal with Lid (Aluminium, Non-stick)",
                        //    Price = "Rs. 1120.00",
                        //    ImageUrl = "~/Images/30348.webp",
                        //    Id = 3
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 37567,
                        //    ProductName = "Prestige Durastone Hard Anodised 6 Layer Non-Stick Omni Tawa, (Black)",
                        //    Price = "Rs. 1080.00",
                        //    ImageUrl = "~/Images/37567.webp",
                        //    Id = 3
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 41824,
                        //    ProductName = "Prestige Zara 900 Auto-clean Glass Kitchen Hood with Revolutionary Motion sensor, 1100m3/HR Suction",
                        //    Price = "Rs. 25410.00",
                        //    ImageUrl = "~/Images/41824.webp",
                        //    Id = 4
                        //},
                        //new Products()
                        //{
                        //    Sku_Code = 42533,
                        //    ProductName = "Prestige Zest 750 W Mixer Grinder, 3 Jars (1500 ml, 1000 ml, 400 ml) Red",
                        //    Price = "Rs. 3810.00",
                        //    ImageUrl = "~/Images/42533.webp",
                        //    Id = 4
                        //}
                        //new Products()
                        //{
                        //    Sku_Code = 41759,
                        //    ProductName = "Prestige PDI 03 750 W Dry Iron (Blue)",
                        //    Price = "Rs. 760.00",
                        //    ImageUrl = "~/Images/41759.webp",
                        //    Id = 42
                        //}
                    });
                    context.SaveChanges();
                }
                if (!context.Products_Capacities.Any())
                {
                    context.Products_Capacities.AddRange(new List<Products_Capacity>()
                    {
                        //new Products_Capacity()
                        //{
                        //    Sku_Code = 20192,
                        //    Capacity_Id = 1
                        //},
                        //new Products_Capacity()
                        //{
                        //    Sku_Code = 20192,
                        //    Capacity_Id = 2
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20192,
                        //    Capacity_Id = 3
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20355,
                        //    Capacity_Id = 1
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20355,
                        //    Capacity_Id = 2
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20355,
                        //    Capacity_Id = 3
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20355,
                        //    Capacity_Id = 4
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20167,
                        //    Capacity_Id = 1
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20167,
                        //    Capacity_Id = 2
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20167,
                        //    Capacity_Id = 5
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20167,
                        //    Capacity_Id = 9
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20160,
                        //    Capacity_Id = 4
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20160,
                        //    Capacity_Id = 6
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20160,
                        //    Capacity_Id = 7
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20160,
                        //    Capacity_Id = 8
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20160,
                        //    Capacity_Id = 10
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 20160,
                        //    Capacity_Id = 1
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 40398,
                        //    Capacity_Id = 11
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 40398,
                        //    Capacity_Id = 12
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 40398,
                        //    Capacity_Id = 13
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 40382,
                        //    Capacity_Id = 11
                        //},
                        //new Products_Capacity()
                        //{
                        //    Sku_Code = 40382,
                        //    Capacity_Id = 12
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 40291,
                        //    Capacity_Id = 13
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 40376,
                        //    Capacity_Id = 11
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 40376,
                        //    Capacity_Id = 12
                        //},new Products_Capacity()
                        //{
                        //    Sku_Code = 40376,
                        //    Capacity_Id = 13
                        //}
                    });
                    context.SaveChanges();
                }
            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@myweb.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@myweb.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
