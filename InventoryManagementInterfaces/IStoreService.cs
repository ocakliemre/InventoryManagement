﻿using InventoryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementInterfaces
{
    public interface IStoreService
    {

        List<Store> GetAll();
        Store Get(int storeId);
        void Add(Store store);
        void Delete(int storeId);
        void Update(Store store);


    }
}