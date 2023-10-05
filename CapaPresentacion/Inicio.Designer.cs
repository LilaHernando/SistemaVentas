
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
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1370, 103);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            this.menuTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema De Ventas";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem4,
            this.iconMenuItem3,
            this.iconMenuItem2,
            this.iconMenuItem6,
            this.iconMenuItem5});
            this.menu.Location = new System.Drawing.Point(0, 103);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menu.Size = new System.Drawing.Size(1370, 79);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip2";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem1.Text = "Usuarios";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem1.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.AutoSize = false;
            this.iconMenuItem4.ForeColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.IconSize = 50;
            this.iconMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem4.Text = "Clientes";
            this.iconMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.AutoSize = false;
            this.iconMenuItem3.ForeColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 50;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem3.Text = "Articulos";
            this.iconMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.AutoToolTip = true;
            this.iconMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 50;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem2.Text = "Preventas";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem6
            // 
            this.iconMenuItem6.AutoSize = false;
            this.iconMenuItem6.ForeColor = System.Drawing.Color.Black;
            this.iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.iconMenuItem6.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem6.IconSize = 50;
            this.iconMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem6.Name = "iconMenuItem6";
            this.iconMenuItem6.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem6.Text = "Facturas";
            this.iconMenuItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem6.Click += new System.EventHandler(this.iconMenuItem6_Click);
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.AutoSize = false;
            this.iconMenuItem5.ForeColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.IconSize = 50;
            this.iconMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem5.Text = "Remitos";
            this.iconMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
    }
}

