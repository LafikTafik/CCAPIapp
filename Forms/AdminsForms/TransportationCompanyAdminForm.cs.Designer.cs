namespace CCAPIapp.Forms.AdminsForms
{
    partial class TransportationCompanyAdminForm
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
            btnRefresh = new Button();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            btnExit = new Button();
            btnDeleteClient = new Button();
            btnEditClient = new Button();
            btnAddClient = new Button();
            dataGridViewCompanies = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompanies).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(3, 272);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(523, 71);
            btnRefresh.TabIndex = 37;
            btnRefresh.Text = "Обновить данные";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(311, 38);
            label7.TabIndex = 36;
            label7.Text = "Доступные действия:\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 18);
            label6.Name = "label6";
            label6.Size = new Size(282, 38);
            label6.TabIndex = 35;
            label6.Text = "Данные компании:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(3, 349);
            button1.Name = "button1";
            button1.Size = new Size(523, 71);
            button1.TabIndex = 34;
            button1.Text = "Удалённые записи\r\n";
            button1.Click += btnViewDeleted_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(3, 140);
            label3.Name = "label3";
            label3.Size = new Size(233, 38);
            label3.TabIndex = 31;
            label3.Text = "Номер телефона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(3, 100);
            label2.Name = "label2";
            label2.Size = new Size(94, 38);
            label2.TabIndex = 30;
            label2.Text = "Адрес";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 60);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 29;
            label1.Text = "Название";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtPhone.Location = new Point(244, 140);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(282, 34);
            txtPhone.TabIndex = 26;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtAddress.Location = new Point(244, 100);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(282, 34);
            txtAddress.TabIndex = 25;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtName.Location = new Point(244, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 34);
            txtName.TabIndex = 24;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(3, 426);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(523, 71);
            btnExit.TabIndex = 23;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Font = new Font("Segoe UI", 16.2F);
            btnDeleteClient.Location = new Point(3, 195);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(523, 71);
            btnDeleteClient.TabIndex = 22;
            btnDeleteClient.Text = "Удалить запись";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDelete_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Font = new Font("Segoe UI", 16.2F);
            btnEditClient.Location = new Point(3, 118);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(523, 71);
            btnEditClient.TabIndex = 21;
            btnEditClient.Text = "Редактировать запись\r\n";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEdit_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.Font = new Font("Segoe UI", 16.2F);
            btnAddClient.Location = new Point(3, 41);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(523, 71);
            btnAddClient.TabIndex = 20;
            btnAddClient.Text = "Добавить запись о компании";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAdd_Click;
            // 
            // dataGridViewCompanies
            // 
            dataGridViewCompanies.Anchor = AnchorStyles.Top;
            dataGridViewCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCompanies.Location = new Point(566, 11);
            dataGridViewCompanies.Name = "dataGridViewCompanies";
            dataGridViewCompanies.RowHeadersWidth = 51;
            dataGridViewCompanies.Size = new Size(1004, 829);
            dataGridViewCompanies.TabIndex = 19;
            dataGridViewCompanies.SelectionChanged += dataGridViewCompanies_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnAddClient);
            panel1.Controls.Add(btnEditClient);
            panel1.Controls.Add(btnDeleteClient);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(12, 337);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 504);
            panel1.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 209);
            panel2.TabIndex = 39;
            // 
            // TransportationCompanyAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCompanies);
            Name = "TransportationCompanyAdminForm";
            Text = "TransportationCompanyAdminForm";
            Load += TransportationCompanyAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompanies).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Label label7;
        private Label label6;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private Button btnExit;
        private Button btnDeleteClient;
        private Button btnEditClient;
        private Button btnAddClient;
        private DataGridView dataGridViewCompanies;
        private Panel panel1;
        private Panel panel2;
    }
}