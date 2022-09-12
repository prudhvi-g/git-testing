using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Models
{
    public class Item
    {
        [Key]
        public int ItemId
        {
            get;
            set;
        }
        public string ItemName
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public string VegOrNonveg
        {
            get;
            set;
        }
        public int FastFoodShopId
        {
            get;
            set;
        }
        public FastFoodShops FastFoodShop{ get; set; }

    }
}
