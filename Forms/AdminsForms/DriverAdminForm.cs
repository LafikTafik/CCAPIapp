using CCAPI.DTO.defaultt;
using CCAPIapp.Services;
using CCAPIapp.Forms.DelForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCAPIapp.Forms.AdminsForms
{
    public partial class DriverAdminForm : Form
    {
        private readonly ApiService<DriverDto> _api = new ApiService<DriverDto>("drivers");

        public DriverAdminForm()
        {
            InitializeComponent();
        }

        private async Task LoadDriversAsync()
        {
            try
            {
                var drivers = await _api.GetAllAsync();

                if (drivers == null || !drivers.Any())
                {
                    dataGridViewDrivers.DataSource = null;
                    MessageBox.Show("Нет активных водителей", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewDrivers.DataSource = drivers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateDriverFields())
                return;

            var dto = new DriverDto
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                LicenseNumber = txtLicenseNum.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            if (await _api.CreateAsync(dto))
            {
                MessageBox.Show("Водитель успешно добавлен");
                await LoadDriversAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении водителя");
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrivers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите водителя для редактирования");
                return;
            }

            var confirm = MessageBox.Show("Вы уверены, что хотите редактировать данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
            {
                return; 
            }

            if (!ValidateDriverFields())
                return;

            var selectedRow = dataGridViewDrivers.SelectedRows[0];
            var original = (DriverDto)selectedRow.DataBoundItem;

            var updated = new DriverDto
            {
                ID = original.ID,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                LicenseNumber = txtLicenseNum.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            if (await _api.UpdateAsync(original.ID, updated))
            {
                MessageBox.Show("Данные о водителе обновлены");
                await LoadDriversAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении водителя");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDrivers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите водителя для удаления");
                return;
            }

            var selectedId = (int)dataGridViewDrivers.SelectedRows[0].Cells["ID"].Value;

            var result = MessageBox.Show("Удалить водителя?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (await _api.DeleteAsync(selectedId))
                {
                    MessageBox.Show("Водитель помечен как удалённый");
                    await LoadDriversAsync();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить водителя");
                }
            }
        }

        private void btnViewDeleted_Click(object sender, EventArgs e)
        {
            var form = new DeletedDriversForm();
            form.ShowDialog();
            LoadDriversAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDriversAsync();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private async void DriverAdminForm_Load(object sender, EventArgs e)
        {
            await LoadDriversAsync();
        }

        private void dataGridViewDrivers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDrivers.SelectedRows.Count > 0)
            {
                var selected = (DriverDto)dataGridViewDrivers.SelectedRows[0].DataBoundItem;

                txtFirstName.Text = selected.FirstName;
                txtLastName.Text = selected.LastName;
                txtLicenseNum.Text = selected.LicenseNumber;
                txtPhoneNumber.Text = selected.PhoneNumber;
            }
        }

        private void dataGridViewDrivers_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewDrivers.SelectedRows.Count > 0)
            {
                var selected = (DriverDto)dataGridViewDrivers.SelectedRows[0].DataBoundItem;

                txtFirstName.Text = selected.FirstName;
                txtLastName.Text = selected.LastName;
                txtLicenseNum.Text = selected.LicenseNumber;
                txtPhoneNumber.Text = selected.PhoneNumber;
            }
        }
        private ErrorProvider errorProvider = new ErrorProvider();
        private bool ValidateDriverFields()
        {
            errorProvider.Clear(); // Очистка предыдущих ошибок
            bool isValid = true;

            // Имя
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, "Имя обязательно");
                MessageBox.Show("Поле 'Имя' обязательное", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                isValid = false;
            }
            else if (txtFirstName.Text.Length > 40)
            {
                errorProvider.SetError(txtFirstName, "Не более 40 символов");
                MessageBox.Show("Поле 'Имя' не должно превышать 40 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Zа-яА-ЯёЁ]+$"))
            {
                errorProvider.SetError(txtFirstName, "Только буквы");
                MessageBox.Show("Поле 'Имя' должно содержать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                isValid = false;
            }

            // Фамилия
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider.SetError(txtLastName, "Фамилия обязательна");
                MessageBox.Show("Поле 'Фамилия' обязательное", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                isValid = false;
            }
            else if (txtLastName.Text.Length > 40)
            {
                errorProvider.SetError(txtLastName, "Не более 40 символов");
                MessageBox.Show("Поле 'Фамилия' не должно превышать 40 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, @"^[a-zA-Zа-яА-ЯёЁ]+$"))
            {
                errorProvider.SetError(txtLastName, "Только буквы");
                MessageBox.Show("Поле 'Фамилия' должно содержать только буквы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                isValid = false;
            }

            // Номер лицензии — ровно 10 цифр
            var license = txtLicenseNum.Text.Replace(" ", "");

            if (string.IsNullOrWhiteSpace(license))
            {
                errorProvider.SetError(txtLicenseNum, "Обязательное поле");
                MessageBox.Show("Поле 'Номер лицензии' обязательное", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseNum.Focus();
                isValid = false;
            }
            else if (license.Length != 10 || !System.Text.RegularExpressions.Regex.IsMatch(license, @"^\d{10}$"))
            {
                errorProvider.SetError(txtLicenseNum, "Должно быть ровно 10 цифр");
                MessageBox.Show("Поле 'Номер лицензии' должно содержать ровно 10 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseNum.Focus();
                isValid = false;
            }

            // Телефон — 11 или 12 цифр
            var phone = txtPhoneNumber.Text.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "");

            if (string.IsNullOrWhiteSpace(phone))
            {
                errorProvider.SetError(txtPhoneNumber, "Обязательное поле");
                MessageBox.Show("Поле 'Телефон' обязательное", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                isValid = false;
            }
            else if (phone.Length < 11 || phone.Length > 12)
            {
                errorProvider.SetError(txtPhoneNumber, "Должно быть 11 или 12 цифр");
                MessageBox.Show("Поле 'Телефон' должно содержать 11 или 12 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
            {
                errorProvider.SetError(txtPhoneNumber, "Только цифры");
                MessageBox.Show("Поле 'Телефон' должно содержать только цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                isValid = false;
            }

            return isValid;
        }
    }
}