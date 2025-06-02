using CCAPI.DTO.deleted;
using CCAPIapp.Services;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCAPIapp.Forms.DelForms
{
    public partial class DeletedDriversForm : Form
    {
        private readonly ApiService<DeletedDriverDto> _api = new ApiService<DeletedDriverDto>("drivers");

        public DeletedDriversForm()
        {
            InitializeComponent();
        }

        private async Task LoadDeletedDriversAsync()
        {
            var deleted = await _api.GetDeletedAsync();
            dataGridViewDeletedDrivers.DataSource = deleted;
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeletedDrivers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите водителя для восстановления");
                return;
            }

            var selected = (DeletedDriverDto)dataGridViewDeletedDrivers.SelectedRows[0].DataBoundItem;

            if (await _api.RestoreAsync(selected.ID))
            {
                MessageBox.Show("Водитель восстановлен");
                await LoadDeletedDriversAsync(); // обновляем список
            }
            else
            {
                MessageBox.Show("Не удалось восстановить водителя");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void DeletedDriversForm_Load(object sender, EventArgs e)
        {
            await LoadDeletedDriversAsync();
        }
    }
}