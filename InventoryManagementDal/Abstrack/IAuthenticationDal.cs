﻿using InventoryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompanyAddressesServices.Abstrack
{
    public interface IAuthenticationDal
    {
        Company AuthenticationCompany(Company user);
        Staff AuthenticationStaff(Staff user);
    }
}