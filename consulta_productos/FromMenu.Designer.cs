namespace consulta_productos
{
    partial class FromMenu
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
            this.buttonAdminUsers = new System.Windows.Forms.Button();
            this.buttonEditProductos = new System.Windows.Forms.Button();
            this.buttonBuscarProductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdminUsers
            // 
            this.buttonAdminUsers.Location = new System.Drawing.Point(198, 87);
            this.buttonAdminUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdminUsers.Name = "buttonAdminUsers";
            this.buttonAdminUsers.Size = new System.Drawing.Size(251, 31);
            this.buttonAdminUsers.TabIndex = 0;
            this.buttonAdminUsers.Text = "ADMINISTRADOR DE USUARIOS";
            this.buttonAdminUsers.UseVisualStyleBackColor = true;
            this.buttonAdminUsers.Click += new System.EventHandler(this.buttonAdminUsers_Click);
            // 
            // buttonEditProductos
            // 
            this.buttonEditProductos.Location = new System.Drawing.Point(198, 179);
            this.buttonEditProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditProductos.Name = "buttonEditProductos";
            this.buttonEditProductos.Size = new System.Drawing.Size(251, 31);
            this.buttonEditProductos.TabIndex = 1;
            this.buttonEditProductos.Text = "EDITAR PRODUCTOS";
            this.buttonEditProductos.UseVisualStyleBackColor = true;
            this.buttonEditProductos.Click += new System.EventHandler(this.buttonEditProductos_Click);
            // 
            // buttonBuscarProductos
            // 
            this.buttonBuscarProductos.Location = new System.Drawing.Point(198, 259);
            this.buttonBuscarProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscarProductos.Name = "buttonBuscarProductos";
            this.buttonBuscarProductos.Size = new System.Drawing.Size(251, 31);
            this.buttonBuscarProductos.TabIndex = 2;
            this.buttonBuscarProductos.Text = "BUSCAR PRODUCTOS";
            this.buttonBuscarProductos.UseVisualStyleBackColor = true;
            this.buttonBuscarProductos.Click += new System.EventHandler(this.buttonBuscarProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::consulta_productos.Properties.Resources.new_login;
            this.pictureBox1.Location = new System.Drawing.Point(3, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FromMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::consulta_productos.Properties.Resources.menu2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 392);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBuscarProductos);
            this.Controls.Add(this.buttonEditProductos);
            this.Controls.Add(this.buttonAdminUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FromMenu";
            this.Text = "FromMenu";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAdminUsers;
        private Button buttonEditProductos;
        private Button buttonBuscarProductos;
        private PictureBox pictureBox1;
    }
}