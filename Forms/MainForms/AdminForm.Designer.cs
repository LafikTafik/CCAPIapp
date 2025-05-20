namespace CCAPIapp.Forms
{
    partial class AdminForm
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
            btnClients = new Button();
            btnOrders = new Button();
            btnCargos = new Button();
            btnVehicles = new Button();
            btnDrivers = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClients
            // 
            btnClients.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClients.Location = new Point(12, 43);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(268, 54);
            btnClients.TabIndex = 0;
            btnClients.Text = "Клиенты";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnOrders
            // 
            btnOrders.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOrders.Location = new Point(12, 103);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(268, 54);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnCargos
            // 
            btnCargos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCargos.Location = new Point(12, 163);
            btnCargos.Name = "btnCargos";
            btnCargos.Size = new Size(268, 54);
            btnCargos.TabIndex = 2;
            btnCargos.Text = "Грузы";
            btnCargos.UseVisualStyleBackColor = true;
            btnCargos.Click += btnCargos_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnVehicles.Location = new Point(12, 223);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(268, 54);
            btnVehicles.TabIndex = 3;
            btnVehicles.Text = "Транспорт";
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDrivers.Location = new Point(12, 283);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(268, 54);
            btnDrivers.TabIndex = 4;
            btnDrivers.Text = "Водители";
            btnDrivers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 31);
            label1.TabIndex = 5;
            label1.Text = "Редактировать данные:";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDrivers);
            Controls.Add(btnVehicles);
            Controls.Add(btnCargos);
            Controls.Add(btnOrders);
            Controls.Add(btnClients);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClients;
        private Button btnOrders;
        private Button btnCargos;
        private Button btnVehicles;
        private Button btnDrivers;
        private Label label1;
    }
}