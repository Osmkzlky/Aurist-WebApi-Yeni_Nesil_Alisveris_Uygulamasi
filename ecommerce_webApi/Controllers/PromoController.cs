using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce_app.Data;
using ecommerce_app.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ecommerce_app.DTOs.Promo;



namespace ecommerce_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromoController : ControllerBase
    {
        private readonly DataContext _context;

        public PromoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPromos()
        {
            var promos = await _context.Promos.ToListAsync();
            var promoDtoList = new List<LoadPromoDto>();

            foreach (var promo in promos)
            {
                var timeLeft = promo.PromoExpirationDate - DateTime.UtcNow;
                string expirationText;

                if (timeLeft.TotalDays >= 1)
                {
                    expirationText = $"{(int)timeLeft.TotalDays} gün kaldı";
                }
                else if (timeLeft.TotalHours >= 1)
                {
                    expirationText = $"{(int)timeLeft.TotalHours} saat kaldı";
                }
                else if (timeLeft.TotalMinutes >= 1)
                {
                    expirationText = $"{(int)timeLeft.TotalMinutes} dakika kaldı";
                }
                else if (timeLeft.TotalSeconds > 0)
                {
                    expirationText = "Az kaldı";
                }
                else
                {
                    expirationText = "Süresi doldu";
                }

                var promoLoadModel = new LoadPromoDto
                {
                    PromoImage = promo.PromoImage,
                    PromoTitle = promo.PromoTitle,
                    PromoDescription = promo.PromoDescription,
                    PromoExpirationDate = expirationText,
                    PromoProcess = promo.PromoProcess
                };

                promoDtoList.Add(promoLoadModel);
            }

            return Ok(promoDtoList);
        }
    }
}