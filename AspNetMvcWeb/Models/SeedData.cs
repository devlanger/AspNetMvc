using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AspNetMvcWeb.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcProjectContext>>()))
            {
                // Look for any movies.
                if (context.Project.Any())
                {
                    return;   // DB has been seeded
                }

                context.Project.AddRange(
                    new Project
                    {
                        Name = "Arnmoire",
                        Description = "Dark Fantasy MMO",
                        Category = 1,
                        Rating = "1",
                    },

                    new Project
                    {
                        Name = "Shinobi Clash",
                        Description = "Ninja MMO",
                        Category = 2,
                        Rating = "2",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}