using Microsoft.EntityFrameworkCore;
using ToDo_List.Models;
using ToDo_List.Models.Data;

namespace ToDo_List.Repositories
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly AppDbContext dbContext;
        // injecting DB Context into Repo Constructor
        public ToDoListRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task AddToDo(ToDo toDo)
        {
            dbContext.ToDos.Add(toDo);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteToDo(ToDo toDo)
        {
            if(toDo!=null)
            {
                dbContext.ToDos.Remove(toDo);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<ToDo>> GetAll()
        {
            return await dbContext.ToDos.ToListAsync(); 
        }

        public async Task<ToDo> GetById(int id)
        {
            return await dbContext.ToDos.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task UpdateToDo(ToDo toDo)
        {
            dbContext.Entry(toDo).State= EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }
    }
}
