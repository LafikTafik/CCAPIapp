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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnClients
            // 
            btnClients.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClients.Location = new Point(12, 73);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(758, 54);
            btnClients.TabIndex = 0;
            btnClients.Text = "Клиенты";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnOrders
            // 
            btnOrders.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOrders.Location = new Point(12, 133);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(758, 54);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnCargos
            // 
            btnCargos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCargos.Location = new Point(12, 193);
            btnCargos.Name = "btnCargos";
            btnCargos.Size = new Size(758, 54);
            btnCargos.TabIndex = 2;
            btnCargos.Text = "Грузы";
            btnCargos.UseVisualStyleBackColor = true;
            btnCargos.Click += btnCargos_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnVehicles.Location = new Point(12, 373);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(758, 54);
            btnVehicles.TabIndex = 3;
            btnVehicles.Text = "Транспорт";
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDrivers.Location = new Point(12, 433);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(758, 54);
            btnDrivers.TabIndex = 4;
            btnDrivers.Text = "Водители";
            btnDrivers.UseVisualStyleBackColor = true;
            btnDrivers.Click += btnDrivers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(364, 41);
            label1.TabIndex = 5;
            label1.Text = "Редактировать данные:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 567);
            button1.Name = "button1";
            button1.Size = new Size(758, 58);
            button1.TabIndex = 6;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(12, 313);
            button2.Name = "button2";
            button2.Size = new Size(758, 54);
            button2.TabIndex = 8;
            button2.Text = "Перевозки";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(12, 253);
            button3.Name = "button3";
            button3.Size = new Size(758, 54);
            button3.TabIndex = 7;
            button3.Text = "Компании";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 637);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
    }
}