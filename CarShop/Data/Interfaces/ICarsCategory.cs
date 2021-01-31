﻿using System.Collections.Generic;
using CarShop.Models;

namespace CarShop.Data.Interfaces
{
    public interface ICarsCategory
    {
        public IEnumerable<Category> AllCategories { get; }
        public Category Get(int id);
    }
}