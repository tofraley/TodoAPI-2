using System;
using System.Collections.Generic;
using System.Linq;
using TodoAPI_2.Todos;
using Xunit;

namespace TodoAPI_2.Tests
{
    public class TodoService_UT
    {
        [Fact]
        public void GetAllTodos_ReturnsTodos()
        {
            // Arrange 
            ITodoRepository repo = new MockTodoRepository();
            var todoService = new TodoService(repo);

            // Act 
            IEnumerable<Todo> actual = todoService.GetAllTodos();

            // Assert
            Assert.True(actual.Count() == 3);
        }
    }
}
