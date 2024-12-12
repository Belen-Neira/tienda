namespace tienda
{
    partial class Envios
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewEnvios;

        private void InitializeComponent()
        {
            this.dataGridViewEnvios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_ENVIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_ENVIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_REPARTIDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEnvios
            // 
            this.dataGridViewEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnvios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ENVIO,
            this.FECHA_ENVIO,
            this.ID_DIRECCION,
            this.ID_REPARTIDOR,
            this.ID_PEDIDO});
            this.dataGridViewEnvios.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewEnvios.Name = "dataGridViewEnvios";
            this.dataGridViewEnvios.RowHeadersWidth = 51;
            this.dataGridViewEnvios.Size = new System.Drawing.Size(776, 374);
            this.dataGridViewEnvios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENVIOS COMPLETADOS O EN PROCESO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID_ENVIO
            // 
            this.ID_ENVIO.HeaderText = "ID_ENVIO";
            this.ID_ENVIO.MinimumWidth = 6;
            this.ID_ENVIO.Name = "ID_ENVIO";
            this.ID_ENVIO.Width = 125;
            // 
            // FECHA_ENVIO
            // 
            this.FECHA_ENVIO.HeaderText = "FECHA_ENVIO";
            this.FECHA_ENVIO.MinimumWidth = 6;
            this.FECHA_ENVIO.Name = "FECHA_ENVIO";
            this.FECHA_ENVIO.Width = 125;
            // 
            // ID_DIRECCION
            // 
            this.ID_DIRECCION.HeaderText = "ID_DIRECCION";
            this.ID_DIRECCION.MinimumWidth = 6;
            this.ID_DIRECCION.Name = "ID_DIRECCION";
            this.ID_DIRECCION.Width = 125;
            // 
            // ID_REPARTIDOR
            // 
            this.ID_REPARTIDOR.HeaderText = "ID_REPARTIDOR";
            this.ID_REPARTIDOR.MinimumWidth = 6;
            this.ID_REPARTIDOR.Name = "ID_REPARTIDOR";
            this.ID_REPARTIDOR.Width = 125;
            // 
            // ID_PEDIDO
            // 
            this.ID_PEDIDO.HeaderText = "ID_PEDIDO";
            this.ID_PEDIDO.MinimumWidth = 6;
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.Width = 125;
            // 
            // Envios
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEnvios);
            this.Name = "Envios";
            this.Text = "Envios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ENVIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_ENVIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_REPARTIDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
    }
}
