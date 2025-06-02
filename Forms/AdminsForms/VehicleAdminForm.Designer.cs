namespace CCAPIapp.Forms.AdminsForms
{
    partial class VehicleAdminForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblType = new Label();
            txtDriverId = new TextBox();
            txtVehicleNum = new TextBox();
            txtCapacity = new TextBox();
            txtType = new TextBox();
            btnExit = new Button();
            btnDeleteClient = new Button();
            btnEditClient = new Button();
            btnAddClient = new Button();
            dataGridViewVehicles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehicles).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(12, 569);
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
            label7.Location = new Point(12, 264);
            label7.Name = "label7";
            label7.Size = new Size(311, 38);
            label7.TabIndex = 36;
            label7.Text = "Доступные действия:\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 10);
            label6.Name = "label6";
            label6.Size = new Size(253, 38);
            label6.TabIndex = 35;
            label6.Text = "Данные клиента:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 646);
            button1.Name = "button1";
            button1.Size = new Size(523, 71);
            button1.TabIndex = 34;
            button1.Text = "Удалённые записи\r\n";
            button1.Click += btnViewDeleted_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(169, 38);
            label4.TabIndex = 32;
            label4.Text = "ID водителя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(144, 38);
            label3.TabIndex = 31;
            label3.Text = "Номер ТС";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(182, 38);
            label2.TabIndex = 30;
            label2.Text = "Вместимость";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblType.Location = new Point(12, 52);
            lblType.Name = "lblType";
            lblType.Size = new Size(215, 38);
            lblType.TabIndex = 29;
            lblType.Text = "Тип транспорта";
            // 
            // txtDriverId
            // 
            txtDriverId.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtDriverId.Location = new Point(253, 172);
            txtDriverId.Name = "txtDriverId";
            txtDriverId.Size = new Size(282, 34);
            txtDriverId.TabIndex = 27;
            // 
            // txtVehicleNum
            // 
            txtVehicleNum.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtVehicleNum.Location = new Point(253, 132);
            txtVehicleNum.Name = "txtVehicleNum";
            txtVehicleNum.Size = new Size(282, 34);
            txtVehicleNum.TabIndex = 26;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtCapacity.Location = new Point(253, 92);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(282, 34);
            txtCapacity.TabIndex = 25;
            // 
            // txtType
            // 
            txtType.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtType.Location = new Point(253, 52);
            txtType.Name = "txtType";
            txtType.Size = new Size(282, 34);
            txtType.TabIndex = 24;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(12, 771);
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
            btnDeleteClient.Location = new Point(12, 472);
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
            btnEditClient.Location = new Point(12, 395);
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
            btnAddClient.Location = new Point(12, 318);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(523, 71);
            btnAddClient.TabIndex = 20;
            btnAddClient.Text = "Добавить запись о клиенте ";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAdd_Click;
            // 
            // dataGridViewVehicles
            // 
            dataGridViewVehicles.Anchor = AnchorStyles.Top;
            dataGridViewVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehicles.Location = new Point(562, 11);
            dataGridViewVehicles.Name = "dataGridViewVehicles";
            dataGridViewVehicles.RowHeadersWidth = 51;
            dataGridViewVehicles.Size = new Size(1008, 829);
            dataGridViewVehicles.TabIndex = 19;
            dataGridViewVehicles.SelectionChanged += dataGridViewVehicles_SelectionChanged_1;
            // 
            // VehicleAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(btnRefresh);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblType);
            Controls.Add(txtDriverId);
            Controls.Add(txtVehicleNum);
            Controls.Add(txtCapacity);
            Controls.Add(txtType);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(dataGridViewVehicles);
            Name = "VehicleAdminForm";
            Text = "VehicleAdminForm";
            Load += VehicleAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Label label7;
        private Label label6;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblType;
        private TextBox txtDriverId;
        private TextBox txtVehicleNum;
        private TextBox txtCapacity;
        private TextBox txtType;
        private Button btnExit;
        private Button btnDeleteClient;
        private Button btnEditClient;
        private Button btnAddClient;
        private DataGridView dataGridViewVehicles;
    }
}