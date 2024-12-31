using MediatR;

public class CreateItemHandler : IRequestHandler<CreateItemCommand, int>
{
    private readonly AppDbContext _context;

    public CreateItemHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        var item = new Item { Name = request.Name };
        _context.Items.Add(item);
        await _context.SaveChangesAsync(cancellationToken);
        return item.Id;
    }
}