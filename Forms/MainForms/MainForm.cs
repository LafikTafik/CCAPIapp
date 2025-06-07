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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                var adminForm = new AdminForm();
                adminForm.Show();
            }
            else if (rbUser.Checked)
            {
                var userForm = new UserForm();
                userForm.Show();
            }
            else
            {
                MessageBox.Show("Выберите тип пользователя");
            }
        }
    }
}
