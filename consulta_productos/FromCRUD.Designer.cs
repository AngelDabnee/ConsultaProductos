﻿using MySql.Data.MySqlClient;
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
            this.label7 = new System.Windows.Forms.Label();
            this.iconPicAplicar = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPicBoxSave = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPicBoxDelet = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxEdit = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicBoxNew = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.iconPicAplicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxDelet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPiBox)).BeginInit();
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
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.iconPicAplicar);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.iconPicBoxSave);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.iconPicBoxDelet);
            this.panel3.Controls.Add(this.iconPicBoxEdit);
            this.panel3.Controls.Add(this.iconPicBoxNew);
            this.panel3.Controls.Add(this.label2);
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
            this.panel3.Location = new System.Drawing.Point(3, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 336);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(638, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "APLICAR";
            // 
            // iconPicAplicar
            // 
            this.iconPicAplicar.BackColor = System.Drawing.Color.Yellow;
            this.iconPicAplicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPicAplicar.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.iconPicAplicar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconPicAplicar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicAplicar.IconSize = 40;
            this.iconPicAplicar.Location = new System.Drawing.Point(587, 284);
            this.iconPicAplicar.Name = "iconPicAplicar";
            this.iconPicAplicar.Size = new System.Drawing.Size(40, 40);
            this.iconPicAplicar.TabIndex = 24;
            this.iconPicAplicar.TabStop = false;
            this.iconPicAplicar.Click += new System.EventHandler(this.iconPicAplicar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(798, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "GUARDAR";
            // 
            // iconPicBoxSave
            // 
            this.iconPicBoxSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconPicBoxSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconPicBoxSave.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPicBoxSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicBoxSave.IconSize = 37;
            this.iconPicBoxSave.Location = new System.Drawing.Point(755, 277);
            this.iconPicBoxSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPicBoxSave.Name = "iconPicBoxSave";
            this.iconPicBoxSave.Size = new System.Drawing.Size(37, 43);
            this.iconPicBoxSave.TabIndex = 22;
            this.iconPicBoxSave.TabStop = false;
            this.iconPicBoxSave.Click += new System.EventHandler(this.iconPicBoxSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(798, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "BORRAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(638, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "EDITAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(636, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "AÑADIR";
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
            this.iconPicBoxDelet.Location = new System.Drawing.Point(755, 226);
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
            this.iconPicBoxEdit.Location = new System.Drawing.Point(589, 230);
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
            this.iconPicBoxNew.Location = new System.Drawing.Point(589, 177);
            this.iconPicBoxNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPicBoxNew.Name = "iconPicBoxNew";
            this.iconPicBoxNew.Size = new System.Drawing.Size(37, 43);
            this.iconPicBoxNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicBoxNew.TabIndex = 16;
            this.iconPicBoxNew.TabStop = false;
            this.iconPicBoxNew.Click += new System.EventHandler(this.iconPicBoxNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(774, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseWaitCursor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(799, 144);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(164, 30);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtCodiBarra
            // 
            this.txtCodiBarra.Enabled = false;
            this.txtCodiBarra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodiBarra.Location = new System.Drawing.Point(799, 100);
            this.txtCodiBarra.Name = "txtCodiBarra";
            this.txtCodiBarra.Size = new System.Drawing.Size(164, 30);
            this.txtCodiBarra.TabIndex = 12;
            // 
            // txtImagen
            // 
            this.txtImagen.Enabled = false;
            this.txtImagen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtImagen.Location = new System.Drawing.Point(169, 188);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(396, 30);
            this.txtImagen.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(171, 144);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(396, 30);
            this.txtDescripcion.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(171, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(396, 30);
            this.txtNombre.TabIndex = 9;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbImagen.Location = new System.Drawing.Point(5, 188);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(103, 28);
            this.lbImagen.TabIndex = 8;
            this.lbImagen.Text = "IMAGEN";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrecio.Location = new System.Drawing.Point(579, 144);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(97, 28);
            this.lbPrecio.TabIndex = 7;
            this.lbPrecio.Text = "PRECIO";
            // 
            // lbCodiBarra
            // 
            this.lbCodiBarra.AutoSize = true;
            this.lbCodiBarra.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCodiBarra.Location = new System.Drawing.Point(575, 102);
            this.lbCodiBarra.Name = "lbCodiBarra";
            this.lbCodiBarra.Size = new System.Drawing.Size(227, 28);
            this.lbCodiBarra.TabIndex = 6;
            this.lbCodiBarra.Text = "CODIGO DE BARRA";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDescripcion.Location = new System.Drawing.Point(5, 144);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(168, 28);
            this.lbDescripcion.TabIndex = 5;
            this.lbDescripcion.Text = "DESCRIPCIÓN";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbnombre.Location = new System.Drawing.Point(5, 100);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(138, 28);
            this.lbnombre.TabIndex = 3;
            this.lbnombre.Text = "PRODUCTO";
            // 
            // iconPiBox
            // 
            this.iconPiBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconPiBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPiBox.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPiBox.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPiBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPiBox.IconSize = 40;
            this.iconPiBox.Location = new System.Drawing.Point(917, 43);
            this.iconPiBox.Name = "iconPiBox";
            this.iconPiBox.Size = new System.Drawing.Size(48, 40);
            this.iconPiBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPiBox.TabIndex = 2;
            this.iconPiBox.TabStop = false;
            this.iconPiBox.Click += new System.EventHandler(this.iconPiBox_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(331, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALTA DE PRODUCTOS";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dGridProductos);
            this.panel2.Location = new System.Drawing.Point(3, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 229);
            this.panel2.TabIndex = 0;
            // 
            // dGridProductos
            // 
            this.dGridProductos.BackgroundColor = System.Drawing.Color.Silver;
            this.dGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna_ID,
            this.Column_nombre,
            this.ColumnCodigo_Barras,
            this.ColumnDESCRIPCION,
            this.ColumnPrecio,
            this.ColumnImagen});
            this.dGridProductos.Location = new System.Drawing.Point(-2, 45);
            this.dGridProductos.Name = "dGridProductos";
            this.dGridProductos.RowHeadersWidth = 51;
            this.dGridProductos.RowTemplate.Height = 29;
            this.dGridProductos.Size = new System.Drawing.Size(981, 203);
            this.dGridProductos.TabIndex = 0;
            this.dGridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridProductos_CellClick);
            // 
            // Columna_ID
            // 
            this.Columna_ID.HeaderText = "ID";
            this.Columna_ID.MinimumWidth = 6;
            this.Columna_ID.Name = "Columna_ID";
            this.Columna_ID.Width = 125;
            // 
            // Column_nombre
            // 
            this.Column_nombre.HeaderText = "NOMBRE";
            this.Column_nombre.MinimumWidth = 6;
            this.Column_nombre.Name = "Column_nombre";
            this.Column_nombre.Width = 125;
            // 
            // ColumnCodigo_Barras
            // 
            this.ColumnCodigo_Barras.HeaderText = "CÓDIGO DE BARRA";
            this.ColumnCodigo_Barras.MinimumWidth = 6;
            this.ColumnCodigo_Barras.Name = "ColumnCodigo_Barras";
            this.ColumnCodigo_Barras.Width = 125;
            // 
            // ColumnDESCRIPCION
            // 
            this.ColumnDESCRIPCION.HeaderText = "DESCRIPCIÓN";
            this.ColumnDESCRIPCION.MinimumWidth = 6;
            this.ColumnDESCRIPCION.Name = "ColumnDESCRIPCION";
            this.ColumnDESCRIPCION.Width = 125;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "PRECIO";
            this.ColumnPrecio.MinimumWidth = 6;
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.Width = 125;
            // 
            // ColumnImagen
            // 
            this.ColumnImagen.HeaderText = "IMAGEN";
            this.ColumnImagen.MinimumWidth = 6;
            this.ColumnImagen.Name = "ColumnImagen";
            this.ColumnImagen.Width = 125;
            // 
            // FromCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 544);
            this.Controls.Add(this.panel1);
            this.Name = "FromCRUD";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FromCRUD_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicAplicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxDelet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPiBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridProductos)).EndInit();
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
        private DataGridViewTextBoxColumn Columna_ID;
        private DataGridViewTextBoxColumn Column_nombre;
        private DataGridViewTextBoxColumn ColumnCodigo_Barras;
        private DataGridViewTextBoxColumn ColumnDESCRIPCION;
        private DataGridViewTextBoxColumn ColumnPrecio;
        private DataGridViewTextBoxColumn ColumnImagen;
        private TextBox txtNombre;
        private Label lbImagen;
        private Label lbPrecio;
        private Label lbCodiBarra;
        private Label lbDescripcion;
        private Label lbnombre;
        private TextBox txtPrecio;
        private TextBox txtCodiBarra;
        private TextBox txtImagen;
        private TextBox txtDescripcion;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxEdit;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxNew;
        private Label label5;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxDelet;
        private FontAwesome.Sharp.IconPictureBox iconPicBoxSave;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPicAplicar;
    }
}