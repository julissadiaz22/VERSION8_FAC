namespace CapaPresentacion
{
    partial class frmNegocio
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnsubir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(22, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "DETALLE NEGOCIO";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 508);
            this.label1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnsubir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.piclogo);
            this.groupBox1.Location = new System.Drawing.Point(25, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 280);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(252, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(314, 28);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(252, 147);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(316, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "R.U.C:";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(252, 96);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(316, 20);
            this.txtRUC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del Negocio:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(252, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(316, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnsubir
            // 
            this.btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnsubir.IconColor = System.Drawing.Color.Black;
            this.btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsubir.IconSize = 20;
            this.btnsubir.Location = new System.Drawing.Point(25, 202);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(158, 28);
            this.btnsubir.TabIndex = 2;
            this.btnsubir.Text = "Subir";
            this.btnsubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsubir.UseVisualStyleBackColor = true;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo:";
            // 
            // piclogo
            // 
            this.piclogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piclogo.Location = new System.Drawing.Point(25, 48);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(158, 138);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnsubir;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRUC;
    }
}