using AutoMapperInterface.Application.Items;
using MediatR;

namespace AutoMapperInterface.Infrastructure.Items;

public sealed class AddItemCommandHandler : IRequestHandler<AddItemCommand>
{
    public Task<Unit> Handle(AddItemCommand request, CancellationToken cancellationToken)
    {
        ItemsRepository.AddItem(request.Item);
        
        return Task.FromResult(Unit.Value);
    }
}