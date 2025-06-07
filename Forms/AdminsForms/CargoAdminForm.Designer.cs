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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDimensions = new TextBox();
            txtWeight = new TextBox();
            txtDescription = new TextBox();
            btnRefresh = new Button();
            button1 = new Button();
            btnExit = new Button();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeleteCargo
            // 
            btnDeleteCargo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteCargo.Location = new Point(9, 195);
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
            btnEditCargo.Location = new Point(9, 118);
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
            btnAddCargo.Location = new Point(9, 41);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F);
            label2.Location = new Point(9, 98);
            label2.Name = "label2";
            label2.Size = new Size(185, 38);
            label2.TabIndex = 15;
            label2.Text = "Размер груза";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(9, 54);
            label3.Name = "label3";
            label3.Size = new Size(136, 38);
            label3.TabIndex = 16;
            label3.Text = "Вес груза";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(9, 142);
            label4.Name = "label4";
            label4.Size = new Size(144, 38);
            label4.TabIndex = 17;
            label4.Text = "Описание";
            // 
            // txtDimensions
            // 
            txtDimensions.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDimensions.Location = new Point(245, 98);
            txtDimensions.Name = "txtDimensions";
            txtDimensions.Size = new Size(282, 38);
            txtDimensions.TabIndex = 19;
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtWeight.Location = new Point(245, 54);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(282, 38);
            txtWeight.TabIndex = 20;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDescription.Location = new Point(245, 142);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(282, 38);
            txtDescription.TabIndex = 21;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(9, 272);
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
            button1.Location = new Point(9, 349);
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
            btnExit.Location = new Point(9, 426);
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
            label6.Location = new Point(9, 13);
            label6.Name = "label6";
            label6.Size = new Size(238, 38);
            label6.TabIndex = 26;
            label6.Text = "Данные о грузе:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(9, 0);
            label7.Name = "label7";
            label7.Size = new Size(311, 38);
            label7.TabIndex = 27;
            label7.Text = "Доступные действия:\r\n";
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
            panel1.Location = new Point(12, 337);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 504);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtWeight);
            panel2.Controls.Add(txtDimensions);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 191);
            panel2.TabIndex = 29;
            // 
            // CargoAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCargos);
            Name = "CargoAdminForm";
            Text = "CargoAdminForm";
            Load += CargoAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCargos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDeleteCargo;
        private Button btnEditCargo;
        private Button btnAddCargo;
        private DataGridView dataGridViewCargos;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDimensions;
        private TextBox txtWeight;
        private TextBox txtDescription;
        private Button btnRefresh;
        private Button button1;
        private Button btnExit;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
    }
}