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
                        Available = 5,
                        Category = _carsCategory.Get(1),
                        ImagePath = "/img/tesla-model-3.png"
                    },
                    new Car
                    {
                        Name = "Tesla Model S", 
                        Price = 45000, 
                        IsFavourite = true, 
                        Available = 5,
                        Category = _carsCategory.Get(1),
                        ImagePath = "/img/tesla-model-s.jpg"
                    },
                    new Car
                    {
                        Name = "BMW X 5",
                        Price = 40000,
                        IsFavourite = true,
                        Available = 20,
                        Category = _carsCategory.Get(2),
                        ImagePath = "/img/bmw-x8.jpg"
                    },
                    new Car
                    {
                        Name = "Mercedes S Class",
                        Price = 40000,
                        IsFavourite = true,
                        Available = 20,
                        Category = _carsCategory.Get(2),
                        ImagePath = "/img/mercedes-s-class.jpg"
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