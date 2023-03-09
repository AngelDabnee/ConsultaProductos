using MySql.Data.MySqlClient;
namespace consulta_productos
{
    public partial class FromConsulta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPicBoxShare = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.lblbuscarproducto = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGridProductos = new System.Windows.Forms.DataGridView();
            this.Columna_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigo_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxShare)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 406);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BackgroundImage = global::consulta_productos.Properties.Resources.spiderman_fondo_crud;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.iconPicBoxShare);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.txtBuscador);
            this.panel3.Controls.Add(this.lblbuscarproducto);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 394);
            this.panel3.TabIndex = 1;
            // 
            // iconPicBoxShare
            // 
            this.iconPicBoxShare.BackColor = System.Drawing.Color.Transparent;
            this.iconPicBoxShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPicBoxShare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxShare.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPicBoxShare.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxShare.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxShare.IconSize = 47;
            this.iconPicBoxShare.Location = new System.Drawing.Point(797, 66);
            this.iconPicBoxShare.Name = "iconPicBoxShare";
            this.iconPicBoxShare.Size = new System.Drawing.Size(47, 47);
            this.iconPicBoxShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicBoxShare.TabIndex = 2;
            this.iconPicBoxShare.TabStop = false;
            this.iconPicBoxShare.UseGdi = true;
            this.iconPicBoxShare.Click += new System.EventHandler(this.iconPicBoxShare_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscador.Location = new System.Drawing.Point(30, 72);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(761, 26);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblbuscarproducto
            // 
            this.lblbuscarproducto.AutoSize = true;
            this.lblbuscarproducto.BackColor = System.Drawing.Color.Transparent;
            this.lblbuscarproducto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbuscarproducto.Location = new System.Drawing.Point(345, 48);
            this.lblbuscarproducto.Name = "lblbuscarproducto";
            this.lblbuscarproducto.Size = new System.Drawing.Size(186, 23);
            this.lblbuscarproducto.TabIndex = 0;
            this.lblbuscarproducto.Text = "BUSCAR PRODUCTO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dGridProductos);
            this.panel2.Location = new System.Drawing.Point(0, 258);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 134);
            this.panel2.TabIndex = 0;
            // 
            // dGridProductos
            // 
            this.dGridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna_ID,
            this.Column_nombre,
            this.ColumnCodigo_Barras,
            this.ColumnDESCRIPCION,
            this.ColumnPrecio,
            this.ColumnImagen});
            this.dGridProductos.Location = new System.Drawing.Point(3, 2);
            this.dGridProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGridProductos.Name = "dGridProductos";
            this.dGridProductos.RowHeadersWidth = 51;
            this.dGridProductos.RowTemplate.Height = 29;
            this.dGridProductos.Size = new System.Drawing.Size(845, 130);
            this.dGridProductos.TabIndex = 0;
            // 
            // Columna_ID
            // 
            this.Columna_ID.HeaderText = "ID";
            this.Columna_ID.MinimumWidth = 6;
            this.Columna_ID.Name = "Columna_ID";
            // 
            // Column_nombre
            // 
            this.Column_nombre.HeaderText = "NOMBRE";
            this.Column_nombre.MinimumWidth = 6;
            this.Column_nombre.Name = "Column_nombre";
            // 
            // ColumnCodigo_Barras
            // 
            this.ColumnCodigo_Barras.HeaderText = "CÓDIGO DE BARRA";
            this.ColumnCodigo_Barras.MinimumWidth = 6;
            this.ColumnCodigo_Barras.Name = "ColumnCodigo_Barras";
            // 
            // ColumnDESCRIPCION
            // 
            this.ColumnDESCRIPCION.HeaderText = "DESCRIPCIÓN";
            this.ColumnDESCRIPCION.MinimumWidth = 6;
            this.ColumnDESCRIPCION.Name = "ColumnDESCRIPCION";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "PRECIO";
            this.ColumnPrecio.MinimumWidth = 6;
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnImagen
            // 
            this.ColumnImagen.HeaderText = "IMAGEN";
            this.ColumnImagen.MinimumWidth = 6;
            this.ColumnImagen.Name = "ColumnImagen";
            // 
            // FromConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 408);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FromConsulta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FromConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxShare)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txtBuscador;
        private Label lblbuscarproducto;
        private Panel panel2;
        private DataGridView dGridProductos;
        private FontAwesome.Sharp.IconPictureBox iconPiBox;
        private DataGridViewTextBoxColumn Columna_ID;
        private DataGridViewTextBoxColumn Column_nombre;
        private DataGridViewTextBoxColumn ColumnCodigo_Barras;
        private DataGridViewTextBoxColumn ColumnDESCRIPCION;
        private DataGridViewTextBoxColumn ColumnPrecio;
        private DataGridViewTextBoxColumn ColumnImagen;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxShare;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
    } 
}
