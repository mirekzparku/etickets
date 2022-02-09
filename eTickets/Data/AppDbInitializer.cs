using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://images90.fotosik.pl/570/313e908d993d9b8egen.jpg",
                            Description = "Description 1"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://images91.fotosik.pl/570/6267cecc134ab80agen.jpg",
                            Description = "Description 2"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://images90.fotosik.pl/570/0139476debaf5af7gen.jpg",
                            Description = "Description 3"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://images89.fotosik.pl/571/26dcc0a07df0279egen.jpg",
                            Description = "Description 4"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://images89.fotosik.pl/571/9770379e76c0f964gen.jpg",
                            Description = "Description 5"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "Bio",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/2/2d/Witold_Kuncewicz.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "Bio",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/e/e5/Tadeusz_Szybowski_%28w_1973%29.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "Bio",
                            ProfilePictureURL = "https://sites.google.com/site/dlafilmowcow/_/rsrc/1467890762242/znani-i-najbardziej-cenieni-aktorzy/bogart.jpg?height=320&width=218"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "Biografia 4 aktora",
                            ProfilePictureURL = "https://img1.stylowi.pl/images/items/s/201403/stylowi_pl_film_humphrey-bogart_19561825.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "Bio",
                            ProfilePictureURL = "https://histmag.org/grafika/thumbs/montgomeryclif_500x666_thb_104066.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "Bio 1",
                            ProfilePictureURL = "https://images92.fotosik.pl/572/89422d403d83fca8gen.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "Bio 2",
                            ProfilePictureURL = "https://images89.fotosik.pl/571/67617975d9fa5804gen.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "Bio 3",
                            ProfilePictureURL = "https://images91.fotosik.pl/570/c70e8de290a011b8gen.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "Bio 4",
                            ProfilePictureURL = "https://images89.fotosik.pl/571/fe5f311ce71f42fbgen.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "Bio 5",
                            ProfilePictureURL = "https://images89.fotosik.pl/571/22ae241ac3d78d6bgen.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Pianista",
                            Description = "Description test",
                            Price = 39.50,
                            ImageURL = "https://images92.fotosik.pl/572/17a8b9f92dfd4a5f.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Piętro wyżej",
                            Description = "Description test",
                            Price = 29.50,
                            ImageURL = "https://images90.fotosik.pl/570/62d6e4cb6e445cf8gen.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Gadające głowy",
                            Description = "Description test",
                            Price = 39.50,
                            ImageURL = "https://images90.fotosik.pl/570/70b1730fd93c48f6.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Przesłuchanie",
                            Description = "Description test",
                            Price = 39.50,
                            ImageURL = "https://images91.fotosik.pl/570/60d91efe8dd42035gen.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Przypadek",
                            Description = "Description test",
                            Price = 39.50,
                            ImageURL = "https://images90.fotosik.pl/570/b9eed6f4809b707dgen.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Bogowie",
                            Description = "Description test",
                            Price = 39.50,
                            ImageURL = "https://images91.fotosik.pl/570/23f4bf525fd41a34.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
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
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
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


                string appUserEmail = "user@etickets.com";

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
