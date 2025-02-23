using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, int>
{
    public Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        // Logic to create an item
        var itemId = 1; // Replace with actual logic
        return Task.FromResult(itemId);
    }
}