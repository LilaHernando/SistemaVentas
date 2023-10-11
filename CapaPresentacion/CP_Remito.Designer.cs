
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BTGuardar = new System.Windows.Forms.Button();
            this.BTEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GBNuevoRemito = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRemitos)).BeginInit();
            this.panel2.SuspendLayout();
            this.GBNuevoRemito.SuspendLayout();
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaRemitos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaRemitos.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.TablaRemitos.Size = new System.Drawing.Size(585, 300);
            this.TablaRemitos.TabIndex = 3;
            this.TablaRemitos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Identificador
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Identificador.DefaultCellStyle = dataGridViewCellStyle12;
            this.Identificador.HeaderText = "ID";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // Sucursal
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sucursal.DefaultCellStyle = dataGridViewCellStyle13;
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            this.Sucursal.Width = 150;
            // 
            // Estado
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle14;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Numero
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Numero.DefaultCellStyle = dataGridViewCellStyle15;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // IDOperacion
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IDOperacion.DefaultCellStyle = dataGridViewCellStyle16;
            this.IDOperacion.HeaderText = "ID Operación";
            this.IDOperacion.Name = "IDOperacion";
            this.IDOperacion.ReadOnly = true;
            // 
            // TipoRemito
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TipoRemito.DefaultCellStyle = dataGridViewCellStyle17;
            this.TipoRemito.HeaderText = "Tipo";
            this.TipoRemito.Name = "TipoRemito";
            this.TipoRemito.ReadOnly = true;
            // 
            // LetraRemito
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LetraRemito.DefaultCellStyle = dataGridViewCellStyle18;
            this.LetraRemito.HeaderText = "Letra";
            this.LetraRemito.Name = "LetraRemito";
            this.LetraRemito.ReadOnly = true;
            this.LetraRemito.Width = 50;
            // 
            // FecharRemito
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FecharRemito.DefaultCellStyle = dataGridViewCellStyle19;
            this.FecharRemito.HeaderText = "Fecha";
            this.FecharRemito.Name = "FecharRemito";
            this.FecharRemito.ReadOnly = true;
            this.FecharRemito.Width = 150;
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
            // GBNuevoRemito
            // 
            this.GBNuevoRemito.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GBNuevoRemito.Controls.Add(this.label1);
            this.GBNuevoRemito.Controls.Add(this.label4);
            this.GBNuevoRemito.Controls.Add(this.label3);
            this.GBNuevoRemito.Controls.Add(this.label2);
            this.GBNuevoRemito.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNuevoRemito.Location = new System.Drawing.Point(12, 37);
            this.GBNuevoRemito.Name = "GBNuevoRemito";
            this.GBNuevoRemito.Size = new System.Drawing.Size(258, 272);
            this.GBNuevoRemito.TabIndex = 11;
            this.GBNuevoRemito.TabStop = false;
            this.GBNuevoRemito.Text = "Nuevo Remito";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Operacion";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "N de Operacion";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sucursal";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // CP_Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 341);
            this.Controls.Add(this.GBNuevoRemito);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TablaRemitos);
            this.Controls.Add(this.ETTitulo2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "CP_Remito";
            this.Text = "158; 24";
            this.Load += new System.EventHandler(this.CP_Remito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaRemitos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.GBNuevoRemito.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ETTitulo2;
        private System.Windows.Forms.DataGridView TablaRemitos;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.Button BTEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetraRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecharRemito;
        private System.Windows.Forms.GroupBox GBNuevoRemito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}