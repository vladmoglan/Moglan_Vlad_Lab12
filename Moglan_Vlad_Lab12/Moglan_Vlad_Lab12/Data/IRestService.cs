﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Moglan_Vlad_Lab12.Models;

namespace Moglan_Vlad_Lab12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}