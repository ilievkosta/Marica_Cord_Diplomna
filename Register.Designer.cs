
namespace Marica_Coord
{
    partial class Register
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
            this.lblR_Username = new System.Windows.Forms.Label();
            this.lblR_Password = new System.Windows.Forms.Label();
            this.lblR_PasswordReenter = new System.Windows.Forms.Label();
            this.txtRusername = new System.Windows.Forms.TextBox();
            this.txbR_Password = new System.Windows.Forms.TextBox();
            this.txbR_Password2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblR_Username
            // 
            this.lblR_Username.AutoSize = true;
            this.lblR_Username.Location = new System.Drawing.Point(56, 71);
            this.lblR_Username.Name = "lblR_Username";
            this.lblR_Username.Size = new System.Drawing.Size(108, 13);
            this.lblR_Username.TabIndex = 0;
            this.lblR_Username.Text = "Потребителско име";
            // 
            // lblR_Password
            // 
            this.lblR_Password.AutoSize = true;
            this.lblR_Password.Location = new System.Drawing.Point(56, 100);
            this.lblR_Password.Name = "lblR_Password";
            this.lblR_Password.Size = new System.Drawing.Size(45, 13);
            this.lblR_Password.TabIndex = 1;
            this.lblR_Password.Text = "Парола";
            // 
            // lblR_PasswordReenter
            // 
            this.lblR_PasswordReenter.AutoSize = true;
            this.lblR_PasswordReenter.Location = new System.Drawing.Point(56, 130);
            this.lblR_PasswordReenter.Name = "lblR_PasswordReenter";
            this.lblR_PasswordReenter.Size = new System.Drawing.Size(154, 13);
            this.lblR_PasswordReenter.TabIndex = 2;
            this.lblR_PasswordReenter.Text = "Потвръждаване на паролата";
            // 
            // txtRusername
            // 
            this.txtRusername.Location = new System.Drawing.Point(221, 71);
            this.txtRusername.Name = "txtRusername";
            this.txtRusername.Size = new System.Drawing.Size(147, 20);
            this.txtRusername.TabIndex = 3;
            // 
            // txbR_Password
            // 
            this.txbR_Password.Location = new System.Drawing.Point(221, 97);
            this.txbR_Password.Name = "txbR_Password";
            this.txbR_Password.Size = new System.Drawing.Size(147, 20);
            this.txbR_Password.TabIndex = 4;
            this.txbR_Password.UseSystemPasswordChar = true;
            // 
            // txbR_Password2
            // 
            this.txbR_Password2.Location = new System.Drawing.Point(221, 123);
            this.txbR_Password2.Name = "txbR_Password2";
            this.txbR_Password2.Size = new System.Drawing.Size(147, 20);
            this.txbR_Password2.TabIndex = 5;
            this.txbR_Password2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Регистрация";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(221, 149);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(147, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Регистрирай";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(31, 178);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(133, 13);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Грешки при регистрация";

            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 211);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbR_Password2);
            this.Controls.Add(this.txbR_Password);
            this.Controls.Add(this.txtRusername);
            this.Controls.Add(this.lblR_PasswordReenter);
            this.Controls.Add(this.lblR_Password);
            this.Controls.Add(this.lblR_Username);
            this.MaximumSize = new System.Drawing.Size(470, 250);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblR_Username;
        private System.Windows.Forms.Label lblR_Password;
        private System.Windows.Forms.Label lblR_PasswordReenter;
        private System.Windows.Forms.TextBox txtRusername;
        private System.Windows.Forms.TextBox txbR_Password;
        private System.Windows.Forms.TextBox txbR_Password2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblError;
    }
}