
namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsuarioActual = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuArticulos = new FontAwesome.Sharp.IconMenuItem();
            this.menuPreventas = new FontAwesome.Sharp.IconMenuItem();
            this.menuFacturas = new FontAwesome.Sharp.IconMenuItem();
            this.menuRemitos = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1370, 102);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema De Ventas";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuClientes,
            this.menuArticulos,
            this.menuPreventas,
            this.menuFacturas,
            this.menuRemitos});
            this.menu.Location = new System.Drawing.Point(0, 102);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menu.Size = new System.Drawing.Size(1370, 79);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(976, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // textUsuarioActual
            // 
            this.textUsuarioActual.AutoSize = true;
            this.textUsuarioActual.BackColor = System.Drawing.Color.DarkRed;
            this.textUsuarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuarioActual.ForeColor = System.Drawing.Color.White;
            this.textUsuarioActual.Location = new System.Drawing.Point(1061, 40);
            this.textUsuarioActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textUsuarioActual.Name = "textUsuarioActual";
            this.textUsuarioActual.Size = new System.Drawing.Size(16, 24);
            this.textUsuarioActual.TabIndex = 4;
            this.textUsuarioActual.Text = "-";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contenedor.Location = new System.Drawing.Point(0, 181);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1370, 568);
            this.contenedor.TabIndex = 5;
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.ForeColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(122, 69);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.ForeColor = System.Drawing.Color.Black;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(122, 69);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuArticulos
            // 
            this.menuArticulos.AutoSize = false;
            this.menuArticulos.ForeColor = System.Drawing.Color.Black;
            this.menuArticulos.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.menuArticulos.IconColor = System.Drawing.Color.Black;
            this.menuArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuArticulos.IconSize = 50;
            this.menuArticulos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuArticulos.Name = "menuArticulos";
            this.menuArticulos.Size = new System.Drawing.Size(122, 69);
            this.menuArticulos.Text = "Articulos";
            this.menuArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuArticulos.Click += new System.EventHandler(this.menuArticulos_Click);
            // 
            // menuPreventas
            // 
            this.menuPreventas.AutoSize = false;
            this.menuPreventas.AutoToolTip = true;
            this.menuPreventas.ForeColor = System.Drawing.Color.Black;
            this.menuPreventas.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.menuPreventas.IconColor = System.Drawing.Color.Black;
            this.menuPreventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuPreventas.IconSize = 50;
            this.menuPreventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPreventas.Name = "menuPreventas";
            this.menuPreventas.Size = new System.Drawing.Size(122, 69);
            this.menuPreventas.Text = "Preventas";
            this.menuPreventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuPreventas.Click += new System.EventHandler(this.menuPreventas_Click);
            // 
            // menuFacturas
            // 
            this.menuFacturas.AutoSize = false;
            this.menuFacturas.ForeColor = System.Drawing.Color.Black;
            this.menuFacturas.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.menuFacturas.IconColor = System.Drawing.Color.Black;
            this.menuFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuFacturas.IconSize = 50;
            this.menuFacturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFacturas.Name = "menuFacturas";
            this.menuFacturas.Size = new System.Drawing.Size(122, 69);
            this.menuFacturas.Text = "Facturas";
            this.menuFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuFacturas.Click += new System.EventHandler(this.menuFacturas_Click);
            // 
            // menuRemitos
            // 
            this.menuRemitos.AutoSize = false;
            this.menuRemitos.ForeColor = System.Drawing.Color.Black;
            this.menuRemitos.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.menuRemitos.IconColor = System.Drawing.Color.Black;
            this.menuRemitos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuRemitos.IconSize = 50;
            this.menuRemitos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuRemitos.Name = "menuRemitos";
            this.menuRemitos.Size = new System.Drawing.Size(122, 69);
            this.menuRemitos.Text = "Remitos";
            this.menuRemitos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuRemitos.Click += new System.EventHandler(this.menuRemitos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(976, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // textUsuarioActual
            // 
            this.textUsuarioActual.AutoSize = true;
            this.textUsuarioActual.BackColor = System.Drawing.Color.DarkRed;
            this.textUsuarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuarioActual.Location = new System.Drawing.Point(1061, 40);
            this.textUsuarioActual.Name = "textUsuarioActual";
            this.textUsuarioActual.Size = new System.Drawing.Size(16, 24);
            this.textUsuarioActual.TabIndex = 4;
            this.textUsuarioActual.Text = "-";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.contenedor.ForeColor = System.Drawing.Color.Black;
            this.contenedor.Location = new System.Drawing.Point(0, 182);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1370, 567);
            this.contenedor.TabIndex = 5;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.textUsuarioActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuArticulos;
        private FontAwesome.Sharp.IconMenuItem menuPreventas;
        private FontAwesome.Sharp.IconMenuItem menuFacturas;
        private FontAwesome.Sharp.IconMenuItem menuRemitos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textUsuarioActual;
        private System.Windows.Forms.Panel contenedor;
    }
}

