using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.Entities
{
    public class Promo
    {
        public int Id { get; set; }
        public string PromoImage { get; set; }
        public string PromoTitle { get; set; }
        public string PromoDescription { get; set; }
        public DateTime PromoExpirationDate { get; set; }
        public string PromoProcess { get; set; }
    }
}