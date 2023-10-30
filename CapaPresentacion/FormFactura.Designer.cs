
namespace CapaPresentacion
{
    partial class FormFactura
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
            this.GbRegistrar = new System.Windows.Forms.GroupBox();
            this.BoxEstado = new System.Windows.Forms.TextBox();
            this.BoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.SearchBtn = new FontAwesome.Sharp.IconButton();
            this.BoxIdUsuario = new System.Windows.Forms.TextBox();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.BoxNumeroFactura = new System.Windows.Forms.TextBox();
            this.LabelNumeroFactura = new System.Windows.Forms.Label();
            this.BoxSucursal = new System.Windows.Forms.TextBox();
            this.LabelSucursal = new System.Windows.Forms.Label();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.BoxMonto = new System.Windows.Forms.TextBox();
            this.LabelMonto = new System.Windows.Forms.Label();
            this.BoxIdOperacion = new System.Windows.Forms.ComboBox();
            this.LabelIdOperacion = new System.Windows.Forms.Label();
            this.BoxTipoFactura = new System.Windows.Forms.ComboBox();
            this.LabelTipoFactura = new System.Windows.Forms.Label();
            this.BaseListado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridFacturas = new System.Windows.Forms.DataGridView();
            this.LabelListadoFacturas = new System.Windows.Forms.Label();
            this.BtnPDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // GbRegistrar
            // 
            this.GbRegistrar.AccessibleDescription = "";
            this.GbRegistrar.AutoSize = true;
            this.GbRegistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GbRegistrar.Controls.Add(this.BoxEstado);
            this.GbRegistrar.Controls.Add(this.BoxNombreUsuario);
            this.GbRegistrar.Controls.Add(this.SearchBtn);
            this.GbRegistrar.Controls.Add(this.BoxIdUsuario);
            this.GbRegistrar.Controls.Add(this.LabelUsuario);
            this.GbRegistrar.Controls.Add(this.BoxNumeroFactura);
            this.GbRegistrar.Controls.Add(this.LabelNumeroFactura);
            this.GbRegistrar.Controls.Add(this.BoxSucursal);
            this.GbRegistrar.Controls.Add(this.LabelSucursal);
            this.GbRegistrar.Controls.Add(this.LabelEstado);
            this.GbRegistrar.Controls.Add(this.AddBtn);
            this.GbRegistrar.Controls.Add(this.BoxMonto);
            this.GbRegistrar.Controls.Add(this.LabelMonto);
            this.GbRegistrar.Controls.Add(this.BoxIdOperacion);
            this.GbRegistrar.Controls.Add(this.LabelIdOperacion);
            this.GbRegistrar.Controls.Add(this.BoxTipoFactura);
            this.GbRegistrar.Controls.Add(this.LabelTipoFactura);
            this.GbRegistrar.Location = new System.Drawing.Point(3, 42);
            this.GbRegistrar.Name = "GbRegistrar";
            this.GbRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GbRegistrar.Size = new System.Drawing.Size(225, 297);
            this.GbRegistrar.TabIndex = 2;
            this.GbRegistrar.TabStop = false;
            this.GbRegistrar.Tag = "";
            // 
            // BoxEstado
            // 
            this.BoxEstado.Location = new System.Drawing.Point(14, 193);
            this.BoxEstado.Name = "BoxEstado";
            this.BoxEstado.ReadOnly = true;
            this.BoxEstado.Size = new System.Drawing.Size(68, 20);
            this.BoxEstado.TabIndex = 20;
            // 
            // BoxNombreUsuario
            // 
            this.BoxNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxNombreUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.BoxNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BoxNombreUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.BoxNombreUsuario.ImeMode = System.Windows.Forms.ImeMode.On;
            this.BoxNombreUsuario.Location = new System.Drawing.Point(15, 18);
            this.BoxNombreUsuario.Multiline = true;
            this.BoxNombreUsuario.Name = "BoxNombreUsuario";
            this.BoxNombreUsuario.ReadOnly = true;
            this.BoxNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BoxNombreUsuario.Size = new System.Drawing.Size(188, 28);
            this.BoxNombreUsuario.TabIndex = 19;
            this.BoxNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchBtn
            // 
            this.SearchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.SearchBtn.IconColor = System.Drawing.Color.Maroon;
            this.SearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SearchBtn.IconSize = 20;
            this.SearchBtn.Location = new System.Drawing.Point(156, 62);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(47, 29);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // BoxIdUsuario
            // 
            this.BoxIdUsuario.Location = new System.Drawing.Point(15, 67);
            this.BoxIdUsuario.Name = "BoxIdUsuario";
            this.BoxIdUsuario.ReadOnly = true;
            this.BoxIdUsuario.Size = new System.Drawing.Size(132, 20);
            this.BoxIdUsuario.TabIndex = 17;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Location = new System.Drawing.Point(16, 51);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(67, 13);
            this.LabelUsuario.TabIndex = 16;
            this.LabelUsuario.Text = "D.N.I Cliente";
            // 
            // BoxNumeroFactura
            // 
            this.BoxNumeroFactura.Location = new System.Drawing.Point(92, 193);
            this.BoxNumeroFactura.Name = "BoxNumeroFactura";
            this.BoxNumeroFactura.ReadOnly = true;
            this.BoxNumeroFactura.Size = new System.Drawing.Size(111, 20);
            this.BoxNumeroFactura.TabIndex = 15;
            // 
            // LabelNumeroFactura
            // 
            this.LabelNumeroFactura.AutoSize = true;
            this.LabelNumeroFactura.Location = new System.Drawing.Point(89, 177);
            this.LabelNumeroFactura.Name = "LabelNumeroFactura";
            this.LabelNumeroFactura.Size = new System.Drawing.Size(83, 13);
            this.LabelNumeroFactura.TabIndex = 14;
            this.LabelNumeroFactura.Text = "Numero Factura";
            // 
            // BoxSucursal
            // 
            this.BoxSucursal.Location = new System.Drawing.Point(92, 154);
            this.BoxSucursal.Name = "BoxSucursal";
            this.BoxSucursal.ReadOnly = true;
            this.BoxSucursal.Size = new System.Drawing.Size(111, 20);
            this.BoxSucursal.TabIndex = 13;
            // 
            // LabelSucursal
            // 
            this.LabelSucursal.AutoSize = true;
            this.LabelSucursal.Location = new System.Drawing.Point(91, 134);
            this.LabelSucursal.Name = "LabelSucursal";
            this.LabelSucursal.Size = new System.Drawing.Size(48, 13);
            this.LabelSucursal.TabIndex = 12;
            this.LabelSucursal.Text = "Sucursal";
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.Location = new System.Drawing.Point(10, 177);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(40, 13);
            this.LabelEstado.TabIndex = 10;
            this.LabelEstado.Text = "Estado";
            // 
            // AddBtn
            // 
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.AddBtn.IconColor = System.Drawing.Color.Green;
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.AddBtn.IconSize = 20;
            this.AddBtn.Location = new System.Drawing.Point(123, 235);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(80, 37);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Agregar";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BoxMonto
            // 
            this.BoxMonto.Location = new System.Drawing.Point(15, 244);
            this.BoxMonto.Name = "BoxMonto";
            this.BoxMonto.ReadOnly = true;
            this.BoxMonto.Size = new System.Drawing.Size(97, 20);
            this.BoxMonto.TabIndex = 8;
            // 
            // LabelMonto
            // 
            this.LabelMonto.AutoSize = true;
            this.LabelMonto.Location = new System.Drawing.Point(14, 228);
            this.LabelMonto.Name = "LabelMonto";
            this.LabelMonto.Size = new System.Drawing.Size(64, 13);
            this.LabelMonto.TabIndex = 7;
            this.LabelMonto.Text = "Monto Total";
            // 
            // BoxIdOperacion
            // 
            this.BoxIdOperacion.FormattingEnabled = true;
            this.BoxIdOperacion.Location = new System.Drawing.Point(15, 109);
            this.BoxIdOperacion.Name = "BoxIdOperacion";
            this.BoxIdOperacion.Size = new System.Drawing.Size(186, 21);
            this.BoxIdOperacion.TabIndex = 6;
            this.BoxIdOperacion.SelectedIndexChanged += new System.EventHandler(this.BoxIdOperacion_SelectedIndexChanged);
            this.BoxIdOperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxIdOperacion_KeyPress);
            // 
            // LabelIdOperacion
            // 
            this.LabelIdOperacion.AutoSize = true;
            this.LabelIdOperacion.Location = new System.Drawing.Point(11, 93);
            this.LabelIdOperacion.Name = "LabelIdOperacion";
            this.LabelIdOperacion.Size = new System.Drawing.Size(70, 13);
            this.LabelIdOperacion.TabIndex = 5;
            this.LabelIdOperacion.Text = "ID Operacion";
            // 
            // BoxTipoFactura
            // 
            this.BoxTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxTipoFactura.FormattingEnabled = true;
            this.BoxTipoFactura.Location = new System.Drawing.Point(15, 153);
            this.BoxTipoFactura.Name = "BoxTipoFactura";
            this.BoxTipoFactura.Size = new System.Drawing.Size(67, 21);
            this.BoxTipoFactura.TabIndex = 4;
            // 
            // LabelTipoFactura
            // 
            this.LabelTipoFactura.AutoSize = true;
            this.LabelTipoFactura.Location = new System.Drawing.Point(12, 133);
            this.LabelTipoFactura.Name = "LabelTipoFactura";
            this.LabelTipoFactura.Size = new System.Drawing.Size(28, 13);
            this.LabelTipoFactura.TabIndex = 2;
            this.LabelTipoFactura.Text = "Tipo";
            // 
            // BaseListado
            // 
            this.BaseListado.BackColor = System.Drawing.Color.DarkRed;
            this.BaseListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseListado.ForeColor = System.Drawing.SystemColors.Control;
            this.BaseListado.Location = new System.Drawing.Point(234, -1);
            this.BaseListado.Name = "BaseListado";
            this.BaseListado.Size = new System.Drawing.Size(683, 45);
            this.BaseListado.TabIndex = 5;
            this.BaseListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(-1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Factura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(893, 298);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // GridFacturas
            // 
            this.GridFacturas.AccessibleDescription = "";
            this.GridFacturas.AccessibleName = "";
            this.GridFacturas.AllowUserToAddRows = false;
            this.GridFacturas.AllowUserToDeleteRows = false;
            this.GridFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnPDF,
            this.Estado,
            this.Fecha,
            this.Sucursal,
            this.IdOperacion,
            this.Factura,
            this.Numero,
            this.Total});
            this.GridFacturas.Location = new System.Drawing.Point(234, 47);
            this.GridFacturas.Name = "GridFacturas";
            this.GridFacturas.ReadOnly = true;
            this.GridFacturas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridFacturas.Size = new System.Drawing.Size(714, 292);
            this.GridFacturas.TabIndex = 4;
            this.GridFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFacturas_CellDoubleClick);
            this.GridFacturas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridFacturas_CellPainting);
            // 
            // LabelListadoFacturas
            // 
            this.LabelListadoFacturas.BackColor = System.Drawing.Color.DarkRed;
            this.LabelListadoFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelListadoFacturas.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelListadoFacturas.Location = new System.Drawing.Point(274, -1);
            this.LabelListadoFacturas.Name = "LabelListadoFacturas";
            this.LabelListadoFacturas.Size = new System.Drawing.Size(186, 45);
            this.LabelListadoFacturas.TabIndex = 6;
            this.LabelListadoFacturas.Text = "Listado De Facturas";
            this.LabelListadoFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnPDF
            // 
            this.BtnPDF.HeaderText = "";
            this.BtnPDF.Name = "BtnPDF";
            this.BtnPDF.ReadOnly = true;
            this.BtnPDF.Width = 32;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 20;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 170;
            // 
            // IdOperacion
            // 
            this.IdOperacion.HeaderText = "Operacion";
            this.IdOperacion.Name = "IdOperacion";
            this.IdOperacion.ReadOnly = true;
            this.IdOperacion.Width = 200;
            // 
            // Factura
            // 
            this.Factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 68;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 341);
            this.Controls.Add(this.LabelListadoFacturas);
            this.Controls.Add(this.GridFacturas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BaseListado);
            this.Controls.Add(this.GbRegistrar);
            this.Controls.Add(this.label1);
            this.Name = "FormFactura";
            this.Text = "sql";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            this.GbRegistrar.ResumeLayout(false);
            this.GbRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GbRegistrar;
        private System.Windows.Forms.Label LabelIdOperacion;
        private System.Windows.Forms.ComboBox BoxTipoFactura;
        private System.Windows.Forms.Label LabelTipoFactura;
        private System.Windows.Forms.TextBox BoxMonto;
        private System.Windows.Forms.Label LabelMonto;
        private System.Windows.Forms.ComboBox BoxIdOperacion;
        private FontAwesome.Sharp.IconButton AddBtn;
        private System.Windows.Forms.Label LabelEstado;
        private System.Windows.Forms.TextBox BoxSucursal;
        private System.Windows.Forms.Label LabelSucursal;
        private System.Windows.Forms.TextBox BoxNumeroFactura;
        private System.Windows.Forms.Label LabelNumeroFactura;
        private System.Windows.Forms.Label BaseListado;
        private System.Windows.Forms.TextBox BoxIdUsuario;
        private System.Windows.Forms.Label LabelUsuario;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private System.Windows.Forms.TextBox BoxNombreUsuario;
        private System.Windows.Forms.TextBox BoxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridFacturas;
        private System.Windows.Forms.Label LabelListadoFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn BtnPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}