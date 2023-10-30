
namespace CapaPresentacion
{
    partial class CP_Remito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaRemito = new System.Windows.Forms.DataGridView();
            this.IDRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetraRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.Label();
            this.NumRemito = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.fechaRem = new System.Windows.Forms.DateTimePicker();
            this.tipoRem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.txtIDOP = new System.Windows.Forms.TextBox();
            this.letraRem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRemito)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaRemito
            // 
            this.tablaRemito.AllowUserToAddRows = false;
            this.tablaRemito.AllowUserToDeleteRows = false;
            this.tablaRemito.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRemito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRemito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRemito,
            this.Sucursal,
            this.Estado,
            this.IDOperacion,
            this.NumeroRemito,
            this.LetraRemito,
            this.TipoRemito,
            this.FechaRemito});
            this.tablaRemito.Dock = System.Windows.Forms.DockStyle.Right;
            this.tablaRemito.GridColor = System.Drawing.Color.Black;
            this.tablaRemito.Location = new System.Drawing.Point(233, 0);
            this.tablaRemito.MultiSelect = false;
            this.tablaRemito.Name = "tablaRemito";
            this.tablaRemito.ReadOnly = true;
            this.tablaRemito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRemito.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaRemito.RowHeadersWidth = 51;
            this.tablaRemito.Size = new System.Drawing.Size(684, 341);
            this.tablaRemito.TabIndex = 3;
            // 
            // IDRemito
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.IDRemito.DefaultCellStyle = dataGridViewCellStyle2;
            this.IDRemito.HeaderText = "ID";
            this.IDRemito.MinimumWidth = 6;
            this.IDRemito.Name = "IDRemito";
            this.IDRemito.ReadOnly = true;
            this.IDRemito.Width = 50;
            // 
            // Sucursal
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Sucursal.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.MinimumWidth = 6;
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 160;
            // 
            // Estado
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle4;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 110;
            // 
            // IDOperacion
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.IDOperacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.IDOperacion.HeaderText = "ID Operacion";
            this.IDOperacion.MinimumWidth = 6;
            this.IDOperacion.Name = "IDOperacion";
            this.IDOperacion.ReadOnly = true;
            this.IDOperacion.Width = 160;
            // 
            // NumeroRemito
            // 
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.NumeroRemito.DefaultCellStyle = dataGridViewCellStyle6;
            this.NumeroRemito.HeaderText = "Num";
            this.NumeroRemito.MinimumWidth = 6;
            this.NumeroRemito.Name = "NumeroRemito";
            this.NumeroRemito.ReadOnly = true;
            this.NumeroRemito.Width = 125;
            // 
            // LetraRemito
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.LetraRemito.DefaultCellStyle = dataGridViewCellStyle7;
            this.LetraRemito.HeaderText = "Letra";
            this.LetraRemito.MinimumWidth = 6;
            this.LetraRemito.Name = "LetraRemito";
            this.LetraRemito.ReadOnly = true;
            this.LetraRemito.Width = 90;
            // 
            // TipoRemito
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.TipoRemito.DefaultCellStyle = dataGridViewCellStyle8;
            this.TipoRemito.HeaderText = "Tipo";
            this.TipoRemito.MinimumWidth = 6;
            this.TipoRemito.Name = "TipoRemito";
            this.TipoRemito.ReadOnly = true;
            this.TipoRemito.Width = 125;
            // 
            // FechaRemito
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.FechaRemito.DefaultCellStyle = dataGridViewCellStyle9;
            this.FechaRemito.HeaderText = "Fecha";
            this.FechaRemito.MinimumWidth = 6;
            this.FechaRemito.Name = "FechaRemito";
            this.FechaRemito.ReadOnly = true;
            this.FechaRemito.Width = 155;
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.DarkRed;
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Black;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(233, 45);
            this.Titulo.TabIndex = 28;
            this.Titulo.Text = "Nuevo remito";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumRemito
            // 
            this.NumRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumRemito.Location = new System.Drawing.Point(12, 166);
            this.NumRemito.Name = "NumRemito";
            this.NumRemito.ReadOnly = true;
            this.NumRemito.Size = new System.Drawing.Size(123, 23);
            this.NumRemito.TabIndex = 34;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(12, 210);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(123, 24);
            this.cbEstado.TabIndex = 37;
            // 
            // fechaRem
            // 
            this.fechaRem.Enabled = false;
            this.fechaRem.Location = new System.Drawing.Point(12, 298);
            this.fechaRem.MaxDate = new System.DateTime(2023, 10, 26, 0, 0, 0, 0);
            this.fechaRem.MinDate = new System.DateTime(2023, 10, 26, 0, 0, 0, 0);
            this.fechaRem.Name = "fechaRem";
            this.fechaRem.Size = new System.Drawing.Size(200, 20);
            this.fechaRem.TabIndex = 38;
            this.fechaRem.Value = new System.DateTime(2023, 10, 26, 0, 0, 0, 0);
            // 
            // tipoRem
            // 
            this.tipoRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoRem.Location = new System.Drawing.Point(12, 251);
            this.tipoRem.Name = "tipoRem";
            this.tipoRem.ReadOnly = true;
            this.tipoRem.Size = new System.Drawing.Size(100, 23);
            this.tipoRem.TabIndex = 41;
            this.tipoRem.Text = "Entrega";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tipo de remito";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSucursal
            // 
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(12, 118);
            this.cbSucursal.MaxDropDownItems = 20;
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(123, 24);
            this.cbSucursal.TabIndex = 43;
            // 
            // txtIDOP
            // 
            this.txtIDOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOP.Location = new System.Drawing.Point(12, 71);
            this.txtIDOP.Name = "txtIDOP";
            this.txtIDOP.Size = new System.Drawing.Size(123, 23);
            this.txtIDOP.TabIndex = 45;
            this.txtIDOP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIDOP_KeyPress);
            // 
            // letraRem
            // 
            this.letraRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letraRem.Location = new System.Drawing.Point(119, 251);
            this.letraRem.Name = "letraRem";
            this.letraRem.ReadOnly = true;
            this.letraRem.Size = new System.Drawing.Size(100, 23);
            this.letraRem.TabIndex = 48;
            this.letraRem.Text = "R";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Letra";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(140, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 23);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::CapaPresentacion.Properties.Resources.tarjeta_sim;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "    ID Operacion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.borrar;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 301);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(233, 20);
            this.btnLimpiar.TabIndex = 39;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.disquete_2_;
            this.btnGuardar.Location = new System.Drawing.Point(0, 321);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(233, 20);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(9, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "FECHA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::CapaPresentacion.Properties.Resources.semaforo;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(9, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "    Estado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::CapaPresentacion.Properties.Resources.supermercado;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "    Sucursal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::CapaPresentacion.Properties.Resources.contrato;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(9, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "    Numero de remito";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CP_Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 341);
            this.Controls.Add(this.letraRem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDOP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.tipoRem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.fechaRem);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.NumRemito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.tablaRemito);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CP_Remito";
            this.Text = "CP_Remito1";
            this.Load += new System.EventHandler(this.CP_Remito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaRemito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaRemito;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetraRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRemito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumRemito;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DateTimePicker fechaRem;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tipoRem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.TextBox txtIDOP;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox letraRem;
        private System.Windows.Forms.Label label7;
    }
}