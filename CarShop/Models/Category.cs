﻿using System.Collections.Generic;

namespace CarShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Car> Cars { get; set; }
    }
}