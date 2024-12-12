namespace tienda
{
    partial class Pedidos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;

        private void InitializeComponent()
        {
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_ENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PEDIDO,
            this.FECHA_PEDIDO,
            this.FECHA_ENTREGA,
            this.ESTADO_PEDIDO,
            this.MONTO_TOTAL,
            this.ID_CLIENTE});
            this.dataGridViewPedidos.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.RowHeadersWidth = 51;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(776, 374);
            this.dataGridViewPedidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDOS ENTREGADOS O EN PROCESO";
            // 
            // ID_PEDIDO
            // 
            this.ID_PEDIDO.HeaderText = "ID_PEDIDO";
            this.ID_PEDIDO.MinimumWidth = 6;
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.Width = 125;
            // 
            // FECHA_PEDIDO
            // 
            this.FECHA_PEDIDO.HeaderText = "FECHA_PEDIDO";
            this.FECHA_PEDIDO.MinimumWidth = 6;
            this.FECHA_PEDIDO.Name = "FECHA_PEDIDO";
            this.FECHA_PEDIDO.Width = 125;
            // 
            // FECHA_ENTREGA
            // 
            this.FECHA_ENTREGA.HeaderText = "FECHA_ENTREGA";
            this.FECHA_ENTREGA.MinimumWidth = 6;
            this.FECHA_ENTREGA.Name = "FECHA_ENTREGA";
            this.FECHA_ENTREGA.Width = 125;
            // 
            // ESTADO_PEDIDO
            // 
            this.ESTADO_PEDIDO.HeaderText = "ESTADO_PEDIDO";
            this.ESTADO_PEDIDO.MinimumWidth = 6;
            this.ESTADO_PEDIDO.Name = "ESTADO_PEDIDO";
            this.ESTADO_PEDIDO.Width = 125;
            // 
            // MONTO_TOTAL
            // 
            this.MONTO_TOTAL.HeaderText = "MONTO_TOTAL";
            this.MONTO_TOTAL.MinimumWidth = 6;
            this.MONTO_TOTAL.Name = "MONTO_TOTAL";
            this.MONTO_TOTAL.Width = 125;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.MinimumWidth = 6;
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.Width = 125;
            // 
            // Pedidos
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_ENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
    }
}
