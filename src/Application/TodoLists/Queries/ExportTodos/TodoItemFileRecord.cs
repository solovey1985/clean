using cleanArchitecture.Application.Common.Mappings;
using cleanArchitecture.Domain.Entities;

namespace cleanArchitecture.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
