using MediatR;

public record CreateItemCommand(string Name) : IRequest<int>;