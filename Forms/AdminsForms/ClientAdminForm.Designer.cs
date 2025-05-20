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
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.Anchor = AnchorStyles.Top;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(420, -1);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(760, 500);
            dataGridViewClients.TabIndex = 0;
            dataGridViewClients.SelectionChanged += dataGridViewClients_SelectionChanged;
            // 
            // btnAddClient
            // 
            btnAddClient.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddClient.Location = new Point(9, 223);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(267, 57);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Добавить клиента";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditClient.Location = new Point(9, 286);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(267, 57);
            btnEditClient.TabIndex = 2;
            btnEditClient.Text = "Редактировать";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteClient.Location = new Point(9, 349);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(267, 57);
            btnDeleteClient.TabIndex = 3;
            btnDeleteClient.Text = "Удалить";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(9, 412);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(267, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 9);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(184, 42);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(230, 27);
            txtSurname.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(184, 75);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(230, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(184, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(184, 141);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(230, 27);
            txtAddress.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 10;
            label1.Text = "Имя ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(9, 41);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 11;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(9, 74);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 12;
            label3.Text = "Номер телефона";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 14;
            label5.Text = "Адресс";
            // 
            // ClientAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 453);
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
    }
}