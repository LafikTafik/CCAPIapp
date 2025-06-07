using CCAPI.DTO.defaultt;
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
    public partial class DeletedTransportationsForm : Form
    {
        private readonly ApiService<DeletedTransportationDto> _api = new ApiService<DeletedTransportationDto>("transportations/deleted");

        public DeletedTransportationsForm()
        {
            InitializeComponent();
            Load += async (sender, args) => await LoadDeletedTransportationsAsync();
        }

        private async Task LoadDeletedTransportationsAsync()
        {
            var transportations = await _api.GetAllAsync();
            dataGridViewDeletedTransportations.DataSource = transportations;
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeletedTransportations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись для восстановления");
                return;
            }

            var selected = (DeletedTransportationDto)dataGridViewDeletedTransportations.SelectedRows[0].DataBoundItem;

            var restoreApi = new ApiService<TransportationDto>("transportations");

            if (await restoreApi.RestoreAsync(selected.ID))
            {
                MessageBox.Show("Перевозка восстановлена");
                await LoadDeletedTransportationsAsync(); // перезагрузим список удалённых
            }
            else
            {
                MessageBox.Show("Не удалось восстановить перевозку");
            }
        }




        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDeletedTransportationsAsync();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
