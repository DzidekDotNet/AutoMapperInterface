using AutoMapperInterface.Domain.Items;
using MediatR;

namespace AutoMapperInterface.Application.Items;

public sealed class GetItemsQuery : IRequest<IEnumerable<Item>>
{
}