using System;

namespace ToDoListSln.Domain.Contract
{
    public class ToDoListDto
    {
        public Guid Id { get; set; }

        public string Conteudo { get; set; }

        public bool Checado { get; set; }
    }
}
