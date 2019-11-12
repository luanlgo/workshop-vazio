using AutoMapper;
using ToDoListSln.Domain.Contract;
using ToDoListSln.Domain.Entities;

namespace ToDoListSln.Application.Mappers
{
    public static class AutoMapperToDoList
    {
        public static IMapper GetMapperConfiguration()
        {
            return new MapperConfiguration(map =>
            {
                map.CreateMap<ToDoListDto, ToDoList>()
                .ConvertUsing(from => new ToDoList(
                    from.Id,
                    from.Conteudo,
                    from.Checado));

                map.CreateMap<ToDoList, ToDoListDto>()
                    .ConvertUsing(from => new ToDoListDto()
                    {
                        Id = from.Id,
                        Conteudo = from.Conteudo,
                        Checado = from.Checado
                    });
            }).CreateMapper();
        }
    }
}
