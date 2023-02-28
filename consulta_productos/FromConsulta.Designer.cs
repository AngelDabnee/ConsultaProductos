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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 540);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BackgroundImage = global::consulta_productos.Properties.Resources.fondo_consulta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.iconPicBoxShare);
            this.panel3.Controls.Add(this.txtBuscador);
            this.panel3.Controls.Add(this.lblbuscarproducto);
            this.panel3.Location = new System.Drawing.Point(3, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 308);
            this.panel3.TabIndex = 1;
            // 
            // iconPicBoxShare
            // 
            this.iconPicBoxShare.BackColor = System.Drawing.Color.Silver;
            this.iconPicBoxShare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iconPicBoxShare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxShare.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPicBoxShare.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxShare.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxShare.IconSize = 33;
            this.iconPicBoxShare.Location = new System.Drawing.Point(915, 48);
            this.iconPicBoxShare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPicBoxShare.Name = "iconPicBoxShare";
            this.iconPicBoxShare.Size = new System.Drawing.Size(36, 33);
            this.iconPicBoxShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPicBoxShare.TabIndex = 2;
            this.iconPicBoxShare.TabStop = false;
            this.iconPicBoxShare.UseGdi = true;
            this.iconPicBoxShare.Click += new System.EventHandler(this.iconPicBoxShare_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscador.Location = new System.Drawing.Point(5, 48);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(903, 30);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblbuscarproducto
            // 
            this.lblbuscarproducto.AutoSize = true;
            this.lblbuscarproducto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbuscarproducto.Location = new System.Drawing.Point(399, 9);
            this.lblbuscarproducto.Name = "lblbuscarproducto";
            this.lblbuscarproducto.Size = new System.Drawing.Size(239, 28);
            this.lblbuscarproducto.TabIndex = 0;
            this.lblbuscarproducto.Text = "BUSCAR PRODUCTO";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dGridProductos);
            this.panel2.Location = new System.Drawing.Point(5, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 290);
            this.panel2.TabIndex = 0;
            // 
            // dGridProductos
            // 
            this.dGridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridProductos.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.dGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna_ID,
            this.Column_nombre,
            this.ColumnCodigo_Barras,
            this.ColumnDESCRIPCION,
            this.ColumnPrecio,
            this.ColumnImagen});
            this.dGridProductos.Location = new System.Drawing.Point(-2, 87);
            this.dGridProductos.Name = "dGridProductos";
            this.dGridProductos.RowHeadersWidth = 51;
            this.dGridProductos.RowTemplate.Height = 29;
            this.dGridProductos.Size = new System.Drawing.Size(974, 196);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 544);
            this.Controls.Add(this.panel1);
            this.Name = "FromConsulta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FromConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxShare)).EndInit();
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
    } 
}
