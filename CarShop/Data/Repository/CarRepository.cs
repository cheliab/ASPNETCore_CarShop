using System.Collections.Generic;
using System.Linq;
using CarShop.Data.Interfaces;
using CarShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDbContent _context;

        public CarRepository(AppDbContent context)
        {
            _context = context;
        }
        
        public IEnumerable<Car> Cars { 
            get => _context.Cars.Include(car => car.Category);
        }

        public IEnumerable<Car> GetFavoriteCars
        {
            get => _context.Cars.Where(car => car.IsFavourite).Include(car => car.Category);
        }
        
        public Car GetObjectCar(int id)
        {
            return _context.Cars.FirstOrDefault(car => car.Id == id);
        }
    }
}