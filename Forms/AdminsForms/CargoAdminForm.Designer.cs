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
            btnExit = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargos).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 412);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(267, 29);
            btnExit.TabIndex = 13;
            btnExit.Text = "выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeleteCargo
            // 
            btnDeleteCargo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteCargo.Location = new Point(12, 348);
            btnDeleteCargo.Name = "btnDeleteCargo";
            btnDeleteCargo.Size = new Size(267, 57);
            btnDeleteCargo.TabIndex = 12;
            btnDeleteCargo.Text = "Удалить";
            btnDeleteCargo.UseVisualStyleBackColor = true;
            btnDeleteCargo.Click += btnDeleteCargo_Click;
            // 
            // btnEditCargo
            // 
            btnEditCargo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEditCargo.Location = new Point(12, 285);
            btnEditCargo.Name = "btnEditCargo";
            btnEditCargo.Size = new Size(267, 57);
            btnEditCargo.TabIndex = 11;
            btnEditCargo.Text = "Редактировать";
            btnEditCargo.UseVisualStyleBackColor = true;
            btnEditCargo.Click += btnEditCargo_Click;
            // 
            // btnAddCargo
            // 
            btnAddCargo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddCargo.Location = new Point(12, 222);
            btnAddCargo.Name = "btnAddCargo";
            btnAddCargo.Size = new Size(267, 57);
            btnAddCargo.TabIndex = 10;
            btnAddCargo.Text = "Добавить запись";
            btnAddCargo.UseVisualStyleBackColor = true;
            btnAddCargo.Click += btnAddCargo_Click;
            // 
            // dataGridViewCargos
            // 
            dataGridViewCargos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCargos.Location = new Point(410, 1);
            dataGridViewCargos.Name = "dataGridViewCargos";
            dataGridViewCargos.RowHeadersWidth = 51;
            dataGridViewCargos.Size = new Size(760, 450);
            dataGridViewCargos.TabIndex = 9;
            dataGridViewCargos.SelectionChanged += dataGridViewCargos_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 14;
            label1.Text = "ID Заказа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 15;
            label2.Text = "Размер груза";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 42);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 16;
            label3.Text = "Вес груза";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 106);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 17;
            label4.Text = "Описание";
            // 
            // txtDimensions
            // 
            txtDimensions.Location = new Point(168, 76);
            txtDimensions.Name = "txtDimensions";
            txtDimensions.Size = new Size(236, 27);
            txtDimensions.TabIndex = 19;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(168, 43);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(236, 27);
            txtWeight.TabIndex = 20;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(168, 107);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(236, 27);
            txtDescription.TabIndex = 21;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(168, 10);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(236, 27);
            txtOrderID.TabIndex = 22;
            // 
            // CargoAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 453);
            Controls.Add(txtOrderID);
            Controls.Add(txtDescription);
            Controls.Add(txtWeight);
            Controls.Add(txtDimensions);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
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

        private Button btnExit;
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
    }
}