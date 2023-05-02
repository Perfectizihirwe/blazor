using BlazorApp.Data;

namespace BlazorApp
{
    public class TodoState
    {
        public List<TodoItem> Todos { get; set; } = new() { };
    }
}
