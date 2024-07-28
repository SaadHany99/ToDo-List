using ToDo_List.Models;

namespace ToDo_List.Services
{
    public interface IToDoListService
    {
        Task<List<ToDo>> GetAll();
        Task<ToDo> GetById(int id);
        Task AddToDo(ToDo toDo);
        Task UpdateToDo(ToDo toDo);
        Task DeleteToDo(ToDo toDo);
    }
}
