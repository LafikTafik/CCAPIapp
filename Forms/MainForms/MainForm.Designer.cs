namespace CCAPIapp.Forms
{
    partial class MainForm
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
            label1 = new Label();
            rbAdmin = new RadioButton();
            rbUser = new RadioButton();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 41);
            label1.TabIndex = 0;
            label1.Text = "Выберите профиль";
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbAdmin.ForeColor = Color.Black;
            rbAdmin.Location = new Point(12, 53);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(489, 85);
            rbAdmin.TabIndex = 1;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Администратор";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            rbUser.AutoSize = true;
            rbUser.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbUser.Location = new Point(12, 144);
            rbUser.Name = "rbUser";
            rbUser.Size = new Size(439, 85);
            rbUser.TabIndex = 2;
            rbUser.TabStop = true;
            rbUser.Text = "Пользователь";
            rbUser.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(18, 234);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(489, 84);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 330);
            Controls.Add(btnLogin);
            Controls.Add(rbUser);
            Controls.Add(rbAdmin);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbAdmin;
        private RadioButton rbUser;
        private Button btnLogin;
    }
}