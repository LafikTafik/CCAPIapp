using CCAPI.DTO.defaultt;
using CCAPIapp.Services;
using CCAPIapp.Forms.DelForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CCAPIapp.Forms.AdminsForms
{
    public partial class VehicleAdminForm : Form
    {
        private readonly ApiService<VehicleDto> _api = new ApiService<VehicleDto>("vehicles");

        public VehicleAdminForm()
        {
            InitializeComponent();
        }

        private async Task LoadVehiclesAsync()
        {
            try
            {
                var vehicles = await _api.GetAllAsync();

                if (vehicles == null || !vehicles.Any())
                {
                    dataGridViewVehicles.DataSource = null;
                    MessageBox.Show("Нет активных транспортов", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewVehicles.DataSource = vehicles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateVehicleFields())
                return;

            var dto = new VehicleDto
            {
                TransportationCompanyId = int.Parse(txtCompanyId.Text),
                Type = txtType.Text,
                Capacity = txtCapacity.Text,
                VehicleNum = txtVehicleNum.Text,
                DriverId = int.TryParse(txtDriverId.Text, out var driverId) ? driverId : 0
            };

            if (await _api.CreateAsync(dto))
            {
                MessageBox.Show("Транспорт успешно добавлен");
                await LoadVehiclesAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении транспорта");
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите транспорт для редактирования");
                return;
            }

            var confirm = MessageBox.Show("Вы уверены, что хотите редактировать данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            if (!ValidateVehicleFields())
                return;

            var selectedRow = dataGridViewVehicles.SelectedRows[0];
            var original = (VehicleDto)selectedRow.DataBoundItem;

            var updated = new VehicleDto
            {
                ID = original.ID,
                TransportationCompanyId = int.Parse(txtCompanyId.Text),
                Type = txtType.Text,
                Capacity = txtCapacity.Text,
                VehicleNum = txtVehicleNum.Text,
                DriverId = int.TryParse(txtDriverId.Text, out var driverId) ? driverId : 0

            };

            if (await _api.UpdateAsync(original.ID, updated))
            {
                MessageBox.Show("Транспорт обновлён");
                await LoadVehiclesAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении транспорта");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите транспорт для удаления");
                return;
            }

            var selectedId = (int)dataGridViewVehicles.SelectedRows[0].Cells["ID"].Value;

            var result = MessageBox.Show("Удалить транспорт?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (await _api.DeleteAsync(selectedId))
                {
                    MessageBox.Show("Транспорт помечен как удалённый");
                    await LoadVehiclesAsync();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить транспорт");
                }
            }
        }

        private void btnViewDeleted_Click(object sender, EventArgs e)
        {
            var form = new DeletedVehiclesForm();
            form.ShowDialog();
            LoadVehiclesAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadVehiclesAsync();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private async void VehicleAdminForm_Load(object sender, EventArgs e)
        {
            await LoadVehiclesAsync();
        }

        private void dataGridViewVehicles_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewVehicles.SelectedRows.Count > 0)
            {
                var selected = (VehicleDto)dataGridViewVehicles.SelectedRows[0].DataBoundItem;
                txtCompanyId.Text = selected.TransportationCompanyId.ToString();
                txtType.Text = selected.Type;
                txtCapacity.Text = selected.Capacity;
                txtVehicleNum.Text = selected.VehicleNum;
                txtDriverId.Text = selected.DriverId.ToString();
            }
        }
        private ErrorProvider errorProvider = new ErrorProvider();

        private bool ValidateVehicleFields()
        {
            errorProvider.Clear(); // Очищаем предыдущие ошибки
            bool isValid = true;

            // Грузоподъемность - только число > 0
            if (!decimal.TryParse(txtCapacity.Text, out var capacity) || capacity <= 0)
            {
                errorProvider.SetError(txtCapacity, "Должно быть положительным числом");
                MessageBox.Show("Поле 'Грузоподъемность' должно содержать положительное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCapacity.Focus();
                isValid = false;
            }

            // ID Водителя - только положительное число
            if (!int.TryParse(txtDriverId.Text, out var driverId) || driverId <= 0)
            {
                errorProvider.SetError(txtDriverId, "Должно быть положительным числом");
                MessageBox.Show("Поле 'ID водителя' должно содержать положительное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDriverId.Focus();
                isValid = false;
            }

            // Номер ТС: формат А123БВ (1 буква + 3 цифры + 2 буквы)
            var vehicleNum = txtVehicleNum.Text.Trim();

            if (string.IsNullOrWhiteSpace(vehicleNum))
            {
                errorProvider.SetError(txtVehicleNum, "Поле обязательно к заполнению");
                MessageBox.Show("Поле 'Номер ТС' обязательно к заполнению", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVehicleNum.Focus();
                isValid = false;
            }
            else
            {

                var regex = new System.Text.RegularExpressions.Regex(@"^[A-Za-zА-Яа-яЁё]\d{3}[A-Za-zА-Яа-яЁё]{2}$",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                if (!regex.IsMatch(vehicleNum))
                {
                    errorProvider.SetError(txtVehicleNum, "Формат: А123БВ");
                    MessageBox.Show("Неверный формат номера ТС. Пример: А123БВ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVehicleNum.Focus();
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}