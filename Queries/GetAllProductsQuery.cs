using CQRSWithMediatR.Models;
using MediatR;
using System.Collections.Generic;

namespace CQRSWithMediatR.Queries
{
    public record GetAllProductsQuery() : IRequest<List<Product>>;
}
