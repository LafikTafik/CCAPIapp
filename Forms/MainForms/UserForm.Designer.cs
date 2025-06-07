namespace CCAPIapp
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmbClients = new ComboBox();
            chkIsNewClient = new CheckBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbCompanies = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            cmbCargos = new ComboBox();
            cmbVehicles = new ComboBox();
            label9 = new Label();
            txtStartPoint = new TextBox();
            txtEndPoint = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            label10 = new Label();
            label11 = new Label();
            txtPrice = new TextBox();
            label12 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(271, 38);
            label1.TabIndex = 0;
            label1.Text = "Выберите клиента:";
            // 
            // cmbClients
            // 
            cmbClients.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbClients.FormattingEnabled = true;
            cmbClients.Location = new Point(3, 52);
            cmbClients.Name = "cmbClients";
            cmbClients.Size = new Size(382, 39);
            cmbClients.TabIndex = 1;
            // 
            // chkIsNewClient
            // 
            chkIsNewClient.AutoSize = true;
            chkIsNewClient.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chkIsNewClient.Location = new Point(3, 97);
            chkIsNewClient.Name = "chkIsNewClient";
            chkIsNewClient.Size = new Size(253, 35);
            chkIsNewClient.TabIndex = 3;
            chkIsNewClient.Text = "Или создать нового?";
            chkIsNewClient.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(132, 138);
            txtName.Name = "txtName";
            txtName.Size = new Size(235, 34);
            txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 12F);
            txtSurname.Location = new Point(132, 178);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(235, 34);
            txtSurname.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(132, 218);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(235, 34);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(132, 258);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(235, 34);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(132, 298);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(235, 34);
            txtAddress.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 141);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 9;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 184);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 10;
            label3.Text = "Фамилия";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 224);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 11;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 264);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 304);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 13;
            label6.Text = "Адрес";
            // 
            // cmbCompanies
            // 
            cmbCompanies.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbCompanies.FormattingEnabled = true;
            cmbCompanies.Location = new Point(9, 52);
            cmbCompanies.Name = "cmbCompanies";
            cmbCompanies.Size = new Size(305, 39);
            cmbCompanies.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(9, 11);
            label7.Name = "label7";
            label7.Size = new Size(305, 38);
            label7.TabIndex = 15;
            label7.Text = "Выберите компанию:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ImageAlign = ContentAlignment.BottomLeft;
            label8.Location = new Point(9, 97);
            label8.Name = "label8";
            label8.Size = new Size(218, 38);
            label8.TabIndex = 16;
            label8.Text = "Выберите груз:";
            // 
            // cmbCargos
            // 
            cmbCargos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Location = new Point(9, 138);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(305, 39);
            cmbCargos.TabIndex = 17;
            // 
            // cmbVehicles
            // 
            cmbVehicles.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbVehicles.FormattingEnabled = true;
            cmbVehicles.Location = new Point(9, 225);
            cmbVehicles.Name = "cmbVehicles";
            cmbVehicles.Size = new Size(305, 39);
            cmbVehicles.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(9, 184);
            label9.Name = "label9";
            label9.Size = new Size(300, 38);
            label9.TabIndex = 19;
            label9.Text = "Выберите транспорт:";
            // 
            // txtStartPoint
            // 
            txtStartPoint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStartPoint.Location = new Point(285, 389);
            txtStartPoint.Name = "txtStartPoint";
            txtStartPoint.Size = new Size(463, 34);
            txtStartPoint.TabIndex = 20;
            // 
            // txtEndPoint
            // 
            txtEndPoint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtEndPoint.Location = new Point(285, 429);
            txtEndPoint.Name = "txtEndPoint";
            txtEndPoint.Size = new Size(463, 34);
            txtEndPoint.TabIndex = 21;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCreate.Location = new Point(10, 539);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(350, 102);
            btnCreate.TabIndex = 22;
            btnCreate.Text = "Создать заказ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(520, 539);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(350, 102);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(12, 395);
            label10.Name = "label10";
            label10.Size = new Size(267, 28);
            label10.TabIndex = 24;
            label10.Text = "Начальная точка маршрута:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(12, 435);
            label11.Name = "label11";
            label11.Size = new Size(258, 28);
            label11.TabIndex = 25;
            label11.Text = "Конечная точка маршрута:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPrice.Location = new Point(285, 469);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(273, 34);
            txtPrice.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(94, 475);
            label12.Name = "label12";
            label12.Size = new Size(176, 28);
            label12.TabIndex = 27;
            label12.Text = "Стоимость заказа:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbClients);
            panel1.Controls.Add(chkIsNewClient);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtSurname);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 366);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cmbCompanies);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cmbCargos);
            panel2.Controls.Add(cmbVehicles);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(408, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 366);
            panel2.TabIndex = 29;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(txtPrice);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtEndPoint);
            Controls.Add(txtStartPoint);
            Name = "UserForm";
            Text = "UserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbClients;
        private CheckBox chkIsNewClient;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCompanies;
        private Label label7;
        private Label label8;
        private ComboBox cmbCargos;
        private ComboBox cmbVehicles;
        private Label label9;
        private TextBox txtStartPoint;
        private TextBox txtEndPoint;
        private Button btnCreate;
        private Button btnCancel;
        private Label label10;
        private Label label11;
        private TextBox txtPrice;
        private Label label12;
        private Panel panel1;
        private Panel panel2;
    }
}