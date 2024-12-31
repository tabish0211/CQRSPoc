using CQRSWithMediatR.Data;
using CQRSWithMediatR.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSWithMediatR.Queries
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllProductsHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync(cancellationToken);
        }
    }
}
