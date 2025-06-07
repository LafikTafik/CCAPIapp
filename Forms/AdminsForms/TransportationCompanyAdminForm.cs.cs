using CCAPI.DTO.defaultt;
using CCAPIapp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCAPIapp.Forms.DelForms;

namespace CCAPIapp.Forms.AdminsForms
{
    public partial class TransportationCompanyAdminForm : Form
    {
        private readonly ApiService<TransportationCompanyDto> _api = new ApiService<TransportationCompanyDto>("transportationcompany");

        public TransportationCompanyAdminForm()
        {
            InitializeComponent();
            Load += async (sender, args) => await LoadCompaniesAsync();
        }

        private async Task LoadCompaniesAsync()
        {
            var companies = await _api.GetAllAsync();
            dataGridViewCompanies.DataSource = companies;
        }

        private void dataGridViewCompanies_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCompanies.SelectedRows.Count > 0)
            {
                var selected = (TransportationCompanyDto)dataGridViewCompanies.SelectedRows[0].DataBoundItem;

                txtName.Text = selected.Name;
                txtAddress.Text = selected.Address;
                txtPhone.Text = selected.PhoneNumber;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            var dto = new TransportationCompanyDto
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhone.Text
            };

            if (await _api.CreateAsync(dto))
            {
                MessageBox.Show("Компания успешно добавлена");
                await LoadCompaniesAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении компании");
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompanies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите компанию для редактирования");
                return;
            }

            var confirm = MessageBox.Show("Вы уверены, что хотите изменить данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            if (!ValidateFields())
                return;

            var selectedRow = dataGridViewCompanies.SelectedRows[0];
            var original = (TransportationCompanyDto)selectedRow.DataBoundItem;

            var updated = new TransportationCompanyDto
            {
                ID = original.ID,
                Name = txtName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhone.Text
            };

            if (await _api.UpdateAsync(original.ID, updated))
            {
                MessageBox.Show("Компания обновлена");
                await LoadCompaniesAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении компании");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompanies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите компанию для удаления");
                return;
            }

            var selectedRow = dataGridViewCompanies.SelectedRows[0];
            var company = (TransportationCompanyDto)selectedRow.DataBoundItem;

            var confirm = MessageBox.Show("Вы действительно хотите удалить эту компанию?", "Удаление", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (await _api.DeleteAsync(company.ID))
                {
                    MessageBox.Show("Компания успешно удалена");
                    await LoadCompaniesAsync();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении компании");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner?.Show(); // показываем предыдущую форму
            this.Hide();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadCompaniesAsync();
        }

        private void btnViewDeleted_Click(object sender, EventArgs e)
        {
            var form = new DeletedTransportationCompaniesForm();
            form.Show();
        }

        private void TransportationCompanyAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); // выход из приложения при закрытии формы
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private bool ValidateFields()
        {
            errorProvider.Clear();
            bool isValid = true;

            // Проверка названия
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Название обязательно");
                MessageBox.Show("Поле 'Название' не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (txtName.Text.Length < 2 || txtName.Text.Length > 100)
            {
                errorProvider.SetError(txtName, "Длина от 2 до 100 символов");
                MessageBox.Show("Поле 'Название' должно содержать от 2 до 100 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            // Проверка телефона
            if (!string.IsNullOrWhiteSpace(txtPhone.Text) &&
                !System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, @"^\+?[0-9\- ]+$"))
            {
                errorProvider.SetError(txtPhone, "Только цифры, пробелы, тире и опциональный '+'");
                MessageBox.Show("Поле 'Телефон' содержит недопустимые символы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }

        private async void TransportationCompanyAdminForm_Load(object sender, EventArgs e)
        {
            await LoadCompaniesAsync();
        }
    }
}
