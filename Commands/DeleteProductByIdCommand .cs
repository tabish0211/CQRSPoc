using MediatR;

namespace CQRSWithMediatR.Commands
{
    public record DeleteProductByIdCommand(int id) : IRequest<string>;
}
