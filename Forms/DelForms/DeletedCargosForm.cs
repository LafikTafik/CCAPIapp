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
    public partial class DeletedCargosForm : Form
    {
        private readonly ApiService<DeletedCargoDto> _api = new ApiService<DeletedCargoDto>("cargos");

        public DeletedCargosForm()
        {
            InitializeComponent();
        }

        private async Task LoadDeletedCargosAsync()
        {
            var deletedCargos = await _api.GetDeletedAsync();
            dataGridViewDeletedCargos.DataSource = deletedCargos;
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeletedCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите груз для восстановления");
                return;
            }

            var selectedId = (int)dataGridViewDeletedCargos.SelectedRows[0].Cells["ID"].Value;

            if (await _api.RestoreAsync(selectedId))
            {
                MessageBox.Show("Груз успешно восстановлен");
                await LoadDeletedCargosAsync(); // обновляем таблицу
            }
            else
            {
                MessageBox.Show("Не удалось восстановить груз");
            }
        }

        private async void DeletedCargosForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDeletedCargosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}