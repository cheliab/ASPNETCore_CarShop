using System.Collections.Generic;
using System.Linq;
using CarShop.Data.Interfaces;
using CarShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContent _context;

        public CategoryRepository(AppDbContent context)
        {
            _context = context;
        }

        public IEnumerable<Category> AllCategories => _context.Categories;
        public Category Get(int id)
        {
            return _context.Categories.FirstOrDefault(category => category.Id == id);
        }
    }
}