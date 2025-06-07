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
    public partial class DeletedTransportationCompaniesForm : Form
    {
        private readonly ApiService<DeletedTransportationCompanyDto> _api =
            new ApiService<DeletedTransportationCompanyDto>("transportationcompany/deleted");

        public DeletedTransportationCompaniesForm()
        {
            InitializeComponent();
            Load += async (sender, args) => await LoadDeletedCompaniesAsync();
        }

        private async Task LoadDeletedCompaniesAsync()
        {
            var deletedCompanies = await _api.GetAllAsync();
            dataGridViewDeletedCompanies.DataSource = deletedCompanies;
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeletedCompanies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите компанию для восстановления");
                return;
            }

            var selected = (DeletedTransportationCompanyDto)dataGridViewDeletedCompanies.SelectedRows[0].DataBoundItem;

            try
            {
                var restoreApi = new ApiService<TransportationCompanyDto>("transportationcompany");

                if (await restoreApi.RestoreAsync(selected.ID))
                {
                    MessageBox.Show("Компания успешно восстановлена");
                    await LoadDeletedCompaniesAsync(); // обновляем таблицу
                }
                else
                {
                    MessageBox.Show("Ошибка при восстановлении компании");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDeletedCompaniesAsync();
        }

        private async void DeletedTransportationCompaniesForm_Load(object sender, EventArgs e)
        {
                await LoadDeletedCompaniesAsync();
        }
    }
}
