using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo_List.Models;
using ToDo_List.Services;

namespace ToDo_List.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoListService service;

        public ToDoController(IToDoListService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetToDos()
        {
            var ToDos = await service.GetAll();
            return Ok(ToDos);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetToDoById(int id)
        {
            var ToDo = await service.GetById(id);
            if (ToDo == null)
                return NotFound();
            return Ok(ToDo);
        }
        [HttpPost]
        public async Task<ActionResult> AddToDo(ToDo toDo)
        {
            await service.AddToDo(toDo);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> EditToDo(int id,ToDo toDo)
        {
            toDo.Id = id;
            if (toDo == null)
                return BadRequest();
            await service.UpdateToDo(toDo);
                return Ok(toDo);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteToDo(int id)
        {
            var RemovedItem = await service.GetById(id);
            if (RemovedItem == null)
                return NotFound();
            await service.DeleteToDo(RemovedItem);
                return Ok();
        }
    }
}
