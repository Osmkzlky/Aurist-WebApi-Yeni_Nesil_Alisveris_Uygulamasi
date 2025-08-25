using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ecommerce_app.DTOs.Review;
using ecommerce_app.Services;

namespace ecommerce_app.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly ReviewService _service;
        public ReviewController(ReviewService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddReview([FromBody] ReviewDto dto)
        {
            await _service.AddReviewAsync(dto);
            return Ok(new { message = "Yorum Eklendi" });
        }


        [HttpGet("product/{productId}")]
        public async Task<IActionResult> GetReviewByProductId(int productId)
        {
            var reviews = await _service.GetProductReviews(productId);
            return Ok(reviews);
        }

        [HttpGet("customer/{customerId}")]
        public async Task<IActionResult> GetReviewByCustomerId(string customerId)
        {
            var reviews = await _service.LoadReviewListCustomerId(customerId);
            return Ok(reviews);
        }

        [HttpDelete("{productId}/{date}")]
        public async Task<IActionResult> DeleteReviewController(int productId, DateTime date)
        {
            await _service.DeleteReview(productId, date);
            return Ok(new { message = "Yorum başarıyla silindi." });
        }

    }
}