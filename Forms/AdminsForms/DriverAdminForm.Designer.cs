﻿namespace CCAPIapp.Forms.AdminsForms
{
    partial class DriverAdminForm
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
            label7 = new Label();
            label6 = new Label();
            btnRefresh = new Button();
            button1 = new Button();
            btnExit = new Button();
            txtFirstName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtLicenseNum = new TextBox();
            lblPhoneNumber = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDeleteCargo = new Button();
            btnEditCargo = new Button();
            btnAddCargo = new Button();
            dataGridViewDrivers = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(15, 0);
            label7.Name = "label7";
            label7.Size = new Size(311, 38);
            label7.TabIndex = 44;
            label7.Text = "Доступные действия:\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(295, 38);
            label6.TabIndex = 43;
            label6.Text = "Данные о водителе:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(15, 272);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(523, 71);
            btnRefresh.TabIndex = 42;
            btnRefresh.Text = "Обновить данные";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(15, 349);
            button1.Name = "button1";
            button1.Size = new Size(523, 71);
            button1.TabIndex = 41;
            button1.Text = "Удалённые записи\r\n";
            button1.Click += btnViewDeleted_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(15, 426);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(523, 71);
            btnExit.TabIndex = 40;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtFirstName.Location = new Point(239, 44);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(282, 38);
            txtFirstName.TabIndex = 39;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPhoneNumber.Location = new Point(239, 176);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(282, 38);
            txtPhoneNumber.TabIndex = 38;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLastName.Location = new Point(239, 88);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 38);
            txtLastName.TabIndex = 37;
            // 
            // txtLicenseNum
            // 
            txtLicenseNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLicenseNum.Location = new Point(239, 132);
            txtLicenseNum.Name = "txtLicenseNum";
            txtLicenseNum.Size = new Size(282, 38);
            txtLicenseNum.TabIndex = 36;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 16.2F);
            lblPhoneNumber.Location = new Point(3, 176);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(128, 38);
            lblPhoneNumber.TabIndex = 35;
            lblPhoneNumber.Text = "Телефон";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(3, 88);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 34;
            label3.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(3, 132);
            label2.Name = "label2";
            label2.Size = new Size(235, 38);
            label2.TabIndex = 33;
            label2.Text = "Номер лицензии";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(3, 44);
            label1.Name = "label1";
            label1.Size = new Size(72, 38);
            label1.TabIndex = 32;
            label1.Text = "Имя";
            // 
            // btnDeleteCargo
            // 
            btnDeleteCargo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteCargo.Location = new Point(15, 195);
            btnDeleteCargo.Name = "btnDeleteCargo";
            btnDeleteCargo.Size = new Size(523, 71);
            btnDeleteCargo.TabIndex = 31;
            btnDeleteCargo.Text = "Удалить запись";
            btnDeleteCargo.UseVisualStyleBackColor = true;
            btnDeleteCargo.Click += btnDelete_Click;
            // 
            // btnEditCargo
            // 
            btnEditCargo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditCargo.Location = new Point(15, 118);
            btnEditCargo.Name = "btnEditCargo";
            btnEditCargo.Size = new Size(523, 71);
            btnEditCargo.TabIndex = 30;
            btnEditCargo.Text = "Редактировать запись";
            btnEditCargo.UseVisualStyleBackColor = true;
            btnEditCargo.Click += btnEdit_Click;
            // 
            // btnAddCargo
            // 
            btnAddCargo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddCargo.Location = new Point(15, 41);
            btnAddCargo.Name = "btnAddCargo";
            btnAddCargo.Size = new Size(523, 71);
            btnAddCargo.TabIndex = 29;
            btnAddCargo.Text = "Добавить запись о водителе";
            btnAddCargo.UseVisualStyleBackColor = true;
            btnAddCargo.Click += btnAdd_Click;
            // 
            // dataGridViewDrivers
            // 
            dataGridViewDrivers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers.Location = new Point(561, 12);
            dataGridViewDrivers.Name = "dataGridViewDrivers";
            dataGridViewDrivers.RowHeadersWidth = 51;
            dataGridViewDrivers.Size = new Size(1009, 829);
            dataGridViewDrivers.TabIndex = 28;
            dataGridViewDrivers.SelectionChanged += dataGridViewDrivers_SelectionChanged_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnAddCargo);
            panel1.Controls.Add(btnEditCargo);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDeleteCargo);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnExit);
            panel1.Location = new Point(11, 337);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 504);
            panel1.TabIndex = 45;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(lblPhoneNumber);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtLicenseNum);
            panel2.Location = new Point(11, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 232);
            panel2.TabIndex = 46;
            // 
            // DriverAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewDrivers);
            Name = "DriverAdminForm";
            Text = "DriverAdminForm";
            Load += DriverAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Label label6;
        private Button btnRefresh;
        private Button button1;
        private Button btnExit;
        private TextBox txtFirstName;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtLicenseNum;
        private Label lblPhoneNumber;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDeleteCargo;
        private Button btnEditCargo;
        private Button btnAddCargo;
        private DataGridView dataGridViewDrivers;
        private Panel panel1;
        private Panel panel2;
    }
}