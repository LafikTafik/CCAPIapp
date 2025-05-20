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
            btnExit = new Button();
            txtIDClient = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteOrder.Location = new Point(13, 358);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(267, 57);
            btnDeleteOrder.TabIndex = 7;
            btnDeleteOrder.Text = "Удалить";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteClient_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditOrder.Location = new Point(13, 295);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(267, 57);
            btnEditOrder.TabIndex = 6;
            btnEditOrder.Text = "Редактировать";
            btnEditOrder.UseVisualStyleBackColor = true;
            btnEditOrder.Click += btnEditClient_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddOrder.Location = new Point(13, 232);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(267, 57);
            btnAddOrder.TabIndex = 5;
            btnAddOrder.Text = "Добавить запись";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddClient_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(413, 0);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(760, 450);
            dataGridViewOrders.TabIndex = 4;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(13, 421);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(267, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtIDClient
            // 
            txtIDClient.Location = new Point(154, 10);
            txtIDClient.Name = "txtIDClient";
            txtIDClient.Size = new Size(253, 27);
            txtIDClient.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(154, 108);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(253, 27);
            txtPrice.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 12;
            label1.Text = "ID клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 13;
            label2.Text = "Дата заказа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 14;
            label3.Text = "Статус заказа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(13, 108);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 15;
            label4.Text = "Цена заказа";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(154, 43);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(253, 27);
            dtpDate.TabIndex = 16;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Оформлен", "Отправлен на сборку", "Собран", "Отгружен", "В пути", "Доставлен", "Получен", "Отменён " });
            cmbStatus.Location = new Point(154, 75);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(253, 28);
            cmbStatus.TabIndex = 17;
            // 
            // OrderAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 453);
            Controls.Add(cmbStatus);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtIDClient);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteOrder);
            Controls.Add(btnEditOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(dataGridViewOrders);
            Name = "OrderAdminForm";
            Text = "OrderAdminForm";
            Load += OrderAdminForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteOrder;
        private Button btnEditOrder;
        private Button btnAddOrder;
        private DataGridView dataGridViewOrders;
        private Button btnExit;
        private TextBox txtIDClient;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpDate;
        private ComboBox cmbStatus;
    }
}