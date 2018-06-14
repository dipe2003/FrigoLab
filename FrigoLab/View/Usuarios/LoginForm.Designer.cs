namespace FrigLab.View.Usuarios {
    partial class LoginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnLogin = new System.Windows.Forms.Button();
        	this.lblUsuario = new System.Windows.Forms.Label();
        	this.txtUsuario = new System.Windows.Forms.TextBox();
        	this.lblPassword = new System.Windows.Forms.Label();
        	this.txtPass = new System.Windows.Forms.TextBox();
        	this.imgUsuario = new System.Windows.Forms.PictureBox();
        	this.imgPassword = new System.Windows.Forms.PictureBox();
        	((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.btnCancelar.Location = new System.Drawing.Point(19, 165);
        	this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(78, 28);
        	this.btnCancelar.TabIndex = 3;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
        	// 
        	// btnLogin
        	// 
        	this.btnLogin.Location = new System.Drawing.Point(123, 165);
        	this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
        	this.btnLogin.Name = "btnLogin";
        	this.btnLogin.Size = new System.Drawing.Size(78, 28);
        	this.btnLogin.TabIndex = 2;
        	this.btnLogin.Text = "Ingresar";
        	this.btnLogin.UseVisualStyleBackColor = true;
        	this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
        	// 
        	// lblUsuario
        	// 
        	this.lblUsuario.AutoSize = true;
        	this.lblUsuario.Location = new System.Drawing.Point(19, 29);
        	this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.lblUsuario.Name = "lblUsuario";
        	this.lblUsuario.Size = new System.Drawing.Size(43, 13);
        	this.lblUsuario.TabIndex = 4;
        	this.lblUsuario.Text = "Usuario";
        	// 
        	// txtUsuario
        	// 
        	this.txtUsuario.Location = new System.Drawing.Point(45, 54);
        	this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
        	this.txtUsuario.Name = "txtUsuario";
        	this.txtUsuario.Size = new System.Drawing.Size(156, 20);
        	this.txtUsuario.TabIndex = 0;
        	// 
        	// lblPassword
        	// 
        	this.lblPassword.AutoSize = true;
        	this.lblPassword.Location = new System.Drawing.Point(19, 91);
        	this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.lblPassword.Name = "lblPassword";
        	this.lblPassword.Size = new System.Drawing.Size(53, 13);
        	this.lblPassword.TabIndex = 5;
        	this.lblPassword.Text = "Password";
        	// 
        	// txtPass
        	// 
        	this.txtPass.Location = new System.Drawing.Point(45, 115);
        	this.txtPass.Margin = new System.Windows.Forms.Padding(2);
        	this.txtPass.Name = "txtPass";
        	this.txtPass.Size = new System.Drawing.Size(156, 20);
        	this.txtPass.TabIndex = 1;
        	this.txtPass.UseSystemPasswordChar = true;
        	// 
        	// imgUsuario
        	// 
        	this.imgUsuario.Image = global::FrigLab.Properties.Resources.imagen_usuario;
        	this.imgUsuario.Location = new System.Drawing.Point(19, 54);
        	this.imgUsuario.Name = "imgUsuario";
        	this.imgUsuario.Size = new System.Drawing.Size(21, 20);
        	this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.imgUsuario.TabIndex = 6;
        	this.imgUsuario.TabStop = false;
        	// 
        	// imgPassword
        	// 
        	this.imgPassword.Image = global::FrigLab.Properties.Resources.imagen_password;
        	this.imgPassword.Location = new System.Drawing.Point(19, 115);
        	this.imgPassword.Name = "imgPassword";
        	this.imgPassword.Size = new System.Drawing.Size(21, 20);
        	this.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.imgPassword.TabIndex = 6;
        	this.imgPassword.TabStop = false;
        	// 
        	// LoginForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.btnCancelar;
        	this.ClientSize = new System.Drawing.Size(214, 245);
        	this.ControlBox = false;
        	this.Controls.Add(this.imgPassword);
        	this.Controls.Add(this.imgUsuario);
        	this.Controls.Add(this.txtPass);
        	this.Controls.Add(this.lblPassword);
        	this.Controls.Add(this.txtUsuario);
        	this.Controls.Add(this.lblUsuario);
        	this.Controls.Add(this.btnLogin);
        	this.Controls.Add(this.btnCancelar);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.MaximizeBox = false;
        	this.MaximumSize = new System.Drawing.Size(230, 283);
        	this.MinimumSize = new System.Drawing.Size(230, 283);
        	this.Name = "LoginForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Login";
        	this.TopMost = true;
        	((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.PictureBox imgPassword;
    }
}