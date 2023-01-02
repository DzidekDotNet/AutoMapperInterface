using AutoMapperInterface.Application.Items;
using AutoMapperInterface.Domain.Items;
using MediatR;

namespace AutoMapperInterface.Infrastructure.Items;

public sealed class GetItemsQueryHandler : IRequestHandler<GetItemsQuery, IEnumerable<Item>>
{
    public Task<IEnumerable<Item>> Handle(GetItemsQuery request, CancellationToken cancellationToken)
    {
        return ItemsRepository.GetItems();
    }
}