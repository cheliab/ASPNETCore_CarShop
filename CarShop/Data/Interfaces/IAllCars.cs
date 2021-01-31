using System.Collections.Generic;
using CarShop.Models;

namespace CarShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }
        IEnumerable<Car> GetFavoriteCars { get; set; }
        Car GetObjectCar(int id);
    }
}