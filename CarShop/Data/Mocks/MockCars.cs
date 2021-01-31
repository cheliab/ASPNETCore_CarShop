using System.Collections.Generic;
using CarShop.Data.Interfaces;
using CarShop.Models;

namespace CarShop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla Model 3", 
                        Price = 37000, 
                        IsFavourite = true, 
                        Available = 5
                    },
                    new Car
                    {
                        Name = "",
                        Price = 40000,
                        IsFavourite = true,
                        Available = 20
                    }
                };
            }
            set
            {
                
            }
        }

        public IEnumerable<Car> GetFavoriteCars { get; set; }
        public Car GetObjectCar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}