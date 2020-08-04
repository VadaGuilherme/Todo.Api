using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo da tarefa", "Guilherme Vada", DateTime.Now);

        public CreateTodoCommandTests()
        {
            _validCommand.Validate();
            _invalidCommand.Validate();
        }

        [TestMethod]
        public void WhenInputCreateTodoCommandValid()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }

        [TestMethod]
        public void WhenInputCreateTodoCommandInValid()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }
    }
}