using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAPI_2.Todos
{
    public class TodoService : ITodoService
    {
        private ITodoRepository _todoRepository { get; set; }

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return _todoRepository.GetAllTodos();
        }
    }
}
