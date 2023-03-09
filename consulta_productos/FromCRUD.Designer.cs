using MySql.Data.MySqlClient;
namespace consulta_productos
{
    public partial class FromCRUD
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
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonFoto = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGridProductos = new System.Windows.Forms.DataGridView();
            this.Columna_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigo_Barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconPicBoxSave = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxDelet = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxEdit = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxNew = new FontAwesome.Sharp.IconPictureBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodiBarra = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCodiBarra = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.iconPiBox = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDialogProtImagen = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxDelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPiBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 559);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BackgroundImage = global::consulta_productos.Properties.Resources.spiderman_fondo_crud;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBoxFoto);
            this.panel3.Controls.Add(this.buttonFoto);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.iconPicBoxSave);
            this.panel3.Controls.Add(this.iconPicBoxDelet);
            this.panel3.Controls.Add(this.iconPicBoxEdit);
            this.panel3.Controls.Add(this.iconPicBoxNew);
            this.panel3.Controls.Add(this.txtPrecio);
            this.panel3.Controls.Add(this.txtCodiBarra);
            this.panel3.Controls.Add(this.txtImagen);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.txtNombre);
            this.panel3.Controls.Add(this.lbImagen);
            this.panel3.Controls.Add(this.lbPrecio);
            this.panel3.Controls.Add(this.lbCodiBarra);
            this.panel3.Controls.Add(this.lbDescripcion);
            this.panel3.Controls.Add(this.lbnombre);
            this.panel3.Controls.Add(this.iconPiBox);
            this.panel3.Controls.Add(this.txtBuscador);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(-2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 548);
            this.panel3.TabIndex = 1;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackColor = System.Drawing.Color.White;
            this.pictureBoxFoto.Location = new System.Drawing.Point(850, 129);
            this.pictureBoxFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(189, 185);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 26;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonFoto
            // 
            this.buttonFoto.Location = new System.Drawing.Point(895, 317);
            this.buttonFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(86, 31);
            this.buttonFoto.TabIndex = 25;
            this.buttonFoto.Text = "EXAMINAR";
            this.buttonFoto.UseVisualStyleBackColor = true;
            this.buttonFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Dollar;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 33;
            this.iconPictureBox1.Location = new System.Drawing.Point(238, 256);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 33);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 24;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dGridProductos);
            this.panel2.Location = new System.Drawing.Point(-2, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 147);
            this.panel2.TabIndex = 0;
            // 
            // dGridProductos
            // 
            this.dGridProductos.AllowUserToAddRows = false;
            this.dGridProductos.AllowUserToDeleteRows = false;
            this.dGridProductos.AllowUserToOrderColumns = true;
            this.dGridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridProductos.BackgroundColor = System.Drawing.Color.White;
            this.dGridProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna_ID,
            this.Column_nombre,
            this.ColumnDESCRIPCION,
            this.ColumnCodigo_Barras,
            this.ColumnPrecio,
            this.ColumnImagen});
            this.dGridProductos.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dGridProductos.Location = new System.Drawing.Point(-2, 3);
            this.dGridProductos.Name = "dGridProductos";
            this.dGridProductos.ReadOnly = true;
            this.dGridProductos.RowHeadersWidth = 51;
            this.dGridProductos.RowTemplate.Height = 29;
            this.dGridProductos.Size = new System.Drawing.Size(1115, 139);
            this.dGridProductos.TabIndex = 0;
            this.dGridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridProductos_CellClick);
            this.dGridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridProductos_CellClick);
            // 
            // Columna_ID
            // 
            this.Columna_ID.HeaderText = "ID";
            this.Columna_ID.MinimumWidth = 6;
            this.Columna_ID.Name = "Columna_ID";
            this.Columna_ID.ReadOnly = true;
            // 
            // Column_nombre
            // 
            this.Column_nombre.HeaderText = "NOMBRE";
            this.Column_nombre.MinimumWidth = 6;
            this.Column_nombre.Name = "Column_nombre";
            this.Column_nombre.ReadOnly = true;
            // 
            // ColumnDESCRIPCION
            // 
            this.ColumnDESCRIPCION.HeaderText = "DESCRIPCIÓN";
            this.ColumnDESCRIPCION.MinimumWidth = 6;
            this.ColumnDESCRIPCION.Name = "ColumnDESCRIPCION";
            this.ColumnDESCRIPCION.ReadOnly = true;
            // 
            // ColumnCodigo_Barras
            // 
            this.ColumnCodigo_Barras.HeaderText = "CÓDIGO DE BARRA";
            this.ColumnCodigo_Barras.MinimumWidth = 6;
            this.ColumnCodigo_Barras.Name = "ColumnCodigo_Barras";
            this.ColumnCodigo_Barras.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "PRECIO";
            this.ColumnPrecio.MinimumWidth = 6;
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // ColumnImagen
            // 
            this.ColumnImagen.HeaderText = "IMAGEN";
            this.ColumnImagen.MinimumWidth = 6;
            this.ColumnImagen.Name = "ColumnImagen";
            this.ColumnImagen.ReadOnly = true;
            // 
            // iconPicBoxSave
            // 
            this.iconPicBoxSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconPicBoxSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconPicBoxSave.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxSave.IconSize = 37;
            this.iconPicBoxSave.Location = new System.Drawing.Point(441, 317);
            this.iconPicBoxSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPicBoxSave.Name = "iconPicBoxSave";
            this.iconPicBoxSave.Size = new System.Drawing.Size(37, 43);
            this.iconPicBoxSave.TabIndex = 22;
            this.iconPicBoxSave.TabStop = false;
            this.iconPicBoxSave.Click += new System.EventHandler(this.iconPicBoxSave_Click);
            // 
            // iconPicBoxDelet
            // 
            this.iconPicBoxDelet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPicBoxDelet.BackColor = System.Drawing.Color.Red;
            this.iconPicBoxDelet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxDelet.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconPicBoxDelet.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxDelet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxDelet.IconSize = 37;
            this.iconPicBoxDelet.Location = new System.Drawing.Point(366, 317);
            this.iconPicBoxDelet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPicBoxDelet.Name = "iconPicBoxDelet";
            this.iconPicBoxDelet.Size = new System.Drawing.Size(37, 43);
            this.iconPicBoxDelet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicBoxDelet.TabIndex = 18;
            this.iconPicBoxDelet.TabStop = false;
            this.iconPicBoxDelet.Click += new System.EventHandler(this.iconPicBoxDelet_Click);
            // 
            // iconPicBoxEdit
            // 
            this.iconPicBoxEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPicBoxEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconPicBoxEdit.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxEdit.IconSize = 37;
            this.iconPicBoxEdit.Location = new System.Drawing.Point(267, 317);
            this.iconPicBoxEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPicBoxEdit.Name = "iconPicBoxEdit";
            this.iconPicBoxEdit.Size = new System.Drawing.Size(37, 43);
            this.iconPicBoxEdit.TabIndex = 17;
            this.iconPicBoxEdit.TabStop = false;
            this.iconPicBoxEdit.Click += new System.EventHandler(this.iconPicBoxEdit_Click);
            // 
            // iconPicBoxNew
            // 
            this.iconPicBoxNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPicBoxNew.BackColor = System.Drawing.Color.Lime;
            this.iconPicBoxNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.iconPicBoxNew.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxNew.IconSize = 37;
            this.iconPicBoxNew.Location = new System.Drawing.Point(167, 317);
            this.iconPicBoxNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPicBoxNew.Name = "iconPicBoxNew";
            this.iconPicBoxNew.Size = new System.Drawing.Size(37, 43);
            this.iconPicBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicBoxNew.TabIndex = 16;
            this.iconPicBoxNew.TabStop = false;
            this.iconPicBoxNew.Click += new System.EventHandler(this.iconPicBoxNew_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(279, 255);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(131, 30);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtCodiBarra
            // 
            this.txtCodiBarra.Enabled = false;
            this.txtCodiBarra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodiBarra.Location = new System.Drawing.Point(258, 211);
            this.txtCodiBarra.Name = "txtCodiBarra";
            this.txtCodiBarra.Size = new System.Drawing.Size(345, 30);
            this.txtCodiBarra.TabIndex = 12;
            // 
            // txtImagen
            // 
            this.txtImagen.Enabled = false;
            this.txtImagen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtImagen.Location = new System.Drawing.Point(862, 355);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(151, 30);
            this.txtImagen.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(258, 171);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(347, 30);
            this.txtDescripcion.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(258, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(347, 30);
            this.txtNombre.TabIndex = 9;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.BackColor = System.Drawing.Color.Transparent;
            this.lbImagen.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbImagen.Location = new System.Drawing.Point(905, 89);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(71, 28);
            this.lbImagen.TabIndex = 8;
            this.lbImagen.Text = "FOTO";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lbPrecio.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrecio.Location = new System.Drawing.Point(34, 256);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(97, 28);
            this.lbPrecio.TabIndex = 7;
            this.lbPrecio.Text = "PRECIO";
            // 
            // lbCodiBarra
            // 
            this.lbCodiBarra.AutoSize = true;
            this.lbCodiBarra.BackColor = System.Drawing.Color.Transparent;
            this.lbCodiBarra.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCodiBarra.Location = new System.Drawing.Point(29, 211);
            this.lbCodiBarra.Name = "lbCodiBarra";
            this.lbCodiBarra.Size = new System.Drawing.Size(227, 28);
            this.lbCodiBarra.TabIndex = 6;
            this.lbCodiBarra.Text = "CODIGO DE BARRA";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripcion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescripcion.Location = new System.Drawing.Point(30, 172);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(168, 28);
            this.lbDescripcion.TabIndex = 5;
            this.lbDescripcion.Text = "DESCRIPCIÓN";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.BackColor = System.Drawing.Color.Transparent;
            this.lbnombre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnombre.Location = new System.Drawing.Point(30, 129);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(138, 28);
            this.lbnombre.TabIndex = 3;
            this.lbnombre.Text = "PRODUCTO";
            // 
            // iconPiBox
            // 
            this.iconPiBox.BackColor = System.Drawing.Color.Transparent;
            this.iconPiBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPiBox.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPiBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPiBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPiBox.IconSize = 41;
            this.iconPiBox.Location = new System.Drawing.Point(74, 79);
            this.iconPiBox.Name = "iconPiBox";
            this.iconPiBox.Size = new System.Drawing.Size(48, 41);
            this.iconPiBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPiBox.TabIndex = 2;
            this.iconPiBox.TabStop = false;
            this.iconPiBox.Click += new System.EventHandler(this.iconPiBox_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscador.Location = new System.Drawing.Point(258, 84);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(347, 30);
            this.txtBuscador.TabIndex = 1;
            this.txtBuscador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(366, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALTA DE PRODUCTOS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1117, 30);
            this.menuStrip1.TabIndex = 27;
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
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // openDialogProtImagen
            // 
            this.openDialogProtImagen.FileName = "openFileDialog1";
            this.openDialogProtImagen.Title = "Abrir Imagen de Producto";
            // 
            // FromCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 557);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FromCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FromCRUD_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxDelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPiBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txtBuscador;
        private Label label1;
        private Panel panel2;
        private DataGridView dGridProductos;
        private FontAwesome.Sharp.IconPictureBox iconPiBox;
        private TextBox txtNombre;
        private Label lbImagen;
        private Label lbPrecio;
        private Label lbCodiBarra;
        private Label lbDescripcion;
        private Label lbnombre;
        private TextBox txtPrecio;
        private TextBox txtCodiBarra;
        private TextBox txtDescripcion;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxEdit;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxNew;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxDelet;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxSave;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridViewTextBoxColumn Columna_ID;
        private DataGridViewTextBoxColumn Column_nombre;
        private DataGridViewTextBoxColumn ColumnDESCRIPCION;
        private DataGridViewTextBoxColumn ColumnCodigo_Barras;
        private DataGridViewTextBoxColumn ColumnPrecio;
        private DataGridViewTextBoxColumn ColumnImagen;
        private PictureBox pictureBoxFoto;
        private Button buttonFoto;
        private OpenFileDialog openDialogProtImagen;
        private TextBox txtImagen;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
    }
}