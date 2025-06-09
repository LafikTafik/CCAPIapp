using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CCAPI.DTO.defaultt;
using CCAPI.DTO.deleted;
using System.Windows.Forms;
using CCAPIapp.Services;
using CCAPIapp.Forms.DelForms;
using CCAPI.Models;

namespace CCAPIapp.Forms.AdminsForms

{
    public partial class TransportationAdminForm : Form
    {
        private readonly ApiService<TransportationDto> _api = new ApiService<TransportationDto>("transportations");
        private readonly ApiService<TransportationCompanyDto> _companyApi = new ApiService<TransportationCompanyDto>("TransportationCompany");
        private readonly ApiService<TransCompDto> _transCompApi = new ApiService<TransCompDto>("TransComp");

        public TransportationAdminForm()
        {
            InitializeComponent();
            Load += async (sender, args) => await LoadTransportationsAsync();
            Load += async (s, e) => await LoadCompaniesAsync();
        }

        private async Task LoadTransportationsAsync()
        {
            var transportations = await _api.GetAllAsync();
            dataGridViewTransportations.DataSource = transportations;
            await LoadCompaniesAsync();

        }

        private void dataGridViewTransportations_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTransportations.SelectedRows.Count > 0)
            {
                var selected = (TransportationDto)dataGridViewTransportations.SelectedRows[0].DataBoundItem;


                txtCargoId.Text = selected.CargoId.ToString();
                txtVehicleId.Text = selected.VehicleId.ToString();
                txtStartPoint.Text = selected.StartPoint;
                txtEndPoint.Text = selected.EndPoint;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            var dto = new TransportationDto
            {
                CargoId = int.Parse(txtCargoId.Text),
                VehicleId = int.Parse(txtVehicleId.Text),
                StartPoint = txtStartPoint.Text,
                EndPoint = txtEndPoint.Text
            };

            if (await _api.CreateAsync(dto))
            {
                MessageBox.Show("Перевозка добавлена");
                await LoadTransportationsAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении перевозки");
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransportations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите перевозку для редактирования");
                return;
            }

            var confirm = MessageBox.Show("Вы уверены, что хотите изменить эту перевозку?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            if (!ValidateFields())
                return;

            var selectedRow = dataGridViewTransportations.SelectedRows[0];
            var original = (TransportationDto)selectedRow.DataBoundItem;

            var updated = new TransportationDto
            {
                ID = original.ID,
                CargoId = int.Parse(txtCargoId.Text),
                VehicleId = int.Parse(txtVehicleId.Text),
                StartPoint = txtStartPoint.Text,
                EndPoint = txtEndPoint.Text
            };

            if (await _api.UpdateAsync(original.ID, updated))
            {
                MessageBox.Show("Перевозка обновлена");
                await LoadTransportationsAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении перевозки");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransportations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите перевозку для удаления");
                return;
            }

            var confirm = MessageBox.Show("Вы действительно хотите удалить эту перевозку?", "Удаление", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            var selectedRow = dataGridViewTransportations.SelectedRows[0];
            var transportation = (TransportationDto)selectedRow.DataBoundItem;

            if (await _api.DeleteAsync(transportation.ID))
            {
                MessageBox.Show("Перевозка успешно удалена");
                await LoadTransportationsAsync();
            }
            else
            {
                MessageBox.Show("Не удалось удалить перевозку");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Hide();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadTransportationsAsync();
        }

        private void btnViewDeleted_Click(object sender, EventArgs e)
        {
            var form = new DeletedTransportationsForm();
            form.Show();
        }

        private void TransportationAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private bool ValidateFields()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (!int.TryParse(txtCargoId.Text, out var cargoId) || cargoId <= 0)
            {
                errorProvider.SetError(txtCargoId, "Должно быть целым положительным числом");
                MessageBox.Show("Поле 'CargoID' должно содержать целое положительное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if (!int.TryParse(txtVehicleId.Text, out var vehicleId) || vehicleId <= 0)
            {
                errorProvider.SetError(txtVehicleId, "Должно быть целым положительным числом");
                MessageBox.Show("Поле 'VehicleID' должно содержать целое положительное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtStartPoint.Text))
            {
                errorProvider.SetError(txtStartPoint, "Поле не может быть пустым");
                MessageBox.Show("Поле 'Начальная точка' обязательно к заполнению", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                errorProvider.SetError(txtEndPoint, "Поле не может быть пустым");
                MessageBox.Show("Поле 'Конечная точка' обязательно к заполнению", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }

        private async void TransportationAdminForm_Load(object sender, EventArgs e)
        {
            await LoadTransportationsAsync();

        }

        private async Task LoadCompaniesAsync()
        {

            var companies = await _companyApi.GetAllAsync();

            if (!companies.Any())
            {
                MessageBox.Show("Список компаний пуст");
                return;
            }

            var displayCompanies = companies.Select(c => new
            {
                c.ID,
                DisplayText = $"{c.Name} (ID: {c.ID})"
            }).ToList();

            cmbCompanies.DataSource = displayCompanies;
            cmbCompanies.DisplayMember = "DisplayText";
            cmbCompanies.ValueMember = "ID";
        }
        private async void btnAddCompanyToTransportation_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransportations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите перевозку в таблице");
                return;
            }

            var selectedTransportationId = Convert.ToInt32(dataGridViewTransportations.SelectedRows[0].Cells["ID"].Value);

            if (cmbCompanies.SelectedItem == null)
            {
                MessageBox.Show("Выберите компанию из списка");
                return;
            }

            var selectedCompanyId = (int)cmbCompanies.SelectedValue;

            var dto = new TransCompDto
            {
                TransportationID = selectedTransportationId,
                CompanyID = selectedCompanyId
            };

            Console.WriteLine($"DTO: TransportationID = {dto.TransportationID}, CompanyID = {dto.CompanyID}");
            if (await _transCompApi.CreateAsync(dto))
            {
                MessageBox.Show("Компания успешно добавлена к перевозке");
                await LoadCompaniesForTransportation(selectedTransportationId);
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении компании");
            }
        }

        private async Task LoadCompaniesForTransportation(int transportationId)
        {
            var companiesInTransportation = await _transCompApi.GetByTransportationIdAsync(transportationId);
            if (companiesInTransportation.Count == 0)
            {
                MessageBox.Show("Нет связанных компаний для этой перевозки");
            }
            else
            {
                MessageBox.Show($"Найдено {companiesInTransportation.Count} компаний");
            }
        }
    }
}
    
