namespace CCAPIapp.Forms.AdminsForms
{
    partial class CargoAdminForm
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
            btnDeleteCargo = new Button();
            btnEditCargo = new Button();
            btnAddCargo = new Button();
            dataGridViewCargos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDimensions = new TextBox();
            txtWeight = new TextBox();
            txtDescription = new TextBox();
            txtOrderID = new TextBox();
            btnRefresh = new Button();
            button1 = new Button();
            btnExit = new Button();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargos).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteCargo
            // 
            btnDeleteCargo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteCargo.Location = new Point(12, 459);
            btnDeleteCargo.Name = "btnDeleteCargo";
            btnDeleteCargo.Size = new Size(523, 71);
            btnDeleteCargo.TabIndex = 12;
            btnDeleteCargo.Text = "Удалить запись";
            btnDeleteCargo.UseVisualStyleBackColor = true;
            btnDeleteCargo.Click += btnDeleteCargo_Click;
            // 
            // btnEditCargo
            // 
            btnEditCargo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditCargo.Location = new Point(12, 382);
            btnEditCargo.Name = "btnEditCargo";
            btnEditCargo.Size = new Size(523, 71);
            btnEditCargo.TabIndex = 11;
            btnEditCargo.Text = "Редактировать запись";
            btnEditCargo.UseVisualStyleBackColor = true;
            btnEditCargo.Click += btnEditCargo_Click;
            // 
            // btnAddCargo
            // 
            btnAddCargo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddCargo.Location = new Point(12, 305);
            btnAddCargo.Name = "btnAddCargo";
            btnAddCargo.Size = new Size(523, 71);
            btnAddCargo.TabIndex = 10;
            btnAddCargo.Text = "Добавить запись о грузе";
            btnAddCargo.UseVisualStyleBackColor = true;
            btnAddCargo.Click += btnAddCargo_Click;
            // 
            // dataGridViewCargos
            // 
            dataGridViewCargos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCargos.Location = new Point(571, 10);
            dataGridViewCargos.Name = "dataGridViewCargos";
            dataGridViewCargos.RowHeadersWidth = 51;
            dataGridViewCargos.Size = new Size(999, 829);
            dataGridViewCargos.TabIndex = 9;
            dataGridViewCargos.SelectionChanged += dataGridViewCargos_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(17, 50);
            label1.Name = "label1";
            label1.Size = new Size(135, 38);
            label1.TabIndex = 14;
            label1.Text = "ID Заказа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(17, 138);
            label2.Name = "label2";
            label2.Size = new Size(185, 38);
            label2.TabIndex = 15;
            label2.Text = "Размер груза";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(17, 94);
            label3.Name = "label3";
            label3.Size = new Size(136, 38);
            label3.TabIndex = 16;
            label3.Text = "Вес груза";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(17, 182);
            label4.Name = "label4";
            label4.Size = new Size(144, 38);
            label4.TabIndex = 17;
            label4.Text = "Описание";
            // 
            // txtDimensions
            // 
            txtDimensions.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDimensions.Location = new Point(253, 138);
            txtDimensions.Name = "txtDimensions";
            txtDimensions.Size = new Size(282, 38);
            txtDimensions.TabIndex = 19;
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtWeight.Location = new Point(253, 94);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(282, 38);
            txtWeight.TabIndex = 20;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDescription.Location = new Point(253, 182);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(282, 38);
            txtDescription.TabIndex = 21;
            // 
            // txtOrderID
            // 
            txtOrderID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtOrderID.Location = new Point(253, 50);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(282, 38);
            txtOrderID.TabIndex = 22;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(12, 573);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(523, 71);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Обновить данные";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 650);
            button1.Name = "button1";
            button1.Size = new Size(523, 71);
            button1.TabIndex = 24;
            button1.Text = "Удалённые записи\r\n";
            button1.Click += btnViewDeleted_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(12, 768);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(523, 71);
            btnExit.TabIndex = 23;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(17, 9);
            label6.Name = "label6";
            label6.Size = new Size(238, 38);
            label6.TabIndex = 26;
            label6.Text = "Данные о грузе:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(17, 241);
            label7.Name = "label7";
            label7.Size = new Size(311, 38);
            label7.TabIndex = 27;
            label7.Text = "Доступные действия:\r\n";
            // 
            // CargoAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnRefresh);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(txtOrderID);
            Controls.Add(txtDescription);
            Controls.Add(txtWeight);
            Controls.Add(txtDimensions);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteCargo);
            Controls.Add(btnEditCargo);
            Controls.Add(btnAddCargo);
            Controls.Add(dataGridViewCargos);
            Name = "CargoAdminForm";
            Text = "CargoAdminForm";
            Load += CargoAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDeleteCargo;
        private Button btnEditCargo;
        private Button btnAddCargo;
        private DataGridView dataGridViewCargos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDimensions;
        private TextBox txtWeight;
        private TextBox txtDescription;
        private TextBox txtOrderID;
        private Button btnRefresh;
        private Button button1;
        private Button btnExit;
        private Label label6;
        private Label label7;
    }
}