using System.Collections.Generic;
using ToDoListSln.Domain.Contract;

namespace ToDoListSln.Domain.Interfaces
{
    public interface IToDoListAppQuery
    {
        List<ToDoListDto> Get();

        bool Exist(ToDoListDto todoList);
    }
}
