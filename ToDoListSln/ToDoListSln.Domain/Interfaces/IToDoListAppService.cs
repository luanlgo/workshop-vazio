using System;
using ToDoListSln.Domain.Contract;

namespace ToDoListSln.Domain.Interfaces
{
    public interface IToDoListAppService
    {
        void Add(ToDoListDto todoListDto);

        void Update(Guid id);

        void Delete(Guid id);
    }
}
