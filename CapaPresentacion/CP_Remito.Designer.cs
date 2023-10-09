
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
            this.PanelIZQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetraRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecharRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelIZQ
            // 
            this.PanelIZQ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelIZQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelIZQ.Font = new System.Drawing.Font("Javanese Text", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelIZQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelIZQ.Location = new System.Drawing.Point(7, 37);
            this.PanelIZQ.Name = "PanelIZQ";
            this.PanelIZQ.Size = new System.Drawing.Size(270, 300);
            this.PanelIZQ.TabIndex = 0;
            this.PanelIZQ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PanelIZQ.Click += new System.EventHandler(this.PanelIZQ_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTADO DE REMITOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Sucursal,
            this.Estado,
            this.Numero,
            this.IDOperacion,
            this.TipoRemito,
            this.LetraRemito,
            this.FecharRemito});
            this.dataGridView1.Location = new System.Drawing.Point(283, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 300);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "ID";
            this.Identificador.Name = "Identificador";
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // IDOperacion
            // 
            this.IDOperacion.HeaderText = "Operación";
            this.IDOperacion.Name = "IDOperacion";
            // 
            // TipoRemito
            // 
            this.TipoRemito.HeaderText = "Tipo";
            this.TipoRemito.Name = "TipoRemito";
            // 
            // LetraRemito
            // 
            this.LetraRemito.HeaderText = "Letra";
            this.LetraRemito.Name = "LetraRemito";
            // 
            // FecharRemito
            // 
            this.FecharRemito.HeaderText = "Fecha";
            this.FecharRemito.Name = "FecharRemito";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUEVO REMITO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sucursal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numero de remito";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fecha";
            // 
            // CP_Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(917, 341);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelIZQ);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "CP_Remito";
            this.Text = "CP_Remito";
            this.Load += new System.EventHandler(this.CP_Remito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PanelIZQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetraRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecharRemito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}