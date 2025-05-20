using CCAPIapp.Forms.AdminsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCAPIapp.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            var clientAdminForm = new ClientAdminForm();
            clientAdminForm.Owner = this;
            clientAdminForm.Show();
            this.Hide();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var orderAdminForm = new OrderAdminForm();
            orderAdminForm.Owner = this; // передаём текущую форму как Owner
            orderAdminForm.Show();
            this.Hide();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            var сargoAdminForm = new CargoAdminForm();
            сargoAdminForm.Owner = this; // передаём текущую форму как Owner
            сargoAdminForm.Show();
            this.Hide();
        }
    }
}
