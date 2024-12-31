using CQRSWithMediatR.Data;
using CQRSWithMediatR.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CQRSWithMediatR.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly ApplicationDbContext _context;

        public GetProductByIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.SingleOrDefaultAsync(p=>p.Id==request.id,cancellationToken);
        }

        
    }
}
