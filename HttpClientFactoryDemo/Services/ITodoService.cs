using HttpClientFactoryDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Services
{
    public interface ITodoService
    {
        Task<TodoModel> GetTodo(int id);
    }
}
