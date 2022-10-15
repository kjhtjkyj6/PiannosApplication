using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PiannosApplication.Data;
using System;
using System.Linq;

namespace PiannosApplication.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PiannosApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PiannosApplicationContext>>()))
            {
                // Look for any movies.
                if (context.Piannos.Any())
                {
                    return;   // DB has been seeded
                }

                context.Piannos.AddRange(
                    new Piannos
                    {
                        Company = "Cargo",
                        Type = "Electric",
                        Color = "Dark Brown",
                        Price = 7.99M,
                        WireType= "Copper Wire",
                        CustomerReview=3
                        
                    },

                    new Piannos
                    {
                        Company = "TJX",
                        Type = "Manual",
                        Color = "Brown",
                        Price = 4.99M,
                        WireType = "Metal Wire",
                        CustomerReview = 4
                    },

                    new Piannos
                    {
                        Company = "Esx",
                        Type = "Electric",
                        Color = "Red",
                        Price = 6.99M,
                        WireType = "Copper Wire",
                        CustomerReview = 5
                    },

                    new Piannos
                    {
                        Company = "WET",
                        Type = "Manual",
                        Color = "White",
                        Price = 2.5M,
                        WireType = "Metal Wire",
                        CustomerReview = 3
                    },
                    new Piannos
                    {
                        Company = "Boston",
                        Type = "Electric",
                        Color = "Pink",
                        Price = 6.99M,
                        WireType = "Copper Wire",
                        CustomerReview = 1
                    },
                     new Piannos
                     {
                         Company = "Essex",
                         Type = "Manual",
                         Color = "Grey",
                         Price = 4.99M,
                         WireType = "Metal  Wire",
                         CustomerReview = 5
                     },
                     new Piannos
                     {
                         Company = "Lester",
                         Type = "Electric",
                         Color = "Blue",
                         Price = 1.99M,
                         WireType = "Copper Wire",
                         CustomerReview = 2
                     },
                     new Piannos
                     {
                         Company = "Boss",
                         Type = "Manual",
                         Color = "Yellow",
                         Price = 2.9M,
                         WireType = "Copper Wire",
                         CustomerReview = 3
                     },
                     new Piannos
                     {
                         Company = "Ohio",
                         Type = "Electric",
                         Color = "Green",
                         Price = 8.9M,
                         WireType = "Metal Wire",
                         CustomerReview = 3
                     },
                     new Piannos
                     {
                         Company = "Roland",
                         Type = "Manual",
                         Color = "Pink",
                         Price = 3.1M,
                         WireType = "Copper Wire",
                         CustomerReview = 4
                     }
                );
                context.SaveChanges();
            }
        }
    }
}