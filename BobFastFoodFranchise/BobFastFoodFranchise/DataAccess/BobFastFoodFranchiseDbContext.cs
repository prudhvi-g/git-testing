using BobFastFoodFranchise.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BobFastFoodFranchise;

namespace BobFastFoodFranchise.DataAccess
{
    public class BobFastFoodFranchiseDbContext:DbContext
    {
        public BobFastFoodFranchiseDbContext(DbContextOptions<BobFastFoodFranchiseDbContext> options) : base(options)
        {

        }
        public DbSet<FastFoodShops> fastFoodShop { get; set; }

        public DbSet<Item>item { get; set; }
        public DbSet<Person> person { get; set; }

        public DbSet<Role> role { get; set; }

        public DbSet<Login> login { get; set; }

        public DbSet<BobFastFoodFranchise.WeatherForecast> WeatherForecast { get; set; }
    }
}
