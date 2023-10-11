﻿
namespace CapaPresentacion
{
    partial class FormArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoMaterial = new System.Windows.Forms.TextBox();
            this.comboRubro = new System.Windows.Forms.ComboBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.labelSuperior = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridArticulo = new System.Windows.Forms.DataGridView();
            this.idenArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDeMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baja = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_actualizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.buttonBuscar = new FontAwesome.Sharp.IconButton();
            this.buttonLimipiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 341);
            this.label1.TabIndex = 4;
            // 
            // textBoxCodigoMaterial
            // 
            this.textBoxCodigoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxCodigoMaterial.Location = new System.Drawing.Point(15, 58);
            this.textBoxCodigoMaterial.Name = "textBoxCodigoMaterial";
            this.textBoxCodigoMaterial.Size = new System.Drawing.Size(199, 24);
            this.textBoxCodigoMaterial.TabIndex = 6;
            // 
            // comboRubro
            // 
            this.comboRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboRubro.FormattingEnabled = true;
            this.comboRubro.Location = new System.Drawing.Point(15, 116);
            this.comboRubro.Name = "comboRubro";
            this.comboRubro.Size = new System.Drawing.Size(199, 26);
            this.comboRubro.TabIndex = 8;
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxCosto.Location = new System.Drawing.Point(15, 171);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(199, 24);
            this.textBoxCosto.TabIndex = 10;
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(15, 225);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(199, 26);
            this.comboMarca.TabIndex = 12;
            // 
            // labelSuperior
            // 
            this.labelSuperior.BackColor = System.Drawing.Color.DarkRed;
            this.labelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuperior.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSuperior.Location = new System.Drawing.Point(220, 0);
            this.labelSuperior.Name = "labelSuperior";
            this.labelSuperior.Size = new System.Drawing.Size(697, 32);
            this.labelSuperior.TabIndex = 13;
            this.labelSuperior.Text = "Listado de Artículos";
            this.labelSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(220, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(697, 309);
            this.label7.TabIndex = 14;
            // 
            // dataGridArticulo
            // 
            this.dataGridArticulo.AllowUserToAddRows = false;
            this.dataGridArticulo.AllowUserToDeleteRows = false;
            this.dataGridArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArticulo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idenArticulo,
            this.CodigoDeMaterial,
            this.rubro,
            this.CostoArticulo,
            this.MarcaArticulo,
            this.Baja,
            this.btn_actualizar});
            this.dataGridArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridArticulo.Location = new System.Drawing.Point(220, 32);
            this.dataGridArticulo.MultiSelect = false;
            this.dataGridArticulo.Name = "dataGridArticulo";
            this.dataGridArticulo.Size = new System.Drawing.Size(697, 309);
            this.dataGridArticulo.TabIndex = 15;
            // 
            // idenArticulo
            // 
            this.idenArticulo.HeaderText = "";
            this.idenArticulo.Name = "idenArticulo";
            this.idenArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idenArticulo.Visible = false;
            // 
            // CodigoDeMaterial
            // 
            this.CodigoDeMaterial.HeaderText = "Codigo Material";
            this.CodigoDeMaterial.Name = "CodigoDeMaterial";
            // 
            // rubro
            // 
            this.rubro.HeaderText = "Rubro";
            this.rubro.Name = "rubro";
            // 
            // CostoArticulo
            // 
            this.CostoArticulo.HeaderText = "Costo";
            this.CostoArticulo.Name = "CostoArticulo";
            // 
            // MarcaArticulo
            // 
            this.MarcaArticulo.HeaderText = "Marca";
            this.MarcaArticulo.Name = "MarcaArticulo";
            // 
            // Baja
            // 
            this.Baja.HeaderText = "Baja";
            this.Baja.Name = "Baja";
            this.Baja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.HeaderText = "";
            this.btn_actualizar.Name = "btn_actualizar";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Image = global::CapaPresentacion.Properties.Resources.pen;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditar.Location = new System.Drawing.Point(138, 281);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(76, 32);
            this.buttonEditar.TabIndex = 17;
            this.buttonEditar.Text = " Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Image = global::CapaPresentacion.Properties.Resources.plus;
            this.buttonRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistrar.Location = new System.Drawing.Point(56, 281);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(76, 32);
            this.buttonRegistrar.TabIndex = 16;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Image = global::CapaPresentacion.Properties.Resources.price_tag;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Marca:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Image = global::CapaPresentacion.Properties.Resources.money;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Costo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Image = global::CapaPresentacion.Properties.Resources.box;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rubro:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Image = global::CapaPresentacion.Properties.Resources.bar_code;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo de material:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(674, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 24);
            this.textBox1.TabIndex = 18;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.Color.DarkRed;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBuscar.Location = new System.Drawing.Point(618, 8);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(59, 18);
            this.labelBuscar.TabIndex = 19;
            this.labelBuscar.Text = "Buscar:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.CausesValidation = false;
            this.buttonBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.buttonBuscar.IconColor = System.Drawing.Color.Black;
            this.buttonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBuscar.IconSize = 15;
            this.buttonBuscar.Location = new System.Drawing.Point(816, 6);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(15, 15);
            this.buttonBuscar.TabIndex = 20;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonLimipiar
            // 
            this.buttonLimipiar.CausesValidation = false;
            this.buttonLimipiar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.buttonLimipiar.IconColor = System.Drawing.Color.Black;
            this.buttonLimipiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonLimipiar.IconSize = 15;
            this.buttonLimipiar.Location = new System.Drawing.Point(837, 6);
            this.buttonLimipiar.Name = "buttonLimipiar";
            this.buttonLimipiar.Size = new System.Drawing.Size(15, 15);
            this.buttonLimipiar.TabIndex = 21;
            this.buttonLimipiar.UseVisualStyleBackColor = true;
            // 
            // FormArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 341);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLimipiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.dataGridArticulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSuperior);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboRubro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCodigoMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArticulo";
            this.ShowIcon = false;
            this.Text = "FormArticulo";
            this.Load += new System.EventHandler(this.FormArticulo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Label labelSuperior;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridArticulo;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idenArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaArticulo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_actualizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelBuscar;
        private FontAwesome.Sharp.IconButton buttonBuscar;
        private FontAwesome.Sharp.IconButton buttonLimipiar;
    }
}