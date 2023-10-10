
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ETTitulo2 = new System.Windows.Forms.Label();
            this.TablaRemitos = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetraRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecharRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETTitulo = new System.Windows.Forms.Label();
            this.ETNumOp = new System.Windows.Forms.Label();
            this.ETIDOp = new System.Windows.Forms.Label();
            this.PanelID = new System.Windows.Forms.Panel();
            this.CBSucursal = new System.Windows.Forms.ComboBox();
            this.CB = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ETSucursal = new System.Windows.Forms.Label();
            this.ETEstado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IngresoFecha = new System.Windows.Forms.DateTimePicker();
            this.ETFecha = new System.Windows.Forms.Label();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.BTEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRemitos)).BeginInit();
            this.PanelID.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ETTitulo2
            // 
            this.ETTitulo2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ETTitulo2.Font = new System.Drawing.Font("Javanese Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETTitulo2.Location = new System.Drawing.Point(283, 3);
            this.ETTitulo2.Margin = new System.Windows.Forms.Padding(3);
            this.ETTitulo2.Name = "ETTitulo2";
            this.ETTitulo2.Size = new System.Drawing.Size(585, 28);
            this.ETTitulo2.TabIndex = 2;
            this.ETTitulo2.Text = "LISTADO DE REMITOS";
            this.ETTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ETTitulo2.Click += new System.EventHandler(this.label1_Click);
            // 
            // TablaRemitos
            // 
            this.TablaRemitos.AllowUserToAddRows = false;
            this.TablaRemitos.AllowUserToDeleteRows = false;
            this.TablaRemitos.AllowUserToOrderColumns = true;
            this.TablaRemitos.AllowUserToResizeRows = false;
            this.TablaRemitos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.TablaRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRemitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Sucursal,
            this.Estado,
            this.Numero,
            this.IDOperacion,
            this.TipoRemito,
            this.LetraRemito,
            this.FecharRemito});
            this.TablaRemitos.Location = new System.Drawing.Point(283, 37);
            this.TablaRemitos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.TablaRemitos.Name = "TablaRemitos";
            this.TablaRemitos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaRemitos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.TablaRemitos.Size = new System.Drawing.Size(585, 299);
            this.TablaRemitos.TabIndex = 3;
            this.TablaRemitos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Identificador
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Identificador.DefaultCellStyle = dataGridViewCellStyle1;
            this.Identificador.HeaderText = "ID";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // Sucursal
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sucursal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 150;
            // 
            // Estado
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Numero
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Numero.DefaultCellStyle = dataGridViewCellStyle4;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // IDOperacion
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IDOperacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.IDOperacion.HeaderText = "ID Operación";
            this.IDOperacion.Name = "IDOperacion";
            this.IDOperacion.ReadOnly = true;
            // 
            // TipoRemito
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TipoRemito.DefaultCellStyle = dataGridViewCellStyle6;
            this.TipoRemito.HeaderText = "Tipo";
            this.TipoRemito.Name = "TipoRemito";
            this.TipoRemito.ReadOnly = true;
            // 
            // LetraRemito
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LetraRemito.DefaultCellStyle = dataGridViewCellStyle7;
            this.LetraRemito.HeaderText = "Letra";
            this.LetraRemito.Name = "LetraRemito";
            this.LetraRemito.ReadOnly = true;
            this.LetraRemito.Width = 50;
            // 
            // FecharRemito
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FecharRemito.DefaultCellStyle = dataGridViewCellStyle8;
            this.FecharRemito.HeaderText = "Fecha";
            this.FecharRemito.Name = "FecharRemito";
            this.FecharRemito.ReadOnly = true;
            this.FecharRemito.Width = 150;
            // 
            // ETTitulo
            // 
            this.ETTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ETTitulo.AutoSize = true;
            this.ETTitulo.Font = new System.Drawing.Font("Javanese Text", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETTitulo.Location = new System.Drawing.Point(36, 4);
            this.ETTitulo.Name = "ETTitulo";
            this.ETTitulo.Size = new System.Drawing.Size(282, 73);
            this.ETTitulo.TabIndex = 4;
            this.ETTitulo.Text = "NUEVO REMITO";
            this.ETTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ETTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // ETNumOp
            // 
            this.ETNumOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETNumOp.Location = new System.Drawing.Point(9, 94);
            this.ETNumOp.Name = "ETNumOp";
            this.ETNumOp.Size = new System.Drawing.Size(141, 24);
            this.ETNumOp.TabIndex = 2;
            this.ETNumOp.Text = "N de operacion";
            this.ETNumOp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ETNumOp.Click += new System.EventHandler(this.label5_Click);
            // 
            // ETIDOp
            // 
            this.ETIDOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETIDOp.Location = new System.Drawing.Point(9, 143);
            this.ETIDOp.Name = "ETIDOp";
            this.ETIDOp.Size = new System.Drawing.Size(141, 24);
            this.ETIDOp.TabIndex = 3;
            this.ETIDOp.Text = "ID Operacion";
            this.ETIDOp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ETIDOp.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // PanelID
            // 
            this.PanelID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PanelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelID.Controls.Add(this.CBSucursal);
            this.PanelID.Controls.Add(this.CB);
            this.PanelID.Controls.Add(this.comboBox3);
            this.PanelID.Controls.Add(this.comboBox2);
            this.PanelID.Controls.Add(this.ETSucursal);
            this.PanelID.Controls.Add(this.ETNumOp);
            this.PanelID.Controls.Add(this.ETEstado);
            this.PanelID.Controls.Add(this.ETIDOp);
            this.PanelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelID.Location = new System.Drawing.Point(12, 121);
            this.PanelID.Name = "PanelID";
            this.PanelID.Size = new System.Drawing.Size(258, 188);
            this.PanelID.TabIndex = 4;
            // 
            // CBSucursal
            // 
            this.CBSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBSucursal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CBSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSucursal.FormattingEnabled = true;
            this.CBSucursal.Location = new System.Drawing.Point(12, 19);
            this.CBSucursal.Name = "CBSucursal";
            this.CBSucursal.Size = new System.Drawing.Size(158, 24);
            this.CBSucursal.TabIndex = 7;
            this.CBSucursal.SelectedIndexChanged += new System.EventHandler(this.CBSucursal_SelectedIndexChanged);
            // 
            // CB
            // 
            this.CB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB.FormattingEnabled = true;
            this.CB.Location = new System.Drawing.Point(12, 67);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(158, 24);
            this.CB.TabIndex = 6;
            this.CB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 163);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(158, 24);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ETSucursal
            // 
            this.ETSucursal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ETSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETSucursal.Location = new System.Drawing.Point(9, -1);
            this.ETSucursal.Name = "ETSucursal";
            this.ETSucursal.Size = new System.Drawing.Size(141, 24);
            this.ETSucursal.TabIndex = 1;
            this.ETSucursal.Text = "Sucursal:";
            this.ETSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ETSucursal.Click += new System.EventHandler(this.label4_Click);
            // 
            // ETEstado
            // 
            this.ETEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ETEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETEstado.Location = new System.Drawing.Point(9, 46);
            this.ETEstado.Name = "ETEstado";
            this.ETEstado.Size = new System.Drawing.Size(141, 24);
            this.ETEstado.TabIndex = 0;
            this.ETEstado.Text = "Estado:";
            this.ETEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ETEstado.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.IngresoFecha);
            this.panel1.Controls.Add(this.ETFecha);
            this.panel1.Controls.Add(this.ETTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 82);
            this.panel1.TabIndex = 7;
            // 
            // IngresoFecha
            // 
            this.IngresoFecha.Location = new System.Drawing.Point(12, 57);
            this.IngresoFecha.Name = "IngresoFecha";
            this.IngresoFecha.Size = new System.Drawing.Size(213, 20);
            this.IngresoFecha.TabIndex = 7;
            // 
            // ETFecha
            // 
            this.ETFecha.AutoSize = true;
            this.ETFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETFecha.Location = new System.Drawing.Point(8, 40);
            this.ETFecha.Name = "ETFecha";
            this.ETFecha.Size = new System.Drawing.Size(64, 24);
            this.ETFecha.TabIndex = 5;
            this.ETFecha.Text = "Fecha";
            // 
            // BTGuardar
            // 
            this.BTGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.BTGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGuardar.Location = new System.Drawing.Point(29, 3);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(87, 19);
            this.BTGuardar.TabIndex = 8;
            this.BTGuardar.Text = "Guardar";
            this.BTGuardar.UseVisualStyleBackColor = false;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // BTEditar
            // 
            this.BTEditar.BackColor = System.Drawing.Color.DarkGray;
            this.BTEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEditar.Location = new System.Drawing.Point(139, 3);
            this.BTEditar.Name = "BTEditar";
            this.BTEditar.Size = new System.Drawing.Size(84, 19);
            this.BTEditar.TabIndex = 9;
            this.BTEditar.Text = "Editar";
            this.BTEditar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BTGuardar);
            this.panel2.Controls.Add(this.BTEditar);
            this.panel2.Location = new System.Drawing.Point(12, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 26);
            this.panel2.TabIndex = 10;
            // 
            // CP_Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(917, 341);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TablaRemitos);
            this.Controls.Add(this.ETTitulo2);
            this.Controls.Add(this.PanelID);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "CP_Remito";
            this.Text = "158; 24";
            this.Load += new System.EventHandler(this.CP_Remito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaRemitos)).EndInit();
            this.PanelID.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ETTitulo2;
        private System.Windows.Forms.DataGridView TablaRemitos;
        private System.Windows.Forms.Label ETTitulo;
        private System.Windows.Forms.Label ETIDOp;
        private System.Windows.Forms.Label ETNumOp;
        private System.Windows.Forms.Panel PanelID;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker IngresoFecha;
        private System.Windows.Forms.Label ETFecha;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.Button BTEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.Label ETSucursal;
        private System.Windows.Forms.Label ETEstado;
        private System.Windows.Forms.ComboBox CBSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetraRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecharRemito;
    }
}