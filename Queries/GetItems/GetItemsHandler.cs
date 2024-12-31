using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetItemsHandler : IRequestHandler<GetItemsQuery, List<Item>>
{
    private readonly AppDbContext _context;

    public GetItemsHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Item>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Items.ToListAsync(cancellationToken);
    }
}