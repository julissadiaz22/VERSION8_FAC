namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuDetallesVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuVerDetalleCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.submenunegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuarios,
            this.menumantenedor,
            this.menuventas,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menureportes,
            this.menuacercade});
            this.menu.Location = new System.Drawing.Point(0, 49);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1260, 71);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuusuarios
            // 
            this.menuusuarios.AutoSize = false;
            this.menuusuarios.IconChar = FontAwesome.Sharp.IconChar.PersonBreastfeeding;
            this.menuusuarios.IconColor = System.Drawing.Color.Black;
            this.menuusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuarios.Name = "menuusuarios";
            this.menuusuarios.Size = new System.Drawing.Size(80, 67);
            this.menuusuarios.Text = "Usuarios";
            this.menuusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuarios.Click += new System.EventHandler(this.menuusuarios_Click);
            // 
            // menumantenedor
            // 
            this.menumantenedor.AutoSize = false;
            this.menumantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCategoria,
            this.subMenuProducto,
            this.submenunegocio});
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.menumantenedor.IconColor = System.Drawing.Color.Black;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Size = new System.Drawing.Size(122, 67);
            this.menumantenedor.Text = "Mantenedor";
            this.menumantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuCategoria
            // 
            this.subMenuCategoria.Name = "subMenuCategoria";
            this.subMenuCategoria.Size = new System.Drawing.Size(180, 22);
            this.subMenuCategoria.Text = "Categoria";
            this.subMenuCategoria.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // subMenuProducto
            // 
            this.subMenuProducto.Name = "subMenuProducto";
            this.subMenuProducto.Size = new System.Drawing.Size(180, 22);
            this.subMenuProducto.Text = "Producto";
            this.subMenuProducto.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarVenta,
            this.subMenuDetallesVenta});
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(122, 67);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarVenta
            // 
            this.subMenuRegistrarVenta.Name = "subMenuRegistrarVenta";
            this.subMenuRegistrarVenta.Size = new System.Drawing.Size(163, 22);
            this.subMenuRegistrarVenta.Text = "Registrar";
            this.subMenuRegistrarVenta.Click += new System.EventHandler(this.subMenuRegistrarVenta_Click);
            // 
            // subMenuDetallesVenta
            // 
            this.subMenuDetallesVenta.Name = "subMenuDetallesVenta";
            this.subMenuDetallesVenta.Size = new System.Drawing.Size(163, 22);
            this.subMenuDetallesVenta.Text = "Detalle de Ventas";
            this.subMenuDetallesVenta.Click += new System.EventHandler(this.subMenuDetallesVenta_Click);
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarCompra,
            this.subMenuVerDetalleCompra});
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(122, 67);
            this.menucompras.Text = "Compras";
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuRegistrarCompra
            // 
            this.subMenuRegistrarCompra.Name = "subMenuRegistrarCompra";
            this.subMenuRegistrarCompra.Size = new System.Drawing.Size(173, 22);
            this.subMenuRegistrarCompra.Text = "Registrar";
            this.subMenuRegistrarCompra.Click += new System.EventHandler(this.subMenuRegistrarCompra_Click);
            // 
            // subMenuVerDetalleCompra
            // 
            this.subMenuVerDetalleCompra.Name = "subMenuVerDetalleCompra";
            this.subMenuVerDetalleCompra.Size = new System.Drawing.Size(173, 22);
            this.subMenuVerDetalleCompra.Text = "Ver Detalle compra";
            this.subMenuVerDetalleCompra.Click += new System.EventHandler(this.subMenuVerDetalleCompra_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(122, 67);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(122, 67);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(122, 67);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(122, 67);
            this.menuacercade.Text = "Acerca de";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1260, 49);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA DE FACTURACIÓN";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 120);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1260, 629);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1081, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblusuario.Location = new System.Drawing.Point(1145, 19);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(69, 16);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // submenunegocio
            // 
            this.submenunegocio.Name = "submenunegocio";
            this.submenunegocio.Size = new System.Drawing.Size(180, 22);
            this.submenunegocio.Text = "Negocio";
            this.submenunegocio.Click += new System.EventHandler(this.submenunegocio_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 749);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menuusuarios;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.ToolStripMenuItem subMenuCategoria;
        private System.Windows.Forms.ToolStripMenuItem subMenuProducto;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem subMenuDetallesVenta;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem subMenuVerDetalleCompra;
        private System.Windows.Forms.ToolStripMenuItem submenunegocio;
    }
}

