using BobFastFoodFranchise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Core.FastFoodShop
{
   public interface IFastFoodshop
    {
         Task<FastFoodShops> AddFastFoodShop(FastFoodShops fastFoodShops);
        Task<IEnumerable<FastFoodShops>> GetFastFoodShop();

    }
}

