﻿using InventoryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDal.Abstrack
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int productId);
        void Add(Product product);
        void Delete(int Id);
        void Update(Product product);
     
    }
}
