using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
  [TestClass]
  public class CreateTodoCommandTests
  {
    [TestMethod]
    public void WhenInputCreateTodoCommandValid()
    {
      var command = new CreateTodoCommand("Titulo da tarefa", "Guilherme Vada", DateTime.Now);
      command.Validate();

      Assert.AreEqual(command.Valid, true);
    }

    [TestMethod]
    public void WhenInputCreateTodoCommandInValid()
    {
      var command = new CreateTodoCommand("", "", DateTime.Now);
      command.Validate();

      Assert.AreEqual(command.Valid, false);
    }
  }
}