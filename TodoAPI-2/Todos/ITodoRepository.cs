using System.Collections.Generic;

namespace TodoAPI_2.Todos
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAllTodos();
    }
}