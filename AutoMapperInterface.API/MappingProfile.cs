using System.Reflection;
using AutoMapper;
using AutoMapperInterface.Infrastructure.Mappers;

namespace AutoMapperInterface.API;

internal class BaseMappingProfile : Profile
{
    public BaseMappingProfile()
    {
        AppDomain.CurrentDomain.GetAssemblies().ToList().ForEach(assembly =>
        {
            ApplyMappingsFrom(assembly);
            ApplyMappingsTo(assembly);
        });
    }

    private void ApplyMappingsFrom(Assembly assembly)
    {
        var types = assembly.GetExportedTypes()
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
            .ToList();

        foreach (var type in types)
        {
            var instance = Activator.CreateInstance(type);

            var methodInfo = type.GetMethod("Mapping")
                             ?? type.GetInterface("IMapFrom`1")!.GetMethod("Mapping");

            methodInfo?.Invoke(instance, new object[] { this });
        }
    }

    private void ApplyMappingsTo(Assembly assembly)
    {
        var types = assembly.GetExportedTypes()
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapTo<>)))
            .ToList();

        foreach (var type in types)
        {
            var instance = Activator.CreateInstance(type);

            var methodInfo = type.GetMethod("Mapping")
                             ?? type.GetInterface("IMapTo`1")!.GetMethod("Mapping");

            methodInfo?.Invoke(instance, new object[] { this });
        }
    }
}