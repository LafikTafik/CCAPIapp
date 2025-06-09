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
    public partial class DeletedOrdersForm : Form
    {
        private readonly ApiService<DeletedOrderDto> _api = new ApiService<DeletedOrderDto>("orders");

        public DeletedOrdersForm()
        {
            InitializeComponent();
        }

        private async Task LoadDeletedOrdersAsync()
        {
            var deletedOrders = await _api.GetDeletedAsync();
            dataGridViewDeletedOrders.DataSource = deletedOrders;
        }

        private async void btnRestore_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewDeletedOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для восстановления");
                return;
            }

            var selectedId = (int)dataGridViewDeletedOrders.SelectedRows[0].Cells["ID"].Value;

            if (await _api.RestoreAsync(selectedId))
            {
                MessageBox.Show("Заказ успешно восстановлен");
                await LoadDeletedOrdersAsync(); 
            }
            else
            {
                MessageBox.Show("Не удалось восстановить заказ");
            }
        }

        private async void DeletedOrdersForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDeletedOrdersAsync();
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