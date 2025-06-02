using CCAPI.DTO.deleted;
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

namespace CCAPIapp.Forms.DelForms
{
    public partial class DeletedClientsForm : Form
    {
        private readonly ApiService<DeletedClientDto> _api = new ApiService<DeletedClientDto>("clients");

        public DeletedClientsForm()
        {
            InitializeComponent();
        }

        private async Task LoadDeletedClientsAsync()
        {
            var deletedClients = await _api.GetDeletedAsync();
            dataGridViewDeletedClients.DataSource = deletedClients;
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeletedClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента для восстановления");
                return;
            }

            var selectedId = (int)dataGridViewDeletedClients.SelectedRows[0].Cells["ID"].Value;

            if (await _api.RestoreAsync(selectedId))
            {
                MessageBox.Show("Клиент успешно восстановлен");
                LoadDeletedClientsAsync();
            }
            else
            {
                MessageBox.Show("Не удалось восстановить клиента");
            }
        }

        private async void DeletedClientsForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDeletedClientsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
