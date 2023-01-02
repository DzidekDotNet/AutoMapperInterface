using AutoMapperInterface.Domain.Items;
using MediatR;

namespace AutoMapperInterface.Application.Items;

public readonly record struct AddItemCommand(Item Item): IRequest;