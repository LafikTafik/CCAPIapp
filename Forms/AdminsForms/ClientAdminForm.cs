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
using CCAPI.DTO.defaultt;
using CCAPI.DTO.deleted;
using System.Windows.Forms;
using CCAPIapp.Services;
using CCAPIapp.Forms.DelForms;
namespace CCAPIapp.Forms.AdminsForms
{
    public partial class ClientAdminForm : Form
    {
        private readonly ApiService<ClientDto> _api = new ApiService<ClientDto>("clients");

        public ClientAdminForm()
        {
            InitializeComponent();
        }

        private async Task LoadClientsAsync()
        {
            var clients = await _api.GetAllAsync();
            dataGridViewClients.DataSource = clients;
        }

        private async void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!ValidateClientFields())
                return;

            var client = new ClientDto
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text
            };

            if (await _api.CreateAsync(client))
            {
                MessageBox.Show("Клиент успешно добавлен");
                await LoadClientsAsync();
                ClearForm();
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

            var confirm = MessageBox.Show("Вы уверены, что хотите редактировать данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
            {
                return; 
            }

            if (!ValidateClientFields())
                return;

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

            if (await _api.UpdateAsync(originalClient.ID, updatedClient))
            {
                MessageBox.Show("Клиент обновлён");
                await LoadClientsAsync();
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
                if (await _api.DeleteAsync(selectedId))
                {
                    MessageBox.Show("Клиент успешно удалён");
                    await LoadClientsAsync();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new DeletedClientsForm();
            form.Show();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadClientsAsync();
        }

        private void ClientAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private ErrorProvider errorProvider = new ErrorProvider();
        private bool ValidateClientFields()
        {
            errorProvider.Clear();

            bool isValid = true;

            // Имя
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Имя обязательно");
                isValid = false;
            }
            else if (txtName.Text.Length > 40)
            {
                errorProvider.SetError(txtName, "Не более 40 символов");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, @"^[a-zA-Zа-яА-ЯёЁ]+$"))
            {
                errorProvider.SetError(txtName, "Только буквы");
                isValid = false;
            }

            // Фамилия
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errorProvider.SetError(txtSurname, "Фамилия обязательна");
                isValid = false;
            }
            else if (txtSurname.Text.Length > 40)
            {
                errorProvider.SetError(txtSurname, "Не более 40 символов");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtSurname.Text, @"^[a-zA-Zа-яА-ЯёЁ]+$"))
            {
                errorProvider.SetError(txtSurname, "Только буквы");
                isValid = false;
            }

            // ТЕЛЕФОН - обновлённая версия
            string phone = txtPhone.Text.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");

            if (string.IsNullOrWhiteSpace(phone))
            {
                errorProvider.SetError(txtPhone, "Номер телефона обязателен");
                isValid = false;
            }
            else if (phone.Length < 11 || phone.Length > 12)
            {
                errorProvider.SetError(txtPhone, "Должно быть 11 или 12 цифр");
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
            {
                errorProvider.SetError(txtPhone, "Только цифры");
                isValid = false;
            }

            // Email
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                errorProvider.SetError(txtEmail, "Email должен содержать @ и .");
                isValid = false;
            }

            return isValid;
        }
        private void ClearForm()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            errorProvider.Clear(); // очищаем ошибки валидации
        }
    }
}
