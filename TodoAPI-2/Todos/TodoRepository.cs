using System.Collections.Generic;

namespace TodoAPI_2.Todos
{
    public class TodoRepository : ITodoRepository
    {
        private List<Todo> Todos { get; }

        public TodoRepository()
        {
            Todos = new List<Todo>
            {
                new Todo() { Id = 1, Content = "first todo", IsChecked = false },
                new Todo() { Id = 2, Content = "second todo", IsChecked = false },
                new Todo() { Id = 3, Content = "third todo", IsChecked = false }
            };
        }
        
        public IEnumerable<Todo> GetAllTodos()
        {
            return Todos;
        }
    }
}