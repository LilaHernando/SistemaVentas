
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.txtIDOP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
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
            this.tablaRemito.Location = new System.Drawing.Point(311, 0);
            this.tablaRemito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tablaRemito.Size = new System.Drawing.Size(912, 420);
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
            this.Titulo.BackColor = System.Drawing.Color.Gray;
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Black;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(311, 55);
            this.Titulo.TabIndex = 28;
            this.Titulo.Text = "Nuevo remito";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Numero de remito";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Sucursal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Estado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 346);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "FECHA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 204);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 34;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(16, 258);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(163, 24);
            this.cbEstado.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 367);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(0, 370);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(311, 25);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(0, 395);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(311, 25);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(16, 309);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 23);
            this.textBox4.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tipo de remito";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSucursal
            // 
            this.cbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(16, 146);
            this.cbSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(163, 24);
            this.cbSucursal.TabIndex = 43;
            // 
            // txtIDOP
            // 
            this.txtIDOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOP.Location = new System.Drawing.Point(16, 87);
            this.txtIDOP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDOP.Name = "txtIDOP";
            this.txtIDOP.Size = new System.Drawing.Size(163, 23);
            this.txtIDOP.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "ID Operacion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 16;
            this.btnBuscar.Location = new System.Drawing.Point(187, 84);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 28);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CP_Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 420);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDOP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.tablaRemito);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.TextBox txtIDOP;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}