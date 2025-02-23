using MediatR;
using System.Threading;
using System.Threading.Tasks;

public class GetItemByIdQueryHandler : IRequestHandler<GetItemByIdQuery, Item>
{
    public Task<Item> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
    {
        // Logic to retrieve an item
        var item = new Item { Id = request.Id, Name = "Sample Item", Description = "Sample Description" };
        return Task.FromResult(item);
    }
}