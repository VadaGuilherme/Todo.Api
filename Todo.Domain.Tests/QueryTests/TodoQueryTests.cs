using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "Usuario A"));
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "Usuario B"));
            _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "Admin"));
            _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "Usuario C"));
            _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "Admin"));
        }

        [TestMethod]
        public void WhenConsultSholdReturnTodoByUserAdmin()
        {
            var result = _items
                .AsQueryable()
                .Where(TodoQueries.GetAll("Admin"));

            Assert.AreEqual(2, result.Count());
        }
    }
}
