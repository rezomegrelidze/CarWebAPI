using System;
using System.Linq;
using CarWebAPI.Data;

namespace CarWebAPI
{
    public static class DbInitializer
    {
        public static void Initialize(CarDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Cars.Any())
            {
                return;   // DB has been seeded
            }

            var cars = new[]
            {
                new Car {Make = "BMW", Model = "740", Year = 1999, HorsePowerCount = 400},

                new Car {Make = "Mercedes-benz", Model = "S500", Year = 1994, HorsePowerCount = 355},

                new Car {Make = "Bugatti", Model = "Veyron", Year = 2018, HorsePowerCount = 700},

                new Car {Make = "Toyota", Model = "Corolla", Year = 2021, HorsePowerCount = 155}
            };
            foreach (var car in cars) 
                context.Cars.Add(car);

            context.SaveChanges();
        }
    }
}