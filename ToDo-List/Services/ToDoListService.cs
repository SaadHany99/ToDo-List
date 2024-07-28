using ToDo_List.Models;
using ToDo_List.Repositories;

namespace ToDo_List.Services
{
    public class ToDoListService:IToDoListService
    {
        private readonly IToDoListRepository repository;

        public ToDoListService(IToDoListRepository repository)
        {
            this.repository = repository;
        }

        public async Task AddToDo(ToDo toDo)
        {
           await repository.AddToDo(toDo);
        }

        public async Task DeleteToDo(ToDo toDo)
        {
            await repository.DeleteToDo(toDo);
        }

        public async Task<List<ToDo>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<ToDo> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task UpdateToDo(ToDo toDo)
        {
            await repository.UpdateToDo(toDo);
        }
    }
}
