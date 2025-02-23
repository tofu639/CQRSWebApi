using MediatR;

public class CreateItemCommand : IRequest<int>
{
    public required string Name { get; set; } // Use 'required' modifier
    public required string Description { get; set; } // Use 'required' modifier
}