using CCAPI.DTO.defaultt;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace CCAPIapp.Services
{
    public class ApiService<T> where T : class
    {
        
        public readonly HttpClient _client;
        public readonly string _endpoint;

        public ApiService(string endpoint)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7218/api/");
            _endpoint = endpoint;
        }
        public async Task<List<T>> GetAllAsync()
        {
            var response = await _client.GetAsync(_endpoint);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<T>>();
            }
            return new List<T>();
        }
        public async Task<bool> CreateAsync(T item)
        {
            var content = new StringContent(JsonSerializer.Serialize(item), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(_endpoint, content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync(int id, T item)
        {
            var content = new StringContent(JsonSerializer.Serialize(item), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_endpoint}/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"{_endpoint}/{id}");
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> RestoreAsync(int id)
        {
            var response = await _client.PostAsync($"{_endpoint}/restore/{id}", null);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<T>> GetDeletedAsync()
        {
            var response = await _client.GetAsync($"{_endpoint}/deleted");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<T>>();
            }
            return new List<T>();
        }
        //_________________________________________________________
        public async Task<List<CargoOrdersDto>> GetByOrderIdAsync(int orderId)
        {
            var response = await _client.GetAsync($"{_endpoint}/orders/{orderId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<CargoOrdersDto>>();
            }
            return new List<CargoOrdersDto>();
        }
        public async Task<List<TransCompDto>> GetByTransportationIdAsync(int transportationId)
        {
            var response = await _client.GetAsync($"{_endpoint}/transportation/{transportationId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<TransCompDto>>();
            }
            return new List<TransCompDto>();
        }
        public async Task<bool> CreateAsync(TransCompDto dto)
        {
            try
            {
                var response = await _client.PostAsJsonAsync(_endpoint, dto);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении компании: {ex.Message}");
                return false;
            }
        }

    }
}