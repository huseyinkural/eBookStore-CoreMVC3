﻿using eBookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBookStore.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
