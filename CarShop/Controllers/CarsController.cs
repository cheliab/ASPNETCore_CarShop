using CarShop.Data.Interfaces;
using CarShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _carsCategory = carsCategory;
        }

        public ViewResult List()
        {
            var viewModel = new CarListViewModel
            {
                CurrentCategory = "Автомобили",
                GetAllCars = _allCars.Cars
            };

            return View(viewModel);
        }
    }
}