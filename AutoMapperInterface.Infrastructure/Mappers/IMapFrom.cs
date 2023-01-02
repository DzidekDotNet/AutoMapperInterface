using AutoMapper;

namespace AutoMapperInterface.Infrastructure.Mappers;

public interface IMapFrom<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
}