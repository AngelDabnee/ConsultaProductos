namespace consulta_productos
{
    partial class FromMenuUsuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuscarProductos = new System.Windows.Forms.Button();
            this.buttonEditProductos = new System.Windows.Forms.Button();
            this.buttonAdminUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::consulta_productos.Properties.Resources.new_login;
            this.pictureBox1.Location = new System.Drawing.Point(177, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBuscarProductos
            // 
            this.buttonBuscarProductos.Location = new System.Drawing.Point(372, 296);
            this.buttonBuscarProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscarProductos.Name = "buttonBuscarProductos";
            this.buttonBuscarProductos.Size = new System.Drawing.Size(251, 31);
            this.buttonBuscarProductos.TabIndex = 6;
            this.buttonBuscarProductos.Text = "BUSCAR PRODUCTOS";
            this.buttonBuscarProductos.UseVisualStyleBackColor = true;
            this.buttonBuscarProductos.Click += new System.EventHandler(this.buttonBuscarProductos_Click_1);
            // 
            // buttonEditProductos
            // 
            this.buttonEditProductos.Location = new System.Drawing.Point(372, 216);
            this.buttonEditProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditProductos.Name = "buttonEditProductos";
            this.buttonEditProductos.Size = new System.Drawing.Size(251, 31);
            this.buttonEditProductos.TabIndex = 5;
            this.buttonEditProductos.Text = "EDITAR PRODUCTOS";
            this.buttonEditProductos.UseVisualStyleBackColor = true;
            this.buttonEditProductos.Click += new System.EventHandler(this.buttonEditProductos_Click);
            // 
            // buttonAdminUsers
            // 
            this.buttonAdminUsers.Enabled = false;
            this.buttonAdminUsers.Location = new System.Drawing.Point(372, 124);
            this.buttonAdminUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdminUsers.Name = "buttonAdminUsers";
            this.buttonAdminUsers.Size = new System.Drawing.Size(251, 31);
            this.buttonAdminUsers.TabIndex = 4;
            this.buttonAdminUsers.Text = "ADMINISTRADOR DE USUARIOS";
            this.buttonAdminUsers.UseVisualStyleBackColor = true;
            // 
            // FromMenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::consulta_productos.Properties.Resources.fondo_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBuscarProductos);
            this.Controls.Add(this.buttonEditProductos);
            this.Controls.Add(this.buttonAdminUsers);
            this.Name = "FromMenuUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FromMenuUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonBuscarProductos;
        private Button buttonEditProductos;
        private Button buttonAdminUsers;
    }
}