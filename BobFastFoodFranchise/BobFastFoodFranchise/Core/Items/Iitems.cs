using BobFastFoodFranchise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Core.Items
{
  public interface Iitems
    {
        Task<IEnumerable<Item>> GetItem();
        Task<Item> GetVegOrNonveg(string vegOrNonveg);
        Task<Item> UpdateItem(int percentage);
    }
}
