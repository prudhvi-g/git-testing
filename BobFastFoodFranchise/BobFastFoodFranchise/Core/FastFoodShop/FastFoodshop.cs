using BobFastFoodFranchise.DataAccess;
using BobFastFoodFranchise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Core.FastFoodShop
{
    [Route("api/[controller]")]
    [ApiController]
    public class FastFoodshop:IFastFoodshop
    {
      
              private readonly BobFastFoodFranchiseDbContext bobFastFoodFranchiseDbContext;
        public FastFoodshop(BobFastFoodFranchiseDbContext bobFastFoodFranchiseDbContext)
        {
            this.bobFastFoodFranchiseDbContext = bobFastFoodFranchiseDbContext;
        }

        public async Task<IEnumerable<FastFoodShops>> GetFastFoodShop ()
        {
            try
            {
                var result = await bobFastFoodFranchiseDbContext.fastFoodShop.ToListAsync();
                return result;
            }
            catch (Exception ex) { throw ex; }
        }
        public async Task<FastFoodShops> AddFastFoodShop(FastFoodShops fastFoodShops)
        {
            try
            {
                var result = await bobFastFoodFranchiseDbContext.fastFoodShop.AddAsync(fastFoodShops);
                await bobFastFoodFranchiseDbContext.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex) { throw ex; }
        }
    }
    }

