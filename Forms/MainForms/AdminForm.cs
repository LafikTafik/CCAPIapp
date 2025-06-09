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
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            var vehicleAdminForm = new VehicleAdminForm();
            vehicleAdminForm.Owner = this;
            vehicleAdminForm.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var orderAdminForm = new OrderAdminForm();
            orderAdminForm.Owner = this; 
            orderAdminForm.Show();
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            var сargoAdminForm = new CargoAdminForm();
            сargoAdminForm.Owner = this; 
            сargoAdminForm.Show();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            var driverAdminForm = new DriverAdminForm();
            driverAdminForm.Owner = this; 
            driverAdminForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var transportationCompanyAdminForm = new TransportationCompanyAdminForm();
            transportationCompanyAdminForm.Owner = this; 
            transportationCompanyAdminForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var transportationAdminForm = new TransportationAdminForm();
            transportationAdminForm.Owner = this; 
            transportationAdminForm.Show();
        }
    }
}

