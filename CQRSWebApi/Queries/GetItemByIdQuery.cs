using MediatR;

public class GetItemByIdQuery : IRequest<Item>
{
    public int Id { get; set; }
}