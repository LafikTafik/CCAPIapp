namespace CCAPIapp.Forms.AdminsForms
{
    partial class OrderAdminForm
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
            btnDeleteOrder = new Button();
            btnEditOrder = new Button();
            btnAddOrder = new Button();
            dataGridViewOrders = new DataGridView();
            txtIDClient = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            btnRefresh = new Button();
            button1 = new Button();
            btnExit = new Button();
            label5 = new Label();
            txtTransid = new TextBox();
            cmbCargos = new ComboBox();
            btnAddCargoToOrder = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteOrder.Location = new Point(3, 195);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(523, 71);
            btnDeleteOrder.TabIndex = 7;
            btnDeleteOrder.Text = "Удалить запись";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click_1;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditOrder.Location = new Point(3, 118);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(523, 71);
            btnEditOrder.TabIndex = 6;
            btnEditOrder.Text = "Редактировать запись";
            btnEditOrder.UseVisualStyleBackColor = true;
            btnEditOrder.Click += btnEditOrder_Click_1;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddOrder.Location = new Point(3, 41);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(523, 71);
            btnAddOrder.TabIndex = 5;
            btnAddOrder.Text = "Добавить запись о заказе";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(577, 12);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(993, 832);
            dataGridViewOrders.TabIndex = 4;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // 
            // txtIDClient
            // 
            txtIDClient.Font = new Font("Segoe UI", 13.8F);
            txtIDClient.Location = new Point(221, 51);
            txtIDClient.Name = "txtIDClient";
            txtIDClient.Size = new Size(309, 38);
            txtIDClient.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 13.8F);
            txtPrice.Location = new Point(221, 184);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(308, 38);
            txtPrice.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new Point(4, 51);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 12;
            label1.Text = "ID клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(4, 95);
            label2.Name = "label2";
            label2.Size = new Size(163, 38);
            label2.TabIndex = 13;
            label2.Text = "Дата заказа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(4, 139);
            label3.Name = "label3";
            label3.Size = new Size(185, 38);
            label3.TabIndex = 14;
            label3.Text = "Статус заказа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(4, 184);
            label4.Name = "label4";
            label4.Size = new Size(171, 38);
            label4.TabIndex = 15;
            label4.Text = "Цена заказа";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 13.8F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(221, 95);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(308, 38);
            dtpDate.TabIndex = 16;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 13.8F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Оформлен", "Отправлен на сборку", "Собран", "Отгружен", "В пути", "Доставлен", "Получен", "Отменён " });
            cmbStatus.Location = new Point(221, 139);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(308, 39);
            cmbStatus.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(254, 38);
            label6.TabIndex = 18;
            label6.Text = "Данные о заказе:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(311, 38);
            label7.TabIndex = 19;
            label7.Text = "Доступные действия:\r\n";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(3, 272);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(523, 71);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Обновить данные";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(3, 349);
            button1.Name = "button1";
            button1.Size = new Size(523, 71);
            button1.TabIndex = 21;
            button1.Text = "Удалённые записи\r\n";
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(2, 426);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(523, 71);
            btnExit.TabIndex = 22;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F);
            label5.Location = new Point(4, 228);
            label5.Name = "label5";
            label5.Size = new Size(187, 38);
            label5.TabIndex = 23;
            label5.Text = "ID перевозки";
            // 
            // txtTransid
            // 
            txtTransid.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtTransid.Location = new Point(221, 228);
            txtTransid.Name = "txtTransid";
            txtTransid.Size = new Size(308, 38);
            txtTransid.TabIndex = 24;
            // 
            // cmbCargos
            // 
            cmbCargos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Location = new Point(221, 283);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(308, 39);
            cmbCargos.TabIndex = 25;
            // 
            // btnAddCargoToOrder
            // 
            btnAddCargoToOrder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddCargoToOrder.Location = new Point(3, 283);
            btnAddCargoToOrder.Name = "btnAddCargoToOrder";
            btnAddCargoToOrder.Size = new Size(205, 39);
            btnAddCargoToOrder.TabIndex = 26;
            btnAddCargoToOrder.Text = "Добавить связь с грузом";
            btnAddCargoToOrder.UseVisualStyleBackColor = true;
            btnAddCargoToOrder.Click += btnAddCargoToOrder_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnAddOrder);
            panel1.Controls.Add(btnEditOrder);
            panel1.Controls.Add(btnDeleteOrder);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(13, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 504);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtIDClient);
            panel2.Controls.Add(btnAddCargoToOrder);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(cmbCargos);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTransid);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(dtpDate);
            panel2.Location = new Point(12, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 334);
            panel2.TabIndex = 28;
            // 
            // OrderAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewOrders);
            Name = "OrderAdminForm";
            Text = "OrderAdminForm";
            Load += OrderAdminForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeleteOrder;
        private Button btnEditOrder;
        private Button btnAddOrder;
        private DataGridView dataGridViewOrders;
        private TextBox txtIDClient;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpDate;
        private ComboBox cmbStatus;
        private Label label6;
        private Label label7;
        private Button btnRefresh;
        private Button button1;
        private Button btnExit;
        private Label label5;
        private TextBox txtTransid;
        private ComboBox cmbCargos;
        private Button btnAddCargoToOrder;
        private Panel panel1;
        private Panel panel2;
    }
}