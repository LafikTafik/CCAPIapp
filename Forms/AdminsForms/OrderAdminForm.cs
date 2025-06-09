using CCAPI.DTO.defaultt;
using CCAPI.DTO.deleted;
using CCAPIapp.Services;
using CCAPIapp.Forms.DelForms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCAPIapp.Forms.AdminsForms
{
    public partial class OrderAdminForm : Form
    {
        private readonly ApiService<OrderDto> _api = new ApiService<OrderDto>("orders");
        private readonly ApiService<CargoDto> _cargoApi = new ApiService<CargoDto>("cargos");
        private readonly ApiService<CargoOrdersDto> _cargoOrderApi = new ApiService<CargoOrdersDto>("cargoorders");
       

        public OrderAdminForm()
        {
            InitializeComponent();
        }

        private async Task LoadOrdersAsync()
        {
            var orders = await _api.GetAllAsync();
            dataGridViewOrders.DataSource = orders;
            await LoadDataAsync();
        }

        private async void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateOrderFields())
                return;

            var price = decimal.Parse(txtPrice.Text);
            var clientId = int.Parse(txtIDClient.Text);

            var order = new OrderDto
            {
                Status = cmbStatus.SelectedItem?.ToString() ?? "Новый",
                Price = price,
                Date = dtpDate.Value,
                IDClient = clientId,
                TransId = int.Parse(txtTransid.Text)
            };

            if (await _api.CreateAsync(order))
            {
                MessageBox.Show("Заказ успешно добавлен");
                await LoadOrdersAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении заказа");
            }
        }


        private async void btnEditOrder_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для редактирования");
                return;
            }

            var confirm = MessageBox.Show("Вы уверены, что хотите редактировать данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            if (!ValidateOrderFields())
                return;

            var selectedRow = dataGridViewOrders.SelectedRows[0];
            var originalOrder = (OrderDto)selectedRow.DataBoundItem;

            var updatedOrder = new OrderDto
            {
                ID = originalOrder.ID,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Новый",
                Price = decimal.Parse(txtPrice.Text),
                Date = dtpDate.Value,
                IDClient = int.Parse(txtIDClient.Text),
                TransId = int.Parse(txtTransid.Text)
            };

            if (await _api.UpdateAsync(originalOrder.ID, updatedOrder))
            {
                MessageBox.Show("Заказ успешно обновлён");
                await LoadOrdersAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении заказа");
            }
        }

        private async void btnDeleteOrder_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для удаления");
                return;
            }

            var selectedId = (int)dataGridViewOrders.SelectedRows[0].Cells["ID"].Value;

            var result = MessageBox.Show("Удалить этот заказ?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (await _api.DeleteAsync(selectedId))
                {
                    MessageBox.Show("Заказ успешно удалён");
                    await LoadOrdersAsync();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить заказ");
                }
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }

        private void btnViewDeleted_Click(object sender, EventArgs e)
        {
            var form = new DeletedOrdersForm();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.Owner != null)
            {
                this.Owner.Show(); 
            }
        }

        private async void OrderAdminForm_Load(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selected = dataGridViewOrders.SelectedRows[0].DataBoundItem as OrderDto;
                if (selected != null)
                {
                    cmbStatus.SelectedItem = selected.Status;
                    txtPrice.Text = selected.Price?.ToString();
                    dtpDate.Value = selected.Date ?? DateTime.Now;
                    txtIDClient.Text = selected.IDClient.ToString();
                    txtTransid.Text = selected.TransId.ToString();
                }
            }
        }

        private async void btnRefresh_Click_1(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new DeletedOrdersForm();
            form.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show(); 
            }

            this.Hide();
        }

        private async void OrderAdminForm_Load_1(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }
        private ErrorProvider errorProvider = new ErrorProvider();

        private bool ValidateOrderFields()
        {
            errorProvider.Clear();
            bool isValid = true;

            // ID клиента
            if (!int.TryParse(txtIDClient.Text, out var clientId))
            {
                errorProvider.SetError(txtIDClient, "Должно быть целое число");
                MessageBox.Show("Поле 'ID клиента' должно содержать только цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDClient.Focus();
                isValid = false;
            }

            if (clientId <= 0)
            {
                errorProvider.SetError(txtIDClient, "ID клиента должен быть больше 0");
                MessageBox.Show("ID клиента должен быть положительным числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDClient.Focus();
                isValid = false;
            }

            // Цена
            if (!decimal.TryParse(txtPrice.Text, out var price) || price < 0)
            {
                errorProvider.SetError(txtPrice, "Цена должна быть положительным числом или 0");
                MessageBox.Show("Цена не может быть отрицательной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                isValid = false;
            }

            return isValid;
        }
        private async Task LoadDataAsync()
        {
            var cargos = await _cargoApi.GetAllAsync();

            var displayCargos = cargos.Select(c => new
            {
                c.ID,
                DisplayText = $"Груз #{c.ID} ({c.Descriptions})"
            }).ToList();

            cmbCargos.DataSource = displayCargos;
            cmbCargos.DisplayMember = "DisplayText";
            cmbCargos.ValueMember = "ID";
        }
        private async void btnAddCargoToOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ в таблице");
                return;
            }

            var selectedOrderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["ID"].Value);
            var selectedCargoId = (int)cmbCargos.SelectedValue;

            var dto = new CargoOrdersDto
            {
                OrderID = selectedOrderId,
                CargoID = selectedCargoId
            };

            if (await _cargoOrderApi.CreateAsync(dto))
            {
                MessageBox.Show("Груз успешно добавлен к заказу");
                await LoadCargosForOrder(selectedOrderId); 
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении груза к заказу");
            }
        }
        private async Task LoadCargosForOrder(int orderId)
        {
            var items = await _cargoOrderApi.GetByOrderIdAsync(orderId);

            foreach (var item in items)
            {
                Console.WriteLine($"Заказ {item.OrderID} связан с грузом {item.CargoID}");
            }
        }
    }
}