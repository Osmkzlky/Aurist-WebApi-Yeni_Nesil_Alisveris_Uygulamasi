using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce_app.Interfaces;
using ecommerce_app.DTOs.Review;
using ecommerce_app.Entities;
using ecommerce_app.Models;
using Microsoft.AspNetCore.Identity;
using ecommerce_app.Data;
using Microsoft.EntityFrameworkCore;




namespace ecommerce_app.Services
{
    public class ReviewService
    {
        private readonly DataContext _context;
        private readonly IReviewRepository _repository;
        private readonly UserManager<AppUser> _userManager;

        public ReviewService(DataContext context, IReviewRepository repository, UserManager<AppUser> userManager)
        {
            _context = context;
            _repository = repository;
            _userManager = userManager;
        }

        public async Task AddReviewAsync(ReviewDto dto)
        {
            var review = new Review
            {
                ProductId = dto.ProductId,
                CustomerId = dto.CustomerId,
                ReviewDetail = dto.ReviewDetail,
                ReviewRating = dto.ReviewRating,
            };

            await _repository.AddReviewAsync(review);
        }


        public async Task<List<ReviewLoadDto>> GetProductReviews(int productId)
        {

            var reviews = await _repository.GetReviewsByProductIdAsync(productId);
            var loadReviewList = new List<ReviewLoadDto>();

            foreach (var review in reviews)
            {
                var customer = _userManager.Users.FirstOrDefault(i => i.Id == review.CustomerId);

                var loadReviewModel = new ReviewLoadDto
                {
                    ReviewFullName = $"{customer.Name} {customer.Surname}",
                    ReviewDetail = review.ReviewDetail,
                    ReviewRating = review.ReviewRating,
                    ReviewDate = review.CreatedAt
                };
                loadReviewList.Add(loadReviewModel);
            }


            return loadReviewList;
        }

        public async Task<List<LoadReviewByCustomerId>> LoadReviewListCustomerId(string customerId)
        {
            var reviews = await _context.Reviews
                .Where(i => i.CustomerId == customerId)
                .ToListAsync();

            var reviewList = new List<LoadReviewByCustomerId>();

            foreach (var review in reviews)
            {
                var product = await _context.Products
                    .FirstOrDefaultAsync(i => i.Id == review.ProductId);

                var image = await _context.ProductImages
                    .FirstOrDefaultAsync(i => i.ProductId == product.Id);

                var reviewModel = new LoadReviewByCustomerId
                {
                    ProductId = product.Id,
                    ProductName = product?.product_name,
                    ProductImage = image?.image_url,
                    ReviewDetail = review.ReviewDetail,
                    ReviewRating = review.ReviewRating,
                    ReviewDate = review.CreatedAt
                };

                reviewList.Add(reviewModel);
            }

            return reviewList;
        }

        public async Task DeleteReview(int productId, DateTime Date)
        {
            var review = await _context.Reviews
                .FirstOrDefaultAsync(i => i.ProductId == productId && i.CreatedAt == Date);

            if (review != null)
            {
                _context.Reviews.Remove(review);
                await _context.SaveChangesAsync();
            }
        }

    }
}