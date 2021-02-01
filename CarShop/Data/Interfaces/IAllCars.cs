using System.Collections.Generic;
using CarShop.Models;

namespace CarShop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavoriteCars { get;  }
        Car GetObjectCar(int id);
    }
}