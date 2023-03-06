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
            this.buttonBuscarProductos = new System.Windows.Forms.Button();
            this.buttonEditProductos = new System.Windows.Forms.Button();
            this.buttonAdminUsers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscarProductos
            // 
            this.buttonBuscarProductos.Location = new System.Drawing.Point(55, 120);
            this.buttonBuscarProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscarProductos.Name = "buttonBuscarProductos";
            this.buttonBuscarProductos.Size = new System.Drawing.Size(261, 31);
            this.buttonBuscarProductos.TabIndex = 6;
            this.buttonBuscarProductos.Text = "BUSCAR PRODUCTOS";
            this.buttonBuscarProductos.UseVisualStyleBackColor = true;
            this.buttonBuscarProductos.Click += new System.EventHandler(this.buttonBuscarProductos_Click_1);
            // 
            // buttonEditProductos
            // 
            this.buttonEditProductos.Location = new System.Drawing.Point(55, 71);
            this.buttonEditProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditProductos.Name = "buttonEditProductos";
            this.buttonEditProductos.Size = new System.Drawing.Size(261, 31);
            this.buttonEditProductos.TabIndex = 5;
            this.buttonEditProductos.Text = "EDITAR PRODUCTOS";
            this.buttonEditProductos.UseVisualStyleBackColor = true;
            this.buttonEditProductos.Click += new System.EventHandler(this.buttonEditProductos_Click);
            // 
            // buttonAdminUsers
            // 
            this.buttonAdminUsers.Enabled = false;
            this.buttonAdminUsers.Location = new System.Drawing.Point(55, 17);
            this.buttonAdminUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdminUsers.Name = "buttonAdminUsers";
            this.buttonAdminUsers.Size = new System.Drawing.Size(261, 31);
            this.buttonAdminUsers.TabIndex = 4;
            this.buttonAdminUsers.Text = "ADMINISTRADOR DE USUARIOS";
            this.buttonAdminUsers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonBuscarProductos);
            this.panel1.Controls.Add(this.buttonEditProductos);
            this.panel1.Controls.Add(this.buttonAdminUsers);
            this.panel1.Location = new System.Drawing.Point(207, 148);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 155);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::consulta_productos.Properties.Resources.new_login;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(14, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 163);
            this.panel2.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProductosToolStripMenuItem,
            this.editarProductosToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // buscarProductosToolStripMenuItem
            // 
            this.buscarProductosToolStripMenuItem.Name = "buscarProductosToolStripMenuItem";
            this.buscarProductosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buscarProductosToolStripMenuItem.Text = "Buscar Productos";
            // 
            // editarProductosToolStripMenuItem
            // 
            this.editarProductosToolStripMenuItem.Name = "editarProductosToolStripMenuItem";
            this.editarProductosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editarProductosToolStripMenuItem.Text = "Editar Productos";
            // 
            // FromMenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::consulta_productos.Properties.Resources.menu2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FromMenuUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FromMenuUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonBuscarProductos;
        private Button buttonEditProductos;
        private Button buttonAdminUsers;
        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private ToolStripMenuItem buscarProductosToolStripMenuItem;
        private ToolStripMenuItem editarProductosToolStripMenuItem;
    }
}