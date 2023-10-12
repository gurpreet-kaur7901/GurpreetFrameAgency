using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GurpreetFrameAgency.Data;
using System;
using System.Linq;

namespace GurpreetFrameAgency.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GurpreetFrameAgencyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GurpreetFrameAgencyContext>>()))
            {
                // Look for any movies.
                if (context.Frame.Any())
                {
                    return;   // DB has been seeded
                }

                context.Frame.AddRange(
                    new Frame
                    {
                        Name = "Modern Marble",
                        Type = "Plastic",
                        ManufacturingDate = DateTime.Parse("2023-07-08"),
                        Color = "White and Grey Marble",
                        Rating = 4,
                        Price = 28.93M
                    },

                    new Frame
                    {
                        Name = "Edgy Geometric",
                        Type = "Metal",
                        ManufacturingDate = DateTime.Parse("2023-11-17"),
                        Color = "Silver",
                        Rating = 4,
                        Price = 27.50M
                    },

                    new Frame
                    {
                        Name = "Classic Black",
                        Type = "Plastic",
                        ManufacturingDate = DateTime.Parse("2022-05-15"),
                        Color = "Black",
                        Rating = 5,
                        Price = 21.33M
                    },

                    new Frame
                    {
                        Name = "Vintage Gold",
                        Type = "Metal",
                        ManufacturingDate = DateTime.Parse("2021-09-28"),
                        Color = "Gold",
                        Rating = 4,
                        Price = 23.78M
                    },

                    new Frame
                    {
                        Name = "Modern Wood",
                        Type = "Wood",
                        ManufacturingDate = DateTime.Parse("2022-02-10"),
                        Color = "Brown",
                        Rating = 5,
                        Price = 39.41M
                    },

                    new Frame
                    {
                        Name = "Rustic Oak",
                        Type = "Wood",
                        ManufacturingDate = DateTime.Parse("2021-01-05"),
                        Color = "Oak Brown",
                        Rating = 4,
                        Price = 37.99M
                    },

                    new Frame
                    {
                        Name = "Glamorous Gold",
                        Type = "Metal",
                        ManufacturingDate = DateTime.Parse("2022-11-28"),
                        Color = "Gold",
                        Rating = 5,
                        Price = 45.67M
                    },

                    new Frame
                    {
                        Name = "Minimalist Clear",
                        Type = "Plastic",
                        ManufacturingDate = DateTime.Parse("2023-2-12"),
                        Color = "Clear",
                        Rating = 3,
                        Price = 19.45M
                    },

                    new Frame
                    {
                        Name = "Industrial Steel",
                        Type = "Metal",
                        ManufacturingDate = DateTime.Parse("2022-12-05"),
                        Color = "Gunmetal Gray",
                        Rating = 4,
                        Price = 27.10M
                    },

                    new Frame
                    {
                        Name = "Sporty Neon",
                        Type = "Plastic",
                        ManufacturingDate = DateTime.Parse("2023-02-25"),
                        Color = "Neon Green",
                        Rating = 3,
                        Price = 18.03M
                    },

                    new Frame
                    {
                        Name = "Sleek Silver",
                        Type = "Metal",
                        ManufacturingDate = DateTime.Parse("2022-03-19"),
                        Color = "Silver",
                        Rating = 5,
                        Price = 25.19M
                    },

                    new Frame
                    {
                        Name = "Elegant Rose Gold",
                        Type = "Metal",
                        ManufacturingDate = DateTime.Parse("2021-10-12"),
                        Color = "Rose Gold",
                        Rating = 5,
                        Price = 46.78M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}