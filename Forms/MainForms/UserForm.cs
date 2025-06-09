using System;
using System.Linq;
using System.Windows.Forms;
using CCAPI.DTO.defaultt;
using CCAPIapp.Forms.AdminsForms;
using CCAPIapp.Services;

namespace CCAPIapp
{
    public partial class UserForm : Form
    {
        private readonly ApiService<ClientDto> _clientApi = new ApiService<ClientDto>("clients");
        private readonly ApiService<TransportationCompanyDto> _companyApi = new ApiService<TransportationCompanyDto>("transportationcompany");
        private readonly ApiService<CargoDto> _cargoApi = new ApiService<CargoDto>("cargos");
        private readonly ApiService<VehicleDto> _vehicleApi = new ApiService<VehicleDto>("vehicles");
        private readonly ApiService<TransportationDto> _transApi = new ApiService<TransportationDto>("transportations");
        private readonly ApiService<OrderDto> _orderApi = new ApiService<OrderDto>("orders");

        public UserForm()
        {
            InitializeComponent();
            Load += async (s, e) => await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
      
            var clients = await _clientApi.GetAllAsync();

            var displayClients = clients.Select(c => new
            {
                c.ID,
                DisplayText = $"{c.Surname} {c.Name} (ID: {c.ID})"
            }).ToList();

            cmbClients.DataSource = displayClients;
            cmbClients.DisplayMember = "DisplayText";
            cmbClients.ValueMember = "ID";

         
            var companies = await _companyApi.GetAllAsync();
            cmbCompanies.DataSource = companies;
            cmbCompanies.DisplayMember = "Name";
            cmbCompanies.ValueMember = "ID";

         
            var cargos = await _cargoApi.GetAllAsync();
            cmbCargos.DataSource = cargos;
            cmbCargos.DisplayMember = "Descriptions";
            cmbCargos.ValueMember = "ID";

            
            var vehicles = await _vehicleApi.GetAllAsync();

            var displayVehicles = vehicles.Select(v => new
            {
                v.ID,
                DisplayText = $"{v.VehicleNum} ({v.Type})"
            }).ToList();

            cmbVehicles.DataSource = displayVehicles;
            cmbVehicles.DisplayMember = "DisplayText";
            cmbVehicles.ValueMember = "ID";
        }
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            int? clientId = null;
            int? transid = null;

           
            if (chkIsNewClient.Checked)
            {
                var newClient = new ClientDto
                {
                    Name = txtName.Text.Trim(),
                    Surname = txtSurname.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                if (!await _clientApi.CreateAsync(newClient))
                {
                    MessageBox.Show("Не удалось добавить клиента");
                    return;
                }

                var clients = await _clientApi.GetAllAsync();
                clientId = clients.Last().ID;
            }
            else
            {
                clientId = (int)cmbClients.SelectedValue;
            }

            var transDto = new TransportationDto
            {
                CargoId = (int)cmbCargos.SelectedValue,
                VehicleId = (int)cmbVehicles.SelectedValue,
                StartPoint = txtStartPoint.Text.Trim(),
                EndPoint = txtEndPoint.Text.Trim()
            };

            if (!await _transApi.CreateAsync(transDto))
            {
                MessageBox.Show("Не удалось создать перевозку");
                return;
            }

            var transports = await _transApi.GetAllAsync();
            transid = transports.Last().ID;
    
            var orderDto = new OrderDto
            {
                IDClient = clientId,
                TransId = (int)transid,
                Price = decimal.Parse(txtPrice.Text),
                Date = DateTime.Now,
                Status = "Новый"
            };

            if (await _orderApi.CreateAsync(orderDto))
            {
                MessageBox.Show("Заказ, перевозка и клиент успешно созданы");
            }
            else
            {
                MessageBox.Show("Ошибка при создании заказа");
            }
        }


        private ErrorProvider errorProvider = new ErrorProvider();
        private bool ValidateFields()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (chkIsNewClient.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    errorProvider.SetError(txtName, "Введите имя");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtSurname.Text))
                {
                    errorProvider.SetError(txtSurname, "Введите фамилию");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length < 7)
                {
                    errorProvider.SetError(txtPhone, "Укажите корректный телефон");
                    isValid = false;
                }
            }
            else
            {
                if (cmbClients.SelectedIndex == -1)
                {
                    errorProvider.SetError(cmbClients, "Выберите клиента");
                    isValid = false;
                }
            }

            if (cmbCompanies.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbCompanies, "Выберите компанию");
                isValid = false;
            }

            if (cmbCargos.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbCargos, "Выберите груз");
                isValid = false;
            }

            if (cmbVehicles.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbVehicles, "Выберите транспорт");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtStartPoint.Text))
            {
                errorProvider.SetError(txtStartPoint, "Введите начальную точку");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                errorProvider.SetError(txtEndPoint, "Введите конечную точку");
                isValid = false;
            }

            if (!decimal.TryParse(txtPrice.Text, out var price) || price <= 0)
            {
                errorProvider.SetError(txtPrice, "Укажите положительное число");
                isValid = false;
            }

            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}