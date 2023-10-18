
namespace CapaPresentacion
{
    partial class FormUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.inputApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputClave = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputConfClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 341);
            this.label1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(18, 25);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(185, 20);
            this.inputNombre.TabIndex = 6;
            this.inputNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNombre_KeyPress);
            // 
            // inputApellido
            // 
            this.inputApellido.Location = new System.Drawing.Point(18, 71);
            this.inputApellido.Name = "inputApellido";
            this.inputApellido.Size = new System.Drawing.Size(185, 20);
            this.inputApellido.TabIndex = 8;
            this.inputApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputApellido_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellido:";
            // 
            // inputDNI
            // 
            this.inputDNI.Location = new System.Drawing.Point(18, 117);
            this.inputDNI.MaxLength = 8;
            this.inputDNI.Name = "inputDNI";
            this.inputDNI.Size = new System.Drawing.Size(185, 20);
            this.inputDNI.TabIndex = 10;
            this.inputDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputDNI_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "DNI:";
            // 
            // inputClave
            // 
            this.inputClave.Location = new System.Drawing.Point(18, 211);
            this.inputClave.Name = "inputClave";
            this.inputClave.PasswordChar = '*';
            this.inputClave.Size = new System.Drawing.Size(185, 20);
            this.inputClave.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Contraseña:";
            // 
            // inputConfClave
            // 
            this.inputConfClave.Location = new System.Drawing.Point(18, 258);
            this.inputConfClave.Name = "inputConfClave";
            this.inputConfClave.PasswordChar = '*';
            this.inputConfClave.Size = new System.Drawing.Size(185, 20);
            this.inputConfClave.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Confirmar Contraseña:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(82, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rol:";
            // 
            // comboRol
            // 
            this.comboRol.BackColor = System.Drawing.Color.White;
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(85, 163);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(118, 21);
            this.comboRol.TabIndex = 16;
            // 
            // comboEstado
            // 
            this.comboEstado.BackColor = System.Drawing.Color.White;
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(18, 163);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(61, 21);
            this.comboEstado.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkRed;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(232, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(669, 43);
            this.label11.TabIndex = 22;
            this.label11.Text = "   Usuarios";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.nombre,
            this.apellido,
            this.dni,
            this.valorEstado,
            this.estado,
            this.idRol,
            this.rol,
            this.clave,
            this.btnSeleccionar});
            this.dgvData.Location = new System.Drawing.Point(232, 60);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(669, 265);
            this.dgvData.TabIndex = 23;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "ID Usuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 200;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // valorEstado
            // 
            this.valorEstado.HeaderText = "Valor Estado";
            this.valorEstado.Name = "valorEstado";
            this.valorEstado.ReadOnly = true;
            this.valorEstado.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "ID Rol";
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 200;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            // 
            // btnSeleccionar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnSeleccionar.Width = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(670, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Buscar:";
            // 
            // inputBuscar
            // 
            this.inputBuscar.Location = new System.Drawing.Point(716, 21);
            this.inputBuscar.Multiline = true;
            this.inputBuscar.Name = "inputBuscar";
            this.inputBuscar.Size = new System.Drawing.Size(120, 21);
            this.inputBuscar.TabIndex = 28;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 24;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(842, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(21, 21);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiarBuscar
            // 
            this.btnLimpiarBuscar.BackColor = System.Drawing.Color.White;
            this.btnLimpiarBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnLimpiarBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnLimpiarBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLimpiarBuscar.IconSize = 24;
            this.btnLimpiarBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(869, 21);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(21, 21);
            this.btnLimpiarBuscar.TabIndex = 24;
            this.btnLimpiarBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarBuscar.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardar.IconSize = 22;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(18, 296);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 29);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLimpiar.IconSize = 22;
            this.btnLimpiar.Location = new System.Drawing.Point(114, 296);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 29);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 341);
            this.Controls.Add(this.inputBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inputConfClave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputClave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputDNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.TextBox inputApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputClave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputConfClave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
    }
}