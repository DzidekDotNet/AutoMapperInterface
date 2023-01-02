using System.Collections.Concurrent;
using AutoMapperInterface.Domain.Items;

namespace AutoMapperInterface.Infrastructure.Items;

internal static class ItemsRepository
{
    private static readonly ConcurrentBag<Item> Items = new ConcurrentBag<Item>();

    internal static Task<IEnumerable<Item>> GetItems()
    {
        return Task.FromResult(Items as IEnumerable<Item>);
    }
    
    internal static Task<Item> GetItem(int id)
    {
        return Task.FromResult(Items.First(x => x.Id == id));
    }
    
    internal static Task AddItem(Item item)
    {
        Items.Add(item);
        return Task.CompletedTask;
    }
}