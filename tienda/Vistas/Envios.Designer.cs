namespace tienda
{
    partial class Envios
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewEnvios;

        private void InitializeComponent()
        {
            this.dataGridViewEnvios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEnvios
            // 
            this.dataGridViewEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnvios.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEnvios.Name = "dataGridViewEnvios";
            this.dataGridViewEnvios.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewEnvios.TabIndex = 0;
            // 
            // Envios
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewEnvios);
            this.Name = "Envios";
            this.Text = "Envios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvios)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
