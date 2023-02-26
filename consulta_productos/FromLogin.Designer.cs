namespace consulta_productos
{
    partial class FromLogin
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
            this.iconPictureBoxNotShow = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxShow = new FontAwesome.Sharp.IconPictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNotShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBoxNotShow
            // 
            this.iconPictureBoxNotShow.BackColor = System.Drawing.Color.Silver;
            this.iconPictureBoxNotShow.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBoxNotShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconPictureBoxNotShow.IconColor = System.Drawing.Color.Black;
            this.iconPictureBoxNotShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxNotShow.IconSize = 22;
            this.iconPictureBoxNotShow.Location = new System.Drawing.Point(415, 265);
            this.iconPictureBoxNotShow.Name = "iconPictureBoxNotShow";
            this.iconPictureBoxNotShow.Size = new System.Drawing.Size(32, 22);
            this.iconPictureBoxNotShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxNotShow.TabIndex = 33;
            this.iconPictureBoxNotShow.TabStop = false;
            this.iconPictureBoxNotShow.Click += new System.EventHandler(this.iconPictureBoxNotShow_Click_1);
            // 
            // iconPictureBoxShow
            // 
            this.iconPictureBoxShow.BackColor = System.Drawing.Color.Silver;
            this.iconPictureBoxShow.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBoxShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPictureBoxShow.IconColor = System.Drawing.Color.Black;
            this.iconPictureBoxShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxShow.IconSize = 22;
            this.iconPictureBoxShow.Location = new System.Drawing.Point(368, 265);
            this.iconPictureBoxShow.Name = "iconPictureBoxShow";
            this.iconPictureBoxShow.Size = new System.Drawing.Size(32, 22);
            this.iconPictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxShow.TabIndex = 32;
            this.iconPictureBoxShow.TabStop = false;
            this.iconPictureBoxShow.Click += new System.EventHandler(this.iconPictureBoxShow_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(144, 265);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(198, 26);
            this.txtPassword.TabIndex = 31;
            this.txtPassword.Tag = "*";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(144, 188);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(198, 26);
            this.txtUsuario.TabIndex = 30;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPassword.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(181, 229);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(133, 23);
            this.lbPassword.TabIndex = 29;
            this.lbPassword.Text = "CONTRASEÑA";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Black;
            this.lbUsuario.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(207, 152);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(90, 23);
            this.lbUsuario.TabIndex = 28;
            this.lbUsuario.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::consulta_productos.Properties.Resources.new_login;
            this.pictureBox1.Location = new System.Drawing.Point(181, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(207, 309);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 35;
            this.buttonLogin.Text = "ENTRAR";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // FromLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::consulta_productos.Properties.Resources.fondolol;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 378);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconPictureBoxNotShow);
            this.Controls.Add(this.iconPictureBoxShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsuario);
            this.Name = "FromLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromLogin";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNotShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBoxNotShow;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxShow;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label lbPassword;
        private Label lbUsuario;
        private PictureBox pictureBox1;
        private Button buttonLogin;
    }
}