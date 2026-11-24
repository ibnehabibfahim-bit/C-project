
namespace MovieR
{
    partial class LoginR
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 11;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelName
            // 
            this.LabelName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(144, 144);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(0, 32);
            this.LabelName.TabIndex = 9;
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // LabelUser
            // 
            this.LabelUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LabelUser.AutoSize = true;
            this.LabelUser.BackColor = System.Drawing.Color.LightGreen;
            this.LabelUser.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelUser.Location = new System.Drawing.Point(123, 155);
            this.LabelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(177, 32);
            this.LabelUser.TabIndex = 13;
            this.LabelUser.Text = "User Name:";
            this.LabelUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelPassword.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(147, 208);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(153, 32);
            this.LabelPassword.TabIndex = 15;
            this.LabelPassword.Text = "Password:";
            this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_Password
            // 
            this.tb_Password.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tb_Password.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_Password.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(323, 208);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(301, 39);
            this.tb_Password.TabIndex = 16;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged_1);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightGreen;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(323, 275);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(149, 50);
            this.btn_login.TabIndex = 18;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // tb_UserName
            // 
            this.tb_UserName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tb_UserName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_UserName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(323, 155);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(301, 39);
            this.tb_UserName.TabIndex = 14;
            this.tb_UserName.TextChanged += new System.EventHandler(this.tb_UserName_TextChanged_1);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Red;
            this.bExit.Location = new System.Drawing.Point(205, 275);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 58);
            this.bExit.TabIndex = 19;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieR.Properties.Resources.Screenshot_2026_01_18_205012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelName);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Button bExit;
    }
}