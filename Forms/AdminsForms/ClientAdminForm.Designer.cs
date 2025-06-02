namespace CCAPIapp.Forms.AdminsForms
{
    partial class ClientAdminForm
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
            dataGridViewClients = new DataGridView();
            btnAddClient = new Button();
            btnEditClient = new Button();
            btnDeleteClient = new Button();
            btnExit = new Button();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.Anchor = AnchorStyles.Top;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(566, 10);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(1004, 829);
            dataGridViewClients.TabIndex = 0;
            dataGridViewClients.SelectionChanged += dataGridViewClients_SelectionChanged;
            // 
            // btnAddClient
            // 
            btnAddClient.Font = new Font("Segoe UI", 16.2F);
            btnAddClient.Location = new Point(12, 317);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(523, 71);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Добавить запись о клиенте ";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Font = new Font("Segoe UI", 16.2F);
            btnEditClient.Location = new Point(12, 394);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(523, 71);
            btnEditClient.TabIndex = 2;
            btnEditClient.Text = "Редактировать запись\r\n";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Font = new Font("Segoe UI", 16.2F);
            btnDeleteClient.Location = new Point(12, 471);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(523, 71);
            btnDeleteClient.TabIndex = 3;
            btnDeleteClient.Text = "Удалить запись";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(12, 770);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(523, 71);
            btnExit.TabIndex = 4;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtName.Location = new Point(253, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 34);
            txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtSurname.Location = new Point(253, 91);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(282, 34);
            txtSurname.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtPhone.Location = new Point(253, 131);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(282, 34);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtEmail.Location = new Point(253, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 34);
            txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtAddress.Location = new Point(253, 211);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(282, 34);
            txtAddress.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(80, 38);
            label1.TabIndex = 10;
            label1.Text = "Имя ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(132, 38);
            label2.TabIndex = 11;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(233, 38);
            label3.TabIndex = 12;
            label3.Text = "Номер телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(83, 38);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F);
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(107, 38);
            label5.TabIndex = 14;
            label5.Text = "Адресс";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 645);
            button1.Name = "button1";
            button1.Size = new Size(523, 71);
            button1.TabIndex = 15;
            button1.Text = "Удалённые записи\r\n";
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(253, 38);
            label6.TabIndex = 16;
            label6.Text = "Данные клиента:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(12, 263);
            label7.Name = "label7";
            label7.Size = new Size(311, 38);
            label7.TabIndex = 17;
            label7.Text = "Доступные действия:\r\n";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(12, 568);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(523, 71);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Обновить данные";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ClientAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(btnRefresh);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(dataGridViewClients);
            Name = "ClientAdminForm";
            FormClosed += ClientAdminForm_FormClosed;
            Load += ClientAdminForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClients;
        private Button btnAddClient;
        private Button btnEditClient;
        private Button btnDeleteClient;
        private Button btnExit;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Label label7;
        private Button btnRefresh;
    }
}