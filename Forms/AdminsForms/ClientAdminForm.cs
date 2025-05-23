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

namespace CCAPIapp.Forms.AdminsForms
{
    public partial class ClientAdminForm : Form
    {
        public ClientAdminForm()
        {
            InitializeComponent();
        }
        private readonly HttpClient _client = new();

        private async Task LoadClientsAsync()
        {
            var url = "https://localhost:7218/api/clients";

            try
            {
                var clients = await _client.GetFromJsonAsync<List<ClientDto>>(url);

                if (clients != null)
                {
                    dataGridViewClients.DataSource = clients;
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
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Имя и фамилия обязательны");
                return;
            }

            var client = new ClientDto
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text
            };

            var json = JsonSerializer.Serialize(client);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://localhost:7218/api/clients";

            var response = await _client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Клиент успешно добавлен");
                LoadClientsAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении клиента");
            }
        }

        private async void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента для редактирования");
                return;
            }

            var selectedRow = dataGridViewClients.SelectedRows[0];
            var originalClient = (ClientDto)selectedRow.DataBoundItem;

            var updatedClient = new ClientDto
            {
                ID = originalClient.ID,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text
            };

            var json = JsonSerializer.Serialize(updatedClient);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = $"https://localhost:7218/api/clients/{updatedClient.ID}";

            var response = await _client.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                await LoadClientsAsync(); // обновляем таблицу
                MessageBox.Show("Клиент успешно обновлён");
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении клиента");
            }
        }

        private async void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента для удаления");
                return;
            }

            var selectedId = (int)dataGridViewClients.SelectedRows[0].Cells["ID"].Value;

            var result = MessageBox.Show("Удалить этого клиента?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var url = $"https://localhost:7218/api/clients/{selectedId}";

                var response = await _client.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    await LoadClientsAsync(); // обновляем данные
                }
                else
                {
                    MessageBox.Show("Не удалось удалить клиента");
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

        private async void ClientAdminForm_Load_1(object sender, EventArgs e)
        {
            await LoadClientsAsync();
        }

        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewClients.SelectedRows[0];
                var client = (ClientDto)selectedRow.DataBoundItem;

                txtName.Text = client.Name;
                txtSurname.Text = client.Surname;
                txtPhone.Text = client.Phone;
                txtEmail.Text = client.Email;
                txtAddress.Text = client.Address;
            }
        }
    }
}
