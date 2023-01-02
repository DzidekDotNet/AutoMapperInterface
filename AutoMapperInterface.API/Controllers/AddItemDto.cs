using AutoMapperInterface.Domain.Items;
using AutoMapperInterface.Infrastructure.Mappers;

namespace AutoMapperInterface.API.Controllers;

public readonly record struct AddItemDto(int Id, string Name) : IMapTo<Item>;