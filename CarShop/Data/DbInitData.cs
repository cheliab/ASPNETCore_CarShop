using System.Collections.Generic;
using System.Linq;
using CarShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CarShop.Data
{
    public class DbInitData
    {
        private static Dictionary<string, Category> _categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var categoriesArr = new Category[]
                    {
                        new Category
                        {
                            Id = 1, 
                            Name = "Электромобили", Description = "Автомобили с электродвигателями"
                        },
                        new Category
                        {
                            Id = 2, Name = "ДВС автомобили",
                            Description = "Автомобили с двигателем внутренного сгорания"
                        }
                    };
                    
                    _categories = new Dictionary<string, Category>();
                    foreach (var category in categoriesArr)
                        _categories.Add(category.Name, category);
                }

                return _categories;
            }
        }
        
        public static void Initial(AppDbContent context)
        {
            if (!context.Categories.Any())
                context.Categories.AddRange(Categories.Select(category => category.Value));

            if (!context.Cars.Any())
            {
                context.Cars.AddRange(new Car
                    {
                        Name = "Tesla Model 3", 
                        Price = 37000, 
                        IsFavourite = true, 
                        Available = 5,
                        Category = Categories["Электромобили"],
                        ImagePath = "/img/tesla-model-3.png"
                    },
                    new Car
                    {
                        Name = "Tesla Model S", 
                        Price = 45000, 
                        IsFavourite = true, 
                        Available = 5,
                        Category = Categories["Электромобили"],
                        ImagePath = "/img/tesla-model-s.jpg"
                    },
                    new Car
                    {
                        Name = "BMW X 5",
                        Price = 40000,
                        IsFavourite = true,
                        Available = 20,
                        Category = Categories["ДВС автомобили"],
                        ImagePath = "/img/bmw-x8.jpg"
                    },
                    new Car
                    {
                        Name = "Mercedes S Class",
                        Price = 40000,
                        IsFavourite = true,
                        Available = 20,
                        Category = Categories["ДВС автомобили"],
                        ImagePath = "/img/mercedes-s-class.jpg"
                    });
            }

            context.SaveChanges();
        }
    }
}