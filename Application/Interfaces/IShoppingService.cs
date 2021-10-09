﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IShoppingService
    {
        IEnumerable<Shopping> GetAllShoppings();
        Shopping GetShoppingById(int id);
        Shopping AddShopping(Shopping newShopping);
        void UpdateShopping(Shopping shopping);
        void DeleteShopping(int id);
    }
}
