using CCAPI.DTO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CCAPIapp.Forms.AdminsForms
{
    public partial class OrderAdminForm : Form
    {

        public OrderAdminForm()
        {
            InitializeComponent();
        }
        private readonly HttpClient _client = new();


        private async Task LoadOrdersAsync()
        {
            var url = "https://localhost:7218/api/order";

            try
            {
                var orders = await _client.GetFromJsonAsync<List<OrderDto>>(url);
                if (orders != null)
                {
                    dataGridViewOrders.DataSource = orders;
                }
                else
                {
                    MessageBox.Show("Не удалось получить данные");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private async void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIDClient.Text, out int idClient))
            {
                MessageBox.Show("Неверный ID клиента");
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Выберите статус из списка");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Неверная сумма");
                return;
            }

            var newOrder = new OrderDto
            {
                IDClient = idClient,
                Status = cmbStatus.SelectedItem.ToString(),
                Price = price,
                Date = dtpDate.Value
            };


            var json = JsonSerializer.Serialize(newOrder);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://localhost:7218/api/order";

            var response = await _client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Заказ успешно добавлен");
                await LoadOrdersAsync(); // обновляем таблицу
            }
            else
            {
                var errorText = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Ошибка при добавлении: {errorText}");
            }
        }

        private async void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для редактирования");
                return;
            }

            var selectedRow = dataGridViewOrders.SelectedRows[0];
            var originalOrder = (OrderDto)selectedRow.DataBoundItem;

            if (!int.TryParse(txtIDClient.Text, out int idClient))
            {
                MessageBox.Show("Неверный ID клиента");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Неверная сумма заказа");
                return;
            }

            var updatedOrder = new OrderDto
            {
                ID = originalOrder.ID,
                IDClient = idClient,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Новый", // берём выбранный статус
                Price = price,
                Date = dtpDate.Value
            };

            var json = JsonSerializer.Serialize(updatedOrder);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = $"https://localhost:7218/api/order/{updatedOrder.ID}";

            var response = await _client.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                await LoadOrdersAsync(); // обновляем таблицу
                MessageBox.Show("Заказ обновлён");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении заказа");
            }
        }

        private async void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для удаления");
                return;
            }

            var selectedId = (int)dataGridViewOrders.SelectedRows[0].Cells["ID"].Value;

            var url = $"https://localhost:7218/api/order/{selectedId}";
            var response = await _client.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                await LoadOrdersAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении заказа");
            }
        }
        private async void OrderAdminForm_Load_1(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); // показываем AdminForm
            }

            this.Hide();
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewOrders.SelectedRows[0];
                var order = (OrderDto)selectedRow.DataBoundItem;

                txtIDClient.Text = order.IDClient.ToString();
                dtpDate.Value = order.Date ?? DateTime.Now;
                txtPrice.Text = order.Price.ToString();

                // Устанавливаем текущий статус в ComboBox
                cmbStatus.SelectedItem = order.Status;
            }
        }
    }

}
