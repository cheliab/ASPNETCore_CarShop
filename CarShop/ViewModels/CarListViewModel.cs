using System.Collections.Generic;
using CarShop.Models;

namespace CarShop.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> GetAllCars { get; set; }
        public string CurrentCategory { get; set; }
    }
}