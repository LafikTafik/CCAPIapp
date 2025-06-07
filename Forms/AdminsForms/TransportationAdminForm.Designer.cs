namespace CCAPIapp.Forms.AdminsForms
{
    partial class TransportationAdminForm
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtEndPoint = new TextBox();
            txtStartPoint = new TextBox();
            txtVehicleId = new TextBox();
            txtCargoId = new TextBox();
            btnExit = new Button();
            btnDeleteClient = new Button();
            btnEditClient = new Button();
            btnAddClient = new Button();
            dataGridViewTransportations = new DataGridView();
            btnAddCargoToOrder = new Button();
            cmbCompanies = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransportations).BeginInit();
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
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(308, 38);
            label6.TabIndex = 35;
            label6.Text = "Данные о перевозке:";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F);
            label5.Location = new Point(3, 161);
            label5.Name = "label5";
            label5.Size = new Size(219, 38);
            label5.TabIndex = 33;
            label5.Text = "Конечная точка";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(3, 121);
            label4.Name = "label4";
            label4.Size = new Size(233, 38);
            label4.TabIndex = 32;
            label4.Text = "Начальная точка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(3, 81);
            label3.Name = "label3";
            label3.Size = new Size(195, 38);
            label3.TabIndex = 31;
            label3.Text = "ID транспорта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(119, 38);
            label2.TabIndex = 30;
            label2.Text = "ID груза";
            // 
            // txtEndPoint
            // 
            txtEndPoint.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtEndPoint.Location = new Point(244, 161);
            txtEndPoint.Name = "txtEndPoint";
            txtEndPoint.Size = new Size(282, 34);
            txtEndPoint.TabIndex = 28;
            // 
            // txtStartPoint
            // 
            txtStartPoint.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtStartPoint.Location = new Point(244, 121);
            txtStartPoint.Name = "txtStartPoint";
            txtStartPoint.Size = new Size(282, 34);
            txtStartPoint.TabIndex = 27;
            // 
            // txtVehicleId
            // 
            txtVehicleId.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtVehicleId.Location = new Point(244, 81);
            txtVehicleId.Name = "txtVehicleId";
            txtVehicleId.Size = new Size(282, 34);
            txtVehicleId.TabIndex = 26;
            // 
            // txtCargoId
            // 
            txtCargoId.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtCargoId.Location = new Point(244, 41);
            txtCargoId.Name = "txtCargoId";
            txtCargoId.Size = new Size(282, 34);
            txtCargoId.TabIndex = 25;
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
            btnAddClient.Text = "Добавить запись о перевозке";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAdd_Click;
            // 
            // dataGridViewTransportations
            // 
            dataGridViewTransportations.Anchor = AnchorStyles.Top;
            dataGridViewTransportations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransportations.Location = new Point(566, 12);
            dataGridViewTransportations.Name = "dataGridViewTransportations";
            dataGridViewTransportations.RowHeadersWidth = 51;
            dataGridViewTransportations.Size = new Size(1004, 829);
            dataGridViewTransportations.TabIndex = 19;
            dataGridViewTransportations.SelectionChanged += dataGridViewTransportations_SelectionChanged;
            // 
            // btnAddCargoToOrder
            // 
            btnAddCargoToOrder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddCargoToOrder.Location = new Point(3, 209);
            btnAddCargoToOrder.Name = "btnAddCargoToOrder";
            btnAddCargoToOrder.Size = new Size(233, 39);
            btnAddCargoToOrder.TabIndex = 39;
            btnAddCargoToOrder.Text = "Добавить связь с компанией";
            btnAddCargoToOrder.UseVisualStyleBackColor = true;
            btnAddCargoToOrder.Click += btnAddCompanyToTransportation_Click;
            // 
            // cmbCompanies
            // 
            cmbCompanies.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbCompanies.FormattingEnabled = true;
            cmbCompanies.Location = new Point(244, 209);
            cmbCompanies.Name = "cmbCompanies";
            cmbCompanies.Size = new Size(282, 39);
            cmbCompanies.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnAddClient);
            panel1.Controls.Add(btnEditClient);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDeleteClient);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 337);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 504);
            panel1.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCargoId);
            panel2.Controls.Add(btnAddCargoToOrder);
            panel2.Controls.Add(txtVehicleId);
            panel2.Controls.Add(cmbCompanies);
            panel2.Controls.Add(txtStartPoint);
            panel2.Controls.Add(txtEndPoint);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 263);
            panel2.TabIndex = 41;
            // 
            // TransportationAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewTransportations);
            Name = "TransportationAdminForm";
            Text = "TransportationAdminForm";
            Load += TransportationAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransportations).EndInit();
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEndPoint;
        private TextBox txtStartPoint;
        private TextBox txtVehicleId;
        private TextBox txtCargoId;
        private Button btnExit;
        private Button btnDeleteClient;
        private Button btnEditClient;
        private Button btnAddClient;
        private DataGridView dataGridViewTransportations;
        private Button btnAddCargoToOrder;
        private ComboBox cmbCompanies;
        private Panel panel1;
        private Panel panel2;
    }
}