﻿namespace CCAPIapp.Forms.AdminsForms
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
            label1 = new Label();
            txtCompanyId = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehicles).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(15, 272);
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
            label7.Location = new Point(15, 0);
            label7.Name = "label7";
            label7.Size = new Size(311, 38);
            label7.TabIndex = 36;
            label7.Text = "Доступные действия:\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(253, 38);
            label6.TabIndex = 35;
            label6.Text = "Данные клиента:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(15, 349);
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
            label4.Location = new Point(3, 201);
            label4.Name = "label4";
            label4.Size = new Size(169, 38);
            label4.TabIndex = 32;
            label4.Text = "ID водителя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(3, 161);
            label3.Name = "label3";
            label3.Size = new Size(144, 38);
            label3.TabIndex = 31;
            label3.Text = "Номер ТС";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(3, 121);
            label2.Name = "label2";
            label2.Size = new Size(182, 38);
            label2.TabIndex = 30;
            label2.Text = "Вместимость";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblType.Location = new Point(3, 81);
            lblType.Name = "lblType";
            lblType.Size = new Size(215, 38);
            lblType.TabIndex = 29;
            lblType.Text = "Тип транспорта";
            // 
            // txtDriverId
            // 
            txtDriverId.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtDriverId.Location = new Point(244, 201);
            txtDriverId.Name = "txtDriverId";
            txtDriverId.Size = new Size(282, 34);
            txtDriverId.TabIndex = 27;
            // 
            // txtVehicleNum
            // 
            txtVehicleNum.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtVehicleNum.Location = new Point(244, 161);
            txtVehicleNum.Name = "txtVehicleNum";
            txtVehicleNum.Size = new Size(282, 34);
            txtVehicleNum.TabIndex = 26;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtCapacity.Location = new Point(244, 121);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(282, 34);
            txtCapacity.TabIndex = 25;
            // 
            // txtType
            // 
            txtType.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtType.Location = new Point(244, 81);
            txtType.Name = "txtType";
            txtType.Size = new Size(282, 34);
            txtType.TabIndex = 24;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(15, 426);
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
            btnDeleteClient.Location = new Point(15, 195);
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
            btnEditClient.Location = new Point(15, 118);
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
            btnAddClient.Location = new Point(15, 41);
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
            dataGridViewVehicles.Location = new Point(575, 11);
            dataGridViewVehicles.Name = "dataGridViewVehicles";
            dataGridViewVehicles.RowHeadersWidth = 51;
            dataGridViewVehicles.Size = new Size(995, 829);
            dataGridViewVehicles.TabIndex = 19;
            dataGridViewVehicles.SelectionChanged += dataGridViewVehicles_SelectionChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 38);
            label1.Name = "label1";
            label1.Size = new Size(180, 38);
            label1.TabIndex = 38;
            label1.Text = "ID компании";
            // 
            // txtCompanyId
            // 
            txtCompanyId.Font = new Font("Microsoft Sans Serif", 13.8F);
            txtCompanyId.Location = new Point(244, 41);
            txtCompanyId.Name = "txtCompanyId";
            txtCompanyId.Size = new Size(282, 34);
            txtCompanyId.TabIndex = 39;
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
            panel2.Controls.Add(txtType);
            panel2.Controls.Add(txtCompanyId);
            panel2.Controls.Add(txtCapacity);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtVehicleNum);
            panel2.Controls.Add(txtDriverId);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblType);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 246);
            panel2.TabIndex = 41;
            // 
            // VehicleAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewVehicles);
            Name = "VehicleAdminForm";
            Text = "VehicleAdminForm";
            Load += VehicleAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehicles).EndInit();
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
        private Label label1;
        private TextBox txtCompanyId;
        private Panel panel1;
        private Panel panel2;
    }
}