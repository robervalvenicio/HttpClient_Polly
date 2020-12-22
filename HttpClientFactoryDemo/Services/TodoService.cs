using HttpClientFactoryDemo.Configuration;
using HttpClientFactoryDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Services
{
    public class TodoService : ITodoService
    {
        private readonly ApiConfig _config;

        private readonly HttpClient _httpClient;
        public TodoService(ApiConfig config, HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<TodoModel> GetTodo(int id)
        {
            return await _httpClient.GetFromJsonAsync<TodoModel>(
                $"{_config.BaseUrl}/todos/{id}"
                );
        }
    }
}
