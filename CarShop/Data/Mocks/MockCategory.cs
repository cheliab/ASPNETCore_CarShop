using System.Collections.Generic;
using System.Linq;
using CarShop.Data.Interfaces;
using CarShop.Models;

namespace CarShop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { Id = 1, Name = "Электромобили", Description = "Автомобили с электродвигателями" },
                new Category { Id = 2, Name = "ДВС автомобили", Description = "Автомобили с двигателем внутренного сгорания" }
            };

        public Category Get(int id)
        {
            return AllCategories.FirstOrDefault(category => category.Id == id);
        }
    }
}