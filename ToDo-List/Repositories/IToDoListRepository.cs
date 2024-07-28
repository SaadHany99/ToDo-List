using ToDo_List.Models;

namespace ToDo_List.Repositories
{
    public interface IToDoListRepository
    {
        Task<List<ToDo>> GetAll();
        Task<ToDo> GetById(int id);
        Task AddToDo(ToDo toDo);
        Task UpdateToDo (ToDo toDo);
        Task DeleteToDo (ToDo toDo);
    }
}
