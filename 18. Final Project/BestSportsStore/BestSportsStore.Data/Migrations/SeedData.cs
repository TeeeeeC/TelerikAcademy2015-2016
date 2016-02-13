namespace BestSportsStore.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;
    
    public class SeedData
    {
        private const string AdminRoleName = "Administator";
        private const string UserName = "user";
        private const string Password = "123456";

        private BestSportsStoreDbContext context;
        private PasswordHasher passwordHasher;

        public SeedData()
        {
            this.context = new BestSportsStoreDbContext();
            this.passwordHasher = new PasswordHasher();
        }

        public void Seed()
        {
            //this.AddAdmin("Admin", "admina");
            //this.AddUsers(5);
            //this.AddCategoriesAndSubCategories();
            //this.AddSports();
            //this.AddBrands();
            //this.AddSizes();
            //this.AddProducts();
            this.AddLikes();
        }

        private void AddAdmin(string username, string password)
        {
            this.context.Roles.Add(new IdentityRole { Name = AdminRoleName });

            var hash = this.passwordHasher.HashPassword(password);
            context.Users.Add(new User
            {
                UserName = username,
                PasswordHash = hash,
                SecurityStamp = Guid.NewGuid().ToString()
            });

            this.context.SaveChanges();

            var role = this.context.Roles.FirstOrDefault(r => r.Name == AdminRoleName);
            var admin = this.context.Users.FirstOrDefault(u => u.UserName == username);

            admin.Roles.Add(new IdentityUserRole { RoleId = role.Id });

            this.context.SaveChanges();
        }

        private void AddUsers(int usersCount)
        {
            for (int i = 1; i <= usersCount; i++)
            {
                var user = new User()
                {
                    UserName = UserName + i,
                    PasswordHash = this.passwordHasher.HashPassword(Password),
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                this.context.Users.Add(user);
            }

            this.context.SaveChanges();
        }

        private void AddCategoriesAndSubCategories()
        {
            var categoriesName = new List<string> { "Mens", "Ladies", "Kids", "Footwear", "Clothing" };

            for (int i = 0; i < 3; i++)
            {
                this.context.Categories.Add(new Category
                {
                    Name = categoriesName[i]
                });
            }

            for (int i = 3; i < 5; i++)
            {
                this.context.SubCategories.Add(new SubCategory
                {
                    Name = categoriesName[i]
                });
            }

            this.context.SaveChanges();

            var categories = this.context.Categories.ToList();
            var subCategories = this.context.SubCategories.ToList();

            for (int i = 0; i < categories.Count; i++)
            {
                for (int j = 0; j < subCategories.Count; j++)
                {
                    categories[i].SubCategories.Add(subCategories[j]);
                }
            }

            this.context.SaveChanges();
        }

        private void AddSports()
        {
            var sports = new List<string> { "Football", "Fitness", "Cycling", "Aerobics", "Running" };

            for (int i = 0; i < sports.Count; i++)
            {
                this.context.Sports.Add(new Sport
                {
                    Name = sports[i]
                });
            }

            this.context.SaveChanges();
        }

        private void AddBrands()
        {
            var brands = new List<string> { "Adidas", "Nike", "Puma" };
            var imagesUrls = new List<string>
            {
                "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQIZ5tGRgWooAlXW5PE13vUpxCZEFct5Ak2YqF5rpsytfJZY_Y8uY0aFEtd",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ2QCgRxSseb1J5VtLuQOqlvxIP_L-mSHmW5kB4H_Zi6pfKFTMt4l7WsA",
                "http://usport.bg/img/cms/Puma-Logo.jpg"
            };

            for (int i = 0; i < brands.Count; i++)
            {
                this.context.Brands.Add(new Brand
                {
                    Name = brands[i],
                    ImageUrl = imagesUrls[i]
                });
            }

            this.context.SaveChanges();
        }

        private void AddSizes()
        {
            for (short i = 17; i < 100; i++)
            {
                this.context.Sizes.Add(new Size
                {
                     Value = i
                });
            }

            this.context.SaveChanges();
        }

        private void AddProducts()
        {
            var categories = this.context.Categories.ToList();
            var subCategories = this.context.SubCategories.ToList();
            var brands = this.context.Brands.ToList();
            var sports = this.context.Sports.ToList();

            var sizes = this.context.Sizes.Where(s => s.Value > 41 && s.Value < 47).ToList();
            var footballUrl = new List<string>()
            {
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFVdpu-29Awn2Y5c-bsXsuuLigf_RthDAEG8rCfl_qUZhlBvZp",
                "http://images.soccerscene.co.uk/images/imgzoom/20/20116124_xxl.jpg",
                "http://2.bp.blogspot.com/-zRjUYtk5EFc/U8ObV5wGKmI/AAAAAAAATsA/jcsk-_tg_Qs/s1600/Puma-evoSPEED-1-3-2014-15+(2).jpg",
                "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRYH0AF-Ic59ro7W8v_RN40PZMY951_yzH23CreLYZDus0WbeU-eQ",
                "http://blog.fieldoo.com/wp-content/uploads/2013/08/Nike-Mercurial-Victory-III-Firm-Ground-Football-Boots-Blue-Orange.jpg"
            };
            for (int i = 0; i < 5; i++)
            {
                var product = new Product()
                {
                    Title = "Mens Boots 11 Pro SG " + i,
                    Content = "These Mens Football Boots benefit from a mixture of removable and moulded studs for increased traction and support on soft ground and the lightly textured upper for increased control over the ball " + i,
                    ImageUrl = footballUrl[i],
                    Price = 15 + (i * 2),
                    Brand = brands[i % brands.Count],
                    Sizes = sizes,
                    SubCategory = subCategories[0],
                    Category = categories[0],
                    Sport = sports[0]
                };

                this.context.Products.Add(product);
            }

            sizes = this.context.Sizes.Where(s => s.Value > 56 && s.Value < 62).ToList();
            var fitnesUrl = new List<string>()
            {
                "http://www.mensfitness.com/sites/mensfitness.com/files/styles/photo_gallery_full/public/sequencials-half-zip-top.jpg?itok=nr_0g4VE",
                "http://cdn.iofferphoto.com/img/item/606/655/428/o_nike-men-women-outdoor-sports-hoodie-jackets-outerwears-0b93.jpg",
                "http://pumaecom.scene7.com/is/image/PUMAECOM/513166_01_01_EEA?$PUMA_GRID$",
                "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSNIvWElHf8WHu-BA78D6kcHaXrEc0v9xONXoGsR-xPBSrrH7rl",
                "http://i.ebayimg.com/00/z/GzcAAOxydyxSQFuI/$(KGrHqZHJBwFIuZWZb98BSQFuIDTz!~~_32.JPG"
            };
            for (int i = 0; i < 5; i++)
            {
                var product = new Product()
                {
                    Title = "Mens Clothing " + i,
                    Content = "This mens jacket is a perfect choice if you are wanting to be seen while out running, with its bright bold neon colouring and reflective safety strip material you are guaranteed to do seen. " + i,
                    ImageUrl = fitnesUrl[i],
                    Price = 25 + (i * 2),
                    Brand = brands[i % brands.Count],
                    Sizes = sizes,
                    SubCategory = subCategories[1],
                    Category = categories[0],
                    Sport = sports[1]
                };

                this.context.Products.Add(product);
            }

            sizes = this.context.Sizes.Where(s => s.Value > 35 && s.Value < 41).ToList();
            var cyclingUrl = new List<string>()
            {
                "http://c12010671.r71.cf2.rackcdn.com/f54090e7-42cc-4ff5-ab51-8dbb8b4f7502__L.jpg",
                "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSLw5UEPKTLuNPKHXtr7JB1F1dqqr6cZbnKsywkGl-eBOVnljJfBg",
                "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcR_Iuf0kNt2jFxtFp4wBKUuKxGLy7yHDS-udv5AHipqJZCMnu99pw",
                "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTfRn38meYt0r90nrUTZif5eKEGjSaYIwMum1y9RuWTPjPx_CQ0",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwopIXDb3NVUY-xPSqDhNTY_YywiFJ280-iMZhh_IeQ2V6Rg3nIA"
            };
            for (int i = 0; i < 5; i++)
            {
                var product = new Product()
                {
                    Title = "Ladies Boots ... " + i,
                    Content = "This mens jacket is a perfect choice if you are wanting to be seen while out running, with its bright bold neon colouring and reflective safety strip material you are guaranteed to do seen. " + i,
                    ImageUrl = cyclingUrl[i],
                    Price = 8 + (i * 2),
                    Brand = brands[i % brands.Count],
                    Sizes = sizes,
                    SubCategory = subCategories[0],
                    Category = categories[1],
                    Sport = sports[2]
                };

                this.context.Products.Add(product);
            }

            sizes = this.context.Sizes.Where(s => s.Value > 35 && s.Value < 41).ToList();
            var aerobicUrl = new List<string>()
            {
                "http://images.sportsdirect.com/images/imgzoom/67/67128002_xxl.jpg",
                "http://images.sportsdirect.com/images/imgzoom/34/34706203_xxl.jpg",
                "http://i.ebayimg.com/00/s/NDMyWDIzNw==/z/FjcAAOxyRhBSyJGE/$_35.JPG?set_id=2",
                "https://s-media-cache-ak0.pinimg.com/236x/fa/2c/c6/fa2cc662e642adc1ac34142406fbd368.jpg",
                "https://s-media-cache-ak0.pinimg.com/236x/63/90/91/639091c932c2f5a950f4d01aaed1e0be.jpg"
            };
            for (int i = 0; i < 5; i++)
            {
                var product = new Product()
                {
                    Title = "Ladies Clothing ... " + i,
                    Content = "These Pro leggings also come with a single zipped pocket to the rear and are finished off with printed detail to the bottom left leg and the Pro printed to the top left hip " + i,
                    ImageUrl = aerobicUrl[i],
                    Price = 20 + (i * 2),
                    Brand = brands[i % brands.Count],
                    Sizes = sizes,
                    SubCategory = subCategories[1],
                    Category = categories[1],
                    Sport = sports[3]
                };

                this.context.Products.Add(product);
            }

            sizes = this.context.Sizes.Where(s => s.Value > 15 && s.Value < 21).ToList();
            var runnigUrl = new List<string>()
            {
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2_yhdpkwZ-KsBYBH0oBFS5d1KyZfeh1a7HNviSzw1XmYvSYs06w",
                "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTCF4Mcxif4RsL81TsTjm9a1ZI5G9oqYg6ybL0Bw1CJP5Qwdl2GXQ",
                "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRWP5RvwU-H-kG4mKRdlx4brscWLMnrBjx3D4e1b_JRdJrpPcl4",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTPkXZ_G1iLFOZhFCzlYwRXIOTlC8wJBJlKX4CfKroY8HpKOguD",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLe_jh1k-5MsEX49j2gKoj1APoQ3XOgGi5kzu6bt3fAt9uJUvp"
            };
            for (int i = 0; i < 5; i++)
            {
                var product = new Product()
                {
                    Title = "Kids Boots ... " + i,
                    Content = "A lightweight mesh upper allows air to flow and the foot to breath, with supportive synthetic overlays for improved foot comfort " + i,
                    ImageUrl = runnigUrl[i],
                    Price = 3 + (i * 2),
                    Brand = brands[i % brands.Count],
                    Sizes = sizes,
                    SubCategory = subCategories[0],
                    Category = categories[2],
                    Sport = sports[4],
                };

                this.context.Products.Add(product);
            }

            this.context.SaveChanges();
        }

        private void AddLikes()
        {
            var users = this.context.Users.ToList();
            var products = this.context.Products.Take(6).ToList();

            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < users.Count - i; j++)
                {
                    products[i].Likes.Add(new Like()
                    {
                        IsLiked = true,
                        User = users[j]
                    });
                }
            }

            this.context.SaveChanges();
        }
    }
}
