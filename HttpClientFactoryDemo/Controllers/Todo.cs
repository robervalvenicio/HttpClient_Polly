using HttpClientFactoryDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Todo : Controller
    {
        //Injetar o service Todo
        private readonly ITodoService _todoService;

        public Todo(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("GetTodo/{id}")]
        public async Task <IActionResult> GetTodo(int id)
        {
            return Ok(await _todoService.GetTodo(id));
        }
    }
}
