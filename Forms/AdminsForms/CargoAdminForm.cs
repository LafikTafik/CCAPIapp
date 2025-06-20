﻿using CCAPI.DTO.defaultt;
using CCAPIapp.Services;
using CCAPIapp.Forms.DelForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCAPIapp.Forms.AdminsForms
{
    public partial class CargoAdminForm : Form
    {
        private readonly ApiService<CargoDto> _api = new ApiService<CargoDto>("cargos");

        public CargoAdminForm()
        {
            InitializeComponent();
        }

        private async Task LoadCargosAsync()
        {
            try
            {
                var cargos = await _api.GetAllAsync();

                if (cargos == null || !cargos.Any())
                {
                    dataGridViewCargos.DataSource = null;
                    MessageBox.Show("Нет активных грузов", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewCargos.DataSource = cargos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddCargo_Click(object sender, EventArgs e)
        {
            if (!ValidateCargoFields())
                return;

            var cargo = new CargoDto
            {
                Weight = txtWeight.Text,
                Dimensions = txtDimensions.Text,
                Descriptions = txtDescription.Text
            };

            if (await _api.CreateAsync(cargo))
            {
                MessageBox.Show("Груз успешно добавлен");
                await LoadCargosAsync();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении груза");
            }
        }
        private void ClearForm()
        {
            txtWeight.Clear();
            txtDimensions.Clear();
            txtDescription.Clear();

            errorProvider.Clear(); 
        }

        private async void btnEditCargo_Click(object sender, EventArgs e)
        {
            if (dataGridViewCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите груз для редактирования");
                return;
            }

            var confirm = MessageBox.Show("Вы уверены, что хотите редактировать данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
            {
                return; 
            }

            if (!ValidateCargoFields())
                return;

            var selectedRow = dataGridViewCargos.SelectedRows[0];
            var original = (CargoDto)selectedRow.DataBoundItem;

            var updated = new CargoDto
            {
                ID = original.ID,
                Weight = txtWeight.Text,
                Dimensions = txtDimensions.Text,
                Descriptions = txtDescription.Text
            };

            if (await _api.UpdateAsync(original.ID, updated))
            {
                MessageBox.Show("Груз успешно обновлён");
                await LoadCargosAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении груза");
            }
        }

        private async void btnDeleteCargo_Click(object sender, EventArgs e)
        {
            if (dataGridViewCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите груз для удаления");
                return;
            }

            var selectedId = (int)dataGridViewCargos.SelectedRows[0].Cells["ID"].Value;

            var result = MessageBox.Show("Удалить этот груз?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (await _api.DeleteAsync(selectedId))
                {
                    MessageBox.Show("Груз помечен как удалённый");
                    await LoadCargosAsync();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить груз");
                }
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadCargosAsync();
        }

        private async void btnViewDeleted_Click(object sender, EventArgs e)
        {
            var form = new DeletedCargosForm();
            form.ShowDialog();
            await LoadCargosAsync();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private async void CargoAdminForm_Load(object sender, EventArgs e)
        {
            await LoadCargosAsync();
        }

        private void dataGridViewCargos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCargos.SelectedRows.Count > 0)
            {
                var selected = (CargoDto)dataGridViewCargos.SelectedRows[0].DataBoundItem;
                txtWeight.Text = selected.Weight;
                txtDimensions.Text = selected.Dimensions;
                txtDescription.Text = selected.Descriptions;
            }
        }
        private ErrorProvider errorProvider = new ErrorProvider();

        private bool ValidateCargoFields()
        {
            errorProvider.Clear(); 
            bool isValid = true;

            
            if (!decimal.TryParse(txtWeight.Text, out var weight) || weight <= 0)
            {
                errorProvider.SetError(txtWeight, "Вес должен быть положительным числом");
                MessageBox.Show("Поле 'Вес' должно содержать положительное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Focus();
                isValid = false;
            }

            
            var dimensions = txtDimensions.Text.Replace(" ", "");

            var parts = dimensions.Split('*');

            if (parts.Length != 3 || !parts.All(p => decimal.TryParse(p, out _)))
            {
                errorProvider.SetError(txtDimensions, "Формат: 100*200*300 (только числа)");
                MessageBox.Show("Поле 'Габариты' должно быть в формате: 100*200*300", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDimensions.Focus();
                isValid = false;
            }

            return isValid;
        }
    }
}