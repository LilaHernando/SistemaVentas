
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoMaterial = new System.Windows.Forms.TextBox();
            this.comboRubro = new System.Windows.Forms.ComboBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridArticulo = new System.Windows.Forms.DataGridView();
            this.idenArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RubroArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.checkBoxBaja = new System.Windows.Forms.CheckBox();
            this.textBoxIden = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.buttonLimipiar = new FontAwesome.Sharp.IconButton();
            this.buttonBuscar = new FontAwesome.Sharp.IconButton();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.labelSuperior = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.textBoxCodigoMaterial.Location = new System.Drawing.Point(12, 68);
            this.textBoxCodigoMaterial.Name = "textBoxCodigoMaterial";
            this.textBoxCodigoMaterial.Size = new System.Drawing.Size(199, 24);
            this.textBoxCodigoMaterial.TabIndex = 6;
            this.textBoxCodigoMaterial.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCodigoMaterial_Validating);
            // 
            // comboRubro
            // 
            this.comboRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboRubro.FormattingEnabled = true;
            this.comboRubro.Location = new System.Drawing.Point(12, 117);
            this.comboRubro.Name = "comboRubro";
            this.comboRubro.Size = new System.Drawing.Size(199, 26);
            this.comboRubro.TabIndex = 8;
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxCosto.Location = new System.Drawing.Point(12, 168);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(199, 24);
            this.textBoxCosto.TabIndex = 10;
            this.textBoxCosto.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCosto_Validating);
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(12, 217);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(199, 26);
            this.comboMarca.TabIndex = 12;
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
            this.dataGridArticulo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idenArticulo,
            this.CodigoMaterial,
            this.RubroArticulo,
            this.CostoArticulo,
            this.MarcaArticulo,
            this.Baja,
            this.botonSeleccionar});
            this.dataGridArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridArticulo.Location = new System.Drawing.Point(220, 32);
            this.dataGridArticulo.MultiSelect = false;
            this.dataGridArticulo.Name = "dataGridArticulo";
            this.dataGridArticulo.Size = new System.Drawing.Size(697, 309);
            this.dataGridArticulo.TabIndex = 15;
            this.dataGridArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridArticulo_CellContentClick);
            this.dataGridArticulo.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridArticulo_CellPainting);
            // 
            // idenArticulo
            // 
            this.idenArticulo.FillWeight = 375.7426F;
            this.idenArticulo.HeaderText = "Iden";
            this.idenArticulo.Name = "idenArticulo";
            this.idenArticulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CodigoMaterial
            // 
            this.CodigoMaterial.FillWeight = 174.2379F;
            this.CodigoMaterial.HeaderText = "Codigo Material";
            this.CodigoMaterial.Name = "CodigoMaterial";
            this.CodigoMaterial.Width = 150;
            // 
            // RubroArticulo
            // 
            this.RubroArticulo.FillWeight = 35.50134F;
            this.RubroArticulo.HeaderText = "Rubro";
            this.RubroArticulo.Name = "RubroArticulo";
            this.RubroArticulo.Width = 200;
            // 
            // CostoArticulo
            // 
            this.CostoArticulo.FillWeight = 35.50134F;
            this.CostoArticulo.HeaderText = "Costo";
            this.CostoArticulo.Name = "CostoArticulo";
            this.CostoArticulo.Width = 180;
            // 
            // MarcaArticulo
            // 
            this.MarcaArticulo.FillWeight = 35.50134F;
            this.MarcaArticulo.HeaderText = "Marca";
            this.MarcaArticulo.Name = "MarcaArticulo";
            this.MarcaArticulo.Width = 200;
            // 
            // Baja
            // 
            this.Baja.FillWeight = 35.50134F;
            this.Baja.HeaderText = "Baja";
            this.Baja.Name = "Baja";
            this.Baja.Width = 50;
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.FillWeight = 48.22705F;
            this.botonSeleccionar.HeaderText = "";
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Width = 28;
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxBuscador.Location = new System.Drawing.Point(674, 6);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(136, 24);
            this.textBoxBuscador.TabIndex = 18;
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
            // checkBoxBaja
            // 
            this.checkBoxBaja.BackColor = System.Drawing.Color.White;
            this.checkBoxBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.checkBoxBaja.Location = new System.Drawing.Point(12, 242);
            this.checkBoxBaja.Name = "checkBoxBaja";
            this.checkBoxBaja.Size = new System.Drawing.Size(62, 33);
            this.checkBoxBaja.TabIndex = 22;
            this.checkBoxBaja.Text = "Baja";
            this.checkBoxBaja.UseVisualStyleBackColor = false;
            // 
            // textBoxIden
            // 
            this.textBoxIden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxIden.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxIden.Location = new System.Drawing.Point(190, 42);
            this.textBoxIden.Name = "textBoxIden";
            this.textBoxIden.ReadOnly = true;
            this.textBoxIden.Size = new System.Drawing.Size(24, 24);
            this.textBoxIden.TabIndex = 23;
            this.textBoxIden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(165, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Iden:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Image = global::CapaPresentacion.Properties.Resources.carretilla;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(0, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 33);
            this.label8.TabIndex = 25;
            this.label8.Text = "     Carga de Artículos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.buttonLimipiar.Click += new System.EventHandler(this.buttonLimipiar_Click);
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
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
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
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
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
            // labelSuperior
            // 
            this.labelSuperior.BackColor = System.Drawing.Color.DarkRed;
            this.labelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuperior.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSuperior.Image = global::CapaPresentacion.Properties.Resources.lista_de_verificacion;
            this.labelSuperior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSuperior.Location = new System.Drawing.Point(220, 0);
            this.labelSuperior.Name = "labelSuperior";
            this.labelSuperior.Size = new System.Drawing.Size(697, 32);
            this.labelSuperior.TabIndex = 13;
            this.labelSuperior.Text = "     Listado de Artículos";
            this.labelSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Image = global::CapaPresentacion.Properties.Resources.price_tag;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(9, 195);
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
            this.label4.Location = new System.Drawing.Point(9, 146);
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
            this.label3.Location = new System.Drawing.Point(12, 95);
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
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo de material:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 341);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxIden);
            this.Controls.Add(this.checkBoxBaja);
            this.Controls.Add(this.buttonLimipiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxBuscador);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Label labelBuscar;
        private FontAwesome.Sharp.IconButton buttonBuscar;
        private FontAwesome.Sharp.IconButton buttonLimipiar;
        private System.Windows.Forms.CheckBox checkBoxBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idenArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubroArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baja;
        private System.Windows.Forms.DataGridViewButtonColumn botonSeleccionar;
        private System.Windows.Forms.TextBox textBoxIden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
    }
}