using System.Collections.Generic;
using TodoAPI_2.Todos;

namespace TodoAPI_2.Tests
{
    internal class MockTodoRepository : ITodoRepository
    {
        private List<Todo> Todos { get; }

        public MockTodoRepository()
        {
            Todos = new List<Todo>
            {
                new Todo(),
                new Todo(),
                new Todo()
            };
        }
        public IEnumerable<Todo> GetAllTodos()
        {
            return Todos;
        }
    }
}