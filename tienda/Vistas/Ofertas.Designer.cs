namespace tienda
{
    partial class Ofertas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOfertas;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtLibroID;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;

        private void InitializeComponent()
        {
            this.dataGridViewOfertas = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtLibroID = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_OFERTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_LIBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INICIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_FIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfertas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOfertas
            // 
            this.dataGridViewOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_OFERTA,
            this.ID_LIBRO,
            this.DESCUENTO,
            this.FECHA_INICIO,
            this.FECHA_FIN});
            this.dataGridViewOfertas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOfertas.Name = "dataGridViewOfertas";
            this.dataGridViewOfertas.RowHeadersWidth = 51;
            this.dataGridViewOfertas.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewOfertas.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 186);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(127, 226);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 22);
            this.txtDescuento.TabIndex = 2;
            // 
            // txtLibroID
            // 
            this.txtLibroID.Location = new System.Drawing.Point(127, 266);
            this.txtLibroID.Name = "txtLibroID";
            this.txtLibroID.Size = new System.Drawing.Size(100, 22);
            this.txtLibroID.TabIndex = 3;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(27, 324);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaInicio.TabIndex = 4;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(27, 364);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaFin.TabIndex = 5;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(268, 182);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertarOferta);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(268, 222);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizarOferta);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(268, 262);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminarOferta);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID OFERTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID LIBRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "DESCUENTO";
            // 
            // ID_OFERTA
            // 
            this.ID_OFERTA.HeaderText = "ID_OFERTA";
            this.ID_OFERTA.MinimumWidth = 6;
            this.ID_OFERTA.Name = "ID_OFERTA";
            this.ID_OFERTA.Width = 125;
            // 
            // ID_LIBRO
            // 
            this.ID_LIBRO.HeaderText = "ID_LIBRO";
            this.ID_LIBRO.MinimumWidth = 6;
            this.ID_LIBRO.Name = "ID_LIBRO";
            this.ID_LIBRO.Width = 125;
            // 
            // DESCUENTO
            // 
            this.DESCUENTO.HeaderText = "DESCUENTO";
            this.DESCUENTO.MinimumWidth = 6;
            this.DESCUENTO.Name = "DESCUENTO";
            this.DESCUENTO.Width = 125;
            // 
            // FECHA_INICIO
            // 
            this.FECHA_INICIO.HeaderText = "FECHA_INICIO";
            this.FECHA_INICIO.MinimumWidth = 6;
            this.FECHA_INICIO.Name = "FECHA_INICIO";
            this.FECHA_INICIO.Width = 125;
            // 
            // FECHA_FIN
            // 
            this.FECHA_FIN.HeaderText = "FECHA_FIN";
            this.FECHA_FIN.MinimumWidth = 6;
            this.FECHA_FIN.Name = "FECHA_FIN";
            this.FECHA_FIN.Width = 125;
            // 
            // Ofertas
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtLibroID);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridViewOfertas);
            this.Name = "Ofertas";
            this.Text = "Gestión de Ofertas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_OFERTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LIBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INICIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_FIN;
    }
}
