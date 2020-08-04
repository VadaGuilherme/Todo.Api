using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _validTodo = new TodoItem("Titulo", DateTime.Now, "gvadaguariba");

        [TestMethod]
        public void WhenNewTodoCreatedAsDoneFalse()
        {            
            Assert.AreEqual(_validTodo.Done, false);
        }
    }
}
