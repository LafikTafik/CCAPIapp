namespace CCAPIapp.Forms.DelForms
{
    partial class DeletedOrdersForm
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
            dataGridViewDeletedOrders = new DataGridView();
            btnExit = new Button();
            btnRestore = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeletedOrders).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDeletedOrders
            // 
            dataGridViewDeletedOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeletedOrders.Location = new Point(12, 12);
            dataGridViewDeletedOrders.Name = "dataGridViewDeletedOrders";
            dataGridViewDeletedOrders.RowHeadersWidth = 51;
            dataGridViewDeletedOrders.Size = new Size(1238, 554);
            dataGridViewDeletedOrders.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(643, 572);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(607, 89);
            btnExit.TabIndex = 4;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.Honeydew;
            btnRestore.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRestore.Location = new Point(12, 572);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(607, 89);
            btnRestore.TabIndex = 3;
            btnRestore.Text = "Восстановить запись";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click_1;
            // 
            // DeletedOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnExit);
            Controls.Add(btnRestore);
            Controls.Add(dataGridViewDeletedOrders);
            Name = "DeletedOrdersForm";
            Text = "DeletedOrdersForm";
            Load += DeletedOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeletedOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDeletedOrders;
        private Button btnExit;
        private Button btnRestore;
    }
}