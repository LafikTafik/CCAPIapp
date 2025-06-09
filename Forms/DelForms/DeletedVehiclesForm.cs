using CCAPI.DTO.deleted;
using CCAPIapp.Services;

using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCAPIapp.Forms.DelForms
{
    public partial class DeletedVehiclesForm : Form
    {
        private readonly ApiService<DeletedVehicleDto> _api = new ApiService<DeletedVehicleDto>("vehicles");

        public DeletedVehiclesForm()
        {
            InitializeComponent();
        }

        private async Task LoadDeletedVehiclesAsync()
        {
            try
            {
                var deletedVehicles = await _api.GetDeletedAsync();

                if (deletedVehicles == null || !deletedVehicles.Any())
                {
                    dataGridViewDeletedVehicles.DataSource = null;
                    MessageBox.Show("Нет удалённых транспортов", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewDeletedVehicles.DataSource = deletedVehicles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeletedVehicles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите транспорт для восстановления");
                return;
            }

            var selectedRow = dataGridViewDeletedVehicles.SelectedRows[0];
            var selectedVehicle = (DeletedVehicleDto)selectedRow.DataBoundItem;

            var result = MessageBox.Show(
                $"Восстановить транспорт с ID={selectedVehicle.ID}?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (await _api.RestoreAsync(selectedVehicle.ID))
                {
                    MessageBox.Show("Транспорт успешно восстановлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDeletedVehiclesAsync(); 
                }
                else
                {
                    MessageBox.Show("Не удалось восстановить транспорт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void DeletedVehiclesForm_Load(object sender, EventArgs e)
        {
            await LoadDeletedVehiclesAsync();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}