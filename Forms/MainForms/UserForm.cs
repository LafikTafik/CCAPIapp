using System.Windows.Forms;

namespace CCAPIapp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            this.Text = "Пользовательский интерфейс";
            this.Size = new System.Drawing.Size(800, 600);

            Label lbl = new Label()
            {
                Text = "Вы вошли как пользователь",
                Location = new System.Drawing.Point(300, 50),
                AutoSize = true
            };
            this.Controls.Add(lbl);

            Button btnSearchOrders = new Button()
            {
                Text = "Поиск заказов",
                Location = new System.Drawing.Point(300, 100),
                Width = 150
           
            };
            this.Controls.Add(btnSearchOrders);

            // Другие кнопки можно добавить позже
        }
    }
}