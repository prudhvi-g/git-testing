using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Models
{
    public class FastFoodShops
    {
        [Key]
        public int FastFoodShopId
        {
            get;
            set;
        }
        public string FastFoodShopName
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }
        public long PhoneNumber
        {
            get;
            set;
        }

    }
}
