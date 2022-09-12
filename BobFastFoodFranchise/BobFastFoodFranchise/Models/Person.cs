using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BobFastFoodFranchise.Models
{
    public class Person
    {
        [Key]
        public int PersonId
        {
            get;
            set;
        }
        public string PersonName
        {
            get;
            set;
        }
        public int Password
        {
            get;
            set;
        }
        public string EmailId
        {
            get;
            set;
        }
        public string PersonCity
        {
            get;
            set;
        }
        public int RoleId
        {
            get;
            set;
        }
        public Role Role { get; set; }
    }
}
