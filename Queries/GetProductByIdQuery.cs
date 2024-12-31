using CQRSWithMediatR.Models;
using MediatR;
using System.Collections.Generic;

namespace CQRSWithMediatR.Queries
{
    public record GetProductByIdQuery(int id) : IRequest<Product>;
}
