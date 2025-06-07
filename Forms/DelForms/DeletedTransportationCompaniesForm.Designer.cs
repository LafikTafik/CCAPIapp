namespace CCAPIapp.Forms.DelForms
{
    partial class DeletedTransportationCompaniesForm
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
            btnRestore = new Button();
            dataGridViewDeletedCompanies = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeletedCompanies).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnExit.Location = new Point(643, 572);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(607, 89);
            btnExit.TabIndex = 5;
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
            btnRestore.TabIndex = 4;
            btnRestore.Text = "Восстановить запись";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // dataGridViewDeletedCompanies
            // 
            dataGridViewDeletedCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeletedCompanies.Location = new Point(12, 12);
            dataGridViewDeletedCompanies.Name = "dataGridViewDeletedCompanies";
            dataGridViewDeletedCompanies.RowHeadersWidth = 51;
            dataGridViewDeletedCompanies.Size = new Size(1238, 541);
            dataGridViewDeletedCompanies.TabIndex = 3;
            // 
            // DeletedTransportationCompaniesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnExit);
            Controls.Add(btnRestore);
            Controls.Add(dataGridViewDeletedCompanies);
            Name = "DeletedTransportationCompaniesForm";
            Text = "DeletedTransportationCompaniesForm";
            Load += DeletedTransportationCompaniesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeletedCompanies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnRestore;
        private DataGridView dataGridViewDeletedCompanies;
    }
}