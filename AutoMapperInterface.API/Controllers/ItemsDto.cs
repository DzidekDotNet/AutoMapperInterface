using AutoMapperInterface.Domain.Items;
using AutoMapperInterface.Infrastructure.Mappers;

namespace AutoMapperInterface.API.Controllers;

public readonly record struct ItemDto(int Id, string Name) : IMapFrom<Item>;