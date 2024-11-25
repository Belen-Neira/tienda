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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEnvios
            // 
            this.dataGridViewEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnvios.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewEnvios.Name = "dataGridViewEnvios";
            this.dataGridViewEnvios.Size = new System.Drawing.Size(776, 374);
            this.dataGridViewEnvios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENVIOS COMPLETADOS O EN PROCESO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Envios
            // 
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
    }
}
