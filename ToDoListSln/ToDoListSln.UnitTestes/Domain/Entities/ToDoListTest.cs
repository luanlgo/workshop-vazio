using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoListSln.Domain.Entities;

namespace ToDoListSln.UnitTestes.Domain.Entities
{
    [TestClass]
    public class ToDoListTest
    {
        [TestMethod]
        public void Gerar_ToDoList_Por_Construtor_DeveConstruirObjetoComValores()
        {
            //Arrange 
            Guid idToDo = Guid.NewGuid();
            string conteudo = "Qualquer coisa aqui";
            bool checado = true;

            //Act
            var domain = new ToDoList(idToDo, conteudo, checado);

            //Assert
            domain.Id.Should().Be(idToDo);
            domain.Conteudo.Should().Be(conteudo);
            domain.Checado.Should().BeTrue();
        }
    }
}
