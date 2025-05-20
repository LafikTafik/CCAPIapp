using CCAPIapp.DTO;
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
using static CCAPI.Controllers.CargosController;

namespace CCAPIapp.Forms.AdminsForms
{
    public partial class CargoAdminForm : Form
    {
        public CargoAdminForm()
        {
            InitializeComponent();
        }
        private readonly HttpClient _client = new();

        private async Task LoadCargosAsync()
        {
            var url = "https://localhost:7218/api/Cargos";

            try
            {
                var cargos = await _client.GetFromJsonAsync<List<CargoDto>>(url);
                if (cargos != null && cargos.Count > 0)
                {
                    dataGridViewCargos.DataSource = cargos;
                }
                else
                {
                    MessageBox.Show("Нет данных");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }

        private async void CargoAdminForm_Load(object sender, EventArgs e)
        {
            await LoadCargosAsync();
        }

        private async void btnAddCargo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtDimensions.Text))
            {
                MessageBox.Show("Поля 'Вес' и 'Размеры' обязательны");
                return;
            }

            if (!int.TryParse(txtOrderID.Text, out int orderId))
            {
                MessageBox.Show("Введите корректный ID заказа");
                return;
            }

            var dto = new CreateCargoDto
            {
                Weight = txtWeight.Text,
                Dimensions = txtDimensions.Text,
                Descriptions = txtDescription.Text,
                OrderID = orderId
            };

            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://localhost:7218/api/Cargos";

            var response = await _client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Груз успешно добавлен");
                await LoadCargosAsync(); // обновляем таблицу
            }
            else
            {
                var errorText = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Ошибка при добавлении: {errorText}");
            }
        }

        private async void btnEditCargo_Click(object sender, EventArgs e)
        {
            if (dataGridViewCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите груз для редактирования");
                return;
            }

            var selectedRow = dataGridViewCargos.SelectedRows[0];
            var originalCargo = (CargoDto)selectedRow.DataBoundItem;

            if (!int.TryParse(txtOrderID.Text, out int orderId))
            {
                MessageBox.Show("Введите корректный OrderID");
                return;
            }

            var dto = new CargoDto
            {
                Weight = txtWeight.Text,
                Dimensions = txtDimensions.Text,
                Descriptions = txtDescription.Text,
                OrderID = orderId
            };

            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = $"https://localhost:7218/api/Cargos/{originalCargo.ID}";

            var response = await _client.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Груз обновлён");
                await LoadCargosAsync(); // обновляем таблицу
            }
            else
            {
                var errorText = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Ошибка при обновлении: {errorText}");
            }
        }

        private async void btnDeleteCargo_Click(object sender, EventArgs e)
        {
            if (dataGridViewCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите груз для удаления");
                return;
            }

            var selectedId = (int)dataGridViewCargos.SelectedRows[0].Cells["ID"].Value;

            var result = MessageBox.Show("Удалить этот груз?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var url = $"https://localhost:7218/api/Cargos/{selectedId}";
                var response = await _client.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    await LoadCargosAsync();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить груз");
                }
            }
        }

        private void dataGridViewCargos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCargos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewCargos.SelectedRows[0];
                var cargo = (CargoDto)selectedRow.DataBoundItem;

                txtWeight.Text = cargo.Weight;
                txtDimensions.Text = cargo.Dimensions;
                txtDescription.Text = cargo.Descriptions;

      
                if (cargo.OrderID.HasValue)
                {
                    txtOrderID.Text = cargo.OrderID.Value.ToString();
                }
                else
                {
                    txtOrderID.Clear(); 
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); // показываем AdminForm
            }

            this.Hide();
        }
    }
}


