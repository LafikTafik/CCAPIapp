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

        public OrderAdminForm()
        {
            InitializeComponent();
        }

        private async Task LoadOrdersAsync()
        {
            var orders = await _api.GetAllAsync();
            dataGridViewOrders.DataSource = orders;
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
                IDClient = clientId
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
                IDClient = int.Parse(txtIDClient.Text)
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
                this.Owner.Show(); // показываем AdminForm
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
                this.Owner.Show(); // показываем AdminForm
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
    }
}