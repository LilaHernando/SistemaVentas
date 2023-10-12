
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new FontAwesome.Sharp.IconButton();
            this.BoxIdUsuario = new System.Windows.Forms.TextBox();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.BoxNumeroFactura = new System.Windows.Forms.TextBox();
            this.LabelNumeroFactura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelSucursal = new System.Windows.Forms.Label();
            this.BoxEstado = new System.Windows.Forms.ComboBox();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.AddBtn = new FontAwesome.Sharp.IconButton();
            this.InputMonto = new System.Windows.Forms.TextBox();
            this.LabelMonto = new System.Windows.Forms.Label();
            this.BoxIdOperacion = new System.Windows.Forms.ComboBox();
            this.LabelIdOperacion = new System.Windows.Forms.Label();
            this.BoxTipoFactura = new System.Windows.Forms.ComboBox();
            this.LabelTipoFactura = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridIdOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTipoDeFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelListadoFacturas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Factura";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.BoxIdUsuario);
            this.groupBox1.Controls.Add(this.LabelUsuario);
            this.groupBox1.Controls.Add(this.BoxNumeroFactura);
            this.groupBox1.Controls.Add(this.LabelNumeroFactura);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.LabelSucursal);
            this.groupBox1.Controls.Add(this.BoxEstado);
            this.groupBox1.Controls.Add(this.LabelEstado);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.InputMonto);
            this.groupBox1.Controls.Add(this.LabelMonto);
            this.groupBox1.Controls.Add(this.BoxIdOperacion);
            this.groupBox1.Controls.Add(this.LabelIdOperacion);
            this.groupBox1.Controls.Add(this.BoxTipoFactura);
            this.groupBox1.Controls.Add(this.LabelTipoFactura);
            this.groupBox1.Location = new System.Drawing.Point(18, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(202, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.SearchBtn.IconColor = System.Drawing.Color.Maroon;
            this.SearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SearchBtn.IconSize = 20;
            this.SearchBtn.Location = new System.Drawing.Point(147, 26);
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
            this.BoxIdUsuario.Location = new System.Drawing.Point(10, 31);
            this.BoxIdUsuario.Name = "BoxIdUsuario";
            this.BoxIdUsuario.Size = new System.Drawing.Size(129, 20);
            this.BoxIdUsuario.TabIndex = 17;
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Location = new System.Drawing.Point(7, 14);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(67, 13);
            this.LabelUsuario.TabIndex = 16;
            this.LabelUsuario.Text = "D.N.I Cliente";
            // 
            // BoxNumeroFactura
            // 
            this.BoxNumeroFactura.Location = new System.Drawing.Point(84, 162);
            this.BoxNumeroFactura.Name = "BoxNumeroFactura";
            this.BoxNumeroFactura.ReadOnly = true;
            this.BoxNumeroFactura.Size = new System.Drawing.Size(111, 20);
            this.BoxNumeroFactura.TabIndex = 15;
            // 
            // LabelNumeroFactura
            // 
            this.LabelNumeroFactura.AutoSize = true;
            this.LabelNumeroFactura.Location = new System.Drawing.Point(81, 146);
            this.LabelNumeroFactura.Name = "LabelNumeroFactura";
            this.LabelNumeroFactura.Size = new System.Drawing.Size(83, 13);
            this.LabelNumeroFactura.TabIndex = 14;
            this.LabelNumeroFactura.Text = "Numero Factura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 13;
            // 
            // LabelSucursal
            // 
            this.LabelSucursal.AutoSize = true;
            this.LabelSucursal.Location = new System.Drawing.Point(82, 101);
            this.LabelSucursal.Name = "LabelSucursal";
            this.LabelSucursal.Size = new System.Drawing.Size(48, 13);
            this.LabelSucursal.TabIndex = 12;
            this.LabelSucursal.Text = "Sucursal";
            // 
            // BoxEstado
            // 
            this.BoxEstado.FormattingEnabled = true;
            this.BoxEstado.Location = new System.Drawing.Point(8, 161);
            this.BoxEstado.Name = "BoxEstado";
            this.BoxEstado.Size = new System.Drawing.Size(67, 21);
            this.BoxEstado.TabIndex = 11;
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.Location = new System.Drawing.Point(5, 145);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(40, 13);
            this.LabelEstado.TabIndex = 10;
            this.LabelEstado.Text = "Estado";
            // 
            // AddBtn
            // 
            this.AddBtn.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.AddBtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.AddBtn.IconColor = System.Drawing.Color.Green;
            this.AddBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.AddBtn.IconSize = 20;
            this.AddBtn.Location = new System.Drawing.Point(9, 239);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(187, 37);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Agregar";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // InputMonto
            // 
            this.InputMonto.Location = new System.Drawing.Point(7, 204);
            this.InputMonto.Name = "InputMonto";
            this.InputMonto.ReadOnly = true;
            this.InputMonto.Size = new System.Drawing.Size(187, 20);
            this.InputMonto.TabIndex = 8;
            // 
            // LabelMonto
            // 
            this.LabelMonto.AutoSize = true;
            this.LabelMonto.Location = new System.Drawing.Point(4, 188);
            this.LabelMonto.Name = "LabelMonto";
            this.LabelMonto.Size = new System.Drawing.Size(64, 13);
            this.LabelMonto.TabIndex = 7;
            this.LabelMonto.Text = "Monto Total";
            // 
            // BoxIdOperacion
            // 
            this.BoxIdOperacion.FormattingEnabled = true;
            this.BoxIdOperacion.Location = new System.Drawing.Point(9, 74);
            this.BoxIdOperacion.Name = "BoxIdOperacion";
            this.BoxIdOperacion.Size = new System.Drawing.Size(187, 21);
            this.BoxIdOperacion.TabIndex = 6;
            // 
            // LabelIdOperacion
            // 
            this.LabelIdOperacion.AutoSize = true;
            this.LabelIdOperacion.Location = new System.Drawing.Point(6, 58);
            this.LabelIdOperacion.Name = "LabelIdOperacion";
            this.LabelIdOperacion.Size = new System.Drawing.Size(70, 13);
            this.LabelIdOperacion.TabIndex = 5;
            this.LabelIdOperacion.Text = "ID Operacion";
            // 
            // BoxTipoFactura
            // 
            this.BoxTipoFactura.FormattingEnabled = true;
            this.BoxTipoFactura.Location = new System.Drawing.Point(9, 117);
            this.BoxTipoFactura.Name = "BoxTipoFactura";
            this.BoxTipoFactura.Size = new System.Drawing.Size(67, 21);
            this.BoxTipoFactura.TabIndex = 4;
            // 
            // LabelTipoFactura
            // 
            this.LabelTipoFactura.AutoSize = true;
            this.LabelTipoFactura.Location = new System.Drawing.Point(6, 101);
            this.LabelTipoFactura.Name = "LabelTipoFactura";
            this.LabelTipoFactura.Size = new System.Drawing.Size(46, 13);
            this.LabelTipoFactura.TabIndex = 2;
            this.LabelTipoFactura.Text = " Factura";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(226, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 282);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridEstado,
            this.GridFecha,
            this.GridSucursal,
            this.GridIdOperacion,
            this.GridTipoDeFactura,
            this.GridNumeroFactura,
            this.GridMonto});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(725, 290);
            this.dataGridView1.TabIndex = 4;
            // 
            // GridEstado
            // 
            this.GridEstado.HeaderText = "Estado";
            this.GridEstado.Name = "GridEstado";
            this.GridEstado.ReadOnly = true;
            // 
            // GridFecha
            // 
            this.GridFecha.HeaderText = "Fecha";
            this.GridFecha.Name = "GridFecha";
            this.GridFecha.ReadOnly = true;
            // 
            // GridSucursal
            // 
            this.GridSucursal.HeaderText = "Sucursal";
            this.GridSucursal.Name = "GridSucursal";
            this.GridSucursal.ReadOnly = true;
            this.GridSucursal.Width = 170;
            // 
            // GridIdOperacion
            // 
            this.GridIdOperacion.HeaderText = "Operacion";
            this.GridIdOperacion.Name = "GridIdOperacion";
            this.GridIdOperacion.ReadOnly = true;
            this.GridIdOperacion.Width = 200;
            // 
            // GridTipoDeFactura
            // 
            this.GridTipoDeFactura.HeaderText = "Factura";
            this.GridTipoDeFactura.Name = "GridTipoDeFactura";
            this.GridTipoDeFactura.ReadOnly = true;
            this.GridTipoDeFactura.Width = 170;
            // 
            // GridNumeroFactura
            // 
            this.GridNumeroFactura.HeaderText = "Número";
            this.GridNumeroFactura.Name = "GridNumeroFactura";
            this.GridNumeroFactura.ReadOnly = true;
            // 
            // GridMonto
            // 
            this.GridMonto.HeaderText = "Total";
            this.GridMonto.Name = "GridMonto";
            this.GridMonto.ReadOnly = true;
            // 
            // LabelListadoFacturas
            // 
            this.LabelListadoFacturas.AutoSize = true;
            this.LabelListadoFacturas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelListadoFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelListadoFacturas.Location = new System.Drawing.Point(222, 14);
            this.LabelListadoFacturas.Name = "LabelListadoFacturas";
            this.LabelListadoFacturas.Size = new System.Drawing.Size(153, 20);
            this.LabelListadoFacturas.TabIndex = 5;
            this.LabelListadoFacturas.Text = "Listado De Facturas";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(893, 323);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseMnemonic = false;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 341);
            this.Controls.Add(this.LabelListadoFacturas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelIdOperacion;
        private System.Windows.Forms.ComboBox BoxTipoFactura;
        private System.Windows.Forms.Label LabelTipoFactura;
        private System.Windows.Forms.TextBox InputMonto;
        private System.Windows.Forms.Label LabelMonto;
        private System.Windows.Forms.ComboBox BoxIdOperacion;
        private FontAwesome.Sharp.IconButton AddBtn;
        private System.Windows.Forms.ComboBox BoxEstado;
        private System.Windows.Forms.Label LabelEstado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelSucursal;
        private System.Windows.Forms.TextBox BoxNumeroFactura;
        private System.Windows.Forms.Label LabelNumeroFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridIdOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridTipoDeFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridMonto;
        private System.Windows.Forms.Label LabelListadoFacturas;
        private System.Windows.Forms.TextBox BoxIdUsuario;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton SearchBtn;
    }
}