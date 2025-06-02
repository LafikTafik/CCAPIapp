using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;


namespace CCAPIapp.Services
{
    public class ApiService<T> where T : class
    {
        private readonly HttpClient _client;

        private readonly string _endpoint;

        public ApiService(string endpoint)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7218/api/");
            _endpoint = endpoint;
        }

        // Получить все активные записи
        public async Task<List<T>> GetAllAsync()
        {
            var response = await _client.GetAsync(_endpoint);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<List<T>>();

            return new List<T>();
        }

        // Получить удалённые записи
        public async Task<List<T>> GetDeletedAsync()
        {
            var response = await _client.GetAsync($"{_endpoint}/deleted");
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<List<T>>();

            return new List<T>();
        }

        // Создать запись
        public async Task<bool> CreateAsync(T item)
        {
            var response = await _client.PostAsJsonAsync(_endpoint, item);
            return response.IsSuccessStatusCode;
        }

        // Обновить запись
        public async Task<bool> UpdateAsync(int id, T item)
        {
            var response = await _client.PutAsJsonAsync($"{_endpoint}/{id}", item);
            return response.IsSuccessStatusCode;
        }

        // Удалить запись (SoftDelete)
        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"{_endpoint}/{id}");
            return response.IsSuccessStatusCode;
        }

        // Восстановить запись
        public async Task<bool> RestoreAsync(int id)
        {
            var response = await _client.PostAsync($"{_endpoint}/restore/{id}", null);
            return response.IsSuccessStatusCode;
        }
    }
}
