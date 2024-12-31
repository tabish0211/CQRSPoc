using CQRSWithMediatR.Data;
using CQRSWithMediatR.Models;
using MediatR;

namespace CQRSWithMediatR.Commands
{
    public class DeleteProductByIdCommandHandler : IRequestHandler<DeleteProductByIdCommand, string>
    {
        private readonly ApplicationDbContext _context;

        public DeleteProductByIdCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(DeleteProductByIdCommand request, CancellationToken cancellationToken)
        {

            //_context.Products.Add(product);
            //await _context.SaveChangesAsync(cancellationToken);

            //return product.Id;
            return "Record deleted";
        }
    }
}
