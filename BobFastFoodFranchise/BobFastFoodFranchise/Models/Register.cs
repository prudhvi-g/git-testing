﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Models
{
    public class Register
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
       public string Password { get; set; }   
       
    }
}
