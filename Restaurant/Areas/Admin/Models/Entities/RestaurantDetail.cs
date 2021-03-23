using Restaurant.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Models.Entities
{
    public class RestaurantDetail 
    {
        public int RestaurantDetailId { get; set; }

        public string Anayemek { get; set; }

        public string Meze { get; set; }

        public string Salatalar { get; set; }

        public string İçecek { get; set; }

        public string Tatlılar { get; set; }

        public int Fiyat { get; set; }

    }
}
