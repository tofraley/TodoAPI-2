using System.Collections.Generic;

namespace TodoAPI_2.Todos
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetAllTodos();
    }
}