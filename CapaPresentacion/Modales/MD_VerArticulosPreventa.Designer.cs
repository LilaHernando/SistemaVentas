
namespace CapaPresentacion.Modales
{
    partial class MD_VerArticulosPreventa
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
            this.dgvDataArticulosPreventa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumPreventa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataArticulosPreventa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDataArticulosPreventa
            // 
            this.dgvDataArticulosPreventa.AllowUserToAddRows = false;
            this.dgvDataArticulosPreventa.AllowUserToDeleteRows = false;
            this.dgvDataArticulosPreventa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDataArticulosPreventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDataArticulosPreventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataArticulosPreventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Rubro,
            this.Costo});
            this.dgvDataArticulosPreventa.Location = new System.Drawing.Point(12, 72);
            this.dgvDataArticulosPreventa.Name = "dgvDataArticulosPreventa";
            this.dgvDataArticulosPreventa.RowHeadersWidth = 51;
            this.dgvDataArticulosPreventa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataArticulosPreventa.Size = new System.Drawing.Size(446, 278);
            this.dgvDataArticulosPreventa.TabIndex = 22;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Rubro
            // 
            this.Rubro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.MinimumWidth = 6;
            this.Rubro.Name = "Rubro";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.Width = 125;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::CapaPresentacion.Properties.Resources.box;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lista de Articulos Preventa N°:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNumPreventa
            // 
            this.labelNumPreventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelNumPreventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNumPreventa.Location = new System.Drawing.Point(262, 21);
            this.labelNumPreventa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumPreventa.Name = "labelNumPreventa";
            this.labelNumPreventa.Size = new System.Drawing.Size(120, 24);
            this.labelNumPreventa.TabIndex = 24;
            this.labelNumPreventa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MD_VerArticulosPreventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 362);
            this.Controls.Add(this.labelNumPreventa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDataArticulosPreventa);
            this.Name = "MD_VerArticulosPreventa";
            this.Text = "MD_VerArticulosPreventa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataArticulosPreventa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDataArticulosPreventa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumPreventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
    }
}