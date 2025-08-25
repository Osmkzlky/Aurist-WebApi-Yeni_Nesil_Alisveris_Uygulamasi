using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ecommerce_app.Entities;

namespace ecommerce_app.Interfaces
{
    public interface IReviewRepository
    {
        Task AddReviewAsync(Review review);
        Task<List<Review>> GetReviewsByProductIdAsync(int productId);
    }
}