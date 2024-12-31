using MediatR;

public record GetItemsQuery : IRequest<List<Item>>;