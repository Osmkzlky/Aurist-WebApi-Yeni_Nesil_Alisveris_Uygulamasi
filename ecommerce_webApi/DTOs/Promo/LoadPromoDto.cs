using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app.DTOs.Promo
{
    public class LoadPromoDto
    {
        public string PromoImage { get; set; }
        public string PromoTitle { get; set; }
        public string PromoDescription { get; set; }
        public String PromoExpirationDate { get; set; }
        public string PromoProcess { get; set; }
    }
}