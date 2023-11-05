namespace CapaPresentacion
{
    partial class frmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.txtdocproveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtregistrar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.btnBuscarproveedor = new FontAwesome.Sharp.IconButton();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 45);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(945, 526);
            this.label10.TabIndex = 22;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(71, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 16);
            this.label9.TabIndex = 72;
            this.label9.Text = "REGISTRAR COMPRA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTipoDocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Location = new System.Drawing.Point(74, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 79);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(191, 42);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(161, 21);
            this.cboTipoDocumento.TabIndex = 1;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(17, 43);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(152, 20);
            this.txtfecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtidproveedor);
            this.groupBox2.Controls.Add(this.txtnombreproveedor);
            this.groupBox2.Controls.Add(this.btnBuscarproveedor);
            this.groupBox2.Controls.Add(this.txtdocproveedor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(534, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 79);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Proveedor";
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(363, 11);
            this.txtidproveedor.Multiline = true;
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(46, 25);
            this.txtidproveedor.TabIndex = 58;
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.Location = new System.Drawing.Point(236, 42);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.Size = new System.Drawing.Size(173, 20);
            this.txtnombreproveedor.TabIndex = 57;
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.Location = new System.Drawing.Point(17, 42);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.Size = new System.Drawing.Size(154, 20);
            this.txtdocproveedor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Razón social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número de Documento";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtprecioventa);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtpreciocompra);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtproducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnbuscarproducto);
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.txtcodproducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(74, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(791, 94);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de producto";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(668, 53);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(98, 20);
            this.txtcantidad.TabIndex = 70;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(669, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Cantidad:";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(564, 53);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(98, 20);
            this.txtprecioventa.TabIndex = 68;
            this.txtprecioventa.TextChanged += new System.EventHandler(this.txtprecioventa_TextChanged);
            this.txtprecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioventa_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(561, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Precio de venta:";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(460, 53);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(98, 20);
            this.txtpreciocompra.TabIndex = 66;
            this.txtpreciocompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciocompra_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Precio de compra:";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(262, 53);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(184, 20);
            this.txtproducto.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Producto:";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(151, 22);
            this.txtidproducto.Multiline = true;
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(46, 25);
            this.txtidproducto.TabIndex = 61;
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(24, 53);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(173, 20);
            this.txtcodproducto.TabIndex = 60;
            this.txtcodproducto.TextChanged += new System.EventHandler(this.txtcodproducto_TextChanged);
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Código de producto:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btnEliminar});
            this.dgvdata.Location = new System.Drawing.Point(74, 319);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdata.Size = new System.Drawing.Size(766, 201);
            this.dgvdata.TabIndex = 76;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(863, 450);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(120, 20);
            this.txttotalpagar.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(880, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Total a pagar";
            // 
            // txtregistrar
            // 
            this.txtregistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.txtregistrar.IconColor = System.Drawing.Color.Black;
            this.txtregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtregistrar.Location = new System.Drawing.Point(863, 476);
            this.txtregistrar.Name = "txtregistrar";
            this.txtregistrar.Size = new System.Drawing.Size(123, 44);
            this.txtregistrar.TabIndex = 78;
            this.txtregistrar.Text = "Registrar";
            this.txtregistrar.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(883, 233);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 60);
            this.iconButton1.TabIndex = 77;
            this.iconButton1.Text = "Agregar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnbuscarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarproducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.White;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 20;
            this.btnbuscarproducto.Location = new System.Drawing.Point(203, 50);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(43, 25);
            this.btnbuscarproducto.TabIndex = 62;
            this.btnbuscarproducto.UseVisualStyleBackColor = false;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // btnBuscarproveedor
            // 
            this.btnBuscarproveedor.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscarproveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarproveedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarproveedor.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarproveedor.IconColor = System.Drawing.Color.White;
            this.btnBuscarproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarproveedor.IconSize = 20;
            this.btnBuscarproveedor.Location = new System.Drawing.Point(177, 37);
            this.btnBuscarproveedor.Name = "btnBuscarproveedor";
            this.btnBuscarproveedor.Size = new System.Drawing.Size(43, 25);
            this.btnBuscarproveedor.TabIndex = 56;
            this.btnBuscarproveedor.UseVisualStyleBackColor = false;
            this.btnBuscarproveedor.Click += new System.EventHandler(this.btnBuscarproveedor_Click);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 30;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 180;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 175;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 45;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 579);
            this.Controls.Add(this.txtregistrar);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdocproveedor;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private FontAwesome.Sharp.IconButton btnBuscarproveedor;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton txtregistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}