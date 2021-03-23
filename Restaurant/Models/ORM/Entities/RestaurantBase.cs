using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.ORM.Entities
{
    public class RestaurantBase
    {
        
        public int Id { get; set; }

        public string RestaurantName { get; set; }

        public string RestaurantAddress { get; set; }

        public string RestaurantMenu { get; set; }

        public int Date { get; set; }

    }
}
