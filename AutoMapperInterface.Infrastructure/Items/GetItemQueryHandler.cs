using AutoMapperInterface.Application.Items;
using AutoMapperInterface.Domain.Items;
using MediatR;

namespace AutoMapperInterface.Infrastructure.Items;

public sealed class GetItemQueryHandler : IRequestHandler<GetItemQuery, Item>
{
    public Task<Item> Handle(GetItemQuery request, CancellationToken cancellationToken)
    {
        return ItemsRepository.GetItem(request.Id);
    }
}