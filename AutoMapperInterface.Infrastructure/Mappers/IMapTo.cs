using AutoMapper;

namespace AutoMapperInterface.Infrastructure.Mappers;

public interface IMapTo<T>
{
    void Mapping(Profile profile) => profile.CreateMap(GetType(), typeof(T));
}