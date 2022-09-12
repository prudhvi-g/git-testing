using BobFastFoodFranchise.DataAccess;
using BobFastFoodFranchise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Core.Items
{
    [Route("api/[controller]")]
    [ApiController]
    public class items:Iitems
    {

        private readonly BobFastFoodFranchiseDbContext bobFastFoodFranchiseDbContext;
        public items(BobFastFoodFranchiseDbContext bobFastFoodFranchiseDbContext)
        {
            this.bobFastFoodFranchiseDbContext = bobFastFoodFranchiseDbContext;
        }


        public async Task<IEnumerable<Item>> GetItem()
        {
            try
            {
                var result = await bobFastFoodFranchiseDbContext.item.ToListAsync();
                return result;
            }
            catch (Exception ex) { throw ex; }
        }
        public async Task<Item> GetVegOrNonveg(string vegOrNonveg)
        {
            try
            {
                var result = await bobFastFoodFranchiseDbContext.item.FirstOrDefaultAsync(x => x.VegOrNonveg == vegOrNonveg);
                return result;
            }
            catch (Exception ex) { throw ex; }
        }
        public async Task<Item> UpdateItem(int percentage)
        {
            var result = await bobFastFoodFranchiseDbContext.item.FirstOrDefaultAsync(x => x.Price == percentage);
            if (result != null)
            {
               result.Price = percentage + (percentage / 10);
                await bobFastFoodFranchiseDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
